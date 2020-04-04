namespace dcs_5020l_windows_controller
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.cntPTControls = new System.Windows.Forms.GroupBox();
            this.btnPTLeft = new System.Windows.Forms.Button();
            this.btnPTRight = new System.Windows.Forms.Button();
            this.btnPTDown = new System.Windows.Forms.Button();
            this.btnPTUp = new System.Windows.Forms.Button();
            this.btnPTHome = new System.Windows.Forms.Button();
            this.cntPresetPositions = new System.Windows.Forms.GroupBox();
            this.btnPresetPositionsGo = new System.Windows.Forms.Button();
            this.cmbPresetPositions = new System.Windows.Forms.ComboBox();
            this.cntSystemTools = new System.Windows.Forms.GroupBox();
            this.btnSystemToolsRestart = new System.Windows.Forms.Button();
            this.cntLogout = new System.Windows.Forms.GroupBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cntPTControls.SuspendLayout();
            this.cntPresetPositions.SuspendLayout();
            this.cntSystemTools.SuspendLayout();
            this.cntLogout.SuspendLayout();
            this.SuspendLayout();
            // 
            // cntPTControls
            // 
            this.cntPTControls.Controls.Add(this.btnPTLeft);
            this.cntPTControls.Controls.Add(this.btnPTRight);
            this.cntPTControls.Controls.Add(this.btnPTDown);
            this.cntPTControls.Controls.Add(this.btnPTUp);
            this.cntPTControls.Controls.Add(this.btnPTHome);
            this.cntPTControls.Location = new System.Drawing.Point(12, 12);
            this.cntPTControls.Name = "cntPTControls";
            this.cntPTControls.Size = new System.Drawing.Size(100, 100);
            this.cntPTControls.TabIndex = 0;
            this.cntPTControls.TabStop = false;
            this.cntPTControls.Text = "Pan/Tilt Controls";
            // 
            // btnPTLeft
            // 
            this.btnPTLeft.Location = new System.Drawing.Point(9, 44);
            this.btnPTLeft.Name = "btnPTLeft";
            this.btnPTLeft.Size = new System.Drawing.Size(25, 23);
            this.btnPTLeft.TabIndex = 4;
            this.btnPTLeft.Text = "˂";
            this.btnPTLeft.UseVisualStyleBackColor = true;
            this.btnPTLeft.Click += new System.EventHandler(this.BtnPTLeft_Click);
            // 
            // btnPTRight
            // 
            this.btnPTRight.Location = new System.Drawing.Point(65, 44);
            this.btnPTRight.Name = "btnPTRight";
            this.btnPTRight.Size = new System.Drawing.Size(25, 23);
            this.btnPTRight.TabIndex = 3;
            this.btnPTRight.Text = "˃";
            this.btnPTRight.UseVisualStyleBackColor = true;
            this.btnPTRight.Click += new System.EventHandler(this.BtnPTRight_Click);
            // 
            // btnPTDown
            // 
            this.btnPTDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPTDown.Location = new System.Drawing.Point(37, 70);
            this.btnPTDown.Name = "btnPTDown";
            this.btnPTDown.Size = new System.Drawing.Size(25, 23);
            this.btnPTDown.TabIndex = 2;
            this.btnPTDown.Text = "˅";
            this.btnPTDown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPTDown.UseVisualStyleBackColor = true;
            this.btnPTDown.Click += new System.EventHandler(this.BtnPTDown_Click);
            // 
            // btnPTUp
            // 
            this.btnPTUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPTUp.Location = new System.Drawing.Point(37, 18);
            this.btnPTUp.Name = "btnPTUp";
            this.btnPTUp.Size = new System.Drawing.Size(25, 23);
            this.btnPTUp.TabIndex = 1;
            this.btnPTUp.Text = "˄";
            this.btnPTUp.UseVisualStyleBackColor = true;
            this.btnPTUp.Click += new System.EventHandler(this.BtnPTUp_Click);
            // 
            // btnPTHome
            // 
            this.btnPTHome.Location = new System.Drawing.Point(37, 44);
            this.btnPTHome.Name = "btnPTHome";
            this.btnPTHome.Size = new System.Drawing.Size(25, 23);
            this.btnPTHome.TabIndex = 0;
            this.btnPTHome.Text = "H";
            this.btnPTHome.UseVisualStyleBackColor = true;
            this.btnPTHome.Click += new System.EventHandler(this.BtnPTHome_Click);
            // 
            // cntPresetPositions
            // 
            this.cntPresetPositions.Controls.Add(this.btnPresetPositionsGo);
            this.cntPresetPositions.Controls.Add(this.cmbPresetPositions);
            this.cntPresetPositions.Location = new System.Drawing.Point(12, 118);
            this.cntPresetPositions.Name = "cntPresetPositions";
            this.cntPresetPositions.Size = new System.Drawing.Size(100, 80);
            this.cntPresetPositions.TabIndex = 5;
            this.cntPresetPositions.TabStop = false;
            this.cntPresetPositions.Text = "Preset Positions";
            // 
            // btnPresetPositionsGo
            // 
            this.btnPresetPositionsGo.Location = new System.Drawing.Point(7, 47);
            this.btnPresetPositionsGo.Name = "btnPresetPositionsGo";
            this.btnPresetPositionsGo.Size = new System.Drawing.Size(87, 23);
            this.btnPresetPositionsGo.TabIndex = 1;
            this.btnPresetPositionsGo.Text = "Go";
            this.btnPresetPositionsGo.UseVisualStyleBackColor = true;
            this.btnPresetPositionsGo.Click += new System.EventHandler(this.BtnPresetPositionsGo_Click);
            // 
            // cmbPresetPositions
            // 
            this.cmbPresetPositions.DisplayMember = "1";
            this.cmbPresetPositions.FormattingEnabled = true;
            this.cmbPresetPositions.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cmbPresetPositions.Location = new System.Drawing.Point(7, 20);
            this.cmbPresetPositions.Name = "cmbPresetPositions";
            this.cmbPresetPositions.Size = new System.Drawing.Size(87, 21);
            this.cmbPresetPositions.TabIndex = 0;
            // 
            // cntSystemTools
            // 
            this.cntSystemTools.Controls.Add(this.btnSystemToolsRestart);
            this.cntSystemTools.Location = new System.Drawing.Point(12, 204);
            this.cntSystemTools.Name = "cntSystemTools";
            this.cntSystemTools.Size = new System.Drawing.Size(100, 49);
            this.cntSystemTools.TabIndex = 6;
            this.cntSystemTools.TabStop = false;
            this.cntSystemTools.Text = "System";
            // 
            // btnSystemToolsRestart
            // 
            this.btnSystemToolsRestart.Location = new System.Drawing.Point(7, 18);
            this.btnSystemToolsRestart.Name = "btnSystemToolsRestart";
            this.btnSystemToolsRestart.Size = new System.Drawing.Size(87, 23);
            this.btnSystemToolsRestart.TabIndex = 2;
            this.btnSystemToolsRestart.Text = "Restart";
            this.btnSystemToolsRestart.UseVisualStyleBackColor = true;
            this.btnSystemToolsRestart.Click += new System.EventHandler(this.BtnSystemToolsRestart_Click);
            // 
            // cntLogout
            // 
            this.cntLogout.Controls.Add(this.btnLogout);
            this.cntLogout.Location = new System.Drawing.Point(13, 259);
            this.cntLogout.Name = "cntLogout";
            this.cntLogout.Size = new System.Drawing.Size(100, 49);
            this.cntLogout.TabIndex = 7;
            this.cntLogout.TabStop = false;
            this.cntLogout.Text = "Logout";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(7, 18);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(125, 317);
            this.Controls.Add(this.cntLogout);
            this.Controls.Add(this.cntSystemTools);
            this.Controls.Add(this.cntPresetPositions);
            this.Controls.Add(this.cntPTControls);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Controller";
            this.Load += new System.EventHandler(this.Main_Load);
            this.cntPTControls.ResumeLayout(false);
            this.cntPresetPositions.ResumeLayout(false);
            this.cntSystemTools.ResumeLayout(false);
            this.cntLogout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox cntPTControls;
        private System.Windows.Forms.Button btnPTLeft;
        private System.Windows.Forms.Button btnPTRight;
        private System.Windows.Forms.Button btnPTDown;
        private System.Windows.Forms.Button btnPTUp;
        private System.Windows.Forms.Button btnPTHome;
        private System.Windows.Forms.GroupBox cntPresetPositions;
        private System.Windows.Forms.Button btnPresetPositionsGo;
        private System.Windows.Forms.ComboBox cmbPresetPositions;
        private System.Windows.Forms.GroupBox cntSystemTools;
        private System.Windows.Forms.Button btnSystemToolsRestart;
        private System.Windows.Forms.GroupBox cntLogout;
        private System.Windows.Forms.Button btnLogout;
    }
}

