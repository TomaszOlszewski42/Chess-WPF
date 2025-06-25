using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace chess;

internal class ChessPiece
{
	public ChessPiece(BitmapImage image)
	{
		Image = image;
	}

	public BitmapImage Image { get; set; }
}
