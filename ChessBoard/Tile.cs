using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class Tile
{
	public Tile(bool isBlack)
	{
		IsBlack = isBlack;
	}

	public ChessPiece? ChessPiece { get; set; }
	public bool IsBlack { get; set; }
}