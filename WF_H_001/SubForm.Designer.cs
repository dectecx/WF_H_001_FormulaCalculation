namespace WF_H_001
{
    partial class SubForm
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
            this.CalBtn = new System.Windows.Forms.Button();
            this.ResultGV = new System.Windows.Forms.DataGridView();
            this.AC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Z2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ResultGV)).BeginInit();
            this.SuspendLayout();
            // 
            // CalBtn
            // 
            this.CalBtn.Location = new System.Drawing.Point(16, 15);
            this.CalBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CalBtn.Name = "CalBtn";
            this.CalBtn.Size = new System.Drawing.Size(100, 29);
            this.CalBtn.TabIndex = 0;
            this.CalBtn.Text = "計算";
            this.CalBtn.UseVisualStyleBackColor = true;
            this.CalBtn.Click += new System.EventHandler(this.CalBtn_Click);
            // 
            // ResultGV
            // 
            this.ResultGV.AllowUserToAddRows = false;
            this.ResultGV.AllowUserToDeleteRows = false;
            this.ResultGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ResultGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AC,
            this.CC,
            this.X2,
            this.Y2,
            this.Z2});
            this.ResultGV.Location = new System.Drawing.Point(16, 51);
            this.ResultGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ResultGV.Name = "ResultGV";
            this.ResultGV.ReadOnly = true;
            this.ResultGV.RowHeadersWidth = 51;
            this.ResultGV.RowTemplate.Height = 24;
            this.ResultGV.Size = new System.Drawing.Size(1035, 496);
            this.ResultGV.TabIndex = 23;
            // 
            // AC
            // 
            this.AC.HeaderText = "A軸角度";
            this.AC.MinimumWidth = 6;
            this.AC.Name = "AC";
            this.AC.ReadOnly = true;
            this.AC.Width = 125;
            // 
            // CC
            // 
            this.CC.HeaderText = "C軸角度";
            this.CC.MinimumWidth = 6;
            this.CC.Name = "CC";
            this.CC.ReadOnly = true;
            this.CC.Width = 125;
            // 
            // X2
            // 
            this.X2.HeaderText = "X";
            this.X2.MinimumWidth = 6;
            this.X2.Name = "X2";
            this.X2.ReadOnly = true;
            this.X2.Width = 125;
            // 
            // Y2
            // 
            this.Y2.HeaderText = "Y";
            this.Y2.MinimumWidth = 6;
            this.Y2.Name = "Y2";
            this.Y2.ReadOnly = true;
            this.Y2.Width = 125;
            // 
            // Z2
            // 
            this.Z2.HeaderText = "Z";
            this.Z2.MinimumWidth = 6;
            this.Z2.Name = "Z2";
            this.Z2.ReadOnly = true;
            this.Z2.Width = 125;
            // 
            // SubForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.ResultGV);
            this.Controls.Add(this.CalBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SubForm";
            this.Text = "SubForm";
            ((System.ComponentModel.ISupportInitialize)(this.ResultGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CalBtn;
        private System.Windows.Forms.DataGridView ResultGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn AC;
        private System.Windows.Forms.DataGridViewTextBoxColumn CC;
        private System.Windows.Forms.DataGridViewTextBoxColumn X2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Z2;
    }
}