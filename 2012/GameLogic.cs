using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2012
{
    public class GameLogic
    {
        public enum Piece { Empty, Player1, Player2 }
        private Piece[] board = new Piece[24];

        public GameLogic()
        {
            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // 게임 시작 전 보드 초기화
            for (int i = 0; i < board.Length; i++)
            {
                board[i] = Piece.Empty;
            }
        }

        public bool PlacePiece(int position, Piece player)
        {
            if (board[position] == Piece.Empty)
            {
                board[position] = player;
                return true;
            }
            return false;
        }

        // 말 제거 로직 
        public bool RemovePiece(int position)
        {
            return false;
        }

        // 승리 조건 로직
        public bool CheckWin(Piece player)
        {
          
            return false;
        }
    }
}
