
namespace Carsbuliding
{
    partial class BuildingFRM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BNTXT = new System.Windows.Forms.TextBox();
            this.FNTXT = new System.Windows.Forms.TextBox();
            this.PNTXT = new System.Windows.Forms.TextBox();
            this.BNLBL = new System.Windows.Forms.Label();
            this.FNLBL = new System.Windows.Forms.Label();
            this.PNLBL = new System.Windows.Forms.Label();
            this.RONLBL = new System.Windows.Forms.Label();
            this.saveBTN = new System.Windows.Forms.Button();
            this.ViewBBTN = new System.Windows.Forms.Button();
            this.RONCMB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BNTXT
            // 
            this.BNTXT.Location = new System.Drawing.Point(243, 37);
            this.BNTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BNTXT.Name = "BNTXT";
            this.BNTXT.Size = new System.Drawing.Size(191, 23);
            this.BNTXT.TabIndex = 0;
            // 
            // FNTXT
            // 
            this.FNTXT.Location = new System.Drawing.Point(243, 74);
            this.FNTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FNTXT.Name = "FNTXT";
            this.FNTXT.Size = new System.Drawing.Size(191, 23);
            this.FNTXT.TabIndex = 1;
            // 
            // PNTXT
            // 
            this.PNTXT.Location = new System.Drawing.Point(243, 116);
            this.PNTXT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PNTXT.Name = "PNTXT";
            this.PNTXT.Size = new System.Drawing.Size(191, 23);
            this.PNTXT.TabIndex = 2;
            // 
            // BNLBL
            // 
            this.BNLBL.Location = new System.Drawing.Point(83, 37);
            this.BNLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BNLBL.Name = "BNLBL";
            this.BNLBL.Size = new System.Drawing.Size(103, 23);
            this.BNLBL.TabIndex = 4;
            this.BNLBL.Text = "building name";
            this.BNLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNLBL
            // 
            this.FNLBL.Location = new System.Drawing.Point(83, 78);
            this.FNLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FNLBL.Name = "FNLBL";
            this.FNLBL.Size = new System.Drawing.Size(103, 23);
            this.FNLBL.TabIndex = 5;
            this.FNLBL.Text = "floor numbers";
            // 
            // PNLBL
            // 
            this.PNLBL.Location = new System.Drawing.Point(83, 120);
            this.PNLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PNLBL.Name = "PNLBL";
            this.PNLBL.Size = new System.Drawing.Size(103, 23);
            this.PNLBL.TabIndex = 6;
            this.PNLBL.Text = "parking name";
            // 
            // RONLBL
            // 
            this.RONLBL.Location = new System.Drawing.Point(83, 165);
            this.RONLBL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RONLBL.Name = "RONLBL";
            this.RONLBL.Size = new System.Drawing.Size(103, 23);
            this.RONLBL.TabIndex = 7;
            this.RONLBL.Text = "reserverd or not";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(83, 220);
            this.saveBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(150, 28);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // ViewBBTN
            // 
            this.ViewBBTN.Location = new System.Drawing.Point(281, 220);
            this.ViewBBTN.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ViewBBTN.Name = "ViewBBTN";
            this.ViewBBTN.Size = new System.Drawing.Size(152, 28);
            this.ViewBBTN.TabIndex = 9;
            this.ViewBBTN.Text = "view buldings list";
            this.ViewBBTN.UseVisualStyleBackColor = true;
            this.ViewBBTN.Click += new System.EventHandler(this.ViewBBTN_Click);
            // 
            // RONCMB
            // 
            this.RONCMB.FormattingEnabled = true;
            this.RONCMB.Items.AddRange(new object[] {
            "Reserved",
            "NotReserved"});
            this.RONCMB.Location = new System.Drawing.Point(243, 163);
            this.RONCMB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RONCMB.Name = "RONCMB";
            this.RONCMB.Size = new System.Drawing.Size(191, 23);
            this.RONCMB.TabIndex = 10;
            // 
            // BuildingFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 270);
            this.Controls.Add(this.RONCMB);
            this.Controls.Add(this.ViewBBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.RONLBL);
            this.Controls.Add(this.PNLBL);
            this.Controls.Add(this.FNLBL);
            this.Controls.Add(this.BNLBL);
            this.Controls.Add(this.PNTXT);
            this.Controls.Add(this.FNTXT);
            this.Controls.Add(this.BNTXT);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BuildingFRM";
            this.Text = "Buildings";
            this.Load += new System.EventHandler(this.BuildingFRM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BNTXT;
        private System.Windows.Forms.TextBox FNTXT;
        private System.Windows.Forms.TextBox PNTXT;
        private System.Windows.Forms.Label BNLBL;
        private System.Windows.Forms.Label FNLBL;
        private System.Windows.Forms.Label PNLBL;
        private System.Windows.Forms.Label RONLBL;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button ViewBBTN;
        private System.Windows.Forms.ComboBox RONCMB;
    }
}

