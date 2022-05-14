namespace Luotao.LearningCsharp.Test.Books.PROCN2021._15._00;

public class HomeController
{
    private readonly IGreetingService greetingService;
    private readonly IGreetingService02 greetingService02;

    public HomeController(IGreetingService greetingService, IGreetingService02 greetingService02)
    {
        this.greetingService = greetingService;
        this.greetingService02 = greetingService02;
    }

    public string Hello(string name)
    {
        return greetingService.Greet(name);
    }

    public string F02(string name)
    {
        return greetingService02.Greet(name);
    }
}
