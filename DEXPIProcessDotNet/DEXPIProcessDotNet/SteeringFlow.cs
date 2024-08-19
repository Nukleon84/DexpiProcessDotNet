using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class SteeringFlow : ProcessStep
    {
        public MassFlowRate Flow { get; set; }
        public VolumeFlowRate VolumeFlow { get; set; }

        MaterialPort _XL1;
        MaterialPort _XL2;
        InformationPort _XG1;
        public MaterialPort XL1
        {
            get => _XL1;
            set
            {
                if (Ports.Contains(_XL1))
                    Ports.Remove(_XL1);

                _XL1 = value;

                if (!Ports.Contains(_XL1))
                    Ports.Add(_XL1);
            }
        }
        public MaterialPort XL2
        {
            get => _XL2;
            set
            {
                if (Ports.Contains(_XL2))
                    Ports.Remove(_XL2);

                _XL2 = value;

                if (!Ports.Contains(_XL2))
                    Ports.Add(_XL2);
            }
        }

        public InformationPort XG1
        {
            get => _XG1;
            set
            {
                if (Ports.Contains(_XG1))
                    Ports.Remove(_XG1);

                _XG1 = value;

                if (!Ports.Contains(_XG1))
                    Ports.Add(_XG1);
            }
        }

        public SteeringFlow()
        {
            XL1 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Inlet, Identifier = "XL1", Description = ("en", "Flow control inlet") };
            XL2 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Outlet, Identifier = "XL2", Description = ("en", "Flow control outlet") };
            XG1 = new InformationPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Inlet };
        }

    }

    public class Draining : SteeringFlow
    {

    }

    public class RelievingVacuumAndOverpressure : SteeringFlow
    {

    }
    public class RelievingOverpressure : SteeringFlow
    {

    }

    public class RelievingVacuum : SteeringFlow
    {

    }

    public class BlowingDown : SteeringFlow
    {

    }

    public class FeedingMaterial : SteeringFlow
    {
        public Mass Capacity { get; set; }
    }

    public class LimitingFlow : SteeringFlow
    {
        public PressureAbsolute PressureDifference { get; set; }
    }

    public class PreventingBackflow : SteeringFlow
    {
        public TimeInterval ClosingTime { get; set; }
        public PressureAbsolute PressureDifference { get; set; }
    }

    public class ShuttingOffFlow:SteeringFlow
    {
        public TimeInterval ClosingTime { get; set; }
        public TimeInterval OpeningTime { get; set; }
        public PressureAbsolute PressureDifference { get; set; }
    }

    public class RegulatingFlow:SteeringFlow
    {
        public TimeInterval ClosingTime { get; set; }
        public TimeInterval OpeningTime { get; set; }
        public PressureAbsolute PressureDifference { get; set; }
    }
}
