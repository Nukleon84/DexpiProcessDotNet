using System;

namespace DEXPIProcessDotNet.Enumerations
{
    public enum VoltageUnitsType
    {
        Kilovolt,
        Megavolt,
        Volt,
    }

    public enum CompositionBasis
    {
        Mass,
        Mole,
    }

    public enum CompositionDisplay
    {
        Fraction,
        Percent,
        AbsoluteValue,
    }

    public enum PercentageUnitsType
    {
        Percent,
        Fraction,
    }

    public enum QuantityMode
    {
        Design,
        Allowable,
        Incidental,
        Expected,
        Operating,
        Test,
    }
    public enum QuantityRange
    {
        Actual,
        Average,
        Nominal,
        Normal,
        UpperLimit,
        LowerLimit,
    }
    public enum QuantityProvenance
    {
        Set,
        Specified,
        Estimated,
        Calculated,
        Observed,
    }
    public enum MoleFlowUnitsType
    {
        KilomolePerSecond,
        KilomolePerHour,
        PoundMolePerSecond,
        PoundMolePerHour,
    }
    public enum MoleSpecificEnergyUnit
    {
        JoulePerMole,
        KilocaloriePerMole,
        KilojoulePerKilomole,
        KilojoulePerMole,
    }
    public enum MagneticFieldIntensityUnit
    {
        Oersted,
        AmperePerMetre,
        KiloamperePerMetre,
    }
    public enum MagneticFluxDensityUnit
    {
        Gauss,
        Tesla,
        WeberPerSquareMetre,
    }
    public enum MassSpecificEnergyUnit
    {
        KilojoulesPerKilogram,
        MegajoulesPerKilogram,
    }
    public enum MomentOfForceUnitsType
    {
        NewtonMetre,
        PoundForceFoot,
    }
    public enum RotationalFrequencyUnitsType
    {
        ReciprocalMinute,
        ReciprocalSecond,
    }
    public enum PowerUnitsType
    {
        Kilowatt,
        Megawatt,
        Watt,
    }
    public enum VolumeUnitsType
    {
        cc,
        MicrometreSquaredMetre,
        MillimetreCubed,
        CentimetreCubed,
        DecimetreCubed,
        MetreCubed,
        StandardMetreCubed,
        KilometreCubed,
        MillionMetreCubed,
        Millilitre,
        Centilitre,
        Decilitre,
        Litre,
        Hectolitre,
        InchCubed,
        StandardFootCubed,
        FootCubed,
        HundredFootCubed,
        ThousandFootCubed,
        MillionFootCubed,
        BillionFootCubed,
        YardCubed,
        MileCubed,
        AcreFoot,
        UkBushel,
        UkFluidOunce,
        UkGallon,
        ThousandUkGallon,
        UkPint,
        UkQuart,
        UsBarrel,
        UsBushel,
        UsDryBarrel,
        UsDryPint,
        UsFluidOunce,
        UsGallon,
        ThousandUsGallon,
        UsLiquidPint,
        UsPint,
        UsQuart,
        Barrel,
        ThousandBarrel,
        MillionBarrel,
        Cubem,
        HectareMetre,
    }

    public enum ParticleSizeUnitsType
    {
        Inch,
        Micrometre,
        Millimetre,
    }
    public enum pHUnitsType
    {
        pH,
    }
    public enum ThermalConductivityUnitsType
    {
        BtuPerFootDegreeFahrenheit,
        WattPerMetreKelvin,
    }
    public enum SurfaceTensionUnitsType
    {
        NewtonPerMetre,
        DynePerCentimetre,
        PoundForcePerInch,
    }
    public enum MassConcentrationUnitsType
    {
        KilogramPerLitre,
        KilogramPerMetreCubed,
        PoundMassPerUsGallon,
        PoundMassPerFootCubed,
    }
    public enum KinematicViscosityUnitsType
    {
        CentimetresSquaredPerSecond,
        MetresSquaredPerSecond,
        Centistokes,
        Stokes,
    }
    public enum HeatTransferResistanceUnitsType
    {
        FootSquaredDegreeFahrenheitPerBtu,
        MetreSquaredKelvinPerWatt,
    }
    public enum HeatTransferCoefficientUnitsType
    {
        KilowattPerMetreSquaredKelvin,
        WattPerMetreSquaredKelvin,
    }

