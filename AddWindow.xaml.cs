using System.Windows;
using System.Windows.Controls;

namespace Chess
{
    /// <summary>
    /// Interaction logic for AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private ListView listView;
        public AddWindow(ListView chessListView)
        {
            listView = chessListView;
            InitializeComponent();

            InitializeComboBoxes();
        }

        private void InitializeComboBoxes()
        {
            pieceBox.Items.Add("King");
            pieceBox.Items.Add("Queen");
            pieceBox.Items.Add("Rook");
            pieceBox.Items.Add("Bishop");
            pieceBox.Items.Add("Knight");
            pieceBox.Items.Add("Pawn");

            for (char column = 'A'; column <= 'H'; column++)
            {
                columnBox.Items.Add(new ComboBoxItem { Content = column.ToString(), Tag = column.ToString() });
            }

            for (int row = 1; row <= 8; row++)
            {
                rowBox.Items.Add(new ComboBoxItem { Content = row.ToString(), Tag = row.ToString() });
            }
            colorBox.Items.Add("White");
            colorBox.Items.Add("Black");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(columnBox.Text) && !string.IsNullOrEmpty(rowBox.Text) && !string.IsNullOrEmpty(pieceBox.Text) && !string.IsNullOrEmpty(colorBox.Text))
            {
                
                char column = columnBox.Text[0];
                int row = int.Parse(rowBox.Text);
                string color = colorBox.Text;

                ChessPiece piece = null;
                switch (pieceBox.SelectedIndex)
                {
                    case 0:
                        piece = new King(row,column,color);
                        break;
                    case 1:
                        piece = new Queen(row, column, color);
                        break;
                    case 2:
                        piece = new Rook(row, column, color);
                        break;
                    case 3:
                        piece = new Bishop(row, column,color);
                        break;
                    case 4:
                        piece = new Knight(row, column, color);
                        break;
                    case 5:
                        piece = new Pawn(row, column, color);
                        break;
                }
                bool isSuccess = ChessTable.AddPiece(piece);
                if(isSuccess)
                {
                    listView.Items.Add(ChessTable.ChessPieces.Last());
                    MessageBox.Show($"Added {ChessTable.ChessPieces.Last().GetInfo()}");
                    Close();
                }
            }
        }
    }
}
