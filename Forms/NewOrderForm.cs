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
    public partial class NewOrderForm : Form, INewOrderGui
    {
        private NewOrderPresenter _presenter;

        public NewOrderForm()
        {
            InitializeComponent();
        }

        public void Register(NewOrderPresenter presenter)
        {
            _presenter = presenter;
        }

        public void ShowMessage(String message)
        {
            MessageBox.Show(message);
        }

        public String CustomerId
        {
            set
            {
                txtCustomerId.Text = value;
            }
            get
            {
                return txtCustomerId.Text;
            }
        }


        public String CustomerName
        {
            set
            {
                txtCustomerName.Text = value;
            }
        }

        public String Address
        {
            set
            {
                txtAddress.Text = value;
            }
        }

        public String Town
        {
            set
            {
                txtTown.Text = value;
            }
        }

        public String PostCode
        {
            set
            {
                txtPostCode.Text = value;
            }
        }

        public String Telephone
        {
            set
            {
                txtTelephone.Text = value;
            }
            get
            {
                return txtTelephone.Text;
            }
        }

        public String Mobile
        {
            set
            {
                txtMobile.Text = value;
            }
        }


        public String Registered
        {
            // This is a read-only field used to show when the customer was registered

            set
            {
                txtRegistered.Text = value;
            }
        }

        public String BuildingType
        {
            set
            {
                if (value!="")    
                    cboBuildingType.SelectedValue = value;
            }
            get
            {
                return cboBuildingType.SelectedValue.ToString();
            }
        }
        public String FramePrice
        {
            set
            {
                txtFramePrice.Text = value.ToString();
            }
            get
            {
                return txtFramePrice.Text;
            }
        }

        public String ReceptionRooms
        {
            set
            {
                txtReceptionRooms.Text = value;
            }
        }
        public String Bedrooms
        {
            set
            {
                txtBedrooms.Text = value;
            }
        }
        public String Bathrooms
        {
            set
            {
                txtBathrooms.Text = value;
            }
        }
        public String OptionsPrice
        {
            set
            {
                txtOptionsPrice.Text = value;
                txtSelectedOptionsPrice.Text = value;
            }
        }

        public String VAT
        {
            set
            {
                txtVat.Text = value;
            }
        }

        public String TotalPrice
        {
            set
            {
                txtTotalPrice.Text = value;
            }
        }

        public String SelectedOptionsPrice
        {
            set
            {
                txtSelectedOptionsPrice.Text = value;
            }
        }

        private void txtCustomerId_TextChanged(object sender, EventArgs e)
        {
            _presenter.txtCustomerId_TextChanged();
        }

        public void EnableControls(Boolean enabled)
        {
            // This simple function allows the 'Presenter' to enable.disable data entry text boxes
            // stopping the user from entering data before they've made it clear what they are doing

        
        }

        private void NewOrderForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BuildingGateway.List();
            cboBuildingType.DataSource = ds.Tables[0];
            cboBuildingType.DisplayMember = "TypeCode";
            cboBuildingType.ValueMember = "TypeCode";

        }

        private void btnCustomerSearch_Click(object sender, EventArgs e)
        {
            // The Customer search Button invokes as simple modal search dialogue
            // This enables the user to find a customer when they don't know the CustomerID

            CustomerSearchForm search = new CustomerSearchForm();
            search.ShowDialog();
            txtCustomerId.Text = search.SelectedCustomerId();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _presenter.btnNext_Click();
        }

        public void SetTab(String tabName)
        {
            switch (tabName)
            {
                case "Customer":
                    tabWizzard.SelectTab("Customer");
                    break;

                case "Building":
                    tabWizzard.SelectTab("Building");
                    break;

                case "Options":
                    tabWizzard.SelectTab("Options");
                    break;

                case "Confirm":
                    tabWizzard.SelectTab("Confirm");
                    break;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _presenter.btnBack_Click();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            _presenter.btnNewCustomer_Click();
        }

        private void tabWizzard_Selected(object sender, TabControlEventArgs e)
        {
            _presenter.tabWizzard_Selected(tabWizzard.SelectedTab.Name);
        }

        private void cboBuildingType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrEmpty(cboBuildingType.SelectedText))
            //    _presenter.cboBuildingType_SelectedIndexChanged();
        }

        private void cboBuildingType_SelectedValueChanged(object sender, EventArgs e)
        {
            _presenter.cboBuildingType_SelectedIndexChanged();
        }

        public void ClearBuildingOptions()
        {
            vwBuildingOptions.Rows.Clear();
        }

        public void AddBuildingOption(String optionId, String optionName, String optionPrice)
        {
            String[] row = new String[3];
            row[0] = optionId;
            row[1] = optionName;
            row[2] = optionPrice;
            vwBuildingOptions.Rows.Add(row);
        }

        private void vwBuildingOptions_SelectionChanged(object sender, EventArgs e)
        {
            _presenter.vwBuildingOptions_SelectionChanged();
        }

        public List<Tuple<String, String, String>> SelectedBuildingOptions()
        {
            List<Tuple<String, String, String>> opts = new List<Tuple<String, String, String>>();

            foreach (DataGridViewRow row in vwBuildingOptions.SelectedRows)
            {
                opts.Add(new Tuple<String, String, String>(row.Cells["id"].Value.ToString(), row.Cells["option"].Value.ToString(), row.Cells["price"].Value.ToString()));
            }

            return opts;
        }
     }
}
