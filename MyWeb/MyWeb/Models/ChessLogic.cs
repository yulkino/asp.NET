using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    public class ChessLogic
    {
        static string from;
        static string to;

        public static bool Check(string piece, string from0, string to0)
        {
            from = from0; to = to0;
            bool result = false;
            switch (piece)
            {
                case "King": result = CheckKing();
                    break;
                case "Queen": result = CheckQueen();
                    break;
                case "Rook": result = CheckRook();
                    break;
                case "Bishop": result = CheckBishop();
                    break;
                case "Knight": result = CheckKnight();
                    break;
                case "Pawn": result = CheckPawn();
                    break;
            }
            return from == to ? false : result;
        }

        static bool CheckRook() => from[0] == to[0] || from[1] == to[1];

        static bool CheckPawn() => from[1] == to[1] && from[0] - to[0] == 1;

        static bool CheckBishop() => Math.Abs(from[1] - to[1]) == Math.Abs(from[0] - to[0]);

        static bool CheckQueen() => CheckRook() || CheckBishop();

        static bool CheckKing() =>  (Math.Abs(from[0] - to[0]) <= 1 && Math.Abs(from[1] - to[1]) <= 1);

        static bool CheckKnight() => (Math.Abs(from[1] - to[1]) == 1 && Math.Abs(from[0] - to[0]) == 2) 
        || (Math.Abs(from[1] -  to[1]) == 2 && Math.Abs(from[0] - to[0]) == 1);

    }
}
