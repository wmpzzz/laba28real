namespace laba28
{
    partial class Ex3Form
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            MarketDataGridView = new DataGridView();
            Code = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Price = new DataGridViewTextBoxColumn();
            InCart = new DataGridViewCheckBoxColumn();
            TotalLabel = new Label();
            OrderButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MarketDataGridView).BeginInit();
            SuspendLayout();
            // 
            // MarketDataGridView
            // 
            MarketDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MarketDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MarketDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MarketDataGridView.Columns.AddRange(new DataGridViewColumn[] { Code, Name, Price, InCart });
            MarketDataGridView.Location = new Point(137, 47);
            MarketDataGridView.Name = "MarketDataGridView";
            MarketDataGridView.Size = new Size(418, 231);
            MarketDataGridView.TabIndex = 0;
            MarketDataGridView.CellValueChanged += MarketDataGridView_CellValueChanged;
            // 
            // Code
            // 
            Code.HeaderText = "Код";
            Code.Name = "Code";
            Code.Visible = false;
            // 
            // Name
            // 
            Name.HeaderText = "Название";
            Name.Name = "Name";
            // 
            // Price
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            Price.DefaultCellStyle = dataGridViewCellStyle2;
            Price.HeaderText = "Цена";
            Price.Name = "Price";
            // 
            // InCart
            // 
            InCart.HeaderText = "В корзину";
            InCart.Name = "InCart";
            InCart.Resizable = DataGridViewTriState.True;
            InCart.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Location = new Point(120, 381);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(46, 15);
            TotalLabel.TabIndex = 1;
            TotalLabel.Text = "Итого: ";
            // 
            // OrderButton
            // 
            OrderButton.Location = new Point(462, 367);
            OrderButton.Name = "OrderButton";
            OrderButton.Size = new Size(124, 42);
            OrderButton.TabIndex = 2;
            OrderButton.Text = "Заказать";
            OrderButton.UseVisualStyleBackColor = true;
            OrderButton.Click += OrderButton_Click;
            // 
            // Ex3Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 463);
            Controls.Add(OrderButton);
            Controls.Add(TotalLabel);
            Controls.Add(MarketDataGridView);
            Text = "Задание 3";
            Load += Ex3Form_Load;
            ((System.ComponentModel.ISupportInitialize)MarketDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MarketDataGridView;
        private Label TotalLabel;
        private Button OrderButton;
        private DataGridViewTextBoxColumn Code;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewCheckBoxColumn InCart;
    }
}