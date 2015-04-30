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

namespace Amazon.CognitoSync.SyncManager
{
    /// <summary>
    /// This exception is thrown when the dataset that is attempted to access does
    /// not exist.
    /// </summary>
    public class DatasetNotFoundException : DataStorageException
    {
        public DatasetNotFoundException()
            : base()
        {
        }

        public DatasetNotFoundException(string detailMessage, Exception ex)
            : base(detailMessage, ex)
        {
        }

        public DatasetNotFoundException(string detailMessage)
            : base(detailMessage)
        {
        }

        public DatasetNotFoundException(Exception ex)
            : base(ex.Message, ex)
        {
        }
    }
}

