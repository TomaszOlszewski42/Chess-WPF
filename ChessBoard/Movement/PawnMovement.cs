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

		if (start_y + _direction < 8 && start_y + _direction >= 0 && tiles[start_y + _direction, start_x].ChessPiece == null)
			result.Add(tiles[start_y + _direction, start_x]);

		return result;
	}
}
