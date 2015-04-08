using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    public class OrderMemento
    {
        private Nullable<DateTime> _foundationReady;
        private Nullable<DateTime> _estimatedFab;
        private Nullable<DateTime> _assemblyDate;
        private Nullable<DateTime> _contractSigned;
        private Nullable<DateTime> _planningGranted;
        private Nullable<DateTime> _planningRejected;

        public OrderMemento(Order order)
        {
            _foundationReady = order.FoundationReady;
            _estimatedFab = order.EstimatedFab;
            _assemblyDate = order.AssemblyDate;
            _contractSigned = order.ContractSigned;
            _planningGranted = order.PlanningGranted;
            _planningRejected =order.PlanningRejected;      
        }

        public Nullable<DateTime> PlanningGranted
        {
            get
            { return _planningGranted; }
            set
            { _planningGranted = value; }
        }

        public Nullable<DateTime> PlanningRejected
        {
            get
            { return _planningRejected; }
            set
            { _planningRejected = value; }
        }

        public Nullable<DateTime> FoundationReady
        {
            get
            { return _foundationReady; }
            set
            { _foundationReady = value; }
        }

        public Nullable<DateTime> EstimatedFab
        {
            get
            { return _estimatedFab; }
            set
            { _estimatedFab = value; }
        }

        public Nullable<DateTime> AssemblyDate
        {
            get
            { return _assemblyDate; }
            set
            { _assemblyDate = value; }
        }

        public Nullable<DateTime> ContractSigned
        {
            get
            { return _contractSigned; }
            set
            { _contractSigned = value; }
        }

    }
}
