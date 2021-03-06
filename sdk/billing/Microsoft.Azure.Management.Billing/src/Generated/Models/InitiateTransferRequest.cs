// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Request parameters to initiate transfer.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InitiateTransferRequest
    {
        /// <summary>
        /// Initializes a new instance of the InitiateTransferRequest class.
        /// </summary>
        public InitiateTransferRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InitiateTransferRequest class.
        /// </summary>
        /// <param name="recipientEmailId">Email Id of recipient for
        /// transfer.</param>
        /// <param name="resellerId">Optional reseller Id for transfer.</param>
        public InitiateTransferRequest(string recipientEmailId = default(string), string resellerId = default(string))
        {
            RecipientEmailId = recipientEmailId;
            ResellerId = resellerId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets email Id of recipient for transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.recipientEmailId")]
        public string RecipientEmailId { get; set; }

        /// <summary>
        /// Gets or sets optional reseller Id for transfer.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resellerId")]
        public string ResellerId { get; set; }

    }
}
