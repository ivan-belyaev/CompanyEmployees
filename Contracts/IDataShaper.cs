using Entities.Models;
using System.Collections.Generic;

namespace Contracts
{
    public interface IDataShaper<T>
    {
        /// <summary>
        /// Shape Data
        /// </summary>
        /// <param name="entities">Entities</param>
        /// <param name="fieldsString">fields String</param>
        IEnumerable<Entity> ShapeData(IEnumerable<T> entities, string fieldsString);
        Entity ShapeData(T entity, string fieldsString);
    }
}
