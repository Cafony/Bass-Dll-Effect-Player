using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using Un4seen.Bass.Misc;



namespace Bass_Dll_PitchShift
{
    public partial class speedchange : Form
    {
        private bool _isPlaying=false;
        string _musicFile;
        public int _fileToStream;
        public int _stream;
        private int _streamFx;
        private int _fx;
        private Timer _timer;
        float count = 0;
        int _trackBarSpeed = 1;
        float _speed;
        
        int click = 7; // Buton click for transpose
        int _trackBarPosition=7;
        //=======Pitchshift Values for Transposing : -6 -5 -4 -3- 2 -1  0  1  2  3  4  5  6
        double[] pitchArrayIndex = { 0.70,0.75,0.80,0.85,0.90,0.95, 1, 1.05, 1.10, 1.15, 1.25, 1.30, 1.40 };
        //=====TrackBar Valu Position  1    2    3    4    5    6   7    8     9     10   11    12     13
        double pitchArrayValue;
        
        


        public speedchange()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Initialize BASS.NET
            if (!Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero))
            {
                MessageBox.Show("BASS_Init error: " + Bass.BASS_ErrorGetCode());
                return;
            }


        } 

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            _musicFile=  myFuntions.openFileTz();
            
            //_stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_DEFAULT);
        }



        private void pitchShift()
        {   // MP3 Music Transpose funtion 
            _fileToStream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_STREAM_DECODE);
            _fx = Bass.BASS_ChannelSetFX(_fileToStream, BASSFXType.BASS_FX_BFX_PITCHSHIFT, 0);

            BASS_BFX_PITCHSHIFT parametros = new BASS_BFX_PITCHSHIFT();
            Bass.BASS_FXGetParameters(_fx, parametros);
            parametros.fPitchShift = (float)pitchArrayValue; // Defines the shift transpose value            
            parametros.fSemitones = 0;  // Define the initial pitch value, 0=reset;            
            Bass.BASS_FXSetParameters(_fx, parametros);
            //Bass.BASS_ChannelPlay(_stream, false);
        } 

        private void changeSpeed()
        {
            //http://www.bass.radio42.com/help/html/90d034c4-b426-7f7c-4f32-28210a5e6bfb.htmc
            //https://www.un4seen.com/forum/?topic=19662.msg137608#msg137608

                               
            _stream = BassFx.BASS_FX_TempoCreate(_fileToStream, BASSFlag.BASS_STREAM_AUTOFREE);
            Bass.BASS_ChannelSetAttribute(_stream,BASSAttribute.BASS_ATTRIB_TEMPO,_speed);
            //Bass.BASS_ChannelPlay(_streamFx, false);
        }
        
        private void buttonPlay_Click(object sender, EventArgs e)
        {                     
            pitchShift();
            changeSpeed();
            Bass.BASS_ChannelPlay(_stream, false);            
        }



        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Free resources when closing the form
            Bass.BASS_ChannelRemoveFX(_stream, _fx);
            Bass.BASS_StreamFree(_stream);
            Bass.BASS_Free();
        }

        
        private void buttonMais_Click(object sender, EventArgs e)
        {
            _trackBarPosition = trackBar1.Value - trackBar1.Minimum; // Value of the actual trackbar position
            _trackBarPosition++;
            if(_trackBarPosition >= 0 && _trackBarPosition < 13)
            {
                pitchArrayValue= pitchArrayIndex[_trackBarPosition];
                trackBar1.Value = _trackBarPosition+1;
                
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
            
            trackBar1.Value = _trackBarPosition;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            //_timer.Stop();
            //Bass.BASS_ChannelRemoveFX(_fx, _stream);
            //Bass.BASS_StreamFree(_stream);
            //Bass.BASS_StreamFree(_fx);
            //Bass.BASS_Stop();
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_ChannelStop(_streamFx);
            
            //Bass.BASS_ChannelPause(_stream);           

        }



        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _trackBarPosition = trackBar1.Value - trackBar1.Minimum;
            if (_trackBarPosition >= 0 && _trackBarPosition < pitchArrayIndex.Length)
            {
                pitchArrayValue = pitchArrayIndex[_trackBarPosition];
                
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string url = "https://www.un4seen.com/";
            Process.Start(url);
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
       
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            _speed=trackBarSpeed.Value;
        }

        private void pictureBoxReset_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            trackBarSpeed.Value = 1;
            _speed = 1;
        }





    }
}
