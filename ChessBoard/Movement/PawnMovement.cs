namespace chess;

class PawnMovement : AbstractMovement
{
	private int _direction;

	public PawnMovement(int direction)
	{
		_direction = direction;
	}

	public override List<Tile> PossibleMoves(Tile[,] tiles, int start_x, int start_y)
	{
		List<Tile> result = new List<Tile>();
		PlayerEnum owner = tiles[start_y, start_x].ChessPiece.Owner;

		if (start_y + _direction >= 8 || start_y + _direction < 0)
			return result;

		if (tiles[start_y + _direction, start_x].ChessPiece == null)
			result.Add(tiles[start_y + _direction, start_x]);
		if (start_x + 1 < 8 && tiles[start_y + _direction, start_x + 1].ChessPiece != null && tiles[start_y + _direction, start_x + 1].ChessPiece.Owner != owner)
			result.Add(tiles[start_y + _direction, start_x + 1]);
		if (start_x - 1 < 8 && tiles[start_y + _direction, start_x - 1].ChessPiece != null && tiles[start_y + _direction, start_x - 1].ChessPiece.Owner != owner)
			result.Add(tiles[start_y + _direction, start_x - 1]);

		return result;
	}
}
