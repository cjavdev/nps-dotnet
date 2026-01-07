using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class WebcamServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var webcams = await this.client.Webcams.List(new(), TestContext.Current.CancellationToken);
        foreach (var item in webcams)
        {
            item.Validate();
        }
    }
}
