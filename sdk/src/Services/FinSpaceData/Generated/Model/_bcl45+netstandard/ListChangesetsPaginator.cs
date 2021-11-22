/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the finspace-data-2020-07-13.normal.json service model.
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
 
namespace Amazon.FinSpaceData.Model
{
    /// <summary>
    /// Base class for ListChangesets paginators.
    /// </summary>
    internal sealed partial class ListChangesetsPaginator : IPaginator<ListChangesetsResponse>, IListChangesetsPaginator
    {
        private readonly IAmazonFinSpaceData _client;
        private readonly ListChangesetsRequest _request;
        private int _isPaginatorInUse = 0;
        
        /// <summary>
        /// Enumerable containing all full responses for the operation
        /// </summary>
        public IPaginatedEnumerable<ListChangesetsResponse> Responses => new PaginatedResponse<ListChangesetsResponse>(this);

        /// <summary>
        /// Enumerable containing all of the Changesets
        /// </summary>
        public IPaginatedEnumerable<ChangesetSummary> Changesets => 
            new PaginatedResultKeyResponse<ListChangesetsResponse, ChangesetSummary>(this, (i) => i.Changesets);

        internal ListChangesetsPaginator(IAmazonFinSpaceData client, ListChangesetsRequest request)
        {
            this._client = client;
            this._request = request;
        }
#if BCL
        IEnumerable<ListChangesetsResponse> IPaginator<ListChangesetsResponse>.Paginate()
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListChangesetsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = _client.ListChangesets(_request);
                nextToken = response.NextToken;
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
#if AWS_ASYNC_ENUMERABLES_API
        async IAsyncEnumerable<ListChangesetsResponse> IPaginator<ListChangesetsResponse>.PaginateAsync(CancellationToken cancellationToken = default)
        {
            if (Interlocked.Exchange(ref _isPaginatorInUse, 1) != 0)
            {
                throw new System.InvalidOperationException("Paginator has already been consumed and cannot be reused. Please create a new instance.");
            }
            PaginatorUtils.SetUserAgentAdditionOnRequest(_request);
            var nextToken = _request.NextToken;
            ListChangesetsResponse response;
            do
            {
                _request.NextToken = nextToken;
                response = await _client.ListChangesetsAsync(_request, cancellationToken).ConfigureAwait(false);
                nextToken = response.NextToken;
                cancellationToken.ThrowIfCancellationRequested();
                yield return response;
            }
            while (!string.IsNullOrEmpty(nextToken));
        }
#endif
    }
}