namespace ProjCB.Tests;

public class CBTest
{
    [Fact]
    public void CheckIfCBRespondsToHiTest()
    {
        //Arrange        
        string responseMessage = "Hello";
        ChatBot objectCB = new ChatBot();
        //Act
        responseMessage = ObjectCB.SendMessage("Hi CB.. How are you?");
        //Assert
        Assert.Equal("Hello", responseMessage);
    }
}