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
        IEnumerable<ShapedEntity> ShapeData(IEnumerable<T> entities, string fieldsString);

        /// <summary>
        /// Shape Data
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <param name="fieldsString">fields String</param>
        ShapedEntity ShapeData(T entity, string fieldsString);
    }
}
