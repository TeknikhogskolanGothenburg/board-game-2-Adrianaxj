using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Square
    {
        public int squareNumber { get; set; }
        public int player { get; set; }
    }

    public class Player
    {
        public int Id { get; set; }
        public string SessionId { get; set; }
    }

    public class GameEngine
    {
        public List<Square> squares = new List<Square>();
        public List<Player> players = new List<Player>();
        public int currentPlayer = 1;

        public GameEngine()
        {
            for (int i = 0; i < 9; i++)
            {
                Square square = new Square();
                square.player = 0;
                squares.Add(square);
            }
        }

        public int GetPlayer(string sessionId)
        {
            if (players.Count > 0 && players[0].SessionId == sessionId)
                return 1;

            if (players.Count > 1 && players[1].SessionId == sessionId)
                return 2;

            if (players.Count == 0)
            {
                players.Add(new Player { Id = 1, SessionId = sessionId });
                return 1;
            }
            if (players.Count == 1)
            {
                players.Add(new Player { Id = 2, SessionId = sessionId });
                return 2;
            }
            if (players.Count > 0 && players[0].SessionId == null)
            {
                players[0].SessionId = sessionId;
            }
            
            if(players[1].SessionId == null)
            {
                players[1].SessionId = sessionId;
            }

            return -1;
        }

        public void PlayerLeave(int player)
        {
            players[player-1].SessionId = null;
        }

        public bool MakeMove(int player, int position)
        {
            if(currentPlayer == player)
            {
                if (squares[position].player == 0)
                {
                    squares[position].player = player;
                    if (player == 1)
                        currentPlayer = 2;
                    if (player == 2)
                        currentPlayer = 1;
                    return true;
                }
            }
            return false;
        }

        public int HasWon()
        {
            if(squares[0].player == 1 &&
               squares[1].player == 1 &&
               squares[2].player == 1)
            {
                return 1;
            }

            if (squares[3].player == 1 &&
               squares[4].player == 1 &&
               squares[5].player == 1)
            {
                return 1;
            }

            if (squares[6].player == 1 &&
               squares[7].player == 1 &&
               squares[8].player == 1)
            {
                return 1;
            }

            if (squares[0].player == 1 &&
               squares[3].player == 1 &&
               squares[6].player == 1)
            {
                return 1;
            }

            if (squares[1].player == 1 &&
               squares[4].player == 1 &&
               squares[7].player == 1)
            {
                return 1;
            }

            if (squares[2].player == 1 &&
               squares[5].player == 1 &&
               squares[8].player == 1)
            {
                return 1;
            }

            if (squares[0].player == 1 &&
               squares[4].player == 1 &&
               squares[8].player == 1)
            {
                return 1;
            }



            if (squares[0].player == 2 &&
              squares[1].player == 2 &&
              squares[2].player == 2)
            {
                return 2;
            }

            if (squares[3].player == 2 &&
               squares[4].player == 2 &&
               squares[5].player == 2)
            {
                return 2;
            }

            if (squares[6].player == 2 &&
               squares[7].player == 2 &&
               squares[8].player == 2)
            {
                return 2;
            }

            if (squares[0].player == 2 &&
               squares[3].player == 2 &&
               squares[6].player == 2)
            {
                return 2;
            }

            if (squares[1].player == 2 &&
               squares[4].player == 2 &&
               squares[7].player == 2)
            {
                return 2;
            }

            if (squares[2].player == 2 &&
               squares[5].player == 2 &&
               squares[8].player == 2)
            {
                return 2;
            }

            if (squares[0].player == 2 &&
               squares[4].player == 2 &&
               squares[8].player == 2)
            {
                return 2;
            }

            return 0;


        }

    }
}
