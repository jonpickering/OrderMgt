using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OrderMgt
{
    public partial class OrderSearchForm : Form
    {
        private String _selectedOrderNumber;

        public OrderSearchForm()
        {
            InitializeComponent();
        }

        public String SelectedOrderNumber()
        {
            return _selectedOrderNumber;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _selectedOrderNumber = "4";
            this.Close();
        }
    }
}
