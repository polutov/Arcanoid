using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
	class Ball
	{
		public int Size { get; set; }
		public int X { get; set; }
		public int Y { get; set; }
		public int SpeedH { get; set; }
		public int SpeedV { get; set; }

		public int CenterX { get { return X + Size / 2; } }
		public int CenterY { get { return Y + Size / 2; } }

		public Point Top { get { return new Point(X + Size / 2, Y); } }
		public Point Bottom { get { return new Point(X + Size / 2, Y + Size); } }
		public Point Left { get { return new Point(X, Y + Size / 2); } }
		public Point Right { get { return new Point(X + Size, Y + Size / 2); } }

		
	}
}
