namespace StopWatch
{
    partial class frmCr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCr));
            this.txtDs = new System.Windows.Forms.TextBox();
            this.cmdPl = new System.Windows.Forms.Button();
            this.cmdPp = new System.Windows.Forms.Button();
            this.cmdSt = new System.Windows.Forms.Button();
            this.tmT = new System.Windows.Forms.Timer(this.components);
            this.lstSv = new System.Windows.Forms.ListBox();
            this.cmdSv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDs
            // 
            this.txtDs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDs.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDs.Location = new System.Drawing.Point(12, 12);
            this.txtDs.Name = "txtDs";
            this.txtDs.ReadOnly = true;
            this.txtDs.Size = new System.Drawing.Size(260, 47);
            this.txtDs.TabIndex = 0;
            // 
            // cmdPl
            // 
            this.cmdPl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPl.Location = new System.Drawing.Point(12, 65);
            this.cmdPl.Name = "cmdPl";
            this.cmdPl.Size = new System.Drawing.Size(52, 41);
            this.cmdPl.TabIndex = 1;
            this.cmdPl.Text = "&Go";
            this.cmdPl.UseVisualStyleBackColor = true;
            this.cmdPl.Click += new System.EventHandler(this.cmdPl_Click);
            // 
            // cmdPp
            // 
            this.cmdPp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPp.Enabled = false;
            this.cmdPp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPp.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPp.Location = new System.Drawing.Point(127, 65);
            this.cmdPp.Name = "cmdPp";
            this.cmdPp.Size = new System.Drawing.Size(68, 41);
            this.cmdPp.TabIndex = 2;
            this.cmdPp.Text = "&Pause";
            this.cmdPp.UseVisualStyleBackColor = true;
            this.cmdPp.Click += new System.EventHandler(this.cmdPp_Click);
            // 
            // cmdSt
            // 
            this.cmdSt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSt.Enabled = false;
            this.cmdSt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSt.Location = new System.Drawing.Point(70, 65);
            this.cmdSt.Name = "cmdSt";
            this.cmdSt.Size = new System.Drawing.Size(51, 41);
            this.cmdSt.TabIndex = 3;
            this.cmdSt.Text = "&Zerar";
            this.cmdSt.UseVisualStyleBackColor = true;
            this.cmdSt.Click += new System.EventHandler(this.cmdSt_Click);
            // 
            // tmT
            // 
            this.tmT.Interval = 1000;
            this.tmT.Tick += new System.EventHandler(this.tmT_Tick);
            // 
            // lstSv
            // 
            this.lstSv.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSv.FormattingEnabled = true;
            this.lstSv.ItemHeight = 15;
            this.lstSv.Location = new System.Drawing.Point(278, 12);
            this.lstSv.Name = "lstSv";
            this.lstSv.Size = new System.Drawing.Size(100, 94);
            this.lstSv.TabIndex = 4;
            // 
            // cmdSv
            // 
            this.cmdSv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSv.Enabled = false;
            this.cmdSv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSv.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSv.Location = new System.Drawing.Point(201, 65);
            this.cmdSv.Name = "cmdSv";
            this.cmdSv.Size = new System.Drawing.Size(71, 41);
            this.cmdSv.TabIndex = 5;
            this.cmdSv.Text = "&Salvar";
            this.cmdSv.UseVisualStyleBackColor = true;
            this.cmdSv.Click += new System.EventHandler(this.cmdSv_Click);
            // 
            // frmCr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 116);
            this.Controls.Add(this.cmdSv);
            this.Controls.Add(this.lstSv);
            this.Controls.Add(this.cmdSt);
            this.Controls.Add(this.cmdPp);
            this.Controls.Add(this.cmdPl);
            this.Controls.Add(this.txtDs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCr";
            this.Text = "Cronômetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDs;
        private System.Windows.Forms.Button cmdPl;
        private System.Windows.Forms.Button cmdPp;
        private System.Windows.Forms.Button cmdSt;
        private System.Windows.Forms.Timer tmT;
        private System.Windows.Forms.ListBox lstSv;
        private System.Windows.Forms.Button cmdSv;
    }
}

