using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class Port:BaseObject
    {
        public MultiLanguageString Description { get; set; }
        public PortDirection Direction { get; set; }
        public string Identifier { get; set; }

    }

    public class InformationPort : Port
    {

    }
    public class EnergyPort : Port
    {

    }
    public class MaterialPort : Port
    {

    }
    public class ElectricalEnergyPort : EnergyPort
    {

    }
    public class MechanicalEnergyPort : EnergyPort
    {
    }
    public class ThermalEnergyPort : EnergyPort
    {

    }
}
