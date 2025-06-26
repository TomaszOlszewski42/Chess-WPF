using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class RookMovement : IMovement
{
	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		for (int i = start_x - 1; i >= 0; i--)
		{
			if (tiles[start_y, i].ChessPiece == null)
				result.Add(tiles[start_y, i]);
			else if (tiles[start_y, i].ChessPiece.Owner != tiles[start_y, start_x].ChessPiece.Owner)
				result.Add(tiles[start_y, i]);
			else
				break;
		}

		for (int i = start_x + 1; i < 8; i++)
		{
			if (tiles[start_y, i].ChessPiece == null)
				result.Add(tiles[start_y, i]);
			else if (tiles[start_y, i].ChessPiece.Owner != tiles[start_y, start_x].ChessPiece.Owner)
				result.Add(tiles[start_y, i]);
			else
				break;
		}

		for (int i = start_y - 1; i >= 0; i--)
		{
			if (tiles[i, start_x].ChessPiece == null)
				result.Add(tiles[i, start_x]);
			else if (tiles[i, start_x].ChessPiece.Owner != tiles[start_y, start_x].ChessPiece.Owner)
				result.Add(tiles[start_y, i]);
			else
				break;
		}

		for (int i = start_y + 1; i < 8; i++)
		{
			if (tiles[i, start_x].ChessPiece == null)
				result.Add(tiles[i, start_x]);
			else if (tiles[i, start_x].ChessPiece.Owner != tiles[start_y, start_x].ChessPiece.Owner)
				result.Add(tiles[start_y, i]);
			else
				break;
		}

		return result;
	}
}
