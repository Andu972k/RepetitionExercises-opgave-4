using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionExercises.HomeTheaterClasses
{
    interface ISpeaker
    {
        int CurrentVolume { get;}

        void IncreaseVolume();

        void DecreaseVolume();

    }
}
