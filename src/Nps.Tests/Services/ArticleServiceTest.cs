using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ArticleServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var articles = await this.client.Articles.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in articles)
        {
            item.Validate();
        }
    }
}
