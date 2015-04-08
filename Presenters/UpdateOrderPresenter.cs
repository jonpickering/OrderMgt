using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class UpdateOrderPresenter
    {
        //private Customer _customer;
        private Order _order;
        private IUpdateOrderGui _screen;

        public UpdateOrderPresenter(IUpdateOrderGui screen)
        {
            _screen = screen;
            _screen.Register(this);

            _screen.EnableControls(false); // Disables order list until user selects a customer or clicks 'New'
        }

        public void txtOrderNumber_TextChanged()
        {
            _order = new Order(_screen.OrderId);
            OrderCaretaker.Instance.OrderMemento = _order.SaveOrderMemento();
            RefreshScreen();
        }

        public void undoChanges()
        {
            _order.RestoreMemento(OrderCaretaker.Instance.OrderMemento);
            RefreshScreen();
        }
        
        public void planningRejectedChanged()
        {
            if (_screen.PlanningRejected == true)
            {
                _order.PlanningRejected = DateTime.Now;
            }
            else
            {
                _order.PlanningRejected = DateTime.MinValue;
            }
            RefreshScreen();
        }

        public void planningGrantedChanged()
        {
            if (_screen.PlanningGranted == true)
            {
                _order.PlanningGranted = DateTime.Now;
            }
            else
            {
                _order.PlanningGranted = DateTime.MinValue;
            }
            RefreshScreen();
        }

        public void contractSignedChanged()
        {
            if (_screen.ContractSigned == true)
            {
                _order.ContractSigned = DateTime.Now;
            }
            else
            {
                _order.ContractSigned = DateTime.MinValue;
            }
            RefreshScreen();
        }

        public void UpdateOrder()
        {
            //this should just call a method on the model not actually have the buisness logic here
            //save_ordermodel to db or something like that and then use an order manager object to workout what has changed and 
            //fire off an actions that the , maybe stick a message box on update saying sccess and any resulting actions
        }

        private void RefreshScreen()
        { 
            //Set the values returned for the order model to the screen.
            _screen.OrderStatus = _order.Status;
               
            //check for presence of a date and set relvant boxes
            if (_order.PlanningGranted == DateTime.MinValue)
            {
                _screen.PlanningGranted = false;
                _screen.PlanningGrantedDate = "";
            }
            else
            {
                _screen.PlanningGranted = true;
                _screen.PlanningGrantedDate = _order.PlanningGranted.ToString();
            }
            
            if (_order.PlanningRejected == DateTime.MinValue)
            {
                _screen.PlanningRejected = false;
                _screen.PlanningRejectedDate = "";
            }
            else
            {
                _screen.PlanningRejected = true;
                _screen.PlanningRejectedDate = _order.PlanningRejected.ToString();
            }

            if (_order.ContractSigned == DateTime.MinValue)
            {
                _screen.ContractSigned = false;
                _screen.ContractSignedDate = "";
            }
            else
            {
                _screen.ContractSigned = true;
                _screen.ContractSignedDate = _order.ContractSigned.ToString();
            }
            
            //some logic is need to lock access to boxses once an order has passed that status. 
            //eg if contact and planning then lock planning. 
            //_screen.EnableControls(true);

        }
    }
}
