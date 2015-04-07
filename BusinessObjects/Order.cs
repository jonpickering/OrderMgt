using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OrderMgt
{
    class Order
    {
        private Boolean _isNewOrder;
        private String _orderId;
        private String _customerId;
        private String _buildingType;
        private Decimal _framePrice;
        private DateTime _created;
        private IBuildingType _building;

        public Order(IBuildingType buildingType)
        {
            _isNewOrder = true;

            _building = buildingType;

            _orderId = "new";
            _customerId = "";
            _created = DateTime.Now;
        }

        public Order(String orderId)
        {
            _isNewOrder = false;

            _orderId = orderId;

            Initialise();
        }

        public String CustomerId
        {
            get
            { return _customerId; }
            set
            { _customerId = value; }
        }

        public String BuildingType
        {
            get
            { 
                return _building.Name; 
            }
        }

        public Decimal FramePrice
        {
            get
            { return _building.FramePrice; }

        }

        public Decimal OptionsPrice
        {
            get
            {
                return 0;
            }
        }

        public Decimal TotalPrice
        {
            get
            {
                return 0;
            }
        }

        public Decimal Vat
        {
            get
            {
                return 0;
            }
        }

        public int ReceptionRooms
        {
            get
            {
                return _building.ReceptionRooms;
            }
        }

        public int Bedrooms
        {
            get
            {
                return _building.Bedrooms;
            }
        }

        public int Bathrooms
        {
            get
            {
                return _building.Bathrooms;
            }
        }


        private void Initialise()
        {
            DataSet ds = OrderGateway.Find(_orderId);

            if (ds.Tables[0].Rows.Count > 0)
            {
                _customerId = ds.Tables[0].Rows[0]["CustomerId"].ToString();
                _buildingType =  ds.Tables[0].Rows[0]["BuildingType"].ToString();
                _framePrice = (Decimal)ds.Tables[0].Rows[0]["FramePrice"];
                _created = (DateTime)ds.Tables[0].Rows[0]["Created"];
            }
        }
    }
}
