using System.Security.AccessControl;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace chess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Board board;
        public MainWindow()
        {
            InitializeComponent();
            board = new Board();
            DataContext = board;
        }

		private void TileClick(object sender, RoutedEventArgs e)
		{
            var button = (Button)sender;
            var tile = (Tile)button.DataContext;
            if (tile == null) return;
            int index = board.Tiles.IndexOf(tile);
            int row = index / 8;
            int col = index % 8;

            if (board.SelectedPiece == null)
            {
				if (board.TilesTable[row, col].ChessPiece == null) return;
                board.SelectedPiece = (board.TilesTable[row, col].ChessPiece, row, col);
                var possible = board.SelectedPiece.Value.piece.PossibleMoves(board.TilesTable, col, row);
				board.PossibleMoves = possible;
                /*foreach (var tileee in possible)
                {
                    tileee.Color = Brushes.Red;
                }*/
			}
            else
            {
                if (board.PossibleMoves.Contains(board.TilesTable[row, col]))
                {
                    var selected = board.SelectedPiece.Value;
                    board.TilesTable[row, col].ChessPiece = selected.piece;
                    board.TilesTable[selected.row, selected.col].ChessPiece = null;
                }
				board.SelectedPiece = null;
				board.PossibleMoves = null;
			}
        }
    }
}