namespace Infinite_Walker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.spike1 = new System.Windows.Forms.PictureBox();
            this.spike2 = new System.Windows.Forms.PictureBox();
            this.spike3 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.sprite = new System.Windows.Forms.ImageList(this.components);
            this.move_stuff = new System.Windows.Forms.Timer(this.components);
            this.animate = new System.Windows.Forms.Timer(this.components);
            this.manager = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spike1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // spike1
            // 
            this.spike1.Image = ((System.Drawing.Image)(resources.GetObject("spike1.Image")));
            this.spike1.Location = new System.Drawing.Point(192, 0);
            this.spike1.Name = "spike1";
            this.spike1.Size = new System.Drawing.Size(64, 64);
            this.spike1.TabIndex = 0;
            this.spike1.TabStop = false;
            // 
            // spike2
            // 
            this.spike2.Image = ((System.Drawing.Image)(resources.GetObject("spike2.Image")));
            this.spike2.Location = new System.Drawing.Point(192, 64);
            this.spike2.Name = "spike2";
            this.spike2.Size = new System.Drawing.Size(64, 64);
            this.spike2.TabIndex = 1;
            this.spike2.TabStop = false;
            // 
            // spike3
            // 
            this.spike3.Image = ((System.Drawing.Image)(resources.GetObject("spike3.Image")));
            this.spike3.Location = new System.Drawing.Point(192, 129);
            this.spike3.Name = "spike3";
            this.spike3.Size = new System.Drawing.Size(64, 64);
            this.spike3.TabIndex = 2;
            this.spike3.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(0, 65);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(63, 62);
            this.player.TabIndex = 3;
            this.player.TabStop = false;
            // 
            // sprite
            // 
            this.sprite.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("sprite.ImageStream")));
            this.sprite.TransparentColor = System.Drawing.Color.Transparent;
            this.sprite.Images.SetKeyName(0, "1");
            this.sprite.Images.SetKeyName(1, "2");
            // 
            // move_stuff
            // 
            this.move_stuff.Interval = 10;
            this.move_stuff.Tick += new System.EventHandler(this.move_stuff_Tick);
            // 
            // animate
            // 
            this.animate.Tick += new System.EventHandler(this.animate_Tick);
            // 
            // manager
            // 
            this.manager.Interval = 1;
            this.manager.Tick += new System.EventHandler(this.manager_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("FixedsysTTF", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.Color.Silver;
            this.score.Location = new System.Drawing.Point(12, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(17, 18);
            this.score.TabIndex = 4;
            this.score.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(192, 192);
            this.Controls.Add(this.score);
            this.Controls.Add(this.player);
            this.Controls.Add(this.spike3);
            this.Controls.Add(this.spike2);
            this.Controls.Add(this.spike1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Infinite Walker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spike1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spike3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox spike1;
        private System.Windows.Forms.PictureBox spike2;
        private System.Windows.Forms.PictureBox spike3;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.ImageList sprite;
        private System.Windows.Forms.Timer move_stuff;
        private System.Windows.Forms.Timer animate;
        private System.Windows.Forms.Timer manager;
        private System.Windows.Forms.Label score;
    }
}

