namespace ProjetoTrello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sidePanelBlue = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.homebutton = new System.Windows.Forms.Button();
            this.topPanelGrey = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.PowerButton = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.homeControl = new ProjetoTrello.HomeControl();
            this.searchControl1 = new ProjetoTrello.SearchControl();
            this.settingsControl1 = new ProjetoTrello.SettingsControl();
            this.sidePanelBlue.SuspendLayout();
            this.topPanelGrey.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanelBlue
            // 
            this.sidePanelBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.sidePanelBlue.Controls.Add(this.SettingsButton);
            this.sidePanelBlue.Controls.Add(this.homebutton);
            this.sidePanelBlue.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanelBlue.Location = new System.Drawing.Point(0, 0);
            this.sidePanelBlue.Name = "sidePanelBlue";
            this.sidePanelBlue.Size = new System.Drawing.Size(83, 561);
            this.sidePanelBlue.TabIndex = 0;
            this.sidePanelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sidePanelBlue_MouseDown);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SettingsButton.AutoSize = true;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.SettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.Image")));
            this.SettingsButton.Location = new System.Drawing.Point(0, 516);
            this.SettingsButton.Margin = new System.Windows.Forms.Padding(0);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(48, 45);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(60)))));
            this.homebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homebutton.Font = new System.Drawing.Font("Coolvetica Condensed Rg", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homebutton.ForeColor = System.Drawing.SystemColors.Control;
            this.homebutton.Location = new System.Drawing.Point(-8, -2);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(99, 66);
            this.homebutton.TabIndex = 0;
            this.homebutton.Text = "H o m e";
            this.homebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.homebutton.UseVisualStyleBackColor = false;
            this.homebutton.Click += new System.EventHandler(this.home_Click);
            // 
            // topPanelGrey
            // 
            this.topPanelGrey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topPanelGrey.BackColor = System.Drawing.Color.LightGray;
            this.topPanelGrey.Controls.Add(this.button1);
            this.topPanelGrey.Controls.Add(this.MinimizeButton);
            this.topPanelGrey.Controls.Add(this.PowerButton);
            this.topPanelGrey.Controls.Add(this.SearchButton);
            this.topPanelGrey.Controls.Add(this.searchControl1);
            this.topPanelGrey.Location = new System.Drawing.Point(83, -2);
            this.topPanelGrey.Name = "topPanelGrey";
            this.topPanelGrey.Size = new System.Drawing.Size(717, 64);
            this.topPanelGrey.TabIndex = 2;
            this.topPanelGrey.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            this.topPanelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.topPanelGrey.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(595, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 64);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.Color.LightGray;
            this.MinimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.Image")));
            this.MinimizeButton.Location = new System.Drawing.Point(632, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(37, 64);
            this.MinimizeButton.TabIndex = 6;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MaximizeButton_Click);
            // 
            // PowerButton
            // 
            this.PowerButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PowerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PowerButton.ForeColor = System.Drawing.Color.LightGray;
            this.PowerButton.Image = ((System.Drawing.Image)(resources.GetObject("PowerButton.Image")));
            this.PowerButton.Location = new System.Drawing.Point(669, 0);
            this.PowerButton.Name = "PowerButton";
            this.PowerButton.Size = new System.Drawing.Size(48, 64);
            this.PowerButton.TabIndex = 4;
            this.PowerButton.UseVisualStyleBackColor = true;
            this.PowerButton.Click += new System.EventHandler(this.Power_Click);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(217)))), ((int)(((byte)(246)))));
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchButton.Image = ((System.Drawing.Image)(resources.GetObject("SearchButton.Image")));
            this.SearchButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.Location = new System.Drawing.Point(184, 22);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(177, 25);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "     Search...";
            this.SearchButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.Search_Click);
            this.SearchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseClick);
            // 
            // homeControl
            // 
            this.homeControl.Location = new System.Drawing.Point(83, 70);
            this.homeControl.Name = "homeControl";
            this.homeControl.Size = new System.Drawing.Size(717, 491);
            this.homeControl.TabIndex = 4;
            this.homeControl.Load += new System.EventHandler(this.homeControl_Load);
            this.homeControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.homeControl_MouseDown);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(184, 22);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(177, 35);
            this.searchControl1.TabIndex = 7;
            this.searchControl1.Load += new System.EventHandler(this.searchControl1_Load);
            // 
            // settingsControl1
            // 
            this.settingsControl1.Location = new System.Drawing.Point(83, 61);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(717, 500);
            this.settingsControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.homeControl);
            this.Controls.Add(this.topPanelGrey);
            this.Controls.Add(this.sidePanelBlue);
            this.Controls.Add(this.settingsControl1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sidePanelBlue.ResumeLayout(false);
            this.sidePanelBlue.PerformLayout();
            this.topPanelGrey.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanelBlue;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Panel topPanelGrey;
        private System.Windows.Forms.Button SearchButton;
        private HomeControl homeControl;
        private SettingsControl settingsControl1;
        private System.Windows.Forms.Button PowerButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button button1;
        private SearchControl searchControl1;
    }
}