    public enum TimeIntervalUnitsType
    {
        Millisecond,
        Second,
        Minute,
        Hour,
        Day,
        Year,
    }
    public enum ForceUnitsType
    {
        Kilonewton,
        Newton,
    }

    public enum ElectricalFrequencyUnitsType
    {
        Hertz,
        Kilohertz,
        Megahertz,
    }
    public enum ElectricCurrentUnitsType
    {
        Ampere,
        Milliampere,
        Kiloampere,
    }
    public enum MassSpecificHeatCapacityUnitsType
    {
        BtuPerPoundDegreeFahrenheit,
        JoulePerKilogramKelvin,//TODO: Check why Watts in original??
        KiloJoulePerKilogramKelvin,
    }
    public enum HeatCapacityUnit
    {
        BtuPerDegreeFahrenheit,
        JoulePerKelvin,//TODO: Check why Watts in original??
        KiloJoulePerKelvin,
    }

    public enum EnergyUnitsType
    {
        Joule,
        Kilojoule,
        Megajoule,
        KilowattHour,
        MegawattHour,
    }

    public enum VelocityUnitsType
    {
        FootPerSecond,
        KilometrePerHour,
        MetrePerSecond,
        MilePerHour,
        NauticalMilePerHour,
    }

    public enum LengthUnitsType
    {
        mm,
        cm,
        dm,
        m,
        km,
        @in,
        ft,
        yd,
        Millimetre,
        Centimetre,
        Decimetre,
        Metre,
        Kilometre,
        Inch,
        Yard,
        Mile,
        Foot,
        Picometre,
        Micrometre,
        Megametre,
        Nanometre,
        Femtometre,
        Fathom,
        Mil,
        Parsec,
        Angstrom,
        TenthOfAnInch,
        NauticalMile,
        [System.Xml.Serialization.XmlEnumAttribute("16thOfAnInch")]
        Item16thOfAnInch,
        [System.Xml.Serialization.XmlEnumAttribute("32ndOfAnInch")]
        Item32ndOfAnInch,
        [System.Xml.Serialization.XmlEnumAttribute("64thOfAnInch")]
        Item64thOfAnInch,
        ImperialYard,
        ImperialFoot,
        UsSurveyInch,
        UsSurveyFoot,
        UsSurveyMile,
        UsSurveyChain,
        UsSurveyLink,
        ClarkeChain,
        ClarkeLink,
        ClarkeYard,
        SearsChain,
        SearsLink,
        SearsFoot,
        SearsYard,
        GermanLegalMetre,
        GoldCoastFoot,
        ModifiedAmericanFoot,
        IndianGeodeticFoot,
        IndianYard,
    }

    public enum VolumeFlowRateUnitsType
    {
        FootCubedPerHour,
        FootCubedPerMinute,
        LitrePerSecond,
        MetreCubedPerDay,
        MetreCubedPerHour,
        MetreCubedPerMinute,
        MetreCubedPerSecond,
    }

    public enum DynamicViscosityUnitsType
    {
        Centipoise,
        MillipascalSecond,
        PascalSecond,
        Poise,
    }

    public enum MassUnitsType
    {
        mg,
        g,
        kg,
        Mg,
        lb,
        oz,
        Microgram,
        Milligram,
        Gram,
        Kilogram,
        Megagram,
        PoundMass,
        OunceMass,
        Attogram,
        MillionPoundMass,
        OunceTroy,
        UkHundredweight,
        UnifiedAtomicMassUnit,
        KilopoundMass,
        UsHundredweight,
        [System.Xml.Serialization.XmlEnumAttribute("94PoundSack")]
        Item94PoundSack,
        AvoirdupoisOunce,
        UkTon,
        Tonne,
        OunceMassAv,
        Grain,
        UsTon,
        Carat,
    }

