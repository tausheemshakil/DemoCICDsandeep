using corewebapp.Controller;
using Xunit;

namespace corewebappTest;

public class UnitTest1
{
    ValuesController valController = new ValuesController();        //Arrange

    [Fact]  // Arrange, Act, Assert
    public void Test1()
    {   
        var test = valController.Get(1);                            //Act
        Assert.Equal("Tausheemgit", test);
    }
}