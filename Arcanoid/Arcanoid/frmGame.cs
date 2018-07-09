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
	public partial class frmGame : Form
	{
		Game game;

		public frmGame()
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

			lblMultiplier.Text = "x" + game.ScoreMultiplier.ToString();
			lblScore.Text = game.Score.ToString();
			lblLives.Text = game.Lives.ToString();
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
				if ((ball.Left.X <= game.PlayField.Left && ball.SpeedH < 0) || (ball.Right.X >= game.PlayField.Right && ball.SpeedH > 0))
				{
					ball.SpeedH *= -1;
				}
				 
				if (ball.Top.Y <= game.PlayField.Top && ball.SpeedV < 0)
				{
					ball.SpeedV *= -1;
				}

				if (ball.Bottom.Y >= game.PlayField.Bottom)
				{
					game.RemoveBall(ball);

					if (game.CheckLives())
					{
						game.ThrowBall();
					}
					else
					{
						GameOver();
					}

					break;
				}

				// Bricks check
				// ТУДУ Сделать проверку координат шарика выше нижнего кубика и ниже верхнего, чтобы не делать лишних проверок в пустом пространстве
				if (game.Bricks.Count > 0 && ball.Top.Y <= game.Bricks[game.Bricks.Count - 1].Rect.Bottom)
				{
					foreach (Brick brick in game.Bricks)
					{
						if ((brick.Rect.Contains(ball.Left) && ball.SpeedH < 0) || (brick.Rect.Contains(ball.Right) && ball.SpeedH > 0))
						{
							ball.SpeedH *= -1;
							game.HitBrick(brick);
							break;
						}

						if ((brick.Rect.Contains(ball.Top) && ball.SpeedV < 0) || (brick.Rect.Contains(ball.Bottom) && ball.SpeedV > 0))
						{
							ball.SpeedV *= -1;
							game.HitBrick(brick);
							break;
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

					game.ScoreMultiplier = 1;
				}
			}

			this.Invalidate();
		}

		private void frmMain_MouseMove(object sender, MouseEventArgs e)
		{
			game.MovePad(e.X);
		}

		public void GameOver()
		{
			tmrUpdate.Stop();
			lblGOScore.Text = game.Score.ToString();
			pnlGameOver.Visible = true;
		}
	}
}
