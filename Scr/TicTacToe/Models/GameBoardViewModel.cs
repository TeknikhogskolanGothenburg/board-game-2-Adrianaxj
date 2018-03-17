using GameLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static GameLogic.GameEngine;

namespace TicTacToe.Models
{
    public class GameBoardViewModel
    {
        public int player;
        public int currentPlayer;
        public List<Square> squares;
        public GameBoardViewModel() { squares = new List<Square> ();}

    }

}