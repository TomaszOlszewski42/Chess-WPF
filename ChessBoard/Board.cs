using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

		BitmapImage pawn = new BitmapImage();
		pawn.BeginInit();
		pawn.UriSource = new Uri("..\\..\\..\\images\\white_pawn.png", UriKind.Relative);
		pawn.CacheOption = BitmapCacheOption.OnLoad;
		pawn.EndInit();
		TilesTable[6, 0].ChessPiece = new ChessPiece(pawn, new PawnMovement(-1), PlayerEnum.White);

		BitmapImage rook = new BitmapImage();
		rook.BeginInit();
		rook.UriSource = new Uri("..\\..\\..\\images\\white_rook.png", UriKind.Relative);
		rook.CacheOption = BitmapCacheOption.OnLoad;
		rook.EndInit();

		TilesTable[7, 0].ChessPiece = new ChessPiece(rook, new RookMovement(), PlayerEnum.White);
	}
}
