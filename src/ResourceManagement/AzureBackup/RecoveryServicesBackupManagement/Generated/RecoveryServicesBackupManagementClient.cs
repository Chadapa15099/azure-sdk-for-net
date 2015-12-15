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
using System.Net.Http;
using Hyak.Common;
using Microsoft.Azure;
using Microsoft.Azure.Management.RecoveryServices.Backup;

namespace Microsoft.Azure.Management.RecoveryServices.Backup
{
    public partial class RecoveryServicesBackupManagementClient : ServiceClient<RecoveryServicesBackupManagementClient>, IRecoveryServicesBackupManagementClient
    {
        private string _apiVersion;
        
        /// <summary>
        /// Gets the API version.
        /// </summary>
        public string ApiVersion
        {
            get { return this._apiVersion; }
        }
        
        private Uri _baseUri;
        
        /// <summary>
        /// Gets the URI used as the base for all cloud service requests.
        /// </summary>
        public Uri BaseUri
        {
            get { return this._baseUri; }
        }
        
        private SubscriptionCloudCredentials _credentials;
        
        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        public SubscriptionCloudCredentials Credentials
        {
            get { return this._credentials; }
        }
        
        private int _longRunningOperationInitialTimeout;
        
        /// <summary>
        /// Gets or sets the initial timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationInitialTimeout
        {
            get { return this._longRunningOperationInitialTimeout; }
            set { this._longRunningOperationInitialTimeout = value; }
        }
        
        private int _longRunningOperationRetryTimeout;
        
        /// <summary>
        /// Gets or sets the retry timeout for Long Running Operations.
        /// </summary>
        public int LongRunningOperationRetryTimeout
        {
            get { return this._longRunningOperationRetryTimeout; }
            set { this._longRunningOperationRetryTimeout = value; }
        }
        
        private IBackupOperations _backup;
        
        /// <summary>
        /// Definition of Backup operations for the Azure Backup extension.
        /// </summary>
        public virtual IBackupOperations Backup
        {
            get { return this._backup; }
        }
        
        private IContainerOperation _container;
        
        /// <summary>
        /// Definition of Container operations for the Azure Backup extension
        /// with RecoveryService Vault.
        /// </summary>
        public virtual IContainerOperation Container
        {
            get { return this._container; }
        }
        
        private IJobOperations _job;
        
        /// <summary>
        /// Definition of Job operations for the Azure Backup extension.
        /// </summary>
        public virtual IJobOperations Job
        {
            get { return this._job; }
        }
        
        private IProtectableObjectOperations _protectableObject;
        
        /// <summary>
        /// Definition of Protectable Object operations for the Azure Backup
        /// extension.
        /// </summary>
        public virtual IProtectableObjectOperations ProtectableObject
        {
            get { return this._protectableObject; }
        }
        
        private IProtectedItemOperations _protectedItem;
        
        /// <summary>
        /// Definition of ProtectedItem operations for the Azure Backup
        /// extension.
        /// </summary>
        public virtual IProtectedItemOperations ProtectedItem
        {
            get { return this._protectedItem; }
        }
        
        private IProtectionPolicyOperations _protectionPolicy;
        
        /// <summary>
        /// Definition of Protection Policy operations for the Azure Backup
        /// extension.
        /// </summary>
        public virtual IProtectionPolicyOperations ProtectionPolicy
        {
            get { return this._protectionPolicy; }
        }
        
        private IRecoveryPointOperations _recoveryPoint;
        
        /// <summary>
        /// Definition of Backup operations for the Azure Backup extension.
        /// </summary>
        public virtual IRecoveryPointOperations RecoveryPoint
        {
            get { return this._recoveryPoint; }
        }
        
        private IRestoreOperations _restore;
        
        /// <summary>
        /// Definition of Restore operations for the Azure Backup extension.
        /// </summary>
        public virtual IRestoreOperations Restore
        {
            get { return this._restore; }
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        public RecoveryServicesBackupManagementClient()
            : base()
        {
            this._backup = new BackupOperations(this);
            this._container = new ContainerOperation(this);
            this._job = new JobOperations(this);
            this._protectableObject = new ProtectableObjectOperations(this);
            this._protectedItem = new ProtectedItemOperations(this);
            this._protectionPolicy = new ProtectionPolicyOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._restore = new RestoreOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        public RecoveryServicesBackupManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        public RecoveryServicesBackupManagementClient(SubscriptionCloudCredentials credentials)
            : this()
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesBackupManagementClient(HttpClient httpClient)
            : base(httpClient)
        {
            this._backup = new BackupOperations(this);
            this._container = new ContainerOperation(this);
            this._job = new JobOperations(this);
            this._protectableObject = new ProtectableObjectOperations(this);
            this._protectedItem = new ProtectedItemOperations(this);
            this._protectionPolicy = new ProtectionPolicyOperations(this);
            this._recoveryPoint = new RecoveryPointOperations(this);
            this._restore = new RestoreOperations(this);
            this._apiVersion = "2013-03-01";
            this._longRunningOperationInitialTimeout = -1;
            this._longRunningOperationRetryTimeout = -1;
            this.HttpClient.Timeout = TimeSpan.FromSeconds(300);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='baseUri'>
        /// Optional. Gets the URI used as the base for all cloud service
        /// requests.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesBackupManagementClient(SubscriptionCloudCredentials credentials, Uri baseUri, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            if (baseUri == null)
            {
                throw new ArgumentNullException("baseUri");
            }
            this._credentials = credentials;
            this._baseUri = baseUri;
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// RecoveryServicesBackupManagementClient class.
        /// </summary>
        /// <param name='credentials'>
        /// Required. Gets subscription credentials which uniquely identify
        /// Microsoft Azure subscription. The subscription ID forms part of
        /// the URI for every service call.
        /// </param>
        /// <param name='httpClient'>
        /// The Http client
        /// </param>
        public RecoveryServicesBackupManagementClient(SubscriptionCloudCredentials credentials, HttpClient httpClient)
            : this(httpClient)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }
            this._credentials = credentials;
            this._baseUri = new Uri("https://management.core.windows.net");
            
            this.Credentials.InitializeServiceClient(this);
        }
        
        /// <summary>
        /// Clones properties from current instance to another
        /// RecoveryServicesBackupManagementClient instance
        /// </summary>
        /// <param name='client'>
        /// Instance of RecoveryServicesBackupManagementClient to clone to
        /// </param>
        protected override void Clone(ServiceClient<RecoveryServicesBackupManagementClient> client)
        {
            base.Clone(client);
            
            if (client is RecoveryServicesBackupManagementClient)
            {
                RecoveryServicesBackupManagementClient clonedClient = ((RecoveryServicesBackupManagementClient)client);
                
                clonedClient._credentials = this._credentials;
                clonedClient._baseUri = this._baseUri;
                clonedClient._apiVersion = this._apiVersion;
                clonedClient._longRunningOperationInitialTimeout = this._longRunningOperationInitialTimeout;
                clonedClient._longRunningOperationRetryTimeout = this._longRunningOperationRetryTimeout;
                
                clonedClient.Credentials.InitializeServiceClient(clonedClient);
            }
        }
    }
}
