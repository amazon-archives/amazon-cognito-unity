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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CognitoSync.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.CognitoSync.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// KinesisStreaming Marshaller
    /// </summary>       
    public class KinesisStreamingMarshaller : IRequestMarshaller<KinesisStreaming, JsonMarshallerContext> 
    {
        public void Marshall(KinesisStreaming requestObject, JsonMarshallerContext context)
        {
            if(requestObject.IsSetKinesisRoleArn())
            {
                context.Writer.WritePropertyName("KinesisRoleArn");
                context.Writer.Write(requestObject.KinesisRoleArn);
            }

            if(requestObject.IsSetStreamingStatus())
            {
                context.Writer.WritePropertyName("StreamingStatus");
                context.Writer.Write(requestObject.StreamingStatus);
            }

            if(requestObject.IsSetStreamName())
            {
                context.Writer.WritePropertyName("StreamName");
                context.Writer.Write(requestObject.StreamName);
            }

        }

        public readonly static KinesisStreamingMarshaller Instance = new KinesisStreamingMarshaller();

    }
}