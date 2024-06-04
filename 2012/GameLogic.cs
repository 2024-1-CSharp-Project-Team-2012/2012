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

        // 말 제거 로직 
        public bool RemovePiece(int position)
        {
            return false;
        }

        // 승리 조건 로직
        public bool CheckWin(Piece player)
        {
            Piece opponent = (player == Piece.Player1) ? Piece.Player2 : Piece.Player1;
            int opponentPiecesCount = board.Count(p => p == opponent);

            // 상대방 말의 수가 2개 이하인 경우
            if (opponentPiecesCount <= 2)
            {
                return true;
            }

            // 상대방이 더 이상 움직일 수 없는 경우
            if (!CanMove(opponent))
            {
                return true;
            }

            return false;
        }

        // 움직임 가능성 체크 : 미완성
        public bool CanMove(Piece player)
        {
            return false;
        }
    }
}
