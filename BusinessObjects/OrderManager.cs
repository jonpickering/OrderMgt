using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderManager
    {
        private static OrderManager instance; 

        private OrderManager() { }

        public static OrderManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderManager();
                }
                return instance;
            }
        }

        public void ManageOrderUpdate(Order o, OrderMemento om)
        {

            if (om.ContractSigned != o.ContractSigned)
            { 
            
            }
        }

        private Boolean PlacedStatusComplete(Order o, OrderMemento om)
        {
            //Instialise status flag
            Boolean complete = false;
            if (o.Status != "Placed" && o.Status != "Unsubmitted")
            {
                complete = true;
                return complete;
            }
            else 
            {
                if (o.PlanningGranted == DateTime.MinValue)
                {

                }
            
            }
            return complete;
        }
    
    }
                  
}
