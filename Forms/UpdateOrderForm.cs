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
    public partial class UpdateOrderForm : Form, IUpdateOrderGui
    {
        private UpdateOrderPresenter _presenter;
        
        public UpdateOrderForm()
        {
            InitializeComponent();
            
        }

        public void Register(UpdateOrderPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }
                
        public OrderStatus OrderStatus 
        {
            set
            {
                lblStatus.Text = value.ToString();
            }
        }
        
        public Boolean PlacedPaymentRecieved
        {
            set
            {
                chkPlanningPay.Checked = value;
            }
            get
            {
                return chkPlanningPay.Checked;
            }
        }
        public Boolean PlanningGranted
        {
            set
            {
                chkPlanning.Checked = value;
            }
            get
            {
                return chkPlanning.Checked;
            }
        }

        public Boolean PlanningRejected
        {
            set
            {
                chkRejected.Checked = value;
            }
            get
            {
                return chkRejected.Checked;
            }
        }
        
        public String PlanningGrantedDate
        {
            set
            {
                chkPlanning.Text = value;
            }
            get
            {
                return chkPlanning.Text;
            }
        }

        public String PlanningRejectedDate
        {
            set
            {
                chkRejected.Text = value;
            }
            get
            {
                return chkRejected.Text;
            }
        }

        public String OrderId
        {
            set
            {
                txtOrderNum.Text = value;
            }
            get
            {
                return txtOrderNum.Text;
            }
        }

        public Boolean ContractSigned 
        {
            set
            {
                chkContract.Checked = value;
            }
            get
            {
                return chkContract.Checked;
            }
        }

        public String ContractSignedDate
        {
            set
            {
                chkContract.Text = value;
            }
            get
            {
                return chkContract.Text;
            }
        }
        
        public String FoundationDate 
        {
            set
            {
                dtpFoundationDate.Text = value;
            }
            get
            {
                return dtpFoundationDate.Text;
            }
        }

        public Boolean FullInvoicePaymentRecieved 
        {
            set
            {
                chkOrderInvoice.Checked = value;
            }
            get
            {
                return chkOrderInvoice.Checked;
            }
        }
        
        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing
            //chkPlanning.Enabled = false;
            //grpPlanning.Enabled = false; 
        }

        public void EnablePlanningRejected(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing
            chkRejected.Enabled = enabled;
            //grpPlanning.Enabled = false; 
        }

        private void btnOrderSearch_Click(object sender, EventArgs e)
        {
            // The Order search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID
            _presenter.getOrderToUpdate();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.UpdateOrder();
        }

        private void chkPlanning_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.planningGrantedChanged();
        }

        private void chkRejected_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.planningRejectedChanged();
        }

        private void chkContract_CheckedChanged(object sender, EventArgs e)
        {
            _presenter.contractSignedChanged();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            _presenter.undoChanges();
        }

    }
}
