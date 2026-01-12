using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class MapServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParkBoundaries_Works()
    {
        var response = await this.client.Maps.RetrieveParkBoundaries(
            "sitecode",
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
