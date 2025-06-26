using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

class PawnMovement : IMovement
{
	private int _direction;

	public PawnMovement(int direction)
	{
		_direction = direction;
	}

	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();

		if (tiles[start_y + _direction, start_x].ChessPiece == null)
			result.Add(tiles[start_y + _direction, start_x]);

		return result;
	}
}
