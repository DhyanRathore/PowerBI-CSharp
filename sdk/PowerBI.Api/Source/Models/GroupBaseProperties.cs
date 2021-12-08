// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GroupBaseProperties
    {
        /// <summary>
        /// Initializes a new instance of the GroupBaseProperties class.
        /// </summary>
        public GroupBaseProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupBaseProperties class.
        /// </summary>
        /// <param name="id">The workspace ID</param>
        /// <param name="name">The group name</param>
        public GroupBaseProperties(System.Guid id, string name = default(string))
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the workspace ID
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets the group name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}