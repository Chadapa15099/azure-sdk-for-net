// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    /// <summary>
    /// The definition of ProtectionContainerBase object.
    /// </summary>
    public partial class ProtectionContainerBase
    {
        private string _providerType;
        
        /// <summary>
        /// Optional. Provider Type
        /// </summary>
        public string ProviderType
        {
            get { return this._providerType; }
            set { this._providerType = value; }
        }
        
        private string _workloadType;
        
        /// <summary>
        /// Optional. Workload Type
        /// </summary>
        public string WorkloadType
        {
            get { return this._workloadType; }
            set { this._workloadType = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ProtectionContainerBase class.
        /// </summary>
        public ProtectionContainerBase()
        {
        }
    }
}
