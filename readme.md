# DEXPI Process in .net

## What is this?
This is a reference implementation of the DEXPI Process 1.0 Standard for Information Exchange in the Process Industries.

The DEXPI Process Specification defines an information model for BFDs as well as PFDs.
https://dexpi.org/specifications/

This project is a hand-coded implementation of the information model with a nice API for manual creation of flowsheet instances

## Why does this exist?
The intent of this repository is to serve as a baseline implementation for prototypes and hackathons to build applications on top of the DEXPI Process standard, while in practical applications, vendors using the standard will most probably work on their own implementations of the DEXPI Process Object model.


## Examples

The following example shows how the API can be used to construct instances of the DEXPI Process Model to describe a material template and a material stream in a Process Flow Diagram for the Tennessee-Eastman Process.
```
var container = new DataContainer();
document.DataContainer.Add(container);

var cA = container.NewCustomMaterialComponent();
cA.Identifier = "A";
cA.Description = ("en", "Component A");
cA.Label = "A";
cA.ProjectReference = "Tennessee Eastman Anonymised Component";

var cB = container.NewCustomMaterialComponent();
cB.Identifier = "B";
cB.Description = ("en", "Component B");
cB.Label = "B";
cB.ProjectReference = "Tennessee Eastman Anonymised Component";

var cC = container.NewCustomMaterialComponent();
cC.Identifier = "C";
cC.Description = ("en", "Component C");
cC.Label = "C";
cC.ProjectReference = "Tennessee Eastman Anonymised Component";

var cD = container.NewCustomMaterialComponent();
cD.Identifier = "D";
cD.Description = ("en", "Component D");
cD.Label = "D";
cD.ProjectReference = "Tennessee Eastman Anonymised Component";

var cE = container.NewCustomMaterialComponent();
cE.Identifier = "E";
cE.Description = ("en", "Component E");
cE.Label = "E";
cE.ProjectReference = "Tennessee Eastman Anonymised Component";

var cF = container.NewCustomMaterialComponent();
cF.Identifier = "F";
cF.Description = ("en", "Component F");
cF.Label = "F";
cF.ProjectReference = "Tennessee Eastman Anonymised Component";


var cG = container.NewCustomMaterialComponent();
cG.Identifier = "G";
cG.Description = ("en", "Component G");
cG.Label = "G";
cG.ProjectReference = "Tennessee Eastman Anonymised Component";

var cH = container.NewCustomMaterialComponent();
cH.Identifier = "H";
cH.Description = ("en", "Component H");
cH.Label = "H";
cH.ProjectReference = "Tennessee Eastman Anonymised Component";

var mt = container.NewMaterialTemplate();
mt.Description = new[] { ("en", "Material Template for Tennessee Eastman Process"), ("de", "Stoffdatenschablone für den Tennessee Eastman Prozess") };
mt.Identifier = "TEMaterial";
mt.Label = "Tennesee Eastman Material";
mt.PhaseLabel.Add("Vapour");
mt.PhaseLabel.Add("Liquid");
mt.ListOfComponents.Component.Add(cA);
mt.ListOfComponents.Component.Add(cB);
mt.ListOfComponents.Component.Add(cC);
mt.ListOfComponents.Component.Add(cD);
mt.ListOfComponents.Component.Add(cE);
mt.ListOfComponents.Component.Add(cF);
mt.ListOfComponents.Component.Add(cG);
mt.ListOfComponents.Component.Add(cH);

var s1_state = container.NewMaterialState();
s1_state.Identifier = "1";
s1_state.Label = "A Feed";
s1_state.State.Composition.Display = CompositionDisplay.Fraction;
s1_state.State.Composition.Basis = CompositionBasis.Mole;
s1_state.State.Composition.Fraction.Add((0.9999, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0001, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
s1_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));

var s1 = container.NewStream();
s1.Identifier = "1";
s1.Label = "A Feed";
s1.MassFlow = (22.4, MassFlowUnitsType.KilogramPerHour);
s1.Temperature = (45, TemperatureUnitsType.DegreeCelsius);
s1.Connect(sourceA.XL1, kl1.XL1);
s1.BindMaterialState(s1_state);
s1.MaterialTemplateReference = mt;
	
```
