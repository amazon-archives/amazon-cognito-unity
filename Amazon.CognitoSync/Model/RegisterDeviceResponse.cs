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

namespace Amazon.CognitoSync.Model
{
    /// <summary>
    /// Configuration for accessing Amazon RegisterDevice service
    /// </summary>
    public partial class RegisterDeviceResponse : RegisterDeviceResult
    {
        /// <summary>
        /// Gets and sets the RegisterDeviceResult property.
        /// Represents the output of a RegisterDevice operation.
        /// </summary>
        [Obsolete(@"This property has been deprecated. All properties of the RegisterDeviceResult class are now available on the RegisterDeviceResponse class. You should use the properties on RegisterDeviceResponse instead of accessing them through RegisterDeviceResult.")]
        public RegisterDeviceResult RegisterDeviceResult
        {
            get
            {
                return this;
            }
        }
    }
}