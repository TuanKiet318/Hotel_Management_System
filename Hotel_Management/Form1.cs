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
            account = new Account();
            db = new DatabaseManagementDataContext();
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
            try
            {
                account = db.Accounts.Where(acc => acc.Id == login_tb.Text).Single();
                string s = account.Id.ToString();
                switch (position_cb.SelectedIndex)
                {
                    case 0:
                        BossForm bossForm = new BossForm(s);
                        bossForm.ShowDialog();
                        break;
                    //case 1:

                }
            }
            
            catch (Exception ex)
            {
                remind_tb.Visible = true;
                login_tb.Text = string.Empty;
                pass_tb.Text = string.Empty;
            }
        }
    }
}
