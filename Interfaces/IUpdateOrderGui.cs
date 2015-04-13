using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public interface IUpdateOrderGui
    {
        //Order summary
        String OrderId { set; get; }
        //String OrderStatus { set; }
        OrderStatus OrderStatus { set; }
        
        //Planning Phase
        Boolean PlacedPaymentRecieved { set; get; }
        Boolean PlanningGranted { set; get; }
        Boolean PlanningRejected { set; get; }
        String PlanningGrantedDate { set; get; }
        String PlanningRejectedDate { set; get; }

        //Contract and Paymet Phase
        Boolean ContractSigned { set; get; }
        String ContractSignedDate { set; get; }
        Boolean FullInvoicePaymentRecieved { set; get; }
        String FoundationDate { set; get; }
        
        void ShowMessage(String message);
        void Close();
        void EnableControls(Boolean enabled);
        void Register(UpdateOrderPresenter presenter);

        void EnablePlanningRejected(Boolean enabled);

    }
}
