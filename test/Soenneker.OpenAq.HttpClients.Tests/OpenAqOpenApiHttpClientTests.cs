using Soenneker.OpenAq.HttpClients.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenAq.HttpClients.Tests;

[Collection("Collection")]
public sealed class OpenAqOpenApiHttpClientTests : FixturedUnitTest
{
    private readonly IOpenAqOpenApiHttpClient _httpclient;

    public OpenAqOpenApiHttpClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _httpclient = Resolve<IOpenAqOpenApiHttpClient>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
