using UnityEngine;
namespace Pattern.DependencyInjection
{
    public class Client : MonoBehaviour
    {
        // Bike controlled by the player
        public Bike m_PlayerBike;

        // Bike controlled by an android (AI)
        public Bike m_AndroidBike;

        public Bike m_YoungerPBike;
        public Bike m_OlderPBike;

        void Awake()
        {
            // Set up a bike with a human driver and jet engine
            IEngine jetEngine = new JetEngine();
            IDriver humanDriver = new HumanDriver();
            m_PlayerBike.SetEngine(jetEngine);
            m_PlayerBike.SetDriver(humanDriver);
            m_PlayerBike.StartEngine();

            // Set up a bike with a AI driver and a nitro engine
            IEngine nitroEngine = new NitroEngine();
            IDriver androidDriver = new AndroidDriver();
            m_AndroidBike.SetEngine(nitroEngine);
            m_AndroidBike.SetDriver(androidDriver);
            m_AndroidBike.StartEngine();

            IEngine sugarEngine = new SugarEngine();
            IDriver youngDriver = new YoungDriver();
            m_YoungerPBike.SetEngine(sugarEngine);
            m_YoungerPBike.SetDriver(youngDriver);
            m_YoungerPBike.StartEngine();

            IEngine bubbleEngine = new BubbleEngine();
            IDriver oldDriver = new OldDriver();
            m_OlderPBike.SetEngine(bubbleEngine);
            m_OlderPBike.SetDriver(oldDriver);
            m_OlderPBike.StartEngine();
        }
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                m_PlayerBike.TurnLeft();
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                m_PlayerBike.TurnRight();
            }
        }
        void OnGUI()
        {
            GUI.color = Color.black;
            GUI.Label(new Rect(10, 10, 500, 20), "Press A to turn LEFT and D to turn RIGHT");
            GUI.Label(new Rect(10, 30, 500, 20), "Output displayed in the debug console");
        }
    }
}
