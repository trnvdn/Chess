﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var form = new AddWindow(chessListView);
            form.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var form = new DeleteForm();
            form.ShowDialog();
            chessListView.Items.Clear();
            foreach(var item in ChessTable.ChessPieces)
            {
                chessListView.Items.Add(item);
            }
        }
    }
}