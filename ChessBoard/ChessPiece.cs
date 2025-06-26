using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace chess;

internal class ChessPiece
{
	public PlayerEnum Owner { get; set; }

	public ChessPiece(BitmapImage image, IMovement movement, PlayerEnum owner)
	{
		Image = image;
		Movement = movement;
		Owner = owner;
	}

	public IMovement Movement { get; set; }

	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		return Movement.PossibleMoves(tiles, start_x, start_y);
	}

	public BitmapImage Image { get; set; }
}
