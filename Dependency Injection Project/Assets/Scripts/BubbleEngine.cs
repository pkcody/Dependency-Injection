using UnityEngine;
public class BubbleEngine : IEngine
{
    public void StartEngine()
    {
        FloatBubble();
        Debug.Log("Engine started");
    }
    private void FloatBubble()
    {
        Debug.Log("The bubbles aren't floating");
    }
}
