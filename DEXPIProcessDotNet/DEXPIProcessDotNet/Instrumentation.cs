using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class InstrumentationSystemActivity : BaseRootObject
    {
        public MultiLanguageString Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }
        public List<InstrumentationActivity> InstrumentationActivities { get; set; } = new List<InstrumentationActivity>();




    }


    public class InstrumentationActivity : BaseObject
    {
        public MultiLanguageString Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }

    }


    public class ControllingProcessVariable : InstrumentationActivity
    {
        public double InputValue { get; set; }
        public double OutputValue { get; set; }
        public double SetPoint { get; set; }

    }

    public class ConveyingSignal : InstrumentationActivity
    {
        public InformationPort XG1 { get; set; }
        public InformationPort XG2 { get; set; }

        public InformationVariant InformationValue { get; set; } = new InformationVariant();
        public ConveyingSignal()
        {
            XG1 = new InformationPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Inlet, Identifier = "XG1" };
            XG2 = new InformationPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Outlet, Identifier = "XG2" };

        }
    }

    public class InformationVariant : BaseObject
    {
        public bool BooleanValue { get; set; }
        public double DoubleValue { get; set; }
        public int IntegerValue { get; set; }
        public int VectorSize { get; set; }

        public InformationVariantType VariantType { get; set; }
    }


    public class CalculatingProcessVariable : InstrumentationActivity
    {

    }

    public class TransformingProcessVariable : CalculatingProcessVariable
    {
        public double Gain { get; set; }
        public double InputValue { get; set; }
        public double Offset { get; set; }
        public double OutputValue { get; set; }
    }

    public class CalculatingSplitRange : CalculatingProcessVariable
    {
        public double InputValue { get; set; }
        public double Output1Value { get; set; }
        public double Output2Value { get; set; }
        public double SplitValue { get; set; }

    }

    public class CalculatingRatio : CalculatingProcessVariable
    {
        public double Gain { get; set; }
        public double Offset { get; set; }
        public double OutputValue { get; set; }
    }

    public class MeasuringProcessVariable : InstrumentationActivity
    {
        public ProcessConnection ConnectionReference { get; set; }
        public double InputValue { get; set; }
        public double OutputValue { get; set; }
        public MeasuredQuantity MeasuredVariable { get; set; }

        public ProcessStep ProcessStepReference { get; set; }
        public ProcessStepDetail ProcessStepDetailReference { get; set; }
    }


}
