using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace Bass_Dll_Player
{
    public partial class PlayPauseStop : Form
    {
        string _musicFile;
        bool isPlaying;
        int _stream;
        public PlayPauseStop()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();
            Bass.BASS_Init(-1, 44100, BASSInit.BASS_DEVICE_DEFAULT, IntPtr.Zero);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Se estiver a tocar musica desliga tudo            
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = true;
                ofd.Filter = "Audio Files|*.mp3;*.wma";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                Bass.BASS_ChannelStop(_stream); // desliga a musica que estiver a tocar
                _musicFile = ofd.FileName;  // Carrega ficheiro para  _musicFile
                //_stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_DEFAULT); // cria _stream pra tocar
                _stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_UNICODE);
                isPlaying = false;
                buttonPlay.Text = "Play";                 
                }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
                if (!isPlaying)
                {                 
                    Bass.BASS_ChannelPlay(_stream, false);
                    isPlaying = true;
                    buttonPlay.Text = "Pause1";
                }
                else
                {                    
                    Bass.BASS_ChannelPause(_stream);
                    buttonPlay.Text = "Play2";
                    isPlaying = false;
                }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            isPlaying = false;
            buttonPlay.Text = "Play3";
            Bass.BASS_ChannelStop(_stream);
            Bass.BASS_ChannelSetPosition(_stream, 0, BASSMode.BASS_POS_BYTES);
        }
    }
}
