using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class MultimediaServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListAudio_Works()
    {
        var response = await this.client.Multimedia.ListAudio(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListVideos_Works()
    {
        var response = await this.client.Multimedia.ListVideos(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
