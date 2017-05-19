
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

public class Inverter
{
	public bool _exit;
	public bool _invertX;
	public bool _invertY;
    public bool _swapXY;
    private Point pos;
	public bool _running;

    public void Set(bool invertX, bool invertY, bool swapXY)
    {
        _invertX = invertX;
        _invertY = invertY;
        _swapXY = swapXY;
    }


	public Inverter()
	{
		pos = Cursor.Position;
	}

	public event InvertSettingsChangedEventEventHandler InvertSettingsChangedEvent;
	public delegate void InvertSettingsChangedEventEventHandler(Inverter inverter, EventArgs eventArgs);

	private void MouseLoop()
	{
		while (!_exit) {
			var position = Cursor.Position;
			int x = 0, y = 0;
			if (_swapXY) {
				x = pos.X + (_invertX ? -1 : 1) * (position.Y - pos.Y);
                y = pos.Y + (_invertY ? -1 : 1) * (position.X - pos.X);
			} else {
                x = _invertX ? (pos.X - (position.X - pos.X)) : position.X;
				y = _invertY ? (pos.Y - (position.Y - pos.Y)) : position.Y;
			}
            var bound = Screen.PrimaryScreen.Bounds;
            bound.Inflate(-4, -4);
            {
				if (x < bound.Left) 
					x = bound.Left;
				else if (x > (bound.Right)) 
					x = bound.Right;
			}
			{
				if (y < bound.Top)
					y = bound.Top;
				else if (y > (bound.Bottom)) 
					y = bound.Bottom;
			}
            pos = Cursor.Position = new Point(x, y);
			Thread.Sleep(5);
		}
		_exit = false;
	}

	public void Start()
	{
		pos = Cursor.Position;
		_running = true;
        _exit = false;
		dynamic thead = new Thread(new ThreadStart(MouseLoop)) {
			Priority = ThreadPriority.Highest,
			IsBackground = true
		};
		thead.Start();
	}

	public void Stop()
	{
		_running = false;
		_exit = true;
	}
}