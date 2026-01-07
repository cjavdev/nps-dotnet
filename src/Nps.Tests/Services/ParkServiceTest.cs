using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ParkServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var parks = await this.client.Parks.List(new(), TestContext.Current.CancellationToken);
        foreach (var item in parks)
        {
            item.Validate();
        }
    }
}
