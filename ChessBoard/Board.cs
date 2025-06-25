using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess;

internal class Board
{
	public ObservableCollection<Tile[]> Columns { get; set; }

	public Board()
	{
		Columns = new ObservableCollection<Tile[]>();
		for (int i = 0; i < 8; i++)
		{
			Columns.Add(new Tile[8]);
			for (int j = 0; j < 8; j++)
			{
				if (i % 2 == 0 && j % 2 == 0)
					Columns[i][j] = new Tile(false);
				else if (i % 2 == 0)
					Columns[i][j] = new Tile(true);
				else if (j % 2 == 0)
					Columns[i][j] = new Tile(true);
				else
					Columns[i][j] = new Tile(false);
			}
		}
	}
}
