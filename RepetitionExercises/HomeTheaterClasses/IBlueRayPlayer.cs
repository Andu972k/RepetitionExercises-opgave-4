using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepetitionExercises.HomeTheaterClasses
{
    interface IBlueRayPlayer
    {

        bool IsPlaying { get; }

        void Play();

        void Stop();

    }
}
