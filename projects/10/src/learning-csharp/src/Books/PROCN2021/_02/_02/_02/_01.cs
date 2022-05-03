namespace Luotao.LearningCsharp.Test.Books.PROCN2021._02._02._02;

/// <summary>
/// 2.2.2. nullable reference types
/// </summary>
public class _01
{
    private readonly ITestOutputHelper testOutputHelper;

    public _01(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void _02()
    {
#nullable disable
        Book book = null;
        Assert.Null(book);

#nullable restore

#nullable enable
        Book book02 = new Book();
        Assert.NotNull(book02);
#nullable restore
    }
}

class Book
{
    private void Fn02()
    {
    }

    static void Fn01(Book? book)
    {
        if (book is not null)
        {
            Console.WriteLine("");
        }

        if (book != null)
        {
            Console.WriteLine("");
        }

        book?.Fn02();
    }
}
