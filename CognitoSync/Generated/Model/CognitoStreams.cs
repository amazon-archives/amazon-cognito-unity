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

/*
 * Do not modify this file. This file is generated from the cognito-sync-2014-06-30.normal.json service model.
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
    /// Configuration options for configure Cognito streams.
    /// </summary>
    public partial class CognitoStreams
    {
        private string _roleArn;
        private StreamingStatus _streamingStatus;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property RoleArn. The ARN of the role Amazon Cognito can assume
        /// in order to publish to the stream. This role must grant access to Amazon Cognito (cognito-sync)
        /// to invoke <code>PutRecord</code> on your Cognito stream.
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StreamingStatus. Status of the Cognito streams. Valid values
        /// are: 
        /// <para>
        /// <code>ENABLED</code> - Streaming of updates to identity pool is enabled.
        /// </para>
        ///  
        /// <para>
        /// <code>DISABLED</code>Streaming of updates to identity pool is disabled. Bulk publish
        /// will also fail if <code>StreamingStatus</code> is <code>DISABLED</code>.
        /// </para>
        /// </summary>
        public StreamingStatus StreamingStatus
        {
            get { return this._streamingStatus; }
            set { this._streamingStatus = value; }
        }

        // Check to see if StreamingStatus property is set
        internal bool IsSetStreamingStatus()
        {
            return this._streamingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. The name of the Cognito stream to receive updates.
        /// This stream must be in the developers account and in the same region as the identity
        /// pool.
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

    }
}