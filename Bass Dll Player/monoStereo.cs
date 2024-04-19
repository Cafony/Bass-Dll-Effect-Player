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
using System.Runtime.InteropServices;


namespace Bass_Dll_Player
{
    public partial class monoStereo : Form
    {
        int _stream;
        int mixMono;
        bool isPlaying=false;
        string _musica;
        public monoStereo()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();    
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }


        private void buttonOpen_Click(object sender, EventArgs e)
        {
            
            // create the stream
            _musica = myFuntions.openFileTz();

        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (_stream == 0)
            {
                _stream = Bass.BASS_StreamCreateFile(_musica, 0L, 0L, BASSFlag.BASS_DEFAULT);
                Bass.BASS_ChannelPlay(_stream, false);
                buttonPlay.Text = "Pause4";
                isPlaying = true;
            }
            else
            {
                if (!isPlaying)
                {
                    //Start Play music
                    Bass.BASS_ChannelPlay(_stream, false);
                    isPlaying = true;
                    buttonPlay.Text = "Pause1";
                }
                else
                {
                    //                if (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
                    Bass.BASS_ChannelPause(_stream);
                    buttonPlay.Text = "Play2";
                    isPlaying = false;
                }
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            buttonPlay.Text = "Play3";                   
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_ChannelSetPosition(_stream, 0, BASSMode.BASS_POS_BYTES);            
        }

        private void monoStereo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bass.BASS_ChannelStop(_stream);
        }

        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked)
            {
                checkBoxCenter.Checked = false;
                checkBoxRight.Checked = false;
                // Cria um novo stream mixMono
                //mixMono = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_MIX, 0);                
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN1);                                
                Bass.BASS_FXSetParameters(mixMono, swap);                
            }                               
        }
        private void checkBoxCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCenter.Checked)
            {
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(mixMono, swap);
                checkBoxLeft.Checked = false;
                checkBoxRight.Checked = false;
            }
        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRight.Checked)
            {
                
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN2, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(mixMono, swap);
                checkBoxCenter.Checked = false;
                checkBoxLeft.Checked = false;
            }
            
        }

    }
}
