using UnityEngine;
public class OldDriver : IDriver
{
    private Bike m_Bike;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("An older human (different stats for player) will control the bike");
    }
}