    public enum MassFlowUnitsType
    {
        KilogramPerHour,
        KilogramPerMinute,
        KilogramPerSecond,
        PoundMassPerHour,
        PoundMassPerMinute,
        PoundMassPerSecond,
    }
    public enum TemperatureUnitsType
    {
        degC,
        degF,
        degK,
        K,
        DegreeCelsius,
        DegreeRankine,
        DegreeFahrenheit,
        Kelvin,
        MilliKelvin,
    }
    public enum PressureGaugeUnitsType
    {
        Bar,
        Kilopascal,
        Megapascal,
        Millibar,
        Pascal,
        PoundForcePerInchSquared,
    }
    public enum PressureAbsoluteUnitsType
    {
        Bar,
        Kilopascal,
        Megapascal,
        Millibar,
        Pascal,
        PoundForcePerInchSquared,
    }
    public enum DensityUnitsType
    {
        KilogramPerLitre,
        KilogramPerMetreCubed,
        PoundMassPerFootCubed,
        PoundMassPerUsGallon,
    }
    public enum AreaUnitsType
    {
        [System.Xml.Serialization.XmlEnumAttribute("sq mm")]
        sqmm,
        [System.Xml.Serialization.XmlEnumAttribute("sq cm")]
        sqcm,
        [System.Xml.Serialization.XmlEnumAttribute("sq dm")]
        sqdm,
        [System.Xml.Serialization.XmlEnumAttribute("sq m")]
        sqm,
        [System.Xml.Serialization.XmlEnumAttribute("sq km")]
        sqkm,
        [System.Xml.Serialization.XmlEnumAttribute("sq in")]
        sqin,
        [System.Xml.Serialization.XmlEnumAttribute("sq ft")]
        sqft,
        [System.Xml.Serialization.XmlEnumAttribute("sq yd")]
        sqyd,
        MillimetreSquared,
        CentimetreSquared,
        DecimetreSquared,
        MetreSquared,
        KilometreSquared,
        InchSquared,
        FootSquared,
        YardSquared,
        MileSquared,
        Barn,
        MicrometreSquared,
        Are,
        Hectare,
        Acre,
        HundredFootSquared,
        UsSurveyMileSquared,
    }

    public enum NumberPerTimeIntervalUnitsType
    {
        ReciprocalMinute,
        ReciprocalSecond,
    }

    public enum PortDirection
    {
        Inlet,
        Outlet,
    }

    public enum MeasuredQuantity
    {
        AudioVisual,
        Density,
        ElectricCurrent,
        ElectricPotential,
        ElectromagneticField,
        Energy,
        Flow,
        Humidity,
        Level,        
        MultipleQuantities,
        NumberOfEvents,
        Power,
        Pressure,
        PressureDifference,
        Quality,
        Radiation,
        SpatialDimension,
        Temperature,
        Time,
        Velocity,
        VibrationOrTorque,
        WeightMassForce,
    }

    public enum MeasurementPurpose
    {
        Monitoring,
        Control,
        SafetyHigh,
        SafetyLow,
        SafetyHighLow,
    }
    public enum TrayRole
    {
        Bottom,
        Feed,
        Monitored,
        Top,
    }

    public enum HeatExchangeMethod
    {
        Generic,
        Plate,
        Spiral,
        Tubular,
    }

    public enum TurbineDriveMethod
    {
        Expander,
        WindTurbine,
        HydraulicTurbine,
        Unspecified,
    }
    public enum EngineDriveMethod
    {
        OttoCycle,
        DieselEngine,
        GasTurbine,
        Unspecified,
    }
    public enum MotorDriveMethod
    {
        AlternatingCurrent,
        DirectCurrent,
        StepperMotor,
        Unspecified,
    }
    public enum ReactionProcessType
    {
        FluidizedBed,
        PackedBed,
        Tank,
        Tubular,
        Unspecified,
    }

    public enum PumpingMethod
    {
        CentrifugalMotion,
        PositiveDisplacement,
        Eductor,
        RotaryMotion,
        Unspecified,
        CustomMethod,
    }
    public enum CompressionMethod
    {
        AxialMotion,
        Blower,
        CentrifugalMotion,
        CustomMethod,
        Ejector,
        Fan,
        ReciprocatingMotion,
        RotaryMotion,
        Unspecified,
    }

    public enum InformationVariantType
    {
        Integer,
        Double,
        Boolean
    }

}
