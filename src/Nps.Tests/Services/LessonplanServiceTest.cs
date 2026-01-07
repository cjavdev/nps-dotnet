using System.Threading.Tasks;

namespace Nps.Tests.Services;

public class LessonplanServiceTest : TestBase
{
    [Fact(Skip = "Prism tests are disabled")]
    public async Task List_Works()
    {
        var lessonplans = await this.client.Lessonplans.List(
            new(),
            TestContext.Current.CancellationToken
        );
        foreach (var item in lessonplans)
        {
            item.Validate();
        }
    }
}
