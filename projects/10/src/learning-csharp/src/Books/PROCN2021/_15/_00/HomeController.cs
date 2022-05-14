namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;

public class HomeController
{
    private readonly IGreetingService greetingService;

    public HomeController(IGreetingService greetingService)
    {
        this.greetingService = greetingService;
    }

    public string Hello(string name)
    {
        return greetingService.Greet(name);
    }
}
