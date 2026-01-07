using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class TopicServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var topics = await this.client.Topics.List(new(), TestContext.Current.CancellationToken);
        foreach (var item in topics)
        {
            item.Validate();
        }
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParks_Works()
    {
        var response = await this.client.Topics.RetrieveParks(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in response)
        {
            item.Validate();
        }
    }
}
