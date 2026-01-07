using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class MapdataServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParkBoundaries_Works()
    {
        var response = await this.client.Mapdata.RetrieveParkBoundaries(
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
