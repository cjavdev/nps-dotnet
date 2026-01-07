using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ParkinglotServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var parkinglots = await this.client.Parkinglots.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in parkinglots)
        {
            item.Validate();
        }
    }
}
