using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ActivityServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var activities = await this.client.Activities.List(
            new(),
            TestContext.Current.CancellationToken
        );
        activities.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListParks_Works()
    {
        var response = await this.client.Activities.ListParks(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
