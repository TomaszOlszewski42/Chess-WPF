using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace chess;

internal class Tile : INotifyPropertyChanged
{
	public Tile(bool isBlack, SolidColorBrush brush)
	{
		IsBlack = isBlack;
		Color = brush;
	}
	ChessPiece? piece;
	public ChessPiece? ChessPiece
	{
		get
		{
			return piece;
		}
		set
		{
			piece = value;
			OnPropertyChanged(nameof(ChessPiece));
			OnPropertyChanged(nameof(PieceImage));
		}
	}
	public bool IsBlack { get; set; }
	public SolidColorBrush Color { get; set; }
	public BitmapImage? PieceImage 
	{ 
		get
		{
			if (ChessPiece == null) return null;
			return ChessPiece.Image;
		} 
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	protected void OnPropertyChanged([CallerMemberName] string name = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
	}
}