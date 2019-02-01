namespace RepetitionExercises.HomeTheaterClasses
{
    // Denne klasse modellerer et (meget simpelt) Smart TV,
    // der kan tændes og slukkes, og hvor man kan skifte kanal.
    public class SmartTV : HomeTheaterDevice, ISmartTV
    {
        private const int MinChannel = 1;
        private const int MaxChannel = 100;

        
        private int _channel;

        public SmartTV() : base()
        {
            
            _channel = 0;
        }

        

        // Skift kanal, med mindre den nye værdi er
        // ulovlig, jf. min- og max-værdier for kanal.
        public int Channel
        {
            get { return _channel; }
            set
            {
                if (value >= MinChannel && value <= MaxChannel && IsOn)
                {
                    _channel = value;
                }
            }
        }

        

        protected override void HandleOn()
        {
            _channel = 1;
        }

        protected override void HandleOff()
        {
            _channel = 0;
        }
    }
}