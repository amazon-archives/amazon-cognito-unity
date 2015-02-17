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
    /// SetIdentityPoolConfiguration Request Marshaller
    /// </summary>       
    public class SetIdentityPoolConfigurationRequestMarshaller : IMarshaller<IRequest, SetIdentityPoolConfigurationRequest> 
    {
        public IRequest Marshall(SetIdentityPoolConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CognitoSync");
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/identitypools/{IdentityPoolId}/configuration";
            uriResourcePath = uriResourcePath.Replace("{IdentityPoolId}", publicRequest.IsSetIdentityPoolId() ? StringUtils.FromString(publicRequest.IdentityPoolId) : string.Empty);
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                if(publicRequest.IsSetPushSync())
                {
                    writer.WritePropertyName("PushSync");
                    writer.WriteObjectStart();
                    if(publicRequest.PushSync.IsSetApplicationArns())
                    {
                        writer.WritePropertyName("ApplicationArns");
                        writer.WriteArrayStart();
                        foreach(var publicRequestPushSyncApplicationArnsListValue in publicRequest.PushSync.ApplicationArns)
                        {
                            writer.Write(publicRequestPushSyncApplicationArnsListValue);
                        }
                        writer.WriteArrayEnd();
                    }

                    if(publicRequest.PushSync.IsSetRoleArn())
                    {
                        writer.WritePropertyName("RoleArn");
                        writer.Write(publicRequest.PushSync.RoleArn);
                    }

                    writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}