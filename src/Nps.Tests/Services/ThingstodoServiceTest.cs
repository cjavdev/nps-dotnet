using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ThingstodoServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var thingstodos = await this.client.Thingstodo.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in thingstodos)
        {
            item.Validate();
        }
    }
}
