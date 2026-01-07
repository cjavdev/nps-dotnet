using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class VisitorcenterServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var visitorcenters = await this.client.Visitorcenters.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in visitorcenters)
        {
            item.Validate();
        }
    }
}
