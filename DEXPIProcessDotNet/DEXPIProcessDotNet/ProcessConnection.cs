using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class ProcessConnection:BaseRootObject
    {
        public MultiLanguageString Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }
        public Port Target { get; set; }
        public Port Source { get; set; }

    }

    public class InformationFlow : ProcessConnection
    {

    }

    public class EnergyFlow : ProcessConnection
    {
        public Power Duty { get; set; }
    }

    public class ElectricalEnergyFlow : EnergyFlow
    {
        public ElectricalFrequency Frequency { get; set; }
        public int NumberOfPhases { get; set; }
        public Voltage Voltage { get; set; }

    }

    public class MechanicalEnergyFlow : EnergyFlow
    {
        public RotationalFrequency RotationalFrequency { get; set; }
        public MomentOfForce Torque { get; set; }
    }

    public class ThermalEnergyFlow : EnergyFlow
    {
        public Temperature Temperature { get; set; }
    }

    
}
