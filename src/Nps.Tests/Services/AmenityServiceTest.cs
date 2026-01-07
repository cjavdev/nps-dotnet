using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class AmenityServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var amenities = await this.client.Amenities.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in amenities)
        {
            item.Validate();
        }
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParksPlaces_Works()
    {
        var response = await this.client.Amenities.RetrieveParksPlaces(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in response)
        {
            item.Validate();
        }
    }

    [Fact(Skip = "Prism tests are disabled")]
    public async Task RetrieveParksVisitorCenters_Works()
    {
        var response = await this.client.Amenities.RetrieveParksVisitorCenters(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in response)
        {
            item.Validate();
        }
    }
}
