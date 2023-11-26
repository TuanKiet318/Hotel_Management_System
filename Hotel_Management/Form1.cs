using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Account account;
        DatabaseManagementDataContext db;
        private void Form1_Load(object sender, EventArgs e)
        {
            position_cb.Text =position_cb.Items[0].ToString();
        }
        private void position_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (position_cb.SelectedIndex == 3)
            {
                sgup_lbl.Visible = true;
            }
            else
            {
                sgup_lbl.Visible = false;
            }
        }
        
        private void Login_btn_Click(object sender, EventArgs e)
        {
            account = new Account();
            db = new DatabaseManagementDataContext();
            //
            var accMain = from acc in db.Accounts 
                          where (acc.Id == login_tb.Text && acc.Pass == pass_tb.Text && acc.Position == position_cb.Text)
                          select acc;
            if (accMain.Count() > 0 )
            {
                BossForm bossForm = new BossForm("temp");
                bossForm.ShowDialog();
            }
            else
            {
                remind_tb.Visible = true;
                login_tb.Text = string.Empty;
                pass_tb.Text = string.Empty;
            }
        }
    }
}
