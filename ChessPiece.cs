namespace Chess
{
    public abstract class ChessPiece
    {
        public string Name { get; protected set; }
        public int Row { get; set; }
        public char Column { get; set; }
        public string Color { get; set; }

        public string GetInfo()
        {
            return $"{Color} {Name} at {Column}{Row}";
        }
    }

    public class King : ChessPiece
    {
        public King(int row, char column, string color)
        {
            Name = "King";
            Row = row;
            Column = column;
            Color = color;
        }
    }

    public class Queen : ChessPiece
    {
        public Queen(int row, char column, string color)
        {
            Name = "Queen";
            Row = row;
            Column = column;
            Color = color;
        }
    }
    public class Rook : ChessPiece
    {
        public Rook(int row, char column, string color)
        {
            Name = "Rook";
            Row = row;
            Column = column;
            Color = color;
        }
    }
    public class Bishop : ChessPiece
    {
        public Bishop(int row, char column, string color)
        {
            Name = "Bishop";
            Row = row;
            Column = column;
            Color = color;
        }
    }
    public class Knight : ChessPiece
    {
        public Knight(int row, char column, string color)
        {
            Name = "Knight";
            Row = row;
            Column = column;
            Color = color;
        }
    }
    public class Pawn : ChessPiece
    {
        public Pawn(int row, char column, string color)
        {
            Name = "Pawn";
            Row = row;
            Column = column;
            Color = color;
        }
    }
}
