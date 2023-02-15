namespace NoMoreMash
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PCT_CANVAS = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.PANEL_LEFT = new System.Windows.Forms.Panel();
            this.SF = new System.Windows.Forms.Button();
            this.STOP = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ANI_PL_BTT = new System.Windows.Forms.Button();
            this.SAVE = new System.Windows.Forms.Button();
            this.FIGURE_BTT = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.panelDown = new System.Windows.Forms.Panel();
            this.sliderX = new System.Windows.Forms.PictureBox();
            this.panelR = new System.Windows.Forms.Panel();
            this.sliderY = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LBL_TITLE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.PANEL_LEFT.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            this.panelDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderX)).BeginInit();
            this.panelR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderY)).BeginInit();
            this.SuspendLayout();
            // 
            // PCT_CANVAS
            // 
            this.PCT_CANVAS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PCT_CANVAS.Location = new System.Drawing.Point(158, 101);
            this.PCT_CANVAS.Margin = new System.Windows.Forms.Padding(2);
            this.PCT_CANVAS.Name = "PCT_CANVAS";
            this.PCT_CANVAS.Size = new System.Drawing.Size(1150, 530);
            this.PCT_CANVAS.TabIndex = 0;
            this.PCT_CANVAS.TabStop = false;
            this.PCT_CANVAS.Click += new System.EventHandler(this.PCT_CANVAS_Click);
            this.PCT_CANVAS.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDoubleClick);
            this.PCT_CANVAS.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseDown);
            this.PCT_CANVAS.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseMove);
            this.PCT_CANVAS.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PCT_CANVAS_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(0, 0);
            this.trackBar1.Maximum = 500;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(1148, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // PANEL_LEFT
            // 
            this.PANEL_LEFT.Controls.Add(this.SF);
            this.PANEL_LEFT.Controls.Add(this.STOP);
            this.PANEL_LEFT.Controls.Add(this.checkBox1);
            this.PANEL_LEFT.Controls.Add(this.ANI_PL_BTT);
            this.PANEL_LEFT.Controls.Add(this.SAVE);
            this.PANEL_LEFT.Controls.Add(this.FIGURE_BTT);
            this.PANEL_LEFT.Controls.Add(this.treeView1);
            this.PANEL_LEFT.Location = new System.Drawing.Point(0, 52);
            this.PANEL_LEFT.Margin = new System.Windows.Forms.Padding(2);
            this.PANEL_LEFT.Name = "PANEL_LEFT";
            this.PANEL_LEFT.Size = new System.Drawing.Size(150, 644);
            this.PANEL_LEFT.TabIndex = 9;
            // 
            // SF
            // 
            this.SF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.SF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SF.Location = new System.Drawing.Point(11, 564);
            this.SF.Margin = new System.Windows.Forms.Padding(0);
            this.SF.Name = "SF";
            this.SF.Size = new System.Drawing.Size(123, 31);
            this.SF.TabIndex = 7;
            this.SF.Text = "FRAMES";
            this.SF.UseVisualStyleBackColor = false;
            this.SF.Click += new System.EventHandler(this.SF_Click);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.STOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STOP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.STOP.Location = new System.Drawing.Point(11, 524);
            this.STOP.Margin = new System.Windows.Forms.Padding(0);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(123, 31);
            this.STOP.TabIndex = 6;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(11, 606);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(41, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "All";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ANI_PL_BTT
            // 
            this.ANI_PL_BTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.ANI_PL_BTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ANI_PL_BTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ANI_PL_BTT.Location = new System.Drawing.Point(11, 479);
            this.ANI_PL_BTT.Margin = new System.Windows.Forms.Padding(0);
            this.ANI_PL_BTT.Name = "ANI_PL_BTT";
            this.ANI_PL_BTT.Size = new System.Drawing.Size(123, 31);
            this.ANI_PL_BTT.TabIndex = 3;
            this.ANI_PL_BTT.Text = "PLAY";
            this.ANI_PL_BTT.UseVisualStyleBackColor = false;
            this.ANI_PL_BTT.Click += new System.EventHandler(this.PLAY_Click);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SAVE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SAVE.Location = new System.Drawing.Point(11, 438);
            this.SAVE.Margin = new System.Windows.Forms.Padding(2);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(123, 28);
            this.SAVE.TabIndex = 2;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.RECORD_Click);
            // 
            // FIGURE_BTT
            // 
            this.FIGURE_BTT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(35)))), ((int)(((byte)(0)))));
            this.FIGURE_BTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FIGURE_BTT.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FIGURE_BTT.Location = new System.Drawing.Point(11, 397);
            this.FIGURE_BTT.Margin = new System.Windows.Forms.Padding(2);
            this.FIGURE_BTT.Name = "FIGURE_BTT";
            this.FIGURE_BTT.Size = new System.Drawing.Size(123, 27);
            this.FIGURE_BTT.TabIndex = 1;
            this.FIGURE_BTT.Text = "ADD";
            this.FIGURE_BTT.UseVisualStyleBackColor = false;
            this.FIGURE_BTT.Click += new System.EventHandler(this.ADD_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.treeView1.ForeColor = System.Drawing.SystemColors.Info;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(145, 386);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeView1_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trackBar2);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Location = new System.Drawing.Point(158, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1150, 44);
            this.panel1.TabIndex = 10;
            // 
            // trackBar2
            // 
            this.trackBar2.Location = new System.Drawing.Point(1, 0);
            this.trackBar2.Maximum = 5;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(1148, 45);
            this.trackBar2.TabIndex = 9;
            // 
            // panelDown
            // 
            this.panelDown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDown.Controls.Add(this.sliderX);
            this.panelDown.Location = new System.Drawing.Point(169, 694);
            this.panelDown.Margin = new System.Windows.Forms.Padding(2);
            this.panelDown.Name = "panelDown";
            this.panelDown.Size = new System.Drawing.Size(1069, 44);
            this.panelDown.TabIndex = 11;
            // 
            // sliderX
            // 
            this.sliderX.Location = new System.Drawing.Point(14, 11);
            this.sliderX.Margin = new System.Windows.Forms.Padding(2);
            this.sliderX.Name = "sliderX";
            this.sliderX.Size = new System.Drawing.Size(1053, 19);
            this.sliderX.TabIndex = 0;
            this.sliderX.TabStop = false;
            this.sliderX.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseDown);
            this.sliderX.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseMove);
            this.sliderX.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderX_MouseUp);
            // 
            // panelR
            // 
            this.panelR.Controls.Add(this.sliderY);
            this.panelR.Location = new System.Drawing.Point(1314, 52);
            this.panelR.Name = "panelR";
            this.panelR.Size = new System.Drawing.Size(150, 626);
            this.panelR.TabIndex = 4;
            // 
            // sliderY
            // 
            this.sliderY.Location = new System.Drawing.Point(19, 48);
            this.sliderY.Margin = new System.Windows.Forms.Padding(2);
            this.sliderY.Name = "sliderY";
            this.sliderY.Size = new System.Drawing.Size(15, 572);
            this.sliderY.TabIndex = 0;
            this.sliderY.TabStop = false;
            this.sliderY.MouseDown += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseDown);
            this.sliderY.MouseMove += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseMove);
            this.sliderY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.sliderY_MouseUp);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LBL_TITLE
            // 
            this.LBL_TITLE.AutoSize = true;
            this.LBL_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_TITLE.ForeColor = System.Drawing.Color.Snow;
            this.LBL_TITLE.Location = new System.Drawing.Point(428, 9);
            this.LBL_TITLE.Name = "LBL_TITLE";
            this.LBL_TITLE.Size = new System.Drawing.Size(286, 31);
            this.LBL_TITLE.TabIndex = 12;
            this.LBL_TITLE.Text = "NO MORE MASH PLS";
            this.LBL_TITLE.Click += new System.EventHandler(this.LBL_TITLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.LBL_TITLE);
            this.Controls.Add(this.panelR);
            this.Controls.Add(this.panelDown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PANEL_LEFT);
            this.Controls.Add(this.PCT_CANVAS);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "NoMash";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PCT_CANVAS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.PANEL_LEFT.ResumeLayout(false);
            this.PANEL_LEFT.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            this.panelDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderX)).EndInit();
            this.panelR.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sliderY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PCT_CANVAS;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel PANEL_LEFT;
        private System.Windows.Forms.Button FIGURE_BTT;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDown;
        private System.Windows.Forms.PictureBox sliderX;
        private System.Windows.Forms.Panel panelR;
        private System.Windows.Forms.PictureBox sliderY;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ANI_PL_BTT;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label LBL_TITLE;
        private System.Windows.Forms.Button SF;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.TrackBar trackBar2;
    }
}

