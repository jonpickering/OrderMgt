﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderManager : IOrderManager
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

        public OrderStatus ManageOrderUpdate(Order o)
        {
            switch (o.Status)
            {
                case OrderStatus.Unsubmitted:

                    if (this.CheckPlanningComplete(o))
                    {
                        //Generate Planning Pack
                        //Generate Contract
                        //Generate £1000 Planning Pack Invoice
                        return OrderStatus.Planning;
                    }
                    break;
                case OrderStatus.Planning:
                
                    if(this.CheckPlanningComplete(o))
                    {
                        //Generate Full Cost Invoice for customer
                        return OrderStatus.Contract;
                    }
                    break;
                case OrderStatus.PlanningRejected:

                    if (this.CheckPlanningComplete(o))
                    {
                        //Generate Full Cost Invoice for customer
                        return OrderStatus.Contract;
                    }
                    break;
                case OrderStatus.Contract:
                    if (this.CheckContractComplete(o))
                    {
                        
                        //Maybe need the sceduler or oerder object to do something with this now.
                        return OrderStatus.Scheduled;
                    }
                    break;
                case OrderStatus.Scheduled:
                    if (this.CheckContractComplete(o))
                    {

                        //Maybe need the sceduler or oerder object to do something with this now.
                        return OrderStatus.Contract;
                    }
                    break;
                default:
                    // You cannot "fall through" any switch section, including
                    // the last one. 
                    break;
               
            }
                return o.Status;
        }

        private Boolean CheckPlanningComplete(Order o)
        {
            //Instialise status flag
            Boolean planningComplete = false;
            
            //this needs to also include payments how ever we deal with that??
            if (o.PlanningGranted != null)
            {
               planningComplete = true;
               return planningComplete;    
            }
            return planningComplete;
        }

        private Boolean CheckContractComplete(Order o)
        {
            //Instialise status flag
            Boolean contractComplete = false;

            if (o.ContractSigned != null)
            {
                contractComplete = true;
                return contractComplete;
            }
            return contractComplete;
        }
    
    }
                  
}
