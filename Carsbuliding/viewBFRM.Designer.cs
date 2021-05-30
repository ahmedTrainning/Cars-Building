
namespace Carsbuliding
{
    partial class viewBFRM
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insertBTN = new System.Windows.Forms.Button();
            this.deleteBTN = new System.Windows.Forms.Button();
            this.updateBTN = new System.Windows.Forms.Button();
            this.chooseTXT = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 7);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(543, 56);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // insertBTN
            // 
            this.insertBTN.Location = new System.Drawing.Point(8, 325);
            this.insertBTN.Margin = new System.Windows.Forms.Padding(2);
            this.insertBTN.Name = "insertBTN";
            this.insertBTN.Size = new System.Drawing.Size(154, 35);
            this.insertBTN.TabIndex = 1;
            this.insertBTN.Text = "Add New Building";
            this.insertBTN.UseVisualStyleBackColor = true;
            // 
            // deleteBTN
            // 
            this.deleteBTN.Location = new System.Drawing.Point(200, 325);
            this.deleteBTN.Margin = new System.Windows.Forms.Padding(2);
            this.deleteBTN.Name = "deleteBTN";
            this.deleteBTN.Size = new System.Drawing.Size(153, 35);
            this.deleteBTN.TabIndex = 2;
            this.deleteBTN.Text = "Delete building";
            this.toolTip1.SetToolTip(this.deleteBTN, "write the name of the building you want to delete in the empty line\r\nOr double cl" +
        "ick on the name of the building in the list ");
            this.deleteBTN.UseVisualStyleBackColor = true;
            this.deleteBTN.Click += new System.EventHandler(this.deleteBTN_Click);
            // 
            // updateBTN
            // 
            this.updateBTN.Location = new System.Drawing.Point(389, 325);
            this.updateBTN.Margin = new System.Windows.Forms.Padding(2);
            this.updateBTN.Name = "updateBTN";
            this.updateBTN.Size = new System.Drawing.Size(153, 35);
            this.updateBTN.TabIndex = 3;
            this.updateBTN.Text = "modify building";
            this.toolTip1.SetToolTip(this.updateBTN, "write the name of the building you want to modify in the empty line");
            this.updateBTN.UseVisualStyleBackColor = true;
            // 
            // chooseTXT
            // 
            this.chooseTXT.Location = new System.Drawing.Point(8, 281);
            this.chooseTXT.Margin = new System.Windows.Forms.Padding(2);
            this.chooseTXT.Name = "chooseTXT";
            this.chooseTXT.Size = new System.Drawing.Size(544, 23);
            this.chooseTXT.TabIndex = 4;
            this.chooseTXT.TextChanged += new System.EventHandler(this.chooseTXT_TextChanged);
            // 
            // viewBFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 373);
            this.Controls.Add(this.chooseTXT);
            this.Controls.Add(this.updateBTN);
            this.Controls.Add(this.deleteBTN);
            this.Controls.Add(this.insertBTN);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "viewBFRM";
            this.Text = "viewBFRM";
            this.Load += new System.EventHandler(this.viewBFRM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button insertBTN;
        private System.Windows.Forms.Button deleteBTN;
        private System.Windows.Forms.Button updateBTN;
        private System.Windows.Forms.TextBox chooseTXT;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}