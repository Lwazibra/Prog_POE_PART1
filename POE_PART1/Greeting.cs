using System;
using System.IO;
using System.Media;
using static System.Console;

namespace POE_PART1
{
    internal class Greeting
    {
        public Greeting()
        {
            string path_directory = AppDomain.CurrentDomain.BaseDirectory;
           // WriteLine($"{path_directory}");
            string recordpath = path_directory.Replace("\\bin\\Debug", "");
            string record = Path.Combine(recordpath, "voice.wav");
            play_voice(record);

        }
        public void play_voice(string voice)
        {
            try
            {
                using (SoundPlayer spe = new SoundPlayer(voice))
                {
                    spe.PlaySync();
                }

            }
            catch (Exception ex)
            {
                WriteLine($"{ex.Message}");
            }
        }
    }
}