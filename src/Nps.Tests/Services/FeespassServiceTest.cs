using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class FeespassServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var feespasses = await this.client.Feespasses.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in feespasses)
        {
            item.Validate();
        }
    }
}
