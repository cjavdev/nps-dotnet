using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class MapdataServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParkboundaries_Works()
    {
        var response = await this.client.Mapdata.RetrieveParkboundaries(
            "sitecode",
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in response)
        {
            item.Validate();
        }
    }
}
