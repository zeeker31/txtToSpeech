using System;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace TextToSpeech
{
    public partial class Form1 : Form
    {
        private SpeechSynthesizer synthesizer = new SpeechSynthesizer();
        private SpeechRecognitionEngine recognitionEngine = new SpeechRecognitionEngine();

        public Form1()
        {
            InitializeComponent();
            InitializeSpeechRecognition();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            ReadText(text);
        }

        private void btnStartRecognition_Click(object sender, EventArgs e)
        {
            // Start listening for speech
            try
            {
                recognitionEngine.RecognizeAsync(RecognizeMode.Multiple);
                MessageBox.Show("Speech recognition started. Speak now.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting speech recognition: {ex.Message}");
            }
        }

        private void readtext(string text)
        {
            try
            {
                synthesizer.Dispose();
                synthesizer = new SpeechSynthesizer();
                synthesizer.SpeakAsync(text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Speech Synthesis Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSpeechRecognition()
        {
            // Load a dictation grammar to recognize any speech input
            DictationGrammar dictationGrammar = new DictationGrammar();
            recognitionEngine.LoadGrammar(dictationGrammar);

            recognitionEngine.SpeechRecognized += RecognitionEngine_SpeechRecognized;

            try
            {
                recognitionEngine.SetInputToDefaultAudioDevice();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing speech recognition: {ex.Message}");
            }
        }


        private void RecognitionEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            // Display the recognized speech in the textbox
            Invoke(new Action(() => txtRecognizedSpeech.Text = e.Result.Text));
        }

        private void ReadText(string text)
        {
            synthesizer.SpeakAsync(text);
        }

        private void btnReadText_Click(object sender, EventArgs e)
        {
            string text = txtText.Text;
            ReadText(text);
        }
    }
}


