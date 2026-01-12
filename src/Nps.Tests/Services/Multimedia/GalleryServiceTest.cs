using System.Threading.Tasks;

namespace Nps.Tests.Services.Multimedia;

public class GalleryServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var galleries = await this.client.Multimedia.Galleries.List(
            new(),
            TestContext.Current.CancellationToken
        );
        galleries.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListAssets_Works()
    {
        var response = await this.client.Multimedia.Galleries.ListAssets(
            new(),
            TestContext.Current.CancellationToken
        );
        response.Validate();
    }
}
