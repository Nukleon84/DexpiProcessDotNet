// See https://aka.ms/new-console-template for more information
using DEXPIProcessDotNet;
using DEXPIProcessDotNet.Enumerations;
using Newtonsoft.Json;
using System.Text.Json;

var document = new Document();
document.Header = new Header();
document.Header.Name = "DEXPI Process 1.0 Tennessee Eastman Process";
document.Header.Author = new NameAndAddress() { Name = "Jochen Steimel", Address = { "Geheimstraße 1", "12345 Nirgendshausen" } };
document.Header.Organization = new NameAndAddress() { Name = "AVEVA GmbH" };
document.Header.Documentation = @"This file contains a definition of the process flow diagram for the Tennessee Eastman Process, as described in the 
paper Cameron, D.B., Waaler, A., Fjøsna, E., Hole, M., Psarommatis, F., 2022. A semantic systems engineering framework for zero-defect 
engineering and operations in the continuous process industries. Front. Manuf. Technol. 2, 945717. https://doi.org/10.3389/fmtec.2022.945717

An XML representation of the draft DEXPI+ standard for Process block and flow diagrams is used. The ISO/IEC81346 coding breakdown that was used 
in the paper is implemented using the Identifier fields in blocks.The process connections are numbered using the original numbering in the
Tennessee Eastman paper.

The PFD is organized in two layers: a top level (Block Flow Diagram) that contains the process segments and main process streams. Each process 
segment is then broken down into a process flow diagram. 

We have chosen to implement local numbering for blocks in each process segment. This means that we need to identify blocks in the PFD with
the code of their parent process segment, thus = KK1.= GMD1.";

var container = new DataContainer();
document.DataContainer.Add(container);

{

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



    var cWater = container.NewPureMaterialComponent();
    cWater.Identifier = "H2O";
    cWater.Description = ("en", "Water");
    cWater.Label = "Water";
    cWater.ChEBI_identifier = "CHEBI:15377";
    cWater.IUPAC_identifier = "XLYOFNOQVPJJNP-UHFFFAOYSA-N";

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

    var mt_water = container.NewMaterialTemplate();
    mt_water.Description = new[] { ("en", "Material Template for Cooling Water and Steam"), ("de", "Stoffdatenschablone für Kühlwasser und Dampf") };
    mt_water.Identifier = "WaterTemplate";
    mt_water.Label = "Water";
    mt_water.PhaseLabel.Add("Vapour");
    mt_water.PhaseLabel.Add("Liquid");
    mt_water.ListOfComponents.Component.Add(cWater);


    var sourceA = container.NewSource();
    sourceA.Identifier = "ReactantA";
    sourceA.Label = "Reactant A";

    var sourceD = container.NewSource();
    sourceD.Identifier = "ReactantD";
    sourceD.Label = "Reactant D";

    var sourceE = container.NewSource();
    sourceE.Identifier = "ReactantE";
    sourceE.Label = "Reactant E";

    var sourceC = container.NewSource();
    sourceC.Identifier = "ReactantC";
    sourceC.Label = "Reactant C";

    var sinkPurge = container.NewSink();
    sinkPurge.Identifier = "Purge";
    sinkPurge.Label = "Purge";

    var sinkProduct = container.NewSink();
    sinkProduct.Identifier = "Product";
    sinkProduct.Label = "Product";

    var kl1 = container.NewReactingChemicals();
    kl1.Identifier = "=KL1";
    kl1.Label = "Reactor";

    kl1.Ports.Add(new Port() { Direction = PortDirection.Inlet, Identifier = "XL3", Uid = Guid.NewGuid().ToString() });
    kl1.Ports.Add(new Port() { Direction = PortDirection.Inlet, Identifier = "XL4", Uid = Guid.NewGuid().ToString() });
    kl1.Ports.Add(new Port() { Direction = PortDirection.Inlet, Identifier = "XL5", Uid = Guid.NewGuid().ToString() });
    kl1.Ports.Add(new Port() { Direction = PortDirection.Inlet, Identifier = "XL6", Uid = Guid.NewGuid().ToString() });

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

    var s2_state = container.NewMaterialState();
    s2_state.Identifier = "2";
    s2_state.Label = "D Feed";
    s2_state.State.Composition.Display = CompositionDisplay.Fraction;
    s2_state.State.Composition.Basis = CompositionBasis.Mole;    
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0001, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.9999, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s2_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));

    var s2 = container.NewStream();
    s2.Identifier = "2";
    s2.Label = "D Feed";
    s2.MassFlow = (3664.0, MassFlowUnitsType.KilogramPerHour);
    s2.Temperature = (45, TemperatureUnitsType.DegreeCelsius);
    s2.Connect(sourceD.XL1, kl1.Ports.FirstOrDefault(p => p.Identifier == "XL3"));
    s2.BindMaterialState(s2_state);
    s2.MaterialTemplateReference = mt;

    var s3_state = container.NewMaterialState();
    s3_state.Identifier = "3";
    s3_state.Label = "E Feed";
    s3_state.State.Composition.Display = CompositionDisplay.Fraction;
    s3_state.State.Composition.Basis = CompositionBasis.Mole;
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.99990, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.00010, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));
    s3_state.State.Composition.Fraction.Add((0.0, PercentageUnitsType.Fraction));

    var s3 = container.NewStream();
    s3.Identifier = "3";
    s3.Label = "E Feed";
    s3.MassFlow = (4509.3, MassFlowUnitsType.KilogramPerHour);
    s3.Temperature = (45, TemperatureUnitsType.DegreeCelsius);
    s3.Connect(sourceD.XL1, kl1.Ports.FirstOrDefault(p => p.Identifier == "XL4"));
    s3.BindMaterialState(s3_state);
    s3.MaterialTemplateReference = mt;


}

//var options = new JsonSerializerOptions { WriteIndented = true, UnknownTypeHandling = System.Text.Json.Serialization.JsonUnknownTypeHandling.JsonElement, };
//string jsonString = JsonSerializer.Serialize(document, options);

string jsonString = JsonConvert.SerializeObject(document, Formatting.Indented, new JsonSerializerSettings
{
    TypeNameHandling = TypeNameHandling.Auto,
    PreserveReferencesHandling = PreserveReferencesHandling.Objects
});
Console.WriteLine(jsonString);

Console.ReadLine();