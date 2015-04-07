﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderMgt
{
    class FrameOrchard: FrameBase, IBuildingType
    {
        private const String _name="Orchard";


        public FrameOrchard()
            : base(_name)
        {
        }

        public IBuildingType CreateBuilding()
        {
            return new FrameOrchard();
        }

        public static void RegisterBuildingType()
        {
            BuildingFactory.Instance.RegisterBuilding(_name, new FrameOrchard());
        }

    }
}
