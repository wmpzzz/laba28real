using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba28
{
    public partial class Ex3Form : Form
    {
       bool succes = false;
        public Ex3Form()
        {
            InitializeComponent();
            
    }

        private void Ex3Form_Load(object sender, EventArgs e)
        {
            MarketDataGridView.Rows.Add("1", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("2", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("3", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("4", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("5", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("6", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("7", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("8", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("9", "лит энерджи бро", "100", false);
            MarketDataGridView.Rows.Add("10", "лит энерджи бро", "100", false);
            for (int i = 0; i < 10; i++)
            {
                MarketDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                if (i % 2 == 0)
                {
                    MarketDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
                else
                {
                    MarketDataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }
            }

        }

        private void OrderButton_Click(object sender, EventArgs e)
        {

            if (succes)
            {
                MessageBox.Show("Ваш заказ успешно создан");

            }
            else
            {
                MessageBox.Show("Выберите товары");
            }
        }
        private void MarketDataGridView_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (MarketDataGridView.IsCurrentCellDirty)
            {
                MarketDataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void MarketDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (MarketDataGridView[3, i].Value != null && (bool)MarketDataGridView[3, i].Value)
                {
                    sum = sum + Convert.ToInt32(MarketDataGridView[2, i].Value);
                    succes = true;
                }
            }
            TotalLabel.Text = "Итого: " + sum.ToString() + " рублей";
        }
    }
}
