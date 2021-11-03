using UnityEngine;
public class YoungDriver : IDriver
{
    private Bike m_Bike;
    public void Control(Bike bike)
    {
        m_Bike = bike;
        Debug.Log("A younger human (different stats for player) will control the bike");
    }
}

