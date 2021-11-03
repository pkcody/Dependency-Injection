using UnityEngine;
public class SugarEngine : IEngine
{
    public void StartEngine()
    {
        ActivateSugarHigh();
        Debug.Log("Engine started");
    }
    private void ActivateSugarHigh()
    {
        Debug.Log("The sugar high is activated");
    }
}
