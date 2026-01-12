using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class VisitorCenterServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var visitorCenters = await this.client.VisitorCenters.List(
            new(),
            TestContext.Current.CancellationToken
        );
        visitorCenters.Validate();
    }
}
