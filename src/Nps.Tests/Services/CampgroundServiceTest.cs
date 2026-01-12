using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class CampgroundServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var campgrounds = await this.client.Campgrounds.List(
            new(),
            TestContext.Current.CancellationToken
        );
        campgrounds.Validate();
    }
}
