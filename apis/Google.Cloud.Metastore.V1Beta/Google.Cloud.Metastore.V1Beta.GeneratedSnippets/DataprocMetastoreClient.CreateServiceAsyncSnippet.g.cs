// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.Metastore.V1Beta.Snippets
{
    // [START metastore_v1beta_generated_DataprocMetastore_CreateService_async_flattened]
    using Google.Cloud.Metastore.V1Beta;
    using Google.LongRunning;
    using System.Threading.Tasks;

    public sealed partial class GeneratedDataprocMetastoreClientSnippets
    {
        /// <summary>Snippet for CreateServiceAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task CreateServiceAsync()
        {
            // Create client
            DataprocMetastoreClient dataprocMetastoreClient = await DataprocMetastoreClient.CreateAsync();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]";
            Service service = new Service();
            string serviceId = "";
            // Make the request
            Operation<Service, OperationMetadata> response = await dataprocMetastoreClient.CreateServiceAsync(parent, service, serviceId);

            // Poll until the returned long-running operation is complete
            Operation<Service, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            Service result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Service, OperationMetadata> retrievedResponse = await dataprocMetastoreClient.PollOnceCreateServiceAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Service retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END metastore_v1beta_generated_DataprocMetastore_CreateService_async_flattened]
}