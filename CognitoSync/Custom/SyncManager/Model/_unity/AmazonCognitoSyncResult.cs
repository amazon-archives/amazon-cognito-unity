//
// Copyright 2014-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
//
//
// Licensed under the AWS Mobile SDK for Unity Developer Preview License Agreement (the "License").
// You may not use this file except in compliance with the License.
// A copy of the License is located in the "license" file accompanying this file.
// See the License for the specific language governing permissions and limitations under the License.
//
//

using System;
using Amazon.Runtime;

namespace Amazon.CognitoSync.SyncManager
{
    public delegate void AmazonCognitoSyncCallback<TResponse>(AmazonCognitoSyncResult<TResponse> result);

    public delegate void AmazonCognitoSyncCallback(AmazonCognitoSyncResult result);

    public class AmazonCognitoSyncResult<TResponse>
    {
        public TResponse Response { get; internal set; }

        public Exception Exception { get; internal set; }

        public object State { get; internal set; }

        public AmazonCognitoSyncResult(object state)
        {
            this.State = state;
        }

        public AmazonCognitoSyncResult(TResponse response, Exception exception, object state)
        {
            this.Response = response;
            this.Exception = exception;
            this.State = state;
        }
    }

    public class AmazonCognitoSyncResult
    {
        public Exception Exception { get; internal set; }

        public object State { get; internal set; }

        public AmazonCognitoSyncResult(object state)
        {
            this.State = state;
        }

        public AmazonCognitoSyncResult(Exception exception, object state)
        {
            this.Exception = exception;
            this.State = state;
        }
    }

}