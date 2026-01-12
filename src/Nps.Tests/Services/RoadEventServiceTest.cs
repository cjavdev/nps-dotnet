using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class RoadEventServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var roadEvents = await this.client.RoadEvents.List(
            new(),
            TestContext.Current.CancellationToken
        );
        roadEvents.Validate();
    }
}
