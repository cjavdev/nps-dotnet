using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class AlertServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var alerts = await this.client.Alerts.List(new(), TestContext.Current.CancellationToken);
        alerts.Validate();
    }
}
