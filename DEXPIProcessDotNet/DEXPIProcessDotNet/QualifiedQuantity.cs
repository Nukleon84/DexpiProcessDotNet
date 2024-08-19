using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class QualifiedQuantity : BaseObject
    {
        public MultiLanguageString Description { get; set; } 
        public string Label { get; set; }
        public string Case { get; set; }
        public List<string> ProvenanceURI { get; set; }
        public List<string> ReferenceDataURI { get; set; } 
        public List<string> SourceURI { get; set; }

        public QuantityMode Mode { get; set; } = QuantityMode.Design;
        public QuantityRange Range { get; set; } = QuantityRange.Normal;
        public QuantityProvenance Provenance { get; set; } = QuantityProvenance.Specified;

        public double Value { get; set; }


    }

    public class TimeInterval: QualifiedQuantity
    {
        public TimeIntervalUnitsType Unit   { get; set; }
    }
    public class Length:QualifiedQuantity
    {
        public LengthUnitsType Unit { get; set; }
    }
    public class PressureAbsolute : QualifiedQuantity
    {
        public PressureAbsoluteUnitsType Unit { get; set; }
    }

    public class Temperature : QualifiedQuantity
    {
        public TemperatureUnitsType Unit { get; set; }

        public static implicit operator Temperature((double, TemperatureUnitsType) t) => new Temperature { Value = t.Item1, Unit = t.Item2 };
    }

    public class Power : QualifiedQuantity
    {
        public PowerUnitsType Unit { get; set; }
    }

    public class Mass:QualifiedQuantity
    {
        public MassUnitsType Unit { get; set; }
    }
    public class MassFlowRate : QualifiedQuantity
    {
        public MassFlowUnitsType Unit { get; set; }

        public static implicit operator MassFlowRate((double, MassFlowUnitsType) t) => new MassFlowRate { Value = t.Item1, Unit = t.Item2 };
    }
    public class MoleFlowRate : QualifiedQuantity
    {
        public MoleFlowUnitsType Unit { get; set; }

        public static implicit operator MoleFlowRate((double, MoleFlowUnitsType) t) => new MoleFlowRate { Value = t.Item1, Unit = t.Item2 };
    }
    public class VolumeFlowRate : QualifiedQuantity
    {
        public VolumeFlowRateUnitsType Unit { get; set; }
    }
    public class Volume : QualifiedQuantity
    {
        public VolumeUnitsType Unit { get; set; }
    }

    public class Voltage : QualifiedQuantity
    {
        public VoltageUnitsType Unit { get; set; }
    }
    public class ElectricalFrequency : QualifiedQuantity
    {
        public ElectricalFrequencyUnitsType Unit { get; set; }
    }

    public class RotationalFrequency : QualifiedQuantity
    {
        public RotationalFrequencyUnitsType Unit { get; set; }
    }

    public class MomentOfForce : QualifiedQuantity
    {
        public MomentOfForceUnitsType Unit { get; set; }
    }

    public class Percentage : QualifiedQuantity
    {
        public PercentageUnitsType Unit { get; set; }

        public static implicit operator Percentage((double, PercentageUnitsType) t) => new Percentage { Value = t.Item1, Unit = t.Item2 };
    }
}
