using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace Bass_Dll_Player
{
    public partial class Eq_HighPass : Form
    {
        string _musicFile;
        bool isPlaying;
        int _stream;
        public int _freqValue;
        int _streamFx;
        
        
        public Eq_HighPass()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }

        private void openFile()
        {
            // Se estiver a tocar musica desliga tudo            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            ofd.Filter = "Audio Files|*.mp3;*.wma";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _musicFile = ofd.FileName;
                textBox1.Text = ofd.FileName;
            }
        }
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void lowShelf(int _freq)
        {
            //BASS_BFX_LPF parametros = new BASS_BFX_LPF();
            BASS_BFX_BQF parametros = new BASS_BFX_BQF();
            //Bass.BASS_FXGetParameters(_streamFx, parametros);
            //parametros.fBandwidth = 10;
            //parametros.fQ = 0.1f;
            //parametros.fS = 0.1f;
            //parametros.fGain = 15f;
            parametros.fCenter = _freq;
            //parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_LOWPASS;
            parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_HIGHPASS;

            //parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_BANDPASS;
            //parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_NOTCH;            
            //parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_LOWSHELF;
            
            //parametros.lFilter = BASSBFXBQF.BASS_BFX_BQF_HIGHSHELF;
            //parametros.fCenter = 2000;
            Bass.BASS_FXSetParameters(_streamFx, parametros);
        }

        

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked==true)
            {                
                _musicFile = @"C:\\mp3\despertar.mp3";
                textBox1.Text = _musicFile;                
                _stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_DEFAULT);
                _streamFx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_BQF, 0);

                //lowShelf();
                Bass.BASS_ChannelPlay(_stream, false);

            }
            else
            {                
                textBox1.Text = _musicFile;
                _stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_DEFAULT);
                _streamFx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_BQF, 0);

                //lowShelf();
                Bass.BASS_ChannelPlay(_stream, false);
            }
            
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(_stream);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {            
            _freqValue = trackBar1.Value;
            label2.Text = _freqValue.ToString()+ " Hz";
            lowShelf(_freqValue);
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
