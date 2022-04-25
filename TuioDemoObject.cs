/*
	TUIO C# Demo - part of the reacTIVision project
	http://reactivision.sourceforge.net/

	Copyright (c) 2005-2009 Martin Kaltenbrunner <martin@tuio.org>

	This program is free software; you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation; either version 2 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to the Free Software
	Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

using System;
using System.Drawing;
using TUIO;

	public class TuioDemoObject : TuioObject
	{

		

		SolidBrush black = new SolidBrush(Color.Black);
		SolidBrush white = new SolidBrush(Color.White);
		SolidBrush blue = new SolidBrush(Color.Blue);
		SolidBrush red = new SolidBrush(Color.Red);
		SolidBrush yellow = new SolidBrush(Color.Yellow);
		SolidBrush purple = new SolidBrush(Color.Purple);
		SolidBrush orange = new SolidBrush(Color.Orange);
		SolidBrush green = new SolidBrush(Color.Green);

		Bitmap lionfh;
		Bitmap lionsh;
		Bitmap tigerfh;
		Bitmap tigersh;

		
		Cactor lionHalf1;
		Cactor lionHalf2;
		Cactor tigerHalf1;
		Cactor tigerHalf2;

		bool fullLion = false;
		bool fullTiger = false;

		bool halfl1 = false;
		bool halfl2 = false;



	public TuioDemoObject (long s_id, int f_id, float xpos, float ypos, float angle) : base(s_id,f_id,xpos,ypos,angle) 
	{
		
	}

	public TuioDemoObject (TuioObject o) : base(o) 
	{

		
	}

	class Cactor
    {
		public int x, y;
		public Bitmap img;
    }

    public void paint(Graphics g)
	{
		bool halfl1 = false;
		bool halfl2 = false;

		int firstl = 0;
		int secondl = 0;
		int fullL = 0;

		bool halft1 = false;
		bool halft2 = false;

		Bitmap lionfh = new Bitmap("LionFirstHalf.jpg");
		Bitmap lionsh = new Bitmap("LionSecondHalf.jpg");
		Bitmap lion = new Bitmap("lion.jpg");
		Bitmap tigerfh = new Bitmap("TigerFirstHalf.jpg");
		Bitmap tigersh = new Bitmap("TigerSecondHalf.jpg");
		Bitmap tiger = new Bitmap("tiger.jpg");



		int Xpos = (int)(xpos * TuioDemo.width);
		int Ypos = (int)(ypos * TuioDemo.height);
		int size = TuioDemo.height / 10;

		int blueCheck = 0;
		int redCheck = 0;
		int yellowCheck = 0;
		int blackCheck = 0;
		int brownCheck = 0;
		int orangeCheck = 0;
		int greenCheck = 0;

		g.TranslateTransform(Xpos, Ypos);
		g.RotateTransform((float)(angle / Math.PI * 180.0f));
		g.TranslateTransform(-1 * Xpos, -1 * Ypos);

		

		if (symbol_id == 0) //first half of the lion
		{

			lionHalf1 = new Cactor();
			lionHalf1.x = Xpos;
			lionHalf1.y = Ypos;
			lionHalf1.img = lionfh;

			//g.FillRectangle(red, new Rectangle(Xpos - size / 2, Ypos - size / 2, size, size));
			g.DrawImage(lionfh, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));

			halfl1 = true;
			redCheck = 1;
		}
		if (symbol_id == 1) //second half of the lion
		{


			//g.FillRectangle(yellow, new Rectangle(Xpos - size / 2, Ypos - size / 2, size, size));
			g.DrawImage(lionsh, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));
			halfl2 = true;
			yellowCheck = 1;
			
		}

		if (symbol_id == 2) //first half of the tiger
		{

			tigerHalf1 = new Cactor();
			tigerHalf1.x = Xpos;
			tigerHalf1.y = Ypos;
			tigerHalf1.img = lionsh;

			//g.FillRectangle(blue, new Rectangle(Xpos - size / 2, Ypos - size / 2, size, size));
			g.DrawImage(tigerfh, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));
			halft1 = true;
			blueCheck = 1;
		}

		if (symbol_id == 3) //second half of the tiger
		{

			//g.FillRectangle(orange, new Rectangle(Xpos - size / 2, Ypos - size / 2, size, size));
			g.DrawImage(tigersh, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			halft2 = true;
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));
		}


		if (symbol_id == 4 ) //full lion
		{
			g.DrawImage(lion, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));
		}
		Cactor fTiger;
		if (symbol_id == 5 ) //full tiger
		{

			//g.FillRectangle(orange, new Rectangle(Xpos - size / 2, Ypos - size / 2, size, size));
			g.DrawImage(tiger, new Rectangle(Xpos - size / 2, Ypos - size / 2, size + 50, size + 50));
			g.TranslateTransform(Xpos, Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1 * Xpos, -1 * Ypos);
			Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, blue, new PointF(Xpos - 10, Ypos - 10));
		}

		

	}
}
