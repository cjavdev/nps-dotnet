using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class NewsreleaseServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var newsreleases = await this.client.Newsreleases.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in newsreleases)
        {
            item.Validate();
        }
    }
}
