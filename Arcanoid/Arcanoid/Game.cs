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
			Score = 0;
			ScoreMultiplier = 1;

			Lives = 3;

			Balls = new List<Ball>();
			for (int i = 0; i < 1; i++)
			{
				ThrowBall();
			}

			Bricks = new List<Brick>();
			for (int i = 0; i < 5; i++)
			{
				for (int j = 0; j < 11; j++)
				{
					Bricks.Add(new Brick { X = 58 + j * 48, Y = 72 + 24 * i, HP = i + 1, Height = 24, Width = 48 });
				}
			}

			PlayerPad = new Pad { Width = 104, Height = 24, X = (PlayField.Left + PlayField.Right / 2) - 52, Y = 10 + 24 * 26 };
		}

		public void ThrowBall()
		{
			Balls.Add(new Ball { Size = 16, SpeedH = 0, SpeedV = 5, X = (PlayField.Left + PlayField.Right) / 2 - 8, Y = 400 });
		}

		public void MovePad(int x)
		{
			PlayerPad.X = x - PlayerPad.Width / 2;

			if (PlayerPad.X + PlayerPad.Width > PlayField.Right)
			{
				PlayerPad.X = PlayField.Right - PlayerPad.Width;
			}
			else if (PlayerPad.X < PlayField.Left)
			{
				PlayerPad.X = PlayField.Left;
			}
		}

		internal void HitBrick(Brick brick)
		{
			if (brick.HP == 1)
			{
				Bricks.Remove(brick);
				Score += 10 * ScoreMultiplier;
				ScoreMultiplier++;
			}
			else if (brick.HP > 1)
			{
				brick.HP--;
				Score += 5 * ScoreMultiplier;
				ScoreMultiplier++;
			}
		}

		internal void RemoveBall(Ball ball)
		{
			Balls.Remove(ball);

			if (Balls.Count == 0)
			{
				Lives--;
			}
		}

		public bool CheckLives()
		{
			if (Lives >= 1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}
