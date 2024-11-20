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
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();
        }
        private void Ex1Form_Load(object sender, EventArgs e)
        {
            SquaresDataGridView.Columns[0].HeaderText = "1";
            SquaresDataGridView.Columns[1].HeaderText = "2";
            SquaresDataGridView.Columns[2].HeaderText = "3";
            SquaresDataGridView.Columns[3].HeaderText = "4";
            SquaresDataGridView.Columns[4].HeaderText = "5";
            SquaresDataGridView.Columns[5].HeaderText = "6";
            SquaresDataGridView.Columns[6].HeaderText = "7";
            SquaresDataGridView.Columns[7].HeaderText = "8";
            SquaresDataGridView.Columns[8].HeaderText = "9";
            SquaresDataGridView.Rows.Add(9);
            SquaresDataGridView.Rows[0].HeaderCell.Value = "1";
            SquaresDataGridView.Rows[1].HeaderCell.Value = "2";
            SquaresDataGridView.Rows[2].HeaderCell.Value = "3";
            SquaresDataGridView.Rows[3].HeaderCell.Value = "4";
            SquaresDataGridView.Rows[4].HeaderCell.Value = "5";
            SquaresDataGridView.Rows[5].HeaderCell.Value = "6";
            SquaresDataGridView.Rows[6].HeaderCell.Value = "7";
            SquaresDataGridView.Rows[7].HeaderCell.Value = "8";
            SquaresDataGridView.Rows[8].HeaderCell.Value = "9";
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SquaresDataGridView.Rows[i].Cells[j].Value = Convert.ToString(Convert.ToInt16(SquaresDataGridView.Rows[i].HeaderCell.Value + SquaresDataGridView.Columns[j].HeaderText) * Convert.ToInt16(SquaresDataGridView.Rows[i].HeaderCell.Value + SquaresDataGridView.Columns[j].HeaderText));
                }
            }
        }
        private void SquaresDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string text = Convert.ToString(e.RowIndex + 1)+ Convert.ToString(e.ColumnIndex + 1) + " * " + Convert.ToString(e.RowIndex + 1) + Convert.ToString(e.ColumnIndex + 1) + " = "+ Convert.ToString(SquaresDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            MessageBox.Show(text);
        }
    }
}
