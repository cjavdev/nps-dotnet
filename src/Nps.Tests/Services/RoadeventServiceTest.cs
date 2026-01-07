using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class RoadeventServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var roadevents = await this.client.Roadevents.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in roadevents)
        {
            item.Validate();
        }
    }
}
