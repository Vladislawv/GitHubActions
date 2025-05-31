using GitHubActions.Entities;
using Xunit;

namespace GitHubActions.Tests.Unit.UserTests;

public class CheckAgeTests
{
    [Fact]
    public void CheckAge_LessThanEighteen_ShouldThrowException()
    {
        // Arrange
        var user = new User { Age = 17, Name = "Colin" };
        
        // Act
        var act = () => user.CheckAge();
        
        // Assert
        Assert.Throws<Exception>(act);
    }
    
    [Fact]
    public void CheckAge_GreaterThanEighteen_ShouldNotThrowException()
    {
        // Arrange
        var user = new User { Age = 18, Name = "Colin" };
        
        // Act
        var act = Record.Exception(() => user.CheckAge());

        // Assert
        Assert.Null(act);
    }
}