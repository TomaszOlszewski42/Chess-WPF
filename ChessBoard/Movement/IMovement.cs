using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

interface IMovement
{
	public List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y);
}
