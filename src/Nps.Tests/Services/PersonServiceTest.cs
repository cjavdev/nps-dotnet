using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class PersonServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var people = await this.client.People.List(new(), TestContext.Current.CancellationToken);
        people.Validate();
    }
}
