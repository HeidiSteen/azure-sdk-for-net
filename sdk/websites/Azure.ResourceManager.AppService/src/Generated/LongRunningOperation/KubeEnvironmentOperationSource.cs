// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.AppService
{
    internal class KubeEnvironmentOperationSource : IOperationSource<KubeEnvironmentResource>
    {
        private readonly ArmClient _client;

        internal KubeEnvironmentOperationSource(ArmClient client)
        {
            _client = client;
        }

        KubeEnvironmentResource IOperationSource<KubeEnvironmentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = KubeEnvironmentData.DeserializeKubeEnvironmentData(document.RootElement);
            return new KubeEnvironmentResource(_client, data);
        }

        async ValueTask<KubeEnvironmentResource> IOperationSource<KubeEnvironmentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = KubeEnvironmentData.DeserializeKubeEnvironmentData(document.RootElement);
            return new KubeEnvironmentResource(_client, data);
        }
    }
}
