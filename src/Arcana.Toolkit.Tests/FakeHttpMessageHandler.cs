using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Arcana.Toolkit.Tests
{
    public class FakeHttpMessageHandler<T> : DelegatingHandler
    {
        private readonly FakeMessage<T> _fakeMessage;

        public FakeHttpMessageHandler(FakeMessage<T> fakemessage)
        {
            _fakeMessage = fakemessage;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var httpresponsemessage = new HttpResponseMessage
            {
                StatusCode = (HttpStatusCode)_fakeMessage.ReturnCode,
                Content = new StringContent(JsonSerializer.Serialize(_fakeMessage.Content))
            };
            return await Task.FromResult(httpresponsemessage);
        }
    }
}
