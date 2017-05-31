using System;
using System.IO;
using System.Collections.Generic;

namespace RPS
{
  public class RockPaperScissors
  {
// // FOR BOOLEAN TESTS
//     public bool CheckForRock(char r)
//     {
//       if( r == 'r'){
//         return true;
//       }
//       else{
//         return false;
//       }
//     }
//     public bool CheckForPaper(char p)
//     {
//       if( p == 'p'){
//         return true;
//       }
//       else{
//         return false;
//       }
//     }
//     public bool CheckForScissors(char s)
//     {
//       if( s == 's'){
//         return true;
//       }
//       else{
//         return false;
//       }
//     }
//FOR STRING TESTING
    public string CheckWinner(char p1, char p2)
    {
      string playerOneWin = "Player One Wins!";
      string playerTwoWin = "Player Two Wins!";
      string computer = "Computer Wins!";
      string draw = "Draw!";
      if (((p1 == 'r') && (p2 == 's')) || ((p1 == 'p') && (p2 == 'r')) || ((p1 == 's') && (p2 == 'p')))
      {
        return playerOneWin;
      }
      else if (((p1 == 's')&&(p2 == 'r')) || ((p1 == 'r')&&(p2 == 'p')) || ((p1 == 'p')&&(p2 == 's')))
      {
        return playerTwoWin;
      }
      else{
        return draw;
      }
    }
  }
}
