using Microsoft.Extensions.Options;

namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;

class GreetingService02 : IGreetingService02
{
    private readonly int age;

    public GreetingService02(IOptions<GreetingServiceOptions> options)
    {
        age = options.Value.Age;
    }

    public string Greet(string name)
    {
        return $"hello {name} {age}";
    }
}
