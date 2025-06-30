using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class BishopMovement : AbstractMovement
{
	public override List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		PlayerEnum owner = tiles[start_y, start_x].ChessPiece.Owner;
		
		for (int i = 1; i < 8; i++)
		{
			var returned = CheckAddSquare(tiles, start_x, start_y, i, i, owner, result);
			if (returned == null) break;
			if (returned.Value) break;
		}

		for (int i = -1; i > -8; i--)
		{
			var returned = CheckAddSquare(tiles, start_x, start_y, i, i, owner, result);
			if (returned == null) break;
			if (returned.Value) break;
		}

		for (int i = 1; i < 8; i++)
		{
			var returned = CheckAddSquare(tiles, start_x, start_y, -i, i, owner, result);
			if (returned == null) break;
			if (returned.Value) break;
		}

		for (int i = -1; i > -8; i--)
		{
			var returned = CheckAddSquare(tiles, start_x, start_y, -i, i, owner, result);
			if (returned == null) break;
			if (returned.Value) break;
		}

		return result;
	}
}
