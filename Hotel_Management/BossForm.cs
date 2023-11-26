using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class BossForm : Form
    {
        String name = string.Empty;
        public BossForm(string name)
        {
            InitializeComponent();
            this.name = name;   
        }
        M_R mr;
        DatabaseManagementDataContext db;
        private void BossForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(name);
            mr = new M_R();
            db = new DatabaseManagementDataContext();
            var list = (from s in db.M_Rs select s).ToList();
            dataGridView1.DataSource = list;
        }
        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                mr.Id = id_tb.Text;
                mr.Name = name_tb.Text;
                mr.Gender = male_rb.Checked ? "Male" : "Female";
                mr.Position = position_cb.Items[position_cb.SelectedIndex].ToString();
                mr.Date_of_Birth = dateTimePicker1.Value.Date;
                mr.Address = address_tb.Text;
                mr.Phone_Number = number_tb.Text;
                db.M_Rs.InsertOnSubmit(mr);
                db.SubmitChanges();
                BossForm_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot add!");
            }
        }
    }
}
