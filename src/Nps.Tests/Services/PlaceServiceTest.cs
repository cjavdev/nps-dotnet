using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class PlaceServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var page = await this.client.Places.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }
}
