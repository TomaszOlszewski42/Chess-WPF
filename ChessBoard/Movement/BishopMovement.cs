using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class BishopMovement : IMovement
{
	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		PlayerEnum owner = tiles[start_y, start_x].ChessPiece.Owner;
		
		for (int i = 1; i < 8; i++)
		{
			if (start_x + i >= 0 && start_x + i < 8 && start_y + i >= 0 && start_y + i < 8)
				if (tiles[start_y + i, start_x + i].ChessPiece == null)
					result.Add(tiles[start_y + i, start_x + i]);
				else
				{
					if (tiles[start_y + i, start_x + i].ChessPiece.Owner != owner)
						result.Add(tiles[start_y + i, start_x + i]);
					break;
				}
		}

		for (int i = -1; i > -8; i--)
		{
			if (start_x + i >= 0 && start_x + i < 8 && start_y + i >= 0 && start_y + i < 8)
				if (tiles[start_y + i, start_x + i].ChessPiece == null)
					result.Add(tiles[start_y + i, start_x + i]);
				else
				{
					if (tiles[start_y + i, start_x + i].ChessPiece.Owner != owner)
						result.Add(tiles[start_y + i, start_x + i]);
					break;
				}
		}

		for (int i = 1; i < 8; i++)
		{
			if (start_x - i >= 0 && start_x - i < 8 && start_y + i >= 0 && start_y + i < 8)
				if (tiles[start_y + i, start_x - i].ChessPiece == null)
					result.Add(tiles[start_y + i, start_x - i]);
				else
				{
					if (tiles[start_y + i, start_x - i].ChessPiece.Owner != owner)
						result.Add(tiles[start_y + i, start_x - i]);
					break;
				}
		}

		for (int i = -1; i > -8; i--)
		{
			if (start_x - i >= 0 && start_x - i < 8 && start_y + i >= 0 && start_y + i < 8)
				if (tiles[start_y + i, start_x - i].ChessPiece == null)
					result.Add(tiles[start_y + i, start_x - i]);
				else
				{
					if (tiles[start_y + i, start_x - i].ChessPiece.Owner != owner)
						result.Add(tiles[start_y + i, start_x - i]);
					break;
				}
		}

		return result;
	}
}
