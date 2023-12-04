using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Chess
{
    /// <summary>
    /// Interaction logic for DeleteForm.xaml
    /// </summary>
    public partial class DeleteForm : Window
    {
        public DeleteForm()
        {
            InitializeComponent();
            InitializeComboBox();
        }

        private void InitializeComboBox()
        {
            foreach (var piece in ChessTable.ChessPieces)
            {
                string pieceInfo = piece.GetInfo();

                ComboBoxItem item = new ComboBoxItem
                {
                    Content = pieceInfo,
                    Tag = piece
                };

                piecesComboBox.Items.Add(item);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (piecesComboBox.SelectedItem != null)
            {
                var selectedItem = (ComboBoxItem)piecesComboBox.SelectedItem;

                var piece = (ChessPiece)selectedItem.Tag;

                ChessTable.RemovePiece(piece);
                MessageBox.Show($"{piece.GetInfo()} has been removed");
                Close();
            }
        }

    }
}
