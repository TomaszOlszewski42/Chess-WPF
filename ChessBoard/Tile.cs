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
	public Tile(bool isBlack, SolidColorBrush default_brush, SolidColorBrush activ_brush)
	{
		IsBlack = isBlack;
		_defaultColor = default_brush;
		_activatedColor = activ_brush;
		_isActive = false;
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
	private bool _isActive;
	public bool IsActivated 
	{ 
		get
		{
			return _isActive;
		}
		set
		{
			_isActive = value;
			OnPropertyChanged(nameof(Color));
		}
	}
	private SolidColorBrush _defaultColor;
	private SolidColorBrush _activatedColor;
	public SolidColorBrush Color 
	{ 
		get
		{
			if (!IsActivated)
				return _defaultColor;
			else
				return _activatedColor;
		}
	}
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