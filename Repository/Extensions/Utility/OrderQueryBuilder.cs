using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Repository.Extensions.Utility
{
    public static class OrderQueryBuilder
    {
        public static string CreateOrderQuery<T>(string orderByQueryString)
        {
            // Next, we are splitting our query string to get the individual fields
            var orderParams = orderByQueryString.Trim().Split(',');

            // for check if the field received through the query string really exists in the Employee class
            var propertyInfos = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var orderQueryBuilder = new StringBuilder();

            // run through all the parameters and check for their existence
            foreach (var param in orderParams)
            {                
                if (string.IsNullOrWhiteSpace(param))
                    continue;

                var propertyFromQueryName = param.Split(" ")[0];                
                var objectProperty = propertyInfos.FirstOrDefault(pi => pi.Name.Equals(propertyFromQueryName, StringComparison.InvariantCultureIgnoreCase));

                if (objectProperty == null)
                    continue;

                //  how we should order our property
                var direction = param.EndsWith(" desc") ? "descending" : "ascending";

                // use the StringBuilder to build our query with each loop
                orderQueryBuilder.Append($"{objectProperty.Name.ToString()} {direction}, ");
            }

            // removing excess commas
            var orderQuery = orderQueryBuilder.ToString().TrimEnd(',', ' ');

            return orderQuery;
        }
    }
}
