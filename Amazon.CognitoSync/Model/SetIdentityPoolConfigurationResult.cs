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
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Response to a <code>SetIdentityPoolConfiguration</code> request.
    /// </summary>
    public partial class SetIdentityPoolConfigurationResult : AmazonWebServiceResponse
    {
        private string _identityPoolId;
        private PushSync _pushSync;


        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// A name-spaced GUID (for example, us-east-1:23EC4050-6AEA-7089-A2DD-08002EXAMPLE) created
        /// by Amazon Cognito.
        /// </para>
        /// </summary>
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }


        /// <summary>
        /// Gets and sets the property PushSync. 
        /// <para>
        /// Configuration options applied to the identity pool.
        /// </para>
        /// </summary>
        public PushSync PushSync
        {
            get { return this._pushSync; }
            set { this._pushSync = value; }
        }

        // Check to see if PushSync property is set
        internal bool IsSetPushSync()
        {
            return this._pushSync != null;
        }

    }
}