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

namespace Google.Cloud.Video.LiveStream.V1.Snippets
{
    // [START livestream_v1_generated_LivestreamService_ListEvents_async]
    using Google.Api.Gax;
    using Google.Cloud.Video.LiveStream.V1;
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    public sealed partial class GeneratedLivestreamServiceClientSnippets
    {
        /// <summary>Snippet for ListEventsAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task ListEventsRequestObjectAsync()
        {
            // Create client
            LivestreamServiceClient livestreamServiceClient = await LivestreamServiceClient.CreateAsync();
            // Initialize request argument(s)
            ListEventsRequest request = new ListEventsRequest
            {
                ParentAsChannelName = ChannelName.FromProjectLocationChannel("[PROJECT]", "[LOCATION]", "[CHANNEL]"),
                Filter = "",
                OrderBy = "",
            };
            // Make the request
            PagedAsyncEnumerable<ListEventsResponse, Event> response = livestreamServiceClient.ListEventsAsync(request);

            // Iterate over all response items, lazily performing RPCs as required
            await response.ForEachAsync((Event item) =>
            {
                // Do something with each item
                Console.WriteLine(item);
            });

            // Or iterate over pages (of server-defined size), performing one RPC per page
            await response.AsRawResponses().ForEachAsync((ListEventsResponse page) =>
            {
                // Do something with each page of items
                Console.WriteLine("A page of results:");
                foreach (Event item in page)
                {
                    // Do something with each item
                    Console.WriteLine(item);
                }
            });

            // Or retrieve a single page of known size (unless it's the final page), performing as many RPCs as required
            int pageSize = 10;
            Page<Event> singlePage = await response.ReadPageAsync(pageSize);
            // Do something with the page of items
            Console.WriteLine($"A page of {pageSize} results (unless it's the final page):");
            foreach (Event item in singlePage)
            {
                // Do something with each item
                Console.WriteLine(item);
            }
            // Store the pageToken, for when the next page is required.
            string nextPageToken = singlePage.NextPageToken;
        }
    }
    // [END livestream_v1_generated_LivestreamService_ListEvents_async]
}