using Soenneker.OpenAq.HttpClients.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenAq.HttpClients.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenAqOpenApiHttpClientTests : HostedUnitTest
{
    private readonly IOpenAqOpenApiHttpClient _httpclient;

    public OpenAqOpenApiHttpClientTests(Host host) : base(host)
    {
        _httpclient = Resolve<IOpenAqOpenApiHttpClient>(true);
    }

    [Test]
    public void Default()
    {

    }
}
