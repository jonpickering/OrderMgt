﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface INewOrderGui
    {

        String BuildingType { set; get; }
        String ReceptionRooms { set; }
        String Bedrooms { set; }
        String Bathrooms { set; }

        String FramePrice { set; get; }
        String OptionsPrice { set; }
        String VAT { set; }
        String TotalPrice { set; }

        String CustomerId { set; get; }
        String CustomerName { set; }
        String Address { set; }
        String Town { set; }
        String PostCode { set; }
        String Telephone { set; }
        String Mobile { set; }
        String Registered { set; }

        List<Tuple<String, String, String>> SelectedBuildingOptions();

        void ClearBuildingOptions();
        void AddBuildingOption(String optionId, String optionName, String optionPrice);

        void ShowMessage(String message);
        void Close();
        void EnableControls(Boolean enabled);
        void Register(NewOrderPresenter newOrderPresenter);

        void SetTab(String tabName);
    }
}
