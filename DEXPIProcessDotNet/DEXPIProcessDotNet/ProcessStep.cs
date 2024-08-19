using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class ProcessStep : BaseRootObject
    {
        public string Identifier { get; set; }
        public string Label { get; set; }

        public PressureAbsolute AmbientPressure { get; set; }
        public Temperature AmbientTemperature { get; set; }
        public PressureAbsolute Pressure { get; set; }
        public Temperature Temperature { get; set; }

        public List<Port> Ports { get; set; } = new List<Port> { };
    }

    public class Source : ProcessStep
    {
        MaterialPort _XL1;
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

        public Source()
        {
            XL1 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Outlet, Identifier="XL1", Description= ("en", "Source outlet") };

        }

    }

    public class Sink : ProcessStep
    {
        MaterialPort _XL1;
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

        public Sink()
        {
            XL1 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Inlet, Identifier = "XL1", Description = ("en", "Sink inlet") };

        }

    }


    public class ReactingChemicals:ProcessStep
    {
        MaterialPort _XL1;
        MaterialPort _XL2;

        public ReactionProcessType Method { get; set; }
        public Volume Volume { get; set; }
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

        public ReactingChemicals()
        {
            XL1 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Inlet, Identifier = "XL1", Description = ("en", "Reactor inlet") };
            XL2 = new MaterialPort() { Uid = Guid.NewGuid().ToString(), Direction = PortDirection.Outlet, Identifier = "XL2", Description = ("en", "Reactor outlet") };

        }

    }
}
