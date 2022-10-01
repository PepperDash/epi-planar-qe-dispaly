﻿using System.Collections.Generic;
using PepperDash.Essentials.Core;
using PepperDash.Essentials.Core.Config;

namespace PlanarQeDisplay
{
    public class PlanarQeControllerFactory:EssentialsPluginDeviceFactory<PlanarQeController>
    {
        public PlanarQeControllerFactory()
        {
            TypeNames = new List<string> {"planarqe" };

            MinimumEssentialsFrameworkVersion = "1.11.1";
        }

        #region Overrides of EssentialsDeviceFactory<PlanarQeController>

        public override EssentialsDevice BuildDevice(DeviceConfig dc)
        {
            var comms = CommFactory.CreateCommForDevice(dc);

            if (comms == null) return null;

            var config = dc.Properties.ToObject<PlanarQePropertiesConfig>();

            return config == null ? null : new PlanarQeController(dc.Key, dc.Name, config, comms);
        }

        #endregion
    }
}