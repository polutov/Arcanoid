namespace Arcanoid
{
	partial class frmGame
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.ilBalls = new System.Windows.Forms.ImageList(this.components);
			this.ilBricks = new System.Windows.Forms.ImageList(this.components);
			this.ilPads = new System.Windows.Forms.ImageList(this.components);
			this.gbLives = new System.Windows.Forms.GroupBox();
			this.lblLives = new System.Windows.Forms.Label();
			this.gbScore = new System.Windows.Forms.GroupBox();
			this.lblMultiplier = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.pnlGameOver = new System.Windows.Forms.Panel();
			this.lblGameOver = new System.Windows.Forms.Label();
			this.lblGOScore = new System.Windows.Forms.Label();
			this.lblGOText = new System.Windows.Forms.Label();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.gbLives.SuspendLayout();
			this.gbScore.SuspendLayout();
			this.pnlGameOver.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Interval = 10;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// ilBalls
			// 
			this.ilBalls.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBalls.ImageStream")));
			this.ilBalls.TransparentColor = System.Drawing.Color.Transparent;
			this.ilBalls.Images.SetKeyName(0, "ballBlue.png");
			this.ilBalls.Images.SetKeyName(1, "ballGrey.png");
			// 
			// ilBricks
			// 
			this.ilBricks.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBricks.ImageStream")));
			this.ilBricks.TransparentColor = System.Drawing.Color.Transparent;
			this.ilBricks.Images.SetKeyName(0, "element_grey_rectangle.png");
			this.ilBricks.Images.SetKeyName(1, "element_blue_rectangle.png");
			this.ilBricks.Images.SetKeyName(2, "element_green_rectangle.png");
			this.ilBricks.Images.SetKeyName(3, "element_yellow_rectangle.png");
			this.ilBricks.Images.SetKeyName(4, "element_red_rectangle.png");
			this.ilBricks.Images.SetKeyName(5, "element_purple_rectangle.png");
			// 
			// ilPads
			// 
			this.ilPads.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilPads.ImageStream")));
			this.ilPads.TransparentColor = System.Drawing.Color.Transparent;
			this.ilPads.Images.SetKeyName(0, "paddleBlu.png");
			this.ilPads.Images.SetKeyName(1, "paddleRed.png");
			// 
			// gbLives
			// 
			this.gbLives.BackColor = System.Drawing.Color.White;
			this.gbLives.Controls.Add(this.lblLives);
			this.gbLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbLives.Location = new System.Drawing.Point(650, 165);
			this.gbLives.Name = "gbLives";
			this.gbLives.Size = new System.Drawing.Size(200, 60);
			this.gbLives.TabIndex = 6;
			this.gbLives.TabStop = false;
			this.gbLives.Text = "Lives";
			// 
			// lblLives
			// 
			this.lblLives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblLives.Location = new System.Drawing.Point(44, 22);
			this.lblLives.Name = "lblLives";
			this.lblLives.Size = new System.Drawing.Size(150, 32);
			this.lblLives.TabIndex = 1;
			this.lblLives.Text = "12345689";
			this.lblLives.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbScore
			// 
			this.gbScore.BackColor = System.Drawing.Color.White;
			this.gbScore.Controls.Add(this.lblMultiplier);
			this.gbScore.Controls.Add(this.lblScore);
			this.gbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbScore.Location = new System.Drawing.Point(650, 79);
			this.gbScore.Name = "gbScore";
			this.gbScore.Size = new System.Drawing.Size(200, 80);
			this.gbScore.TabIndex = 5;
			this.gbScore.TabStop = false;
			this.gbScore.Text = "Score";
			// 
			// lblMultiplier
			// 
			this.lblMultiplier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMultiplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMultiplier.Location = new System.Drawing.Point(44, 53);
			this.lblMultiplier.Name = "lblMultiplier";
			this.lblMultiplier.Size = new System.Drawing.Size(150, 24);
			this.lblMultiplier.TabIndex = 1;
			this.lblMultiplier.Text = "x1";
			this.lblMultiplier.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// lblScore
			// 
			this.lblScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblScore.Location = new System.Drawing.Point(44, 22);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(150, 32);
			this.lblScore.TabIndex = 0;
			this.lblScore.Text = "12345689";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlGameOver
			// 
			this.pnlGameOver.BackColor = System.Drawing.Color.White;
			this.pnlGameOver.Controls.Add(this.lblGOText);
			this.pnlGameOver.Controls.Add(this.lblGOScore);
			this.pnlGameOver.Controls.Add(this.lblGameOver);
			this.pnlGameOver.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlGameOver.Location = new System.Drawing.Point(0, 0);
			this.pnlGameOver.Name = "pnlGameOver";
			this.pnlGameOver.Size = new System.Drawing.Size(855, 717);
			this.pnlGameOver.TabIndex = 10;
			this.pnlGameOver.Visible = false;
			// 
			// lblGameOver
			// 
			this.lblGameOver.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblGameOver.AutoSize = true;
			this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGameOver.Location = new System.Drawing.Point(309, 264);
			this.lblGameOver.Name = "lblGameOver";
			this.lblGameOver.Size = new System.Drawing.Size(253, 42);
			this.lblGameOver.TabIndex = 0;
			this.lblGameOver.Text = "GAME OVER";
			this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGOScore
			// 
			this.lblGOScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblGOScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGOScore.Location = new System.Drawing.Point(309, 379);
			this.lblGOScore.Name = "lblGOScore";
			this.lblGOScore.Size = new System.Drawing.Size(253, 37);
			this.lblGOScore.TabIndex = 1;
			this.lblGOScore.Text = "123456";
			this.lblGOScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblGOText
			// 
			this.lblGOText.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblGOText.AutoSize = true;
			this.lblGOText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblGOText.Location = new System.Drawing.Point(342, 324);
			this.lblGOText.Name = "lblGOText";
			this.lblGOText.Size = new System.Drawing.Size(186, 37);
			this.lblGOText.TabIndex = 2;
			this.lblGOText.Text = "your score:";
			this.lblGOText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pbLogo
			// 
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.Location = new System.Drawing.Point(650, 11);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(200, 62);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbLogo.TabIndex = 9;
			this.pbLogo.TabStop = false;
			// 
			// frmGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(855, 717);
			this.Controls.Add(this.pnlGameOver);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.gbLives);
			this.Controls.Add(this.gbScore);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "frmGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arcanoid";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
			this.gbLives.ResumeLayout(false);
			this.gbScore.ResumeLayout(false);
			this.pnlGameOver.ResumeLayout(false);
			this.pnlGameOver.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.ImageList ilBalls;
		private System.Windows.Forms.ImageList ilBricks;
		private System.Windows.Forms.ImageList ilPads;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.GroupBox gbLives;
		private System.Windows.Forms.Label lblLives;
		private System.Windows.Forms.GroupBox gbScore;
		private System.Windows.Forms.Label lblMultiplier;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Panel pnlGameOver;
		private System.Windows.Forms.Label lblGameOver;
		private System.Windows.Forms.Label lblGOText;
		private System.Windows.Forms.Label lblGOScore;
	}
}

