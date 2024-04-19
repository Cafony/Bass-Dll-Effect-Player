using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;

namespace Bass_Dll_Player
{    
    public partial class speed : Form
    {
        int _stream;
        int _speed;
        int _streamSpeed;
        //float _speed;


        public speed()
        {
            InitializeComponent();
            Bass.BASS_GetVersion();
            Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_DEFAULT,IntPtr.Zero);

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            // create the stream            
            _stream = Bass.BASS_StreamCreateFile(@"c:\mp3\guerra.mp3", 0L, 0L, BASSFlag.BASS_STREAM_DECODE);
            // Tempo Channel            
            _streamSpeed = BassFx.BASS_FX_TempoCreate(_stream, BASSFlag.BASS_FX_FREESOURCE);
            //Bass.BASS_ChannelSetAttribute(_streamSpeed, BASSAttribute.BASS_ATTRIB_TEMPO, _speed);            

            Bass.BASS_ChannelPlay(_streamSpeed, false);          
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            _speed =(int) trackBarSpeed.Value;
            labelSpeed.Text=_speed.ToString();
            Bass.BASS_ChannelSetAttribute(_streamSpeed, BASSAttribute.BASS_ATTRIB_TEMPO, _speed);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Bass.BASS_ChannelStop(_stream);
        }

        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked)
            {
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN2, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(_streamSpeed, swap);
            }
            else
            {
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(_streamSpeed, swap);
            }
        }
    }
}
