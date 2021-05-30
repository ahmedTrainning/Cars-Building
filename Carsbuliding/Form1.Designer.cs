
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
            this.BNTXT.Location = new System.Drawing.Point(347, 61);
            this.BNTXT.Name = "BNTXT";
            this.BNTXT.Size = new System.Drawing.Size(271, 31);
            this.BNTXT.TabIndex = 0;
            // 
            // FNTXT
            // 
            this.FNTXT.Location = new System.Drawing.Point(347, 124);
            this.FNTXT.Name = "FNTXT";
            this.FNTXT.Size = new System.Drawing.Size(271, 31);
            this.FNTXT.TabIndex = 1;
            // 
            // PNTXT
            // 
            this.PNTXT.Location = new System.Drawing.Point(347, 194);
            this.PNTXT.Name = "PNTXT";
            this.PNTXT.Size = new System.Drawing.Size(271, 31);
            this.PNTXT.TabIndex = 2;
            // 
            // BNLBL
            // 
            this.BNLBL.Location = new System.Drawing.Point(118, 61);
            this.BNLBL.Name = "BNLBL";
            this.BNLBL.Size = new System.Drawing.Size(147, 38);
            this.BNLBL.TabIndex = 4;
            this.BNLBL.Text = "building name";
            this.BNLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNLBL
            // 
            this.FNLBL.Location = new System.Drawing.Point(118, 130);
            this.FNLBL.Name = "FNLBL";
            this.FNLBL.Size = new System.Drawing.Size(147, 38);
            this.FNLBL.TabIndex = 5;
            this.FNLBL.Text = "floor numbers";
            // 
            // PNLBL
            // 
            this.PNLBL.Location = new System.Drawing.Point(118, 200);
            this.PNLBL.Name = "PNLBL";
            this.PNLBL.Size = new System.Drawing.Size(147, 38);
            this.PNLBL.TabIndex = 6;
            this.PNLBL.Text = "parking name";
            // 
            // RONLBL
            // 
            this.RONLBL.Location = new System.Drawing.Point(118, 275);
            this.RONLBL.Name = "RONLBL";
            this.RONLBL.Size = new System.Drawing.Size(147, 38);
            this.RONLBL.TabIndex = 7;
            this.RONLBL.Text = "reserverd or not";
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(118, 367);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(215, 34);
            this.saveBTN.TabIndex = 8;
            this.saveBTN.Text = "save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // ViewBBTN
            // 
            this.ViewBBTN.Location = new System.Drawing.Point(401, 367);
            this.ViewBBTN.Name = "ViewBBTN";
            this.ViewBBTN.Size = new System.Drawing.Size(217, 34);
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
            this.RONCMB.Location = new System.Drawing.Point(347, 272);
            this.RONCMB.Name = "RONCMB";
            this.RONCMB.Size = new System.Drawing.Size(271, 33);
            this.RONCMB.TabIndex = 10;
            // 
            // BuildingFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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

