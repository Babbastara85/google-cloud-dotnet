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

namespace Google.Cloud.AIPlatform.V1.Snippets
{
    // [START aiplatform_v1_generated_MetadataService_PurgeArtifacts_sync_flattened]
    using Google.Cloud.AIPlatform.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedMetadataServiceClientSnippets
    {
        /// <summary>Snippet for PurgeArtifacts</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void PurgeArtifacts()
        {
            // Create client
            MetadataServiceClient metadataServiceClient = MetadataServiceClient.Create();
            // Initialize request argument(s)
            string parent = "projects/[PROJECT]/locations/[LOCATION]/metadataStores/[METADATA_STORE]";
            // Make the request
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> response = metadataServiceClient.PurgeArtifacts(parent);

            // Poll until the returned long-running operation is complete
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            PurgeArtifactsResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<PurgeArtifactsResponse, PurgeArtifactsMetadata> retrievedResponse = metadataServiceClient.PollOncePurgeArtifacts(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                PurgeArtifactsResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END aiplatform_v1_generated_MetadataService_PurgeArtifacts_sync_flattened]
}