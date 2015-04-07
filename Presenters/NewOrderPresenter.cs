using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

// Customer Presenter enabling a passive view model to be implemented for customer maintenance

namespace OrderMgt
{
    public class NewOrderPresenter
    {
        private Customer _customer;
        private INewOrderGui _screen;
        private Order _order;
        private String _currentTab = "Customer";

        public NewOrderPresenter(INewOrderGui screen)
        {
            _screen = screen;
            _screen.Register(this);

            _screen.EnableControls(false); // Disables textboxes until user selects a customer or clicks 'New'
        }

        public void txtCustomerId_TextChanged()
        {
            if (_screen.CustomerId != "")
            {
                _customer = new Customer(_screen.CustomerId);

                _screen.CustomerName = _customer.Name;
                _screen.Address = _customer.Address;
                _screen.Town = _customer.Town;
                _screen.PostCode = _customer.PostCode;
                _screen.Telephone = _customer.Telephone;
                _screen.Mobile = _customer.Mobile;
                _screen.Registered = _customer.Registered;
            }
        }

        public void btnNext_Click()
        {
            switch (_currentTab)
            {
                case "Customer":
                    _screen.SetTab("Building");
                    break;

                case "Building":
                    _screen.SetTab("Options");
                    break;

                case "Options":
                    _screen.SetTab("Confirm");
                    break;

                default:
                    break;
            }
        }

        public void tabWizzard_Selected(String tabName)
        {
            _currentTab = tabName;
        }

        public void btnBack_Click()
        {
            switch (_currentTab)
            {
                case "Building":
                    _screen.SetTab("Customer");
                    break;

                case "Options":
                    _screen.SetTab("Building");
                    break;

                case "Confirm":
                    _screen.SetTab("Options");
                    break;

                default:
                    break;
            }
        }

        public void btnNewCustomer_Click()
        {
            CustomersForm screen = new CustomersForm();
            CustomerPresenter presenter = new CustomerPresenter(screen);

            // Invoke "New Customer" so user can immediately start typing new customer details
            presenter.btnNew_Click();

            screen.ShowDialog();
        }

        public void btnSave_Click()
        {
            try
            {
                _customer.Save();
                _screen.Close();
            }
            catch (Exception ex)
            {
                _screen.ShowMessage("Unable to save customer: " + ex.Message);
            }

        }

        public void cboBuildingType_SelectedIndexChanged()
        {
            IBuildingType building = BuildingFactory.Instance.GetBuildingType(_screen.BuildingType);

            _order = new Order(building);

            _screen.BuildingType = _order.BuildingType.ToString();
            _screen.ReceptionRooms = _order.ReceptionRooms.ToString();
            _screen.Bathrooms = _order.Bathrooms.ToString();
            _screen.Bedrooms = _order.Bedrooms.ToString();

            _screen.ClearBuildingOptions();
            DataSet ds = BuildingGateway.Options(_screen.BuildingType);
            foreach (DataRow option in ds.Tables[0].Rows)
            {
                _screen.AddBuildingOption(option["id"].ToString(), option["optionname"].ToString(), option["optionprice"].ToString());
            }

            RefreshPrice();

        }
        private void RefreshPrice()
        {
            _screen.FramePrice = String.Format("{0:0.00}", _order.FramePrice);
            //_screen.OptionsPrice = String.Format("{0:0.00}", _order.OptionsPrice);
            _screen.VAT = String.Format("{0:0.00}", _order.Vat);
            _screen.TotalPrice = String.Format("{0:0.00}", _order.TotalPrice);
        }

        public void vwBuildingOptions_SelectionChanged()
        {
            List<Tuple<String, String, String>> selectedOptions = _screen.SelectedBuildingOptions();

            Decimal optionsPrice = 0;
            foreach (Tuple<String, String, String> opt in selectedOptions)
            {
                optionsPrice += Decimal.Parse(opt.Item3);
            }

            _screen.OptionsPrice = optionsPrice.ToString();

            RefreshPrice();
        }
    }
}
