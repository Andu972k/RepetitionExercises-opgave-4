using System.Collections.Generic;
using RepetitionExercises.HomeTheaterClasses;

namespace RepetitionExercises.HomeTheaterClasses
{
    // Denne klasse definerer et Home Theater (HT) system. 
    // Dette er defineret som bestående af: 
    // Et TV, en Blu-Ray afspiller samt to højttalere.
    public class HomeTheater
    {

        //private SmartTV _tv;
        //private BluRayPlayer _player;
        //private Speaker _left;
        //private Speaker _right;
        private List<IHomeTheaterDevice> _devices = new List<IHomeTheaterDevice>();

        public HomeTheater()
        {
            //_tv = tv;
            //_player = player;
            //_left = speakerLeft;
            //_right = speakerRight;


        }


        public List<IHomeTheaterDevice> Devices
        {
            get { return _devices; }
            set { _devices = value; }
        }


        // Skift mellem tændt og slukket tilstand for systemet.
        // Dette gøres ved at udføre denne operation på alle
        // devices i systemet.
        public void ToggleOnOff()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                device.ToggleOnOff();
            }


        }

        // Skru op for lydstyrken i begge højttalere.
        public void IncreaseVolume()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is ISpeaker)
                {
                    ((ISpeaker)device).IncreaseVolume();
                }
            }
        }

        // Skru ned for lydstyrken i begge højttalere.
        public void DecreaseVolume()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is ISpeaker)
                {
                    ((ISpeaker)device).DecreaseVolume();
                }
            }
        }

        // Skift til næste kanal (kanal lige efter 
        // nuværende kanal) på TVet.
        public void IncreaseChannel()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is ISmartTV)
                {
                    ((ISmartTV) device).Channel++;
                }
            }
        }

        // Skift til forrige kanal (kanal lige før 
        // nuværende kanal) på TVet.
        public void DecreaseChannel()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is ISmartTV)
                {
                    ((ISmartTV) device).Channel--;
                }
            }
        }

        // Start afspilning på Blu-Ray afspilleren
        public void PlayDevice()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is IBlueRayPlayer)
                {
                    ((IBlueRayPlayer)device).Play();
                }
            }
        }

        // Stop afspilning på Blu-Ray afspilleren
        public void StopDevice()
        {
            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is IBlueRayPlayer)
                {
                    ((IBlueRayPlayer)device).Stop();
                }
            }
        }

        // Returnerer status for hele system, i form af en string.
        // Udskift "???" med navnet på det instance field, du har
        // defineret for hver af de fire devices i HT-systemet.
        public override string ToString()
        {
            string status = "Current status of Home Theater\n";
            status += "------------------------------\n";

            foreach (IHomeTheaterDevice device in _devices)
            {
                if (device is ISmartTV)
                {
                    status += TvInfo((ISmartTV)device);
                }
                else if (device is IBlueRayPlayer)
                {
                    status += BluRayPlayerPlayerInfo((IBlueRayPlayer)device);
                }
                else if (device is ISpeaker)
                {
                    status += SpeakerInfo((ISpeaker)device);
                }
            }

            //status += $"Smart TV       : {ConvertOnOff(_tv.IsOn)}, showing channel {ConvertChannelNo(_tv.Channel)}\n";
            //status += $"Blu-Ray player : {ConvertOnOff(_player.IsOn)}, is {ConvertBluRayStatus(_player.IsPlaying)}\n";
            //status += $"Left Speaker   : {ConvertOnOff(_left.IsOn)}, is at volume {_left.CurrentVolume}\n";
            //status += $"Right Speaker  : {ConvertOnOff(_right.IsOn)}, is at volume {_right.CurrentVolume}\n";

            return status;
        }

        #region Private metoder

        private string TvInfo(ISmartTV tv)
        {
            return $"Smart TV       : {ConvertOnOff(((IHomeTheaterDevice)tv).IsOn)}, showing channel {ConvertChannelNo(tv.Channel)}\n";


        }


        private string BluRayPlayerPlayerInfo(IBlueRayPlayer player)
        {
            
            return $"Blu-Ray player : {ConvertOnOff(((IHomeTheaterDevice)player).IsOn)}, is {ConvertBluRayStatus(player.IsPlaying)}\n";
        }


        private string SpeakerInfo(ISpeaker speaker)
        {
            return $"Speaker        : {ConvertOnOff(((IHomeTheaterDevice)speaker).IsOn)}, is at volume {speaker.CurrentVolume}\n";
        }



        private string ConvertOnOff(bool onOff)
        {
            return onOff ? "On" : "Off";
        }

        private string ConvertChannelNo(int channelNo)
        {
            return channelNo == 0 ? "(No channel)" : channelNo.ToString();
        }

        private string ConvertBluRayStatus(bool isPlaying)
        {
            return isPlaying ? "Playing" : "Stopped";
        } 
        #endregion
    }
}