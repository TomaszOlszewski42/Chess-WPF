using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal abstract class AbstractMovement : IMovement
{
	public abstract List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y);
	protected bool? CheckAddSquare(Tile[,] tiles, int start_x, int start_y, int add_x, int add_y, PlayerEnum our_owner, List<Tile> result_tiles)
	{
		if (start_y + add_y < 0 || start_y + add_y >= 8 || start_x + add_x < 0 || start_x + add_x >= 8) return null;

		if (tiles[start_y + add_y, start_x + add_x].ChessPiece == null)
		{
			result_tiles.Add(tiles[start_y + add_y, start_x + add_x]);
			return false;
		}
		else if (tiles[start_y + add_y, start_x + add_x].ChessPiece.Owner != our_owner)
		{
			result_tiles.Add(tiles[start_y + add_y, start_x + add_x]);
			return true;
		}
		return null;
	}
}
