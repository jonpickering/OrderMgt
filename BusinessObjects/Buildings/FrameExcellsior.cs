using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace OrderMgt
{
    class FrameExcellsior: FrameBase, IBuildingType
    {
        private const String _name="Excellsior";


        public FrameExcellsior()
            : base(_name)
        {
        }

        public IBuildingType CreateBuilding()
        {
            return new FrameExcellsior();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameExcellsior());
        }

    }
}
