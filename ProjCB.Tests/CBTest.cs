using ProjCB;
namespace ProjCB.Tests;

public class CBTest
{
    [Fact]
    public void CheckIfCBRespondsToHiTest()
    {
        //Arrange        
        string responseMessage = "";
        ChatBot objectCB = new ChatBot();
        //Act
        responseMessage = objectCB.SendMessage("Hi CB.. How are you?");
        //Assert
        Assert.Equal("Hello", responseMessage);
    }
}