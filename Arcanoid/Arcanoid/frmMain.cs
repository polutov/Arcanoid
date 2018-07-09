using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arcanoid
{
	public partial class frmMain : Form
	{
		Game game;

		public frmMain()
		{
			InitializeComponent();
			game = new Game();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void frmMain_Paint(object sender, PaintEventArgs e)
		{
			foreach (Ball bl in game.Balls)
			{
				e.Graphics.DrawImage(ilBalls.Images[0], bl.X, bl.Y);
			}

			foreach (Brick br in game.Bricks)
			{
				e.Graphics.DrawImage(ilBricks.Images[br.HP], br.X, br.Y);
			}

			//e.Graphics.DrawImage(ilPads.Images[0], game.PlayerPad.X, game.PlayerPad.Y);

			e.Graphics.DrawRectangle(new Pen(Color.Red), game.PlayField);
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{

		}
	}
}
