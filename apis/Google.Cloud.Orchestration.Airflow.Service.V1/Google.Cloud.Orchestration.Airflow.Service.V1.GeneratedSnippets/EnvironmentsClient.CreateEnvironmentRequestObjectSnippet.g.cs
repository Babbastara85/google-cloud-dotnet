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

namespace Google.Cloud.Orchestration.Airflow.Service.V1.Snippets
{
    // [START composer_v1_generated_Environments_CreateEnvironment_sync]
    using Google.Cloud.Orchestration.Airflow.Service.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedEnvironmentsClientSnippets
    {
        /// <summary>Snippet for CreateEnvironment</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void CreateEnvironmentRequestObject()
        {
            // Create client
            EnvironmentsClient environmentsClient = EnvironmentsClient.Create();
            // Initialize request argument(s)
            CreateEnvironmentRequest request = new CreateEnvironmentRequest
            {
                Parent = "",
                Environment = new Environment(),
            };
            // Make the request
            Operation<Environment, OperationMetadata> response = environmentsClient.CreateEnvironment(request);

            // Poll until the returned long-running operation is complete
            Operation<Environment, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Environment result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Environment, OperationMetadata> retrievedResponse = environmentsClient.PollOnceCreateEnvironment(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Environment retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END composer_v1_generated_Environments_CreateEnvironment_sync]
}