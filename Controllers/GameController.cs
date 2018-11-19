using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab1.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Lab1.Controllers
{
    public class GameController : Controller
    {
        public IActionResult Game()
        {
            return View(new GameViewModel());
        }
        
        public static string DetectWinner(string player1, string player2)
        {
            if (player1 == null || player2 == null)
                return "Oh, Unknown Thing";
            player1 = player1.ToLower();
            player2 = player2.ToLower();

            string[] moves = new string[] { "scissor", "paper", "rock", "lizard", "spock" };

            if (moves.FirstOrDefault(m => m == player1) != null && player1 == player2)
                return "Draw!";

            if (moves.FirstOrDefault(m => m == player1) == null || moves.FirstOrDefault(m => m == player2) == null)
                return "Oh, Unknown Thing";

            if (player1 == moves[0] && (player2 == moves[1] || player2 == moves[3]))
                return "Player 1 won!";
            if (player1 == moves[1] && (player2 == moves[2] || player2 == moves[4]))
                return "Player 1 won!";
            if (player1 == moves[2] && (player2 == moves[0] || player2 == moves[3]))
                return "Player 1 won!";
            if (player1 == moves[3] && (player2 == moves[1] || player2 == moves[4]))
                return "Player 1 won!";
            if (player1 == moves[4] && (player2 == moves[0] || player2 == moves[2]))
                return "Player 1 won!";
            else
                return "Player 2 won!";
        }
    }
}