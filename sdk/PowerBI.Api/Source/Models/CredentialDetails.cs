// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.PowerBI.Api.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The credential details
    /// </summary>
    public partial class CredentialDetails
    {
        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        public CredentialDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CredentialDetails class.
        /// </summary>
        /// <param name="credentials">The credentials, which depend on the
        /// 'credentialType' value. For more information, see [Update
        /// Datasource](/rest/api/power-bi/gateways/update-datasource#examples)
        /// examples.</param>
        /// <param name="credentialType">The credential type. Possible values
        /// include: 'Basic', 'Windows', 'Anonymous', 'OAuth2', 'Key'</param>
        /// <param name="encryptedConnection">Whether to encrypt the data
        /// source connection. The API call will fail if you select encryption
        /// and Power BI is unable to establish an encrypted connection with
        /// the data source. Possible values include: 'Encrypted',
        /// 'NotEncrypted'</param>
        /// <param name="encryptionAlgorithm">The encryption algorithm. For a
        /// cloud data source, specify *None*. For an on-premises data source,
        /// specify *RSA-OAEP* and use the gateway public key. Possible values
        /// include: 'None', 'RSA-OAEP'</param>
        /// <param name="privacyLevel">The privacy level, which is relevant
        /// when combining data from multiple sources. Possible values include:
        /// 'None', 'Public', 'Organizational', 'Private'</param>
        /// <param name="useCallerAADIdentity">Use to indicate that the Azure
        /// AD identity (OAuth2 credentials) of the API caller (which must be
        /// the data source owner) will be used to configure data source
        /// credentials (the owner OAuth access token). Typically, you’d either
        /// use this flag or `useEndUserOAuth2Credentials`.</param>
        /// <param name="useEndUserOAuth2Credentials">Use with data sources
        /// that support [single sign-on
        /// (SSO)](/power-bi/connect-data/power-bi-data-sources#single-sign-on-sso-for-directquery-sources)
        /// to indicate that the end-user Azure AD identity (OAuth2
        /// credentials) is used for connecting to the data source in
        /// DirectQuery mode. Typically, you’d either use this flag or
        /// `useCallerAADIdentity`.</param>
        public CredentialDetails(string credentials, CredentialType credentialType, EncryptedConnection encryptedConnection, EncryptionAlgorithm encryptionAlgorithm, PrivacyLevel privacyLevel, bool? useCallerAADIdentity = default(bool?), bool? useEndUserOAuth2Credentials = default(bool?))
        {
            Credentials = credentials;
            CredentialType = credentialType;
            EncryptedConnection = encryptedConnection;
            EncryptionAlgorithm = encryptionAlgorithm;
            PrivacyLevel = privacyLevel;
            UseCallerAADIdentity = useCallerAADIdentity;
            UseEndUserOAuth2Credentials = useEndUserOAuth2Credentials;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the credentials, which depend on the 'credentialType'
        /// value. For more information, see [Update
        /// Datasource](/rest/api/power-bi/gateways/update-datasource#examples)
        /// examples.
        /// </summary>
        [JsonProperty(PropertyName = "credentials")]
        public string Credentials { get; set; }

        /// <summary>
        /// Gets or sets the credential type. Possible values include: 'Basic',
        /// 'Windows', 'Anonymous', 'OAuth2', 'Key'
        /// </summary>
        [JsonProperty(PropertyName = "credentialType")]
        public CredentialType CredentialType { get; set; }

        /// <summary>
        /// Gets or sets whether to encrypt the data source connection. The API
        /// call will fail if you select encryption and Power BI is unable to
        /// establish an encrypted connection with the data source. Possible
        /// values include: 'Encrypted', 'NotEncrypted'
        /// </summary>
        [JsonProperty(PropertyName = "encryptedConnection")]
        public EncryptedConnection EncryptedConnection { get; set; }

        /// <summary>
        /// Gets or sets the encryption algorithm. For a cloud data source,
        /// specify *None*. For an on-premises data source, specify *RSA-OAEP*
        /// and use the gateway public key. Possible values include: 'None',
        /// 'RSA-OAEP'
        /// </summary>
        [JsonProperty(PropertyName = "encryptionAlgorithm")]
        public EncryptionAlgorithm EncryptionAlgorithm { get; set; }

        /// <summary>
        /// Gets or sets the privacy level, which is relevant when combining
        /// data from multiple sources. Possible values include: 'None',
        /// 'Public', 'Organizational', 'Private'
        /// </summary>
        [JsonProperty(PropertyName = "privacyLevel")]
        public PrivacyLevel PrivacyLevel { get; set; }

        /// <summary>
        /// Gets or sets use to indicate that the Azure AD identity (OAuth2
        /// credentials) of the API caller (which must be the data source
        /// owner) will be used to configure data source credentials (the owner
        /// OAuth access token). Typically, you’d either use this flag or
        /// `useEndUserOAuth2Credentials`.
        /// </summary>
        [JsonProperty(PropertyName = "useCallerAADIdentity")]
        public bool? UseCallerAADIdentity { get; set; }

        /// <summary>
        /// Gets or sets use with data sources that support [single sign-on
        /// (SSO)](/power-bi/connect-data/power-bi-data-sources#single-sign-on-sso-for-directquery-sources)
        /// to indicate that the end-user Azure AD identity (OAuth2
        /// credentials) is used for connecting to the data source in
        /// DirectQuery mode. Typically, you’d either use this flag or
        /// `useCallerAADIdentity`.
        /// </summary>
        [JsonProperty(PropertyName = "useEndUserOAuth2Credentials")]
        public bool? UseEndUserOAuth2Credentials { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Credentials == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Credentials");
            }
        }
    }
}
