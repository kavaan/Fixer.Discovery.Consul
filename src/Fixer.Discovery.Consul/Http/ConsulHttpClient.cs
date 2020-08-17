using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Fixer.HTTP;
using Microsoft.Extensions.Logging;

namespace Fixer.Discovery.Consul.Http
{
    internal sealed class ConsulHttpClient : FixerHttpClient, IConsulHttpClient
    {
        public ConsulHttpClient(HttpClient client, HttpClientOptions options, ILogger<IHttpClient> logger)
            : base(client, options, logger)
        {
        }
    }
}
