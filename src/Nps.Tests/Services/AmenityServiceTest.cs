using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class AmenityServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var page = await this.client.Amenities.List(new(), TestContext.Current.CancellationToken);
        page.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListParksPlaces_Works()
    {
        var page = await this.client.Amenities.ListParksPlaces(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task ListParksVisitorCenters_Works()
    {
        var page = await this.client.Amenities.ListParksVisitorCenters(
            new(),
            TestContext.Current.CancellationToken
        );
        page.Validate();
    }
}
