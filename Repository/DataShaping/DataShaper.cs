using Contracts;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Repository.DataShaping
{
    /// <summary>
    /// Data Shaper
    /// </summary>
    public class DataShaper<T> : IDataShaper<T> where T : class
    {
        /// <summary>
        /// Properties
        /// </summary>
        public PropertyInfo[] Properties { get; set; }

        /// <summary>
        /// ctor
        /// </summary>
        public DataShaper()
        {
            Properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        }

        /// <inheritdoc/>
        public IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString)
        {
            var requiredProperties = GetRequiredProperties(fieldsString);

            return FetchData(entities, requiredProperties);
        }

        /// <inheritdoc/>
        public Entity ShapeData(T entity, string fieldsString)
        {
            var requiredProperties = GetRequiredProperties(fieldsString);

            return FetchDataForEntity(entity, requiredProperties);
        }

        /// <summary>
        /// Get Required Properties
        /// </summary>
        private IEnumerable<PropertyInfo> GetRequiredProperties(string fieldsString)
        {
            var requiredProperties = new List<PropertyInfo>();

            if (!string.IsNullOrWhiteSpace(fieldsString))
            {
                var fields = fieldsString.Split(',', StringSplitOptions.RemoveEmptyEntries);

                foreach (var field in fields)
                {
                    var property = Properties
                        .FirstOrDefault(pi => pi.Name.Equals(field.Trim(), StringComparison.InvariantCultureIgnoreCase));

                    if (property == null)
                        continue;

                    requiredProperties.Add(property);
                }
            }
            else
            {
                requiredProperties = Properties.ToList();
            }

            return requiredProperties;
        }

        /// <summary>
        /// Fetch Data
        /// </summary>
        private IEnumerable<Entity> FetchData(IEnumerable<T> entities, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedData = new List<Entity>();

            foreach (var entity in entities)
            {
                var shapedObject = FetchDataForEntity(entity, requiredProperties);
                shapedData.Add(shapedObject);
            }

            return shapedData;
        }

        /// <summary>
        /// Fetch Data ForEntity
        /// </summary>
        private Entity FetchDataForEntity(T entity, IEnumerable<PropertyInfo> requiredProperties)
        {
            var shapedObject = new Entity();

            foreach (var property in requiredProperties)
            {
                var objectPropertyValue = property.GetValue(entity);
                shapedObject.TryAdd(property.Name, objectPropertyValue);
            }

            return shapedObject;
        }
    }
}
