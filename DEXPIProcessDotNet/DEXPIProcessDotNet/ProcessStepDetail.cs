using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class ProcessStepDetail:BaseObject
    {
        public MultiLanguageString Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }
        public PressureAbsolute Pressure { get; set; }
        public Temperature Temperature { get; set; }

    }


    public class Agitating: ProcessStepDetail
    {
        public RotationalFrequency RotationalFrequency { get; set; }
        public Power ShaftPower { get; set; }
        public MechanicalEnergyPort XN1 { get; set; }
    }

    public class SupplyingThermalEnergyWithBurner:ProcessStepDetail
    {
        public Power Duty { get; set; }
        public MassFlowRate FuelConsumption { get; set; }

        public MaterialPort XL1 { get; set; }
        public MaterialPort XL2 { get; set; }

    }

    public class ContactingInPacking : ProcessStepDetail
    {
        public Length Height { get; set; }
        public int NumberOfTheoreticalStages { get; set; }
    }

    public class ContactingOnTray:ProcessStepDetail
    {
        public int Number { get; set; }
        public TrayRole Role { get; set; }
    }

}
