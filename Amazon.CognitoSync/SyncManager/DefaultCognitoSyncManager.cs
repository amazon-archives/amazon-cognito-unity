/**
 * Copyright 2013-2014 Amazon.com, 
 * Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Amazon Software License (the "License"). 
 * You may not use this file except in compliance with the 
 * License. A copy of the License is located at
 * 
 *     http://aws.amazon.com/asl/
 * 
 * or in the "license" file accompanying this file. This file is 
 * distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 * CONDITIONS OF ANY KIND, express or implied. See the License 
 * for the specific language governing permissions and 
 * limitations under the License.
 */
using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CognitoSync.SyncManager.Storage;
using Amazon.CognitoSync.SyncManager.Storage.Model;
using Amazon.CognitoSync.SyncManager.Util;
using Amazon.CognitoIdentity;
using Amazon.CognitoSync;
using Amazon.Unity3D;

namespace Amazon.CognitoSync.SyncManager
{
    public class DefaultCognitoSyncManager : CognitoSyncManager
    {
        protected readonly LocalStorage local;
        protected readonly CognitoSyncStorage remote;
        protected readonly CognitoAWSCredentials cognitoCredentials;

        public DefaultCognitoSyncManager(CognitoAWSCredentials cognitoCredentials, AmazonCognitoSyncConfig config)
        {
            if (cognitoCredentials == null)
            {
                throw new ArgumentNullException("cognitoCredentials is null");
            }
            if (StringUtils.IsEmpty(cognitoCredentials.IdentityProvider.IdentityPoolId))
            {
                throw new ArgumentException("invalid identity pool id");
            }
            this.cognitoCredentials = cognitoCredentials;
#if UNITY_WEBPLAYER
            local = new InMemoryStorage();
#else
			local = new SQLiteLocalStorage(System.IO.Path.Combine(AmazonHookedPlatformInfo.Instance.PersistentDataPath, AWSConfigs.CognitoDBName));
#endif
            remote = new CognitoSyncStorage(cognitoCredentials, config);
            //remote.setUserAgent(USER_AGENT);
            cognitoCredentials.IdentityProvider.IdentityChangedEvent += this.IdentityChanged;
        }

        public override Dataset OpenOrCreateDataset(string datasetName)
        {
            DatasetUtils.ValidateDatasetName(datasetName);
            local.CreateDataset(GetIdentityId(), datasetName);
            return new DefaultDataset(datasetName, cognitoCredentials, local, remote);
        }

        public override List<DatasetMetadata> ListDatasets()
        {
            return local.GetDatasets(GetIdentityId());
        }

        public override void RefreshDatasetMetadataAsync(AmazonCognitoCallback callback, object state)
        {
            AmazonCognitoResult callbackResult = new AmazonCognitoResult(state);
            cognitoCredentials.GetCredentialsAsync(delegate(AmazonServiceResult getCredentialsResult) {

                if (getCredentialsResult.Exception != null)
                {
                    callbackResult.Exception = getCredentialsResult.Exception;
                    AmazonMainThreadDispatcher.ExecCallback(callback, callbackResult);
                    return;
                }
                remote.GetDatasetsAsync(delegate(AmazonCognitoResult result)
                {
                    if (result.Exception != null)
                    {
                        callbackResult.Exception = result.Exception;
                    }
                    else
                    {
                        GetDatasetsResponse response = result.Response as GetDatasetsResponse;
                        local.UpdateDatasetMetadata(GetIdentityId(), response.Datasets);
                        callbackResult.Response = response;
                    }
                    AmazonMainThreadDispatcher.ExecCallback(callback, callbackResult);
                }, state);
                
            }, null);
        }

        public override void WipeData()
        {
            local.WipeData();
            AmazonLogging.LogInfo("DefaultCognitoSyncManager", "All data has been wiped");
        }

        public void IdentityChanged(object sender, EventArgs e)
        {
            var identityChangedEvent = e as IdentityChangedArgs;
            String oldIdentity = identityChangedEvent.OldIdentityId == null ? DatasetUtils.UNKNOWN_IDENTITY_ID : identityChangedEvent.OldIdentityId;
            String newIdentity = identityChangedEvent.NewIdentityId == null ? DatasetUtils.UNKNOWN_IDENTITY_ID : identityChangedEvent.NewIdentityId;
            AmazonLogging.LogInfo("DefaultCognitoSyncManager", "identity change detected: " + oldIdentity + "," + newIdentity);
            if (oldIdentity != newIdentity) local.ChangeIdentityId(oldIdentity, newIdentity);
        }

        protected string GetIdentityId()
        {
            return DatasetUtils.GetIdentityId(cognitoCredentials);
        }
    }
}

