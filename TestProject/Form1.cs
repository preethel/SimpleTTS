using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TestProject
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();
        public Form1()
        {
            InitializeComponent();
        }
        private bool capsLockState = Control.IsKeyLocked(Keys.CapsLock);
        private void TTS_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync(textBox.Text);
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox.TextLength > 0)
            {
                synth.SpeakAsync(textBox.Text[textBox.TextLength - 1].ToString());
            }
            //synth.SpeakAsync(textBox.Text);
        }

        private void textBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.CapsLock)
            {
                // Toggle the Caps Lock state and speak the appropriate message
                capsLockState = !capsLockState;
                if (capsLockState)
                {
                    synth.SpeakAsync("Caps Lock on");
                }
                else
                {
                    synth.SpeakAsync("Caps Lock off");
                }
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Space)
            {
                // Speak "Space" when the Space key is pressed
                synth.SpeakAsync("Space");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemPeriod)
            {
                // Speak "period" when the period key is pressed
                synth.SpeakAsync("OemPeriod");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oemcomma)
            {
                // Speak "Comma" when the comma key is pressed
                synth.SpeakAsync("Comma");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemSemicolon)
            {
                // Speak "Semicolon" when the semicolon key is pressed
                synth.SpeakAsync("Semicolon");
                e.IsInputKey = true;
            }
            else if (e.KeyCode == Keys.OemQuotes)
            {
                // Speak "Quotes" when the quotes key is pressed
                synth.SpeakAsync("Quotes");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemBackslash)
            {
                // Speak "Backslash" when the backslash key is pressed
                synth.SpeakAsync("Backslash");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemOpenBrackets)
            {
                // Speak "Open bracket" when the open bracket key is pressed
                synth.SpeakAsync("Open bracket");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemCloseBrackets)
            {
                // Speak "Close bracket" when the close bracket key is pressed
                synth.SpeakAsync("Close bracket");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.OemMinus)
            {
                // Speak "Minus" when the minus key is pressed
                synth.SpeakAsync("Minus");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem1)
            {
                // Speak "Semicolon" when the semicolon key is pressed
                synth.SpeakAsync("Semicolon");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem2)
            {
                // Speak "Forward slash" when the forward slash key is pressed
                synth.SpeakAsync("Forward slash");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem3)
            {
                // Speak "Tilde" when the tilde key is pressed
                synth.SpeakAsync("Tilde");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem4)
            {
                // Speak "Open bracket" when the open bracket key is pressed
                synth.SpeakAsync("Open bracket");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem5)
            {
                // Speak "Backslash" when the backslash key is pressed
                synth.SpeakAsync("Backslash");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem6)
            {
                // Speak "Close bracket" when the close bracket key is pressed
                synth.SpeakAsync("Close bracket");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem7)
            {
                // Speak "Quotes" when the quotes key is pressed
                synth.SpeakAsync("Quotes");
                e.IsInputKey = true; 
            }
            else if (e.KeyCode == Keys.Oem8)
            {
                // Speak "Backslash" when the backslash key is pressed
                synth.SpeakAsync("Backslash");
                e.IsInputKey = true; 
            }
        }
    }
}
