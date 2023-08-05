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

     [Fact]
    public void CheckIfCBRespondsToWhatsYourNameTest()
    {
        //Arrange        
        string responseMessage = "";
        ChatBot objectCB = new ChatBot();
        //Act
        responseMessage = objectCB.SendMessage("Whats your name?");
        //Assert
        Assert.Equal("My Name is Siri", responseMessage);
    }

     [Fact]
    public void CheckIfCBRespondsToEmptyTextTest()
    {
        //Arrange        
        string responseMessage = "";
        ChatBot objectCB = new ChatBot();
        //Act
        responseMessage = objectCB.SendMessage(null);
        //Assert
        Assert.Equal("I cannot hear you?", responseMessage);
    }
}