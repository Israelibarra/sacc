using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SACC
{
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string vv = dtpFechaNacimientoF.Value.ToShortDateString();
            MessageBox.Show(vv);
        }
        DBConnect db = new DBConnect();
        private void btnRegistrarF_Click(object sender, EventArgs e)
        {

            string vv = dtpFechaNacimientoF.Value.Date.ToString("yyyy-MM-dd");
            MessageBox.Show(vv);

            db.Insert(vv);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        
    }
}
