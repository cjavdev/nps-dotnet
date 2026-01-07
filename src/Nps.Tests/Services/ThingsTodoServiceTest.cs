using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class ThingsTodoServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var thingsTodos = await this.client.ThingsTodo.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in thingsTodos)
        {
            item.Validate();
        }
    }
}
