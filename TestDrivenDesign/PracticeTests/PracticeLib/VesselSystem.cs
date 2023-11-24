namespace PracticeLib;

public class VesselSystem
{
    
    public Dictionary<Elements, Vessel> Vessels { get; set; }

    public void UpdateVessel(Dictionary<Elements, Vessel> newVessels)
    {
        foreach (var v in newVessels)
        {
            if (Vessels.ContainsKey(v.Key))
            {
                Vessels[v.Key] = v.Value;
            }
            else
            {
                Vessels.TryAdd(v.Key, v.Value);
            }
            
        }
    }
}