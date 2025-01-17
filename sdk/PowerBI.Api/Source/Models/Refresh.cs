// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Power BI refresh history entry
    /// </summary>
    public partial class Refresh
    {
        /// <summary>
        /// Initializes a new instance of the Refresh class.
        /// </summary>
        public Refresh()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Refresh class.
        /// </summary>
        /// <param name="refreshType">The type of refresh request. Possible
        /// values include: 'Scheduled', 'OnDemand', 'ViaApi'</param>
        /// <param name="startTime">The start date and time of the
        /// refresh</param>
        /// <param name="endTime">The end date and time of the refresh (may be
        /// empty if a refresh is in progress)</param>
        /// <param name="serviceExceptionJson">Failure error code in JSON
        /// format (empty if no error)</param>
        /// <param name="status">- `Unknown` if the completion state is unknown
        /// or a refresh is in progress.
        /// - `Completed` for a successfully completed refresh.
        /// - `Failed` for an unsuccessful refresh (`serviceExceptionJson` will
        /// contain the error code).
        /// - `Disabled` if the refresh is disabled by a selective
        /// refresh.</param>
        /// <param name="requestId">The identifier of the refresh request.
        /// Provide this identifier in all service requests.</param>
        public Refresh(RefreshType? refreshType = default(RefreshType?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string serviceExceptionJson = default(string), string status = default(string), string requestId = default(string))
        {
            RefreshType = refreshType;
            StartTime = startTime;
            EndTime = endTime;
            ServiceExceptionJson = serviceExceptionJson;
            Status = status;
            RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of refresh request. Possible values include:
        /// 'Scheduled', 'OnDemand', 'ViaApi'
        /// </summary>
        [JsonProperty(PropertyName = "refreshType")]
        public RefreshType? RefreshType { get; set; }

        /// <summary>
        /// Gets or sets the start date and time of the refresh
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end date and time of the refresh (may be empty if
        /// a refresh is in progress)
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets failure error code in JSON format (empty if no error)
        /// </summary>
        [JsonProperty(PropertyName = "serviceExceptionJson")]
        public string ServiceExceptionJson { get; set; }

        /// <summary>
        /// Gets or sets - `Unknown` if the completion state is unknown or a
        /// refresh is in progress.
        /// - `Completed` for a successfully completed refresh.
        /// - `Failed` for an unsuccessful refresh (`serviceExceptionJson` will
        /// contain the error code).
        /// - `Disabled` if the refresh is disabled by a selective refresh.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the identifier of the refresh request. Provide this
        /// identifier in all service requests.
        /// </summary>
        [JsonProperty(PropertyName = "requestId")]
        public string RequestId { get; set; }

    }
}
