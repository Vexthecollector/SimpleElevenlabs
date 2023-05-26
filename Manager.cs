using ElevenLabs.User;
using ElevenLabs;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleElevenlabs
{
    public class Manager
    {
        Form1 form1;
        Settings settings;
        WaveOut waveOut = new NAudio.Wave.WaveOut();
        int waveOutDeviceNumbers = WaveOut.DeviceCount;
        ElevenLabsClient api;
        ElevenLabs.Voices.Voice voice;
        List<ElevenLabs.Voices.Voice> allVoices;
        UserInfo userInfo;

        private static readonly Manager configs = new Manager();

        static Manager()
        {
        }
        private Manager()
        {
        }

        public static Manager Configs
        {
            get { return configs; }
        }

        public Form1 Form1 { get => form1; set => form1 = value; }
        public Settings Settings { get => settings; set => settings = value; }
        public WaveOut WaveOut { get => waveOut; set => waveOut = value; }
        public int WaveOutDeviceNumbers { get => waveOutDeviceNumbers; }
        public ElevenLabsClient Api { get => api; set => api = value; }
        public ElevenLabs.Voices.Voice Voice { get => voice; set => voice = value; }
        public List<ElevenLabs.Voices.Voice> AllVoices { get => allVoices; set => allVoices = value; }
        public UserInfo UserInfo { get => userInfo; set => userInfo = value; }
    }
}
