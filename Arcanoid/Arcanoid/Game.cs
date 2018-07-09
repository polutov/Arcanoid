using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arcanoid
{
	class Game
	{
		public Player ActivePlayer { get; set; }
		public List<Ball> Balls { get; set; }
		public List<Brick> Bricks { get; set; }
		public List<Bonus> FallingBonuses { get; set; }
		public Pad PlayerPad { get; set; }
		public int Score { get; set; }
		public int Lives { get; set; }
		public int ScoreMultiplier { get; set; }
		public Rectangle PlayField { get; set; }

		Random r;

		public Game()
		{
			r = new Random();

			PlayField = new Rectangle(10, 10, 624, 696);

			ActivePlayer = new Player();

			Balls = new List<Ball>();
			for (int i = 0; i < 10; i++)
			{
				Balls.Add(new Ball { Size = 16, SpeedH = r.Next(-6, -1) * (int)Math.Pow(-1, r.Next(1, 3)), SpeedV = r.Next(-6, -1) * (int)Math.Pow(-1, r.Next(1, 3)), X = 304, Y = 464 });
			}

			Bricks = new List<Brick>();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 11; j++)
				{
					Bricks.Add(new Brick { X = 58 + j * 48, Y = 72 + 24 * i, HP = i + 1, Height = 24, Width = 48 });
				}
			}


		}
	}
}
