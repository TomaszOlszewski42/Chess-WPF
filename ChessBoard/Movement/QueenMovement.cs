using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class QueenMovement : IMovement
{
	private BishopMovement bishop = new BishopMovement();
	private RookMovement rook = new RookMovement();
	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result =
		[
			.. bishop.PossibleMoves(tiles, start_x, start_y),
			.. rook.PossibleMoves(tiles, start_x, start_y),
		];
		return result;
	}
}
