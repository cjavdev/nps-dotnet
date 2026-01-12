using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ActivityServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var page = await this.client.Activities.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListParks_Works()
    {
        var page = await this.client.Activities.ListParks(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }
}
