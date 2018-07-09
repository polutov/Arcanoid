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

			e.Graphics.DrawImage(ilPads.Images[0], game.PlayerPad.X, game.PlayerPad.Y);

			e.Graphics.DrawRectangle(new Pen(Color.Red), game.PlayField);
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			foreach (Ball ball in game.Balls)
			{
				// Передвигаем шарик по горизонтали и по вертикали
				ball.X += ball.SpeedH;
				ball.Y += ball.SpeedV;

				// Проверяем выход шарика за границы поля и отражаем его траекторию
				// Проверка горизонтальной и вертикальной скоростей необходима для того, чтобы шарик не "залипал" в краях
				if ((!game.PlayField.Contains(ball.Left) && ball.SpeedH < 0) || (!game.PlayField.Contains(ball.Right) && ball.SpeedH > 0))
				{
					ball.SpeedH *= -1;
				}
				 
				if ((!game.PlayField.Contains(ball.Top) && ball.SpeedV < 0) || !game.PlayField.Contains(ball.Bottom))
				{
					ball.SpeedV *= -1;
				}

				//if (!game.PlayField.Contains(ball.Bottom))
				//{
				//	game.Balls.Remove(ball);
				//	break;
				//}

				// Bricks check
				// ТУДУ Сделать проверку координат шарика выше нижнего кубика и ниже верхнего, чтобы не делать лишних проверок в пустом пространстве
				if (ball.Top.Y <= game.Bricks[game.Bricks.Count - 1].Rect.Bottom)
				{
					for (int i = 0; i < game.Bricks.Count; i++)
					{
						if ((game.Bricks[i].Rect.Contains(ball.Left) && ball.SpeedH < 0) || (game.Bricks[i].Rect.Contains(ball.Right) && ball.SpeedH > 0))
						{
							ball.SpeedH *= -1;
							game.HitBrick(i);
						}

						if ((game.Bricks[i].Rect.Contains(ball.Top) && ball.SpeedV < 0) || (game.Bricks[i].Rect.Contains(ball.Bottom) && ball.SpeedV > 0))
						{
							ball.SpeedV *= -1;
							game.HitBrick(i);
						}
					}
				}
				

				// Pad Check
				// Градус отскока зависит от места удара шара об панель
				if (game.PlayerPad.Rect.Contains(ball.Bottom) && ball.SpeedV > 0)
				{
					ball.SpeedV *= -1;

					int padCenterX = game.PlayerPad.X + game.PlayerPad.Width / 2;

					ball.SpeedH = (int)((double)(ball.Bottom.X - padCenterX) / (game.PlayerPad.Width / 2) * 6);
				}
			}

			this.Invalidate();
		}

		private void frmMain_MouseMove(object sender, MouseEventArgs e)
		{
			game.MovePad(e.X);
		}
	}
}
