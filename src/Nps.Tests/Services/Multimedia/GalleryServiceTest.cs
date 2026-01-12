using System.Threading.Tasks;

namespace Nps.Tests.Services.Multimedia;

public class GalleryServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var page = await this.client.Multimedia.Galleries.List(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListAssets_Works()
    {
        var page = await this.client.Multimedia.Galleries.ListAssets(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }
}
