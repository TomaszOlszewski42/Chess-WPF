using System.Collections.ObjectModel;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace chess;

internal class Board
{
	public ObservableCollection<Tile> Tiles { get; set; }
	public Tile[,] TilesTable;
	public (ChessPiece? piece, int row, int col)? SelectedPiece { get; set; }
	public List<Tile>? PossibleMoves { get; set; }
	public Board()
	{
		ClassicBoard();
	}

	private void ClassicBoard()
	{
		TilesTable = new Tile[8, 8];
		Tiles = new ObservableCollection<Tile>();
		for (int i = 0; i < 8; i++)
		{
			for (int j = 0; j < 8; j++)
			{
				if (i % 2 == 0 && j % 2 == 0)
					TilesTable[i, j] = new Tile(false, Brushes.White, Brushes.Red);
				else if (i % 2 == 0)
					TilesTable[i, j] = new Tile(true, Brushes.Black, Brushes.DarkRed);
				else if (j % 2 == 0)
					TilesTable[i, j] = new Tile(true, Brushes.Black, Brushes.DarkRed);
				else
					TilesTable[i, j] = new Tile(false, Brushes.White, Brushes.Red);
				Tiles.Add(TilesTable[i, j]);
			}
		}

		BitmapImage w_pawn = LoadImage("..\\..\\..\\images\\white_pawn.png");
		BitmapImage w_rook = LoadImage("..\\..\\..\\images\\white_rook.png");
		BitmapImage w_bishop = LoadImage("..\\..\\..\\images\\white_bishop.png");
		BitmapImage w_queen = LoadImage("..\\..\\..\\images\\white_queen.png");
		BitmapImage w_king = LoadImage("..\\..\\..\\images\\white_king.png");
		BitmapImage w_knight = LoadImage("..\\..\\..\\images\\white_knight.png");
		BitmapImage b_pawn = LoadImage("..\\..\\..\\images\\black_pawn.png");
		BitmapImage b_rook = LoadImage("..\\..\\..\\images\\black_rook.png");
		BitmapImage b_bishop = LoadImage("..\\..\\..\\images\\black_bishop.png");
		BitmapImage b_queen = LoadImage("..\\..\\..\\images\\black_queen.png");
		BitmapImage b_king = LoadImage("..\\..\\..\\images\\black_king.png");
		BitmapImage b_knight = LoadImage("..\\..\\..\\images\\black_knight.png");


		TilesTable[7, 0].ChessPiece = new ChessPiece(w_rook, new RookMovement(), PlayerEnum.White);
		TilesTable[7, 2].ChessPiece = new ChessPiece(w_bishop, new BishopMovement(), PlayerEnum.White);
		TilesTable[7, 3].ChessPiece = new ChessPiece(w_queen, new QueenMovement(), PlayerEnum.White);
		TilesTable[4, 3].ChessPiece = new ChessPiece(w_knight, new KnightMovement(), PlayerEnum.White);
	}

	private BitmapImage LoadImage(string path)
	{
		BitmapImage image = new BitmapImage();
		image.BeginInit();
		image.UriSource = new Uri(path, UriKind.Relative);
		image.CacheOption = BitmapCacheOption.OnLoad;
		image.EndInit();

		return image;
	}
}
