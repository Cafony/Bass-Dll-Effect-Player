using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;


namespace Bass_Dll_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Inicializa o device 1

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bass.BASS_Init(1, 44100, BASSInit.BASS_DEVICE_DEFAULT, this.Handle);
            Bass.BASS_SetDevice(1);
            int stream = Bass.BASS_StreamCreateFile(@"c:\mp3\cigano.mp3", 0, 0, BASSFlag.BASS_DEFAULT);
            Bass.BASS_ChannelSetAttribute(stream, BASSAttribute.BASS_ATTRIB_VOL, 1);
            //Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_I3DL2REVERB, 0);
            //Bass.BASS_ChannelSetFX(stream,BASSFXType.BASS_FX_DX8_COMPRESSOR, 1);
            if (checkBox1.Checked)
            {
                Echo(stream);
                Bass.BASS_ChannelPlay(stream, false);
            }
            else if (checkBox2.Checked)
            {
                changePitch(stream);
                Bass.BASS_ChannelPlay(stream, false);
            }
            else if (checkBox3.Checked)
            {
                phaser(stream);
                Bass.BASS_ChannelPlay(stream, false);
            }
            else
            {
                Bass.BASS_ChannelPlay(stream, false);
            }
            
        }

        private void phaser(int input)
        {
            int stream = input;
            Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_BFX_PHASER, 1);
            BASS_BFX_PHASER parametros = new BASS_BFX_PHASER();
            parametros.fDryMix = 0;
            parametros.fFreq = 0;
            parametros.fDryMix = 0;
            parametros.fFeedback = 0;
            parametros.fRate = 0;
            parametros.fRange = 0;
            //parametros.fFeedback = +1f;
            
            Bass.BASS_FXSetParameters(stream, parametros);

        }

        private void changePitch(int input)
        {
            int stream = input;
            Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_BFX_PITCHSHIFT, 1);
            BASS_BFX_PITCHSHIFT parametros = new BASS_BFX_PITCHSHIFT();
            parametros.fPitchShift = 12f;
            parametros.fSemitones = 1;
            Bass.BASS_FXSetParameters(stream, parametros);

        }

        private void Echo(int input ) // Função ECHO entra o valor de strea = musca mp3
        {
            int stream = input;
            Bass.BASS_ChannelSetFX(stream, BASSFXType.BASS_FX_DX8_ECHO, 1);
            BASS_DX8_ECHO parametros = new BASS_DX8_ECHO();
            parametros.fWetDryMix = 50.0f; // Example parameter
            parametros.fFeedback = 50.0f; // Example parameter
            parametros.fLeftDelay = 500.0f; // Example parameter
            parametros.fRightDelay = 500.0f; // Example parameter
            parametros.lPanDelay = false;
            Bass.BASS_FXSetParameters(stream, parametros);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bass.BASS_Stop();
            
            Bass.BASS_Free();
            
        }

        private void radioButtonDelay_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
