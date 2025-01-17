// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class GroupExtendedProperties
    {
        /// <summary>
        /// Initializes a new instance of the GroupExtendedProperties class.
        /// </summary>
        public GroupExtendedProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupExtendedProperties class.
        /// </summary>
        /// <param name="isReadOnly">Is the group read only</param>
        /// <param name="isOnDedicatedCapacity">Is the group on dedicated
        /// capacity</param>
        /// <param name="capacityId">The capacity ID</param>
        /// <param name="dataflowStorageId">The Power BI dataflow storage
        /// account ID</param>
        public GroupExtendedProperties(bool? isReadOnly = default(bool?), bool? isOnDedicatedCapacity = default(bool?), System.Guid? capacityId = default(System.Guid?), System.Guid? dataflowStorageId = default(System.Guid?))
        {
            IsReadOnly = isReadOnly;
            IsOnDedicatedCapacity = isOnDedicatedCapacity;
            CapacityId = capacityId;
            DataflowStorageId = dataflowStorageId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets is the group read only
        /// </summary>
        [JsonProperty(PropertyName = "isReadOnly")]
        public bool? IsReadOnly { get; set; }

        /// <summary>
        /// Gets or sets is the group on dedicated capacity
        /// </summary>
        [JsonProperty(PropertyName = "isOnDedicatedCapacity")]
        public bool? IsOnDedicatedCapacity { get; set; }

        /// <summary>
        /// Gets or sets the capacity ID
        /// </summary>
        [JsonProperty(PropertyName = "capacityId")]
        public System.Guid? CapacityId { get; set; }

        /// <summary>
        /// Gets or sets the Power BI dataflow storage account ID
        /// </summary>
        [JsonProperty(PropertyName = "dataflowStorageId")]
        public System.Guid? DataflowStorageId { get; set; }

    }
}
