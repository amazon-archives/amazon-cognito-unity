/*
 * Copyright 2014-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *
 *
 * Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located in the "license" file accompanying this file.
 * See the License for the specific language governing permissions and limitations under the License.
 *
 */


using System;
using System.Threading;

using Amazon.CognitoSync.Model;
using Amazon.CognitoSync.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Unity3D;

namespace Amazon.CognitoSync
{
    /// <summary>
    /// Implementation for accessing CognitoSync
    ///
    /// Amazon Cognito Sync 
    /// <para>
    /// Amazon Cognito Sync provides an AWS service and client library that enable cross-device
    /// syncing of application-related user data. High-level client libraries are available
    /// for both iOS and Android. You can use these libraries to persist data locally so that
    /// it's available even if the device is offline. Developer credentials don't need to
    /// be stored on the mobile device to access the service. You can use Amazon Cognito to
    /// obtain a normalized user ID and credentials. User data is persisted in a dataset that
    /// can store up to 1 MB of key-value pairs, and you can have up to 20 datasets per user
    /// identity.
    /// </para>
    ///  
    /// <para>
    /// With Amazon Cognito Sync, the data stored for each identity is accessible only to
    /// credentials assigned to that identity. In order to use the Cognito Sync service, you
    /// need to make API calls using credentials retrieved with <a href="http://docs.aws.amazon.com/cognitoidentity/latest/APIReference/Welcome.html">Amazon
    /// Cognito Identity service</a>.
    /// </para>
    /// </summary>
    public partial class AmazonCognitoSyncClient : AmazonWebServiceClient, IAmazonCognitoSync
    {
        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials)
            : this(credentials, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Credentials and an
        /// AmazonCognitoSyncClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(AWSCredentials credentials, AmazonCognitoSyncConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCognitoSyncConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCognitoSyncConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCognitoSyncClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCognitoSyncClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCognitoSyncClient Configuration Object</param>
        public AmazonCognitoSyncClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCognitoSyncConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

        
        #region  DeleteDataset


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataset operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void DeleteDatasetAsync(DeleteDatasetRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new DeleteDatasetRequestMarshaller();
                var unmarshaller = DeleteDatasetResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  DescribeDataset


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDataset operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void DescribeDatasetAsync(DescribeDatasetRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new DescribeDatasetRequestMarshaller();
                var unmarshaller = DescribeDatasetResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  DescribeIdentityPoolUsage


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityPoolUsage operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void DescribeIdentityPoolUsageAsync(DescribeIdentityPoolUsageRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new DescribeIdentityPoolUsageRequestMarshaller();
                var unmarshaller = DescribeIdentityPoolUsageResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  DescribeIdentityUsage


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityUsage operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void DescribeIdentityUsageAsync(DescribeIdentityUsageRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new DescribeIdentityUsageRequestMarshaller();
                var unmarshaller = DescribeIdentityUsageResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  GetIdentityPoolConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentityPoolConfiguration operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void GetIdentityPoolConfigurationAsync(GetIdentityPoolConfigurationRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new GetIdentityPoolConfigurationRequestMarshaller();
                var unmarshaller = GetIdentityPoolConfigurationResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  ListDatasets


        /// <summary>
        /// Initiates the asynchronous execution of the ListDatasets operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDatasets operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void ListDatasetsAsync(ListDatasetsRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new ListDatasetsRequestMarshaller();
                var unmarshaller = ListDatasetsResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  ListIdentityPoolUsage


        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentityPoolUsage operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentityPoolUsage operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void ListIdentityPoolUsageAsync(ListIdentityPoolUsageRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new ListIdentityPoolUsageRequestMarshaller();
                var unmarshaller = ListIdentityPoolUsageResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  ListRecords


        /// <summary>
        /// Initiates the asynchronous execution of the ListRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRecords operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void ListRecordsAsync(ListRecordsRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new ListRecordsRequestMarshaller();
                var unmarshaller = ListRecordsResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  RegisterDevice


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterDevice operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterDevice operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void RegisterDeviceAsync(RegisterDeviceRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new RegisterDeviceRequestMarshaller();
                var unmarshaller = RegisterDeviceResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  SetIdentityPoolConfiguration


        /// <summary>
        /// Initiates the asynchronous execution of the SetIdentityPoolConfiguration operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIdentityPoolConfiguration operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void SetIdentityPoolConfigurationAsync(SetIdentityPoolConfigurationRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new SetIdentityPoolConfigurationRequestMarshaller();
                var unmarshaller = SetIdentityPoolConfigurationResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  SubscribeToDataset


        /// <summary>
        /// Initiates the asynchronous execution of the SubscribeToDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubscribeToDataset operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void SubscribeToDatasetAsync(SubscribeToDatasetRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new SubscribeToDatasetRequestMarshaller();
                var unmarshaller = SubscribeToDatasetResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  UnsubscribeFromDataset


        /// <summary>
        /// Initiates the asynchronous execution of the UnsubscribeFromDataset operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnsubscribeFromDataset operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void UnsubscribeFromDatasetAsync(UnsubscribeFromDatasetRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new UnsubscribeFromDatasetRequestMarshaller();
                var unmarshaller = UnsubscribeFromDatasetResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
        #region  UpdateRecords


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRecords operation.
        /// <seealso cref="Amazon.CognitoSync.IAmazonCognitoSync"/>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRecords operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// <returns>void</returns>
        public void UpdateRecordsAsync(UpdateRecordsRequest request, AmazonServiceCallback callback, object state)
        {
            if (!AmazonInitializer.IsInitialized)
                throw new Exception("AWSPrefab is not added to the scene");

            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate
            {
                var marshaller = new UpdateRecordsRequestMarshaller();
                var unmarshaller = UpdateRecordsResponseUnmarshaller.Instance;
                Invoke(request, callback, state, marshaller, unmarshaller, signer);
            }));
            return;
        }


        #endregion
        
    }
}