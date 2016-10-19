using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;

namespace StudySound
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            OutputSpeech(voice, txtTextToSpeech.Text, (int)nudDelayAdder.Value, (int)nudDelayMultiplier.Value, (int)nudRepeat.Value);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();

            saveFileDialog1.ShowDialog();

            if(saveFileDialog1.FileName == "")
            {
                return;
            }

            voice.SetOutputToWaveFile(saveFileDialog1.FileName);
            OutputSpeech(voice, txtTextToSpeech.Text, (int)nudDelayAdder.Value, (int)nudDelayMultiplier.Value, (int)nudRepeat.Value);


            saveFileDialog1.FileName = "";
        }
        

        private void btnAddTextFile_Click(object sender, EventArgs e)
        {
            DialogResult r = openFileDialog1.ShowDialog();

            if (r != DialogResult.OK)
            {
                return;
            }

            foreach(string fileName in openFileDialog1.FileNames)
            {
                txtTextToSpeech.Text += System.IO.File.ReadAllText(fileName) + Environment.NewLine;
            }
            
        }



        /// <summary>
        /// Uses a given SpeechSynthesizer to speak the given string, putting delays after each semi-colon, based on the delay values given.
        /// </summary>
        /// <param name="voice">A SpeechSynthesizer that is already instantiated, and has desired settings applied to it.</param>
        /// <param name="textToSpeech">The string that will be spoken by the SpeechSynthesizer.</param>
        /// <param name="delayAdder">The number of silent "a"'s the voice will say to add a delay after each ; in the textToSpeech string</param>
        /// <param name="delayMultiplier">The number of times to repeat the textToSpeech string silently (in order to add a delay), this silence is the length of time between two semi-colons multiplied by this parameter.</param>
        /// <param name="repeat">The number of times to repeat each section</param>
        private void OutputSpeech(SpeechSynthesizer voice, string textToSpeech, int delayAdder, int delayMultiplier, int repeat)
        {
            string delayAdderStr = String.Concat(Enumerable.Repeat("a ", delayAdder));
            int startingVolume = voice.Volume;
            

            foreach (string str in textToSpeech.Split(';'))
            {

                if(str == "")
                {
                    continue;
                }

                for(int repeatCounter = 0; repeatCounter < repeat; repeatCounter++)
                {
                    voice.Speak(str);

                    voice.Volume = 0;
                    for (int i = 0; i < delayMultiplier; i++)
                    {
                        voice.Speak(str);
                    }
                    voice.Speak(delayAdderStr);


                    voice.Volume = startingVolume;

                }
               
            }
            

            voice.SetOutputToDefaultAudioDevice();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
