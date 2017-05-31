using Xunit;
using System;

namespace RPS
{
  public class RockPaperScissorsTest
  {
// BOOLEAN TESTING
    // [Fact]
    // public void IsCheckForRock_true()
    // {
    //   RockPaperScissors rock = new RockPaperScissors();
    //   Assert.Equal(true, rock.CheckForRock('r'));
    // }
    // [Fact]
    // public void IsCheckForPaper_true()
    // {
    //   RockPaperScissors paper = new RockPaperScissors();
    //   Assert.Equal(true, paper.CheckForPaper('p'));
    // }
    // [Fact]
    // public void IsCheckForScissors_true()
    // {
    //   RockPaperScissors scissors = new RockPaperScissors();
    //   Assert.Equal(true, scissors.CheckForScissors('s'));
    // }
//STRING TESTING
    [Fact]
    public void IsCheckPlayerOneWin_true()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "rock";
      char playerOne = playerOneInput[0];
      char playerTwo = playerTwoInput[0];
      RockPaperScissors testGame = new RockPaperScissors();
      Assert.Equal("Player One Wins!", testGame.CheckWinner(playerOne, playerTwo));
      Console.WriteLine("Player One Wins with " + playerOneInput);
    }
    [Fact]
    public void IsCheckPlayerTwoWin_true()
    {
      string playerOneInput = "paper";
      string playerTwoInput = "scissors";
      char playerOne = playerOneInput[0];
      char playerTwo = playerTwoInput[0];
      RockPaperScissors testGame = new RockPaperScissors();
      Assert.Equal("Player Two Wins!", testGame.CheckWinner(playerOne, playerTwo));
      Console.WriteLine("Player Two Wins with " + playerTwoInput);
    }
    [Fact]
    public void IsDraw_true()
    {
      string playerOneInput = "scissors";
      string playerTwoInput = "scissors";
      char playerOne = playerOneInput[0];
      char playerTwo = playerTwoInput[0];
      RockPaperScissors testGame = new RockPaperScissors();
      Assert.Equal("Draw!", testGame.CheckWinner(playerOne, playerTwo));
      Console.WriteLine("Draw " + playerOneInput + " = " + playerTwoInput);
    }
    [Fact]
    public void IsCheckComputerWin_true()
    {
      string playerInput = "paper";
      string computerInput = "scissors";
      char player = playerInput[0];
      char computer = computerInput[0];
      RockPaperScissors testGame = new RockPaperScissors();
      Assert.Equal("Player Two Wins!", testGame.CheckWinner(player, computer));
      Console.WriteLine("Computer wins with " + computerInput);
    }
  }
}
