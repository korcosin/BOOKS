using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoadBook.CsharpBasic.Chapter11.Winform
{
    public partial class Form1 : Form
    {
        List<Model.Menu> lstMenu;

        public Form1()
        {
            InitializeComponent();
            SetMenu();
        }

        private void SetMenu()
        {
            lstMenu = new List<Model.Menu>()
            {
                new Model.Menu{ Id=1, Name="김밥", Price=1000 },
                new Model.Menu{ Id=2, Name="라면", Price=3000 },
                new Model.Menu{ Id=3, Name="떡볶이", Price=2000 },
                new Model.Menu{ Id=4, Name="순대", Price=2500 },
                new Model.Menu{ Id=5, Name="공기밥", Price=500 }
            };
        }

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            listBox1.Items.Add(lstMenu.Find(m => m.Id == Convert.ToInt32(clickedButton.Tag)).Name);
        }

        private void BtnPayment_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach (var item in listBox1.Items)
            {
                total += lstMenu.Find(m => m.Name == item.ToString()).Price;
            }

            lblPaymentInfo.Text = string.Format("총 결제 금액 : {0}", total);
        }
    }
}