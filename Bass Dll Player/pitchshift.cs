using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;


namespace Bass_Dll_PitchShift
{
    public partial class pitchshift : Form
    {
        
        private int _stream;
        private int _fx;
        int _trackBarPitch=0;
        string _musicFile;
        
        int _trackBarPosition=7;
        //=======Pitchshift Values for Transposing : -6 -5 -4 -3- 2 -1  0  1  2  3  4  5  6
        double[] pitchArrayIndex = { 0.70,0.75,0.80,0.85,0.90,0.95, 1, 1.05, 1.10, 1.15, 1.25, 1.30, 1.40 };
        //=====TrackBar Valu Position  1    2    3    4    5    6   7    8     9     10   11    12     13
        double pitchArrayValue;      


        public pitchshift()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();            
        }

         private void Form2_Load(object sender, EventArgs e)
        {
            myFuntions.bassInit();                      
        } 
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Ficheiros|*.mp3";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                _musicFile= ofd.FileName;                
            }
        }

        private void pitchShift(int pitch)
        {   // MP3 Music Transpose funtion 
            BASS_BFX_PITCHSHIFT parametros = new BASS_BFX_PITCHSHIFT();
            Bass.BASS_FXGetParameters(_fx, parametros);
            parametros.fPitchShift = (float)pitchArrayValue; // Defines the shift transpose value Prioritario a fSemitone            
            parametros.fSemitones = pitch;  // Define the initial pitch value, 0=reset;            
            Bass.BASS_FXSetParameters(_fx, parametros);
            if (_fx == 0)
            {
                MessageBox.Show("BASS_ChannelSetFX error: " + Bass.BASS_ErrorGetCode());
                return;
            }
        } 
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            _stream = Bass.BASS_StreamCreateFile(_musicFile, 0, 0, BASSFlag.BASS_DEFAULT);
            //_stream = Bass.BASS_StreamCreateFile(_musicFile, 0, 0, BASSFlag.BASS_STREAM_DECODE);
            _fx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_PITCHSHIFT, 0);
            //pitchShift(_trackBarPitch);            
            Bass.BASS_ChannelPlay(_stream, false);            
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Free resources when closing the form
            //Bass.BASS_ChannelRemoveFX(_stream, _fx);
            //Bass.BASS_StreamFree(_stream);
            //Bass.BASS_Free();
        }

        
        private void buttonMais_Click(object sender, EventArgs e)
        {
            _trackBarPosition = trackBar1.Value - trackBar1.Minimum; // Value of the actual trackbar position
            _trackBarPosition++;
            if(_trackBarPosition >= 0 && _trackBarPosition < 13)
            {
                pitchArrayValue= pitchArrayIndex[_trackBarPosition];
                trackBar1.Value = _trackBarPosition+1;
                label1.Text = pitchArrayValue.ToString();
            }
            else
            {
                _trackBarPosition = 13;
            }               
        }

        private void buttonMenos_Click(object sender, EventArgs e)
        {
            _trackBarPosition = trackBar1.Value - trackBar1.Minimum; // Value of the actual trackbar position
            _trackBarPosition--;
            if(_trackBarPosition >= 0 && _trackBarPosition < 13)
            {
                pitchArrayValue = pitchArrayIndex[_trackBarPosition];
                trackBar1.Value = _trackBarPosition+1;
                label1.Text = pitchArrayValue.ToString();
            }
            else
            {
                _trackBarPosition = 0;
            }
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {            
            _trackBarPosition = 7;
            pitchArrayValue = pitchArrayIndex[_trackBarPosition-1];
            label1.Text=pitchArrayValue.ToString();
            trackBar1.Value = _trackBarPosition;
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {          
            Bass.BASS_ChannelStop(_stream);
            //Bass.BASS_ChannelRemoveDSP(_stream, _fx);
            Bass.BASS_ChannelRemoveFX(_stream,_fx);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _trackBarPosition = trackBar1.Value - trackBar1.Minimum;
            if (_trackBarPosition >= 0 && _trackBarPosition < pitchArrayIndex.Length)
            {
                pitchArrayValue = pitchArrayIndex[_trackBarPosition];
                label1.Text = (pitchArrayValue.ToString());
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text=pitchArrayValue.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.un4seen.com/";
            Process.Start(url);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
       
        }

        private void trackBarPitch_Scroll(object sender, EventArgs e)
        {
            label1ValorPitch.Text = trackBarPitch.Value.ToString();
            _trackBarPitch = trackBarPitch.Value;
            pitchShift(_trackBarPitch);                        
        }
    }
}
