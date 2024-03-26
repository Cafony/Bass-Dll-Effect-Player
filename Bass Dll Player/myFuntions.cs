using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;


namespace Bass_Dll_PitchShift
{   

    public static class myFuntions
    {
        
        private  static int _stream;
        private  static string _musicFile1;

        public static void bassInit()
        {
            Bass.BASS_Init(-1,44100,BASSInit.BASS_DEVICE_DEFAULT,IntPtr.Zero);
            _stream = Bass.BASS_StreamCreateFile(_musicFile1, 0, 0, BASSFlag.BASS_DEFAULT);
            
            if(_stream == 0)
            {                
                MessageBox.Show("Invalid file");
            }

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









    }
}
