using Bass_Dll_Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;


namespace Bass_Dll_PitchShift
{   

    public static class myFuntions
    {
        
        //private  static int _stream;
        private  static string _musicFile1;       

        public static void bassInit()
        {            
            Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_DEFAULT,IntPtr.Zero);                                   
        }

        public static string openFileTz()
        {            
            OpenFileDialog ofd = new OpenFileDialog();            
            ofd.Multiselect = true;
            ofd.Filter = "Audio Files|*.mp3;*.wma" ;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                 _musicFile1 = ofd.FileName;                 
            }
            return _musicFile1;
        }

        public static int speed(int _stream)
        {
            //_stream entra a musica
            // _speed entra o valor do trackbar Speed
            int _streamSpeed = BassFx.BASS_FX_TempoCreate(_stream, BASSFlag.BASS_FX_FREESOURCE);
            //Bass.BASS_ChannelSetAttribute(_streamSpeed, BASSAttribute.BASS_ATTRIB_TEMPO, _speed);
            return _streamSpeed;
        }

        public static int monoLeft(int _stream)
        {            
            int mixfx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_MIX, 0);
            BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN1);            
            Bass.BASS_FXSetParameters(mixfx, swap);
            return mixfx;
        }

        public static int monoRight(int _stream)
        {            
            
            int mixfx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_MIX, 0);
            BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN2, BASSFXChan.BASS_BFX_CHAN2);            
            Bass.BASS_FXSetParameters(mixfx, swap);
            return mixfx;
        }

        public static int monoCenter(int _stream)
        {   
            BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN2);
            int mixfx = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_MIX, 0);                
            Bass.BASS_FXSetParameters(mixfx, swap);
            
            return _stream;
        }

        public static void invertPhase(int music)
        {
            int _stream = music;
            Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_PHASER, 0);
        }

        public static void  pitchShift(int _pitch, float _pitchArrayValue, int _streamPitch)
        {
            //_pitchArrayValue = _pitchArrayIndex[trackBarTranspose.Value];
            BASS_BFX_PITCHSHIFT parametros = new BASS_BFX_PITCHSHIFT();
            Bass.BASS_FXGetParameters(_streamPitch, parametros);
            parametros.fPitchShift = _pitchArrayValue;  //Só funciona sendo float sem nenhum valor (pra nao ter prioridade fSemitone)
            parametros.fSemitones = _pitch;           //(0 won't change the pitch). Default = 0.)
            Bass.BASS_FXSetParameters(_streamPitch, parametros);

            if (_streamPitch == 0)
            {
                MessageBox.Show("Please open a music file !" + Bass.BASS_ErrorGetCode());
                return;
            }
        }



    }
}
