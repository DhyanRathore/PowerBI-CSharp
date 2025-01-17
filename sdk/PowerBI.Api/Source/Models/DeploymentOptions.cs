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
    /// Deployment configuration options. Can be specified either for the
    /// entire deployment or for a specific Power BI item (such as a report or
    /// dashboard). If both are specified, only the deployment options for the
    /// Power BI item are used.
    /// </summary>
    public partial class DeploymentOptions
    {
        /// <summary>
        /// Initializes a new instance of the DeploymentOptions class.
        /// </summary>
        public DeploymentOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentOptions class.
        /// </summary>
        /// <param name="allowCreateArtifact">Whether creating a new Power BI
        /// item (such as a report or a dashboard) in the target stage
        /// workspace is allowed. If this option isn't set to `true` when it's
        /// required for deployment, the deployment will fail.</param>
        /// <param name="allowOverwriteArtifact">Whether overwriting a Power BI
        /// item (such as a report or a dashboard) in the target stage
        /// workspace is allowed. If this option isn't set to `true` when it's
        /// required for deployment, the deployment will fail.</param>
        /// <param name="allowSkipTilesWithMissingPrerequisites">Whether to
        /// skip tiles that don't have a model or a report in the target stage
        /// workspace. If this option isn't set to `true` when it's required
        /// for deployment, the deployment will fail.</param>
        /// <param name="allowPurgeData">Whether to delete all data from the
        /// target Power BI item (such as a report or a dashboard) when there's
        /// a schema mismatch. If this option isn't set to `true` when it's
        /// required for deployment, the deployment will fail.</param>
        /// <param name="allowTakeOver">Allow overriding the previous paginated
        /// report owner and becoming the owner of the paginated report.
        /// Applicable when deploying a paginated report to a stage that
        /// already contains a copy of the paginated report that isn't owned by
        /// you. If this option isn't set to `true` when it's required for
        /// deployment, the deployment will fail.</param>
        /// <param name="allowOverwriteTargetArtifactLabel">Whether the label
        /// of a target Power BI item (such as a report or a dashboard) can be
        /// changed. The label gets changed when the source is protected but
        /// the target isn't. If this option isn't set to `true` when it's
        /// required for deployment, the deployment will fail.</param>
        public DeploymentOptions(bool? allowCreateArtifact = default(bool?), bool? allowOverwriteArtifact = default(bool?), bool? allowSkipTilesWithMissingPrerequisites = default(bool?), bool? allowPurgeData = default(bool?), bool? allowTakeOver = default(bool?), bool? allowOverwriteTargetArtifactLabel = default(bool?))
        {
            AllowCreateArtifact = allowCreateArtifact;
            AllowOverwriteArtifact = allowOverwriteArtifact;
            AllowSkipTilesWithMissingPrerequisites = allowSkipTilesWithMissingPrerequisites;
            AllowPurgeData = allowPurgeData;
            AllowTakeOver = allowTakeOver;
            AllowOverwriteTargetArtifactLabel = allowOverwriteTargetArtifactLabel;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets whether creating a new Power BI item (such as a report
        /// or a dashboard) in the target stage workspace is allowed. If this
        /// option isn't set to `true` when it's required for deployment, the
        /// deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowCreateArtifact")]
        public bool? AllowCreateArtifact { get; set; }

        /// <summary>
        /// Gets or sets whether overwriting a Power BI item (such as a report
        /// or a dashboard) in the target stage workspace is allowed. If this
        /// option isn't set to `true` when it's required for deployment, the
        /// deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowOverwriteArtifact")]
        public bool? AllowOverwriteArtifact { get; set; }

        /// <summary>
        /// Gets or sets whether to skip tiles that don't have a model or a
        /// report in the target stage workspace. If this option isn't set to
        /// `true` when it's required for deployment, the deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowSkipTilesWithMissingPrerequisites")]
        public bool? AllowSkipTilesWithMissingPrerequisites { get; set; }

        /// <summary>
        /// Gets or sets whether to delete all data from the target Power BI
        /// item (such as a report or a dashboard) when there's a schema
        /// mismatch. If this option isn't set to `true` when it's required for
        /// deployment, the deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowPurgeData")]
        public bool? AllowPurgeData { get; set; }

        /// <summary>
        /// Gets or sets allow overriding the previous paginated report owner
        /// and becoming the owner of the paginated report. Applicable when
        /// deploying a paginated report to a stage that already contains a
        /// copy of the paginated report that isn't owned by you. If this
        /// option isn't set to `true` when it's required for deployment, the
        /// deployment will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowTakeOver")]
        public bool? AllowTakeOver { get; set; }

        /// <summary>
        /// Gets or sets whether the label of a target Power BI item (such as a
        /// report or a dashboard) can be changed. The label gets changed when
        /// the source is protected but the target isn't. If this option isn't
        /// set to `true` when it's required for deployment, the deployment
        /// will fail.
        /// </summary>
        [JsonProperty(PropertyName = "allowOverwriteTargetArtifactLabel")]
        public bool? AllowOverwriteTargetArtifactLabel { get; set; }

    }
}
