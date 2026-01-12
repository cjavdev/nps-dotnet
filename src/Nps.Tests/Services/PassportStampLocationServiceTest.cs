using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class PassportStampLocationServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var passportStampLocations = await this.client.PassportStampLocations.List(
            new(),
            TestContext.Current.CancellationToken
        );
        passportStampLocations.Validate();
    }
}
