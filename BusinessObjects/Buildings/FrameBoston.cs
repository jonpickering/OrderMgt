using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    class FrameBoston: FrameBase, IBuildingType
    {
        private const String _name="Boston";


        public FrameBoston()
            : base(_name)
        {
        }

        public IBuildingType CreateBuilding()
        {
            return new FrameBoston();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameBoston());
        }

    }
}
