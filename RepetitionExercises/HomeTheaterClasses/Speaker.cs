namespace RepetitionExercises.HomeTheaterClasses
{
    // Denne klasse modellerer en højttaler, der kan tændes og slukkes,
    // og hvor man kan skrue op og ned for lysstyrken.
    public class Speaker : HomeTheaterDevice, ISpeaker
    {
        private const int MinVolume = 0;
        private const int MaxVolume = 100;

        
        private int _currentVolume;

        public Speaker() : base()
        {
            _currentVolume = 0;
            
        }

        

        public int CurrentVolume
        {
            get { return _currentVolume; }
        }

        // Skift mellem tændt og slukket tilstand.
        // Når højttaleren slukkes, sættes lydstyrken til 0.
        

        // Skru op for lydstyrken, med mindre vi har nået
        // den maksimale lydstyrke
        public void IncreaseVolume()
        {
            if (_currentVolume < MaxVolume && IsOn)
            {
                _currentVolume++;
            }
        }

        // Skru op for lydstyrken, med mindre vi har nået
        // den minimale lydstyrke
        public void DecreaseVolume()
        {
            if (_currentVolume > MinVolume && IsOn)
            {
                _currentVolume--;
            }
        }

        protected override void HandleOff()
        {
            _currentVolume = 0;
        }
    }
}