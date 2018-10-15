namespace WindowsFormsApp1
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.newgamebutton = new System.Windows.Forms.Button();
            this.levelselectbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(210, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Falling Rocks";
            // 
            // newgamebutton
            // 
            this.newgamebutton.BackColor = System.Drawing.Color.Gold;
            this.newgamebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.newgamebutton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newgamebutton.Location = new System.Drawing.Point(195, 239);
            this.newgamebutton.Name = "newgamebutton";
            this.newgamebutton.Size = new System.Drawing.Size(181, 53);
            this.newgamebutton.TabIndex = 1;
            this.newgamebutton.Text = "New Game";
            this.newgamebutton.UseVisualStyleBackColor = false;
            this.newgamebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // levelselectbutton
            // 
            this.levelselectbutton.BackColor = System.Drawing.Color.Gold;
            this.levelselectbutton.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelselectbutton.Location = new System.Drawing.Point(425, 239);
            this.levelselectbutton.Name = "levelselectbutton";
            this.levelselectbutton.Size = new System.Drawing.Size(181, 53);
            this.levelselectbutton.TabIndex = 2;
            this.levelselectbutton.Text = "Level Select";
            this.levelselectbutton.UseVisualStyleBackColor = false;
            this.levelselectbutton.Click += new System.EventHandler(this.levelselectbutton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.levelselectbutton);
            this.Controls.Add(this.newgamebutton);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.Text = "Falling Rocks";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newgamebutton;
        private System.Windows.Forms.Button levelselectbutton;
    }
}

