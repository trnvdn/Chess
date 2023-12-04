using System.Windows;

namespace Chess
{
    public static class ChessTable
    {
        public static List<ChessPiece> ChessPieces = new List<ChessPiece>();
        private static Dictionary<string,int> pieceCountRule = new Dictionary<string, int>()
        {
            { "King", 1 },
            { "Queen", 1},
            { "Rook", 2},
            { "Bishop", 2},
            { "Knight", 2},
            { "Pawn", 8}
        };
        public static bool AddPiece(ChessPiece piece)
        {
            if(pieceCountRule.TryGetValue(piece.Name, out var limitCount))
            {
                int currentCount = 0;
                foreach(var chessPiece in ChessPieces)
                {
                    if(chessPiece.Column == piece.Column && chessPiece.Row == piece.Row)
                    {
                        MessageBox.Show($"We already have {chessPiece.GetInfo()}");
                        return false;
                    }
                    if(chessPiece.Name == piece.Name && chessPiece.Color == piece.Color)
                    {
                        currentCount++;
                    }
                    if (currentCount == limitCount)
                    {
                        MessageBox.Show($"There are too many {piece.Name} for {piece.Color} side. Limit is {limitCount}");
                        return false;
                    }
                }
                ChessPieces.Add(piece);
                return true;
            }

            return false;
        }

        public static void RemovePiece(ChessPiece piece)
        {
            ChessPieces.Remove(piece);
        }
    }
}
