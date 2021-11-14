using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RAT_Lab
{
    public partial class FormOrders : Form
    {
        Order order = new Order();

        public FormOrders()
        {
            InitializeComponent();
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            btnReloadTable_Click(sender, e);
        }

        private void btnReloadTable_Click(object sender, EventArgs e)
        {
            dgvOrders.AutoGenerateColumns = false;
            using (LaboratoryEntities db = new LaboratoryEntities())
            {
                dgvOrders.DataSource = db.Orders.ToList<Order>();
            }
        }
    }
}
