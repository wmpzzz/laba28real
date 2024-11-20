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

    public partial class Ex2Form : Form
    {
        public Ex2Form()
        {
            InitializeComponent();
        }

        private void Ex2Form_Load(object sender, EventArgs e)
        {
            List<Subscribers> subscriber = new List<Subscribers> { new Subscribers { FullName = "Мишаня", Number = "+79528121337", TalkTime = "200" }, new Subscribers { FullName = "Мишаня", Number = "+79528121337", TalkTime = "200" }, new Subscribers { FullName = "Мишаня", Number = "+79528121337", TalkTime = "200" }, new Subscribers { FullName = "Мишаня", Number = "+79528121337", TalkTime = "200" }, new Subscribers { FullName = "Мишаня", Number = "+79528121337", TalkTime = "200" }};
            SubscribersDataGridView.DataSource = subscriber;
            SubscribersDataGridView.Rows[0].HeaderCell.Value = "1";
            SubscribersDataGridView.Rows[1].HeaderCell.Value = "2";
            SubscribersDataGridView.Rows[2].HeaderCell.Value = "3";
            SubscribersDataGridView.Rows[3].HeaderCell.Value = "4";
            SubscribersDataGridView.Rows[4].HeaderCell.Value = "5";
        }
    }
    public class Subscribers
    {
       public string FullName { get; set; }
       public string  Number { get; set; }
       public string TalkTime { get; set; }
    }
}
