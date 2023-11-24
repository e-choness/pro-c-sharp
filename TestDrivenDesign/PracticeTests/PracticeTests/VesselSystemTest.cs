using System.Linq;
using PracticeLib;

namespace PracticeTests;

public class VesselSystemTest
{
    private VesselSystem _vesselSystem;

    [SetUp]
    public void Setup()
    {
        _vesselSystem = new();
    }

    [Test]
    public void Diff_Key_Vessel_Combine_Test()
    {
        
        Vessel vessel1 = new()
        {
            Name = "Urchin",
            UpgradeLevel = 1,
            UpgradeValue = 5.0f
        };

        Vessel vessel2 = new()
        {
            Name = "Urchin",
            UpgradeLevel = 2,
            UpgradeValue = 10.0f
        };

        Dictionary<Elements, Vessel> vessels = new();
        Dictionary<Elements, Vessel> vesselUpgrades = new()
        {
            { Elements.Charge, vessel1 },
            { Elements.Mass, vessel2 }
        };

        _vesselSystem.Vessels = vessels;
        _vesselSystem.UpdateVessel(vesselUpgrades);
        
        Assert.That(_vesselSystem.Vessels.All(e =>  vesselUpgrades.Contains(e)), Is.True);

    }
    
    [Test]
    public void Same_Key_Vessel_Combine_Test()
    {
        Vessel vessel = new()
        {
            Name = "Urchin",
            UpgradeLevel = 1,
            UpgradeValue = 5.0f
        };

        Vessel vesselUpgrade = new()
        {
            Name = "Urchin",
            UpgradeLevel = 2,
            UpgradeValue = 10.0f
        };

        Dictionary<Elements, Vessel> vessels = new()
        {
            { Elements.Charge, vessel }
        };

        Dictionary<Elements, Vessel> vesselUpgrades = new()
        {
            { Elements.Charge, vesselUpgrade }
        };

        _vesselSystem.Vessels = vessels;
        _vesselSystem.UpdateVessel(vesselUpgrades);

        Assert.That(_vesselSystem.Vessels.All(e =>  vesselUpgrades.Contains(e) ), Is.True);
    }
}