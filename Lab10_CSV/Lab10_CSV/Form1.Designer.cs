namespace Lab10_CSV
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
            this.Search = new System.Windows.Forms.Button();
            this.ShowUserInfoListBox = new System.Windows.Forms.ListBox();
            this.ShowAllUserListBox = new System.Windows.Forms.ListView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(875, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 24);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            // 
            // ShowUserInfoListBox
            // 
            this.ShowUserInfoListBox.FormattingEnabled = true;
            this.ShowUserInfoListBox.Location = new System.Drawing.Point(472, 49);
            this.ShowUserInfoListBox.Name = "ShowUserInfoListBox";
            this.ShowUserInfoListBox.Size = new System.Drawing.Size(553, 225);
            this.ShowUserInfoListBox.TabIndex = 4;
            // 
            // ShowAllUserListBox
            // 
            this.ShowAllUserListBox.HideSelection = false;
            this.ShowAllUserListBox.Location = new System.Drawing.Point(12, 308);
            this.ShowAllUserListBox.Name = "ShowAllUserListBox";
            this.ShowAllUserListBox.Size = new System.Drawing.Size(1451, 305);
            this.ShowAllUserListBox.TabIndex = 5;
            this.ShowAllUserListBox.UseCompatibleStateImageBehavior = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(452, 290);
            this.dataGridView1.TabIndex = 6;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(472, 13);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(397, 20);
            this.SearchBox.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1027, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(397, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 813);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ShowAllUserListBox);
            this.Controls.Add(this.ShowUserInfoListBox);
            this.Controls.Add(this.Search);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListBox ShowUserInfoListBox;
        private System.Windows.Forms.ListView ShowAllUserListBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

