// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubResourceWithColocationStatus : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the SubResourceWithColocationStatus
        /// class.
        /// </summary>
        public SubResourceWithColocationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubResourceWithColocationStatus
        /// class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="colocationStatus">Describes colocation status of a
        /// resource in the Proximity Placement Group.</param>
        public SubResourceWithColocationStatus(string id = default(string), InstanceViewStatus colocationStatus = default(InstanceViewStatus))
            : base(id)
        {
            ColocationStatus = colocationStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes colocation status of a resource in the
        /// Proximity Placement Group.
        /// </summary>
        [JsonProperty(PropertyName = "colocationStatus")]
        public InstanceViewStatus ColocationStatus { get; set; }

    }
}
