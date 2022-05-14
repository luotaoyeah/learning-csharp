namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;

class GreetingService : IGreetingService
{
    public string Greet(string name)
    {
        return $"hello {name}";
    }
}
