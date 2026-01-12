using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class TopicServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var page = await this.client.Topics.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParks_Works()
    {
        var response = await this.client.Topics.RetrieveParks(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
