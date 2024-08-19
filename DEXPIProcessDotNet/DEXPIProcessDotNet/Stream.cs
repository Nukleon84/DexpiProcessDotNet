using DEXPIProcessDotNet.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace DEXPIProcessDotNet
{
    public class Stream : ProcessConnection
    {
        public MassFlowRate MassFlow { get; set; }
        public PressureAbsolute Pressure { get; set; }
        public Temperature Temperature { get; set; }
        public VolumeFlowRate VolumeFlow { get; set; }

        public MaterialTemplate MaterialTemplateReference { get; set; }
        public MaterialState MaterialStateReference { get; set; }

        public void BindMaterialState(MaterialState state)
        {
            MaterialStateReference = state;
            state.StreamReference = this;
        }

        public void Connect(Port source, Port target)
        {
            this.Source = source;
            this.Target = target;
        }
    }


    public class MaterialComponent : BaseRootObject
    {
        public string Identifier { get; set; }
        public string Label { get; set; }
        public MultiLanguageString Description { get; set; }

    }
    public class PureMaterialComponent : MaterialComponent
    {
        public string ChEBI_identifier { get; set; }
        public string IUPAC_identifier { get; set; }
        public string CAS_identifier { get; set; }


    }

    public class CustomMaterialComponent : MaterialComponent
    {
        public string ProjectReference { get; set; }
    }

    public class ListOfMaterialComponents
    {
        public List<MaterialComponent> Component { get; set; } = new List<MaterialComponent>();
    }

    public class MaterialTemplate : BaseRootObject
    {
        public MultiLanguageString Description { get; set; } 
        public string Identifier { get; set; }
        public string Label { get; set; }

        public int NumberOfMaterialComponents { get => ListOfComponents.Component.Count; }
        public int NumberOfPhases { get => PhaseLabel.Count; }
        public List<string> PhaseLabel { get; set; } = new List<string>();

        public ListOfMaterialComponents ListOfComponents { get; set; } = new ListOfMaterialComponents();
    }


    public class MaterialState : BaseRootObject
    {
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }

        public MaterialStateType State { get; set; } = new MaterialStateType();
        public List<MaterialStateType> Phases { get; set; } = new List<MaterialStateType>();

        public Stream StreamReference { get; set; }
    }

    public class MaterialStateType
    {
        public string Description { get; set; }
        public string Identifier { get; set; }
        public string Label { get; set; }
        public Composition Composition { get; set; } = new Composition();


    }

    public class Composition
    {
        public CompositionBasis Basis { get; set; } = CompositionBasis.Mass;
        public CompositionDisplay Display { get; set; } = CompositionDisplay.Fraction;        
        public List<Percentage> Fraction { get; set; } = new List<Percentage>();
        public List<MassFlowRate> MassFlow { get; set; } = new List<MassFlowRate>();
        public List<MoleFlowRate> MoleFlow { get; set; } = new List<MoleFlowRate>();


    }

}
