using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ParkingLotServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var parkingLots = await this.client.ParkingLots.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in parkingLots)
        {
            item.Validate();
        }
    }
}
