using Microsoft.EntityFrameworkCore.Metadata;

namespace EntityFrameworkCore.Scaffolding.Handlebars
{
    /// <summary>
    /// Entity property info.
    /// </summary>
    public class EntityPropertyInfo
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public EntityPropertyInfo() { }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="propertyType">Property type.</param>
        /// <param name="propertyName">Property name.</param>
        /// <param name="type"></param>
        /// <param name="propertyIsNullable">Property is nullable</param>
        public EntityPropertyInfo(string propertyType, string propertyName, bool? propertyIsNullable = null, IEntityType type = null)
        {
            PropertyType = propertyType;
            PropertyName = propertyName;
            PropertyIsNullable = propertyIsNullable;
            Type = type;
        }

        /// <summary>
        /// Property type.
        /// </summary>
        public string PropertyType { get; set; }

        /// <summary>
        /// Property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets if the property Is Nullable
        /// </summary>
        public bool? PropertyIsNullable { get; protected set; }
        /// <summary>
        /// IEntityType of Property
        /// </summary>
        public IEntityType Type { get; set; }
    }
}