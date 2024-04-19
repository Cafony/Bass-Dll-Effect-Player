using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass.AddOn.Fx;
using Un4seen.Bass;
using Bass_Dll_PitchShift;

namespace Bass_Dll_Player
{

    public partial class equalizer : Form
    {
        int _stream;
        int _fx;

        
        public equalizer()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            labelFreq.Text = "Freq. : " + trackBarFreq.Value.ToString() + " Hz";
            labelGain.Text = "Gain : " + trackBarGain.Value.ToString() + " db";

        }
                
        private void peakEQ()
        {              
            int volume = Convert.ToInt32(trackBarGain.Value);
            int freq = Convert.ToInt32(trackBarFreq.Value);
            labelFreq.Text = "Freq.: "+freq.ToString()+" Hz";

            BASS_BFX_PEAKEQ pa = new BASS_BFX_PEAKEQ();
            //pa.fBandwidth = 8f; // 0.5; 1; 2; 3; 4; abre a gama de frequencias
            pa.fCenter = freq;   // define a frequencia 
            pa.fGain = volume;
            Bass.BASS_FXSetParameters(_fx, pa);
        }

        private void buttonPeakEQ_Click(object sender, EventArgs e)
        {
            
            string _musicFile2 = @"c:\mp3\cigano.mp3";
            _stream = Bass.BASS_StreamCreateFile(_musicFile2, 0L, 0L, BASSFlag.BASS_DEFAULT);
            // set EQ effect on stream            
            _fx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_PEAKEQ, 0);

            peakEQ();
            Bass.BASS_ChannelPlay(_stream, false);            
        }


        private void equalizer_Load(object sender, EventArgs e)
        {
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            peakEQ();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            labelGain.Text = "Gain : " + trackBarGain.Value.ToString() + " db";
            peakEQ();
        }
    }
}
