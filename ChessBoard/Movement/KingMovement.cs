using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class KingMovement : AbstractMovement
{
	public override List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		PlayerEnum owner = tiles[start_y, start_x].ChessPiece.Owner;

		CheckAddSquare(tiles, start_x, start_y, 0, 1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 0, -1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 1, 0, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -1, 0, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 1, 1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -1, 1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, 1, -1, owner, result);
		CheckAddSquare(tiles, start_x, start_y, -1, -1, owner, result);

		return result;
	}
}
