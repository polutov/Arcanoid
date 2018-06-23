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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnlMainMenu = new System.Windows.Forms.Panel();
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.lblCredit = new System.Windows.Forms.Label();
			this.btnNewGame = new System.Windows.Forms.Button();
			this.btnOptions = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.pnlMainMenu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlMainMenu
			// 
			this.pnlMainMenu.Controls.Add(this.btnExit);
			this.pnlMainMenu.Controls.Add(this.btnOptions);
			this.pnlMainMenu.Controls.Add(this.btnNewGame);
			this.pnlMainMenu.Controls.Add(this.lblCredit);
			this.pnlMainMenu.Controls.Add(this.pbLogo);
			this.pnlMainMenu.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlMainMenu.Location = new System.Drawing.Point(0, 0);
			this.pnlMainMenu.Name = "pnlMainMenu";
			this.pnlMainMenu.Size = new System.Drawing.Size(1006, 721);
			this.pnlMainMenu.TabIndex = 0;
			this.pnlMainMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMainMenu_Paint);
			// 
			// pbLogo
			// 
			this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
			this.pbLogo.InitialImage = null;
			this.pbLogo.Location = new System.Drawing.Point(250, 150);
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size(500, 156);
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// lblCredit
			// 
			this.lblCredit.AutoSize = true;
			this.lblCredit.ForeColor = System.Drawing.Color.White;
			this.lblCredit.Location = new System.Drawing.Point(871, 695);
			this.lblCredit.Name = "lblCredit";
			this.lblCredit.Size = new System.Drawing.Size(123, 17);
			this.lblCredit.TabIndex = 1;
			this.lblCredit.Text = "by Dmytro Polutov";
			this.lblCredit.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// btnNewGame
			// 
			this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnNewGame.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnNewGame.Location = new System.Drawing.Point(403, 352);
			this.btnNewGame.Name = "btnNewGame";
			this.btnNewGame.Size = new System.Drawing.Size(200, 32);
			this.btnNewGame.TabIndex = 2;
			this.btnNewGame.Text = "New Game";
			this.btnNewGame.UseVisualStyleBackColor = true;
			// 
			// btnOptions
			// 
			this.btnOptions.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnOptions.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnOptions.Location = new System.Drawing.Point(403, 390);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(200, 32);
			this.btnOptions.TabIndex = 3;
			this.btnOptions.Text = "Options";
			this.btnOptions.UseVisualStyleBackColor = true;
			// 
			// btnExit
			// 
			this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExit.Location = new System.Drawing.Point(403, 428);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(200, 32);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1006, 721);
			this.Controls.Add(this.pnlMainMenu);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arcanoid";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlMainMenu.ResumeLayout(false);
			this.pnlMainMenu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlMainMenu;
		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Label lblCredit;
		private System.Windows.Forms.Button btnNewGame;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnOptions;
	}
}

