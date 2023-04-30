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

namespace TextToSpeech
{

    public partial class Form1 : Form
    {
        SpeechSynthesizer speech;
        
        public Form1()
        {
            InitializeComponent();
            speech = new SpeechSynthesizer();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var textToSay = txtTextToSay.Text.Trim();
            if (textToSay != string.Empty)
            {
                char last_char = txtTextToSay.Text[txtTextToSay.Text.Length - 1];
                speech.SpeakAsync(last_char.ToString());
            }
           
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            var textToSay = txtTextToSay.Text.Trim();
            if (textToSay != string.Empty)
            {
                speech.SpeakAsync(textToSay);
            }
        }
    }
}
