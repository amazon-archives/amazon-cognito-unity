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
    /// <summary>
    /// This exception is thrown when an error occurs during an data storage
    /// operation.
    /// </summary>
    public class DataStorageException : SyncManagerException
    {
        public DataStorageException()
            : base()
        {
        }

        public DataStorageException(string detailMessage, Exception ex)
            : base(detailMessage, ex)
        {
        }

        public DataStorageException(string detailMessage)
            : base(detailMessage)
        {
        }

        public DataStorageException(Exception ex)
            : base(ex.Message, ex)
        {
        }
    }
}

