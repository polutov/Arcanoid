using System;
using System.Collections.Generic;
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
	}
}
