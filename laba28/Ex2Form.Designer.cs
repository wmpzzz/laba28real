namespace laba28
{
    partial class Ex2Form
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
            SubscribersDataGridView = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)SubscribersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // SubscribersDataGridView
            // 
            SubscribersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubscribersDataGridView.BackgroundColor = Color.White;
            SubscribersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubscribersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            SubscribersDataGridView.Dock = DockStyle.Fill;
            SubscribersDataGridView.Location = new Point(0, 0);
            SubscribersDataGridView.Name = "SubscribersDataGridView";
            SubscribersDataGridView.RowHeadersWidth = 150;
            SubscribersDataGridView.Size = new Size(800, 450);
            SubscribersDataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "FullName";
            Column1.HeaderText = "ФИО";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Number";
            Column2.HeaderText = "Номер телефона";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "TalkTime";
            Column3.HeaderText = "Время разговоров";
            Column3.Name = "Column3";
            // 
            // Ex2Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubscribersDataGridView);
            Name = "Ex2Form";
            Text = "Задание 2";
            Load += Ex2Form_Load;
            ((System.ComponentModel.ISupportInitialize)SubscribersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView SubscribersDataGridView;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}