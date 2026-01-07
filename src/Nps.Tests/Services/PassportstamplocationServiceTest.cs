using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class PassportstamplocationServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var passportstamplocations = await this.client.Passportstamplocations.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in passportstamplocations)
        {
            item.Validate();
        }
    }
}
