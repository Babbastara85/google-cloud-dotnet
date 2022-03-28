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
    // [START aiplatform_v1_generated_FeaturestoreOnlineServingService_StreamingReadFeatureValues_sync_flattened_resourceNames]
    using Google.Api.Gax.Grpc;
    using Google.Cloud.AIPlatform.V1;
    using System.Threading.Tasks;

    public sealed partial class GeneratedFeaturestoreOnlineServingServiceClientSnippets
    {
        /// <summary>Snippet for StreamingReadFeatureValues</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task StreamingReadFeatureValuesResourceNames()
        {
            // Create client
            FeaturestoreOnlineServingServiceClient featurestoreOnlineServingServiceClient = FeaturestoreOnlineServingServiceClient.Create();
            // Initialize request argument(s)
            EntityTypeName entityType = EntityTypeName.FromProjectLocationFeaturestoreEntityType("[PROJECT]", "[LOCATION]", "[FEATURESTORE]", "[ENTITY_TYPE]");
            // Make the request, returning a streaming response
            FeaturestoreOnlineServingServiceClient.StreamingReadFeatureValuesStream response = featurestoreOnlineServingServiceClient.StreamingReadFeatureValues(entityType);

            // Read streaming responses from server until complete
            // Note that C# 8 code can use await foreach
            AsyncResponseStream<ReadFeatureValuesResponse> responseStream = response.GetResponseStream();
            while (await responseStream.MoveNextAsync())
            {
                ReadFeatureValuesResponse responseItem = responseStream.Current;
                // Do something with streamed response
            }
            // The response stream has completed
        }
    }
    // [END aiplatform_v1_generated_FeaturestoreOnlineServingService_StreamingReadFeatureValues_sync_flattened_resourceNames]
}