namespace Arcanoid
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.ilBalls = new System.Windows.Forms.ImageList(this.components);
			this.ilBricks = new System.Windows.Forms.ImageList(this.components);
			this.ilPads = new System.Windows.Forms.ImageList(this.components);
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.gbSpeed = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.gbLevel = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gbLives = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.gbScore = new System.Windows.Forms.GroupBox();
			this.lblMultiplier = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.gbSpeed.SuspendLayout();
			this.gbLevel.SuspendLayout();
			this.gbLives.SuspendLayout();
			this.gbScore.SuspendLayout();
			this.SuspendLayout();
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
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
			// gbSpeed
			// 
			this.gbSpeed.BackColor = System.Drawing.Color.White;
			this.gbSpeed.Controls.Add(this.label3);
			this.gbSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbSpeed.Location = new System.Drawing.Point(650, 297);
			this.gbSpeed.Name = "gbSpeed";
			this.gbSpeed.Size = new System.Drawing.Size(200, 60);
			this.gbSpeed.TabIndex = 8;
			this.gbSpeed.TabStop = false;
			this.gbSpeed.Text = "Speed";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(44, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 32);
			this.label3.TabIndex = 1;
			this.label3.Text = "12345689";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbLevel
			// 
			this.gbLevel.BackColor = System.Drawing.Color.White;
			this.gbLevel.Controls.Add(this.label2);
			this.gbLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbLevel.Location = new System.Drawing.Point(650, 231);
			this.gbLevel.Name = "gbLevel";
			this.gbLevel.Size = new System.Drawing.Size(200, 60);
			this.gbLevel.TabIndex = 7;
			this.gbLevel.TabStop = false;
			this.gbLevel.Text = "Level";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(44, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 32);
			this.label2.TabIndex = 1;
			this.label2.Text = "12345689";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// gbLives
			// 
			this.gbLives.BackColor = System.Drawing.Color.White;
			this.gbLives.Controls.Add(this.label1);
			this.gbLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.gbLives.Location = new System.Drawing.Point(650, 165);
			this.gbLives.Name = "gbLives";
			this.gbLives.Size = new System.Drawing.Size(200, 60);
			this.gbLives.TabIndex = 6;
			this.gbLives.TabStop = false;
			this.gbLives.Text = "Lives";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(44, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 32);
			this.label1.TabIndex = 1;
			this.label1.Text = "12345689";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(855, 717);
			this.Controls.Add(this.pbLogo);
			this.Controls.Add(this.gbSpeed);
			this.Controls.Add(this.gbLevel);
			this.Controls.Add(this.gbLives);
			this.Controls.Add(this.gbScore);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arcanoid";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.gbSpeed.ResumeLayout(false);
			this.gbLevel.ResumeLayout(false);
			this.gbLives.ResumeLayout(false);
			this.gbScore.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Timer tmrUpdate;
		private System.Windows.Forms.ImageList ilBalls;
		private System.Windows.Forms.ImageList ilBricks;
		private System.Windows.Forms.ImageList ilPads;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.GroupBox gbSpeed;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox gbLevel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox gbLives;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox gbScore;
		private System.Windows.Forms.Label lblMultiplier;
		private System.Windows.Forms.Label lblScore;
	}
}

