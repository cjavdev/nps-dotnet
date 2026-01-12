using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class EventServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var events = await this.client.Events.List(new(), TestContext.Current.CancellationToken);
        events.Validate();
    }
}
