using System.Threading.Tasks;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._11._02
{
    namespace _00
    {
        /// <summary>
        /// 11.2. task-based async pattern
        /// </summary>
        public class T00
        {
            private readonly ITestOutputHelper testOutputHelper;

            public T00(ITestOutputHelper testOutputHelper)
            {
                this.testOutputHelper = testOutputHelper;
            }

            [Fact]
            public async Task _01()
            {
                using HttpClient httpClient = new HttpClient();

                try
                {
                    using HttpResponseMessage httpResponseMessage = await httpClient.GetAsync(new Uri("https://github.com/"));

                    if (httpResponseMessage.IsSuccessStatusCode)
                    {
                        string content = await httpResponseMessage.Content.ReadAsStringAsync();
                        testOutputHelper.WriteLine(content[..1000]);
                    }
                    else
                    {
                        testOutputHelper.WriteLine(httpResponseMessage.StatusCode.ToString());
                    }
                }
                catch (HttpRequestException e)
                {
                    testOutputHelper.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    testOutputHelper.WriteLine(e.Message);
                }
            }
        }
    }
}
