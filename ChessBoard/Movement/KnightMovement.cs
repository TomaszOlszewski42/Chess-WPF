using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class KnightMovement : AbstractMovement
{
	public override List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		PlayerEnum owner = tiles[start_y, start_x].ChessPiece.Owner;

		CheckAddSquare(tiles, start_x, start_y, 2, 1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 2, -1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -2, 1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -2, -1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 1, 2, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -1, 2, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 1, -2, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -1, -2, owner, result);

		return result;
	}
}
