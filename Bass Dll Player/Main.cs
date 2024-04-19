using Bass_Dll_Player;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using Un4seen.Bass;
using Un4seen.Bass.AddOn.Fx;
using Un4seen.Bass.AddOn.Mix;




namespace Bass_Dll_PitchShift
{
    public partial class Main : Form
    {
        
        string _musicFile;
        public int _fileToStream;
        public static int _stream;
        public int _streamMono;        
        private int _streamPitch;
        public int _streamEQ;
        bool _isPlaying = false;
        private float _volume = 50;
        int _volumeEq;
        int _freqEq;
        float _speed;
        float _pitchArrayValue;
        private int bufferSize = 4096; // Adjust buffer size as needed
        private byte[] buffer = new byte[4096];        
        public int _streamSpeed;        
        double[] _pitchArrayIndex = { 0.70,0.75,0.80,0.85,0.90,0.95, 1, 1.05, 1.10, 1.15, 1.25, 1.30, 1.40 };
        
        public int _trackBarPitch;      
                   

        public Main()
        {
            InitializeComponent();
            BassFx.BASS_FX_GetVersion();
            peakEqValues();  //Coloca os valores no Eq, Freq e Gain
            richTextBox1.AllowDrop = true;
            richTextBox1.EnableAutoDragDrop = true;

        }
        private void Form2_Load(object sender, EventArgs e)
        {
            myFuntions.bassInit();
            
        } 

        private void resetAllLabels()
        {            
            //====CheckBoxs
            checkBoxEqOn.Checked= false;
            checkBoxCenter.Checked= true;
            //=====Trackbars
            trackBarTranspose.Value = 0;
            trackBarSpeed.Value= 0;
            //============Labels
            labelTranspose.ForeColor = Color.Black;
            labelSpeed.ForeColor = Color.Black;

        }
 
        private void karaoke()
        {
            // Create a karaoke stream
            int karaoke = Bass.BASS_StreamCreateFile(_musicFile, 0, 0, BASSFlag.BASS_DEFAULT);
            if (karaoke == 0)
            {
                // Handle error if stream creation fails
                throw new Exception("Unable to create karaoke stream.");
            }
            int mixerHandle = BassMix.BASS_Mixer_StreamCreate(44100, 2, BASSFlag.BASS_MIXER_NONSTOP);
            if (mixerHandle == 0)
            {
                // Handle error if mixer creation fails
                throw new Exception("Unable to create mixer.");
            }

            // Apply karaoke effect by removing center channel (vocals)
            Bass.BASS_ChannelSetAttribute(karaoke, BASSAttribute.BASS_ATTRIB_PAN, -1); // Set panning to left channel
            
            // Add the stereo stream and karaoke stream to the mixer
            BassMix.BASS_Mixer_StreamAddChannel(mixerHandle, _stream, BASSFlag.BASS_MIXER_DOWNMIX);
            BassMix.BASS_Mixer_StreamAddChannel(mixerHandle, karaoke, BASSFlag.BASS_MIXER_DOWNMIX);
            
            BassMix.BASS_Mixer_ChannelPlay(mixerHandle);           
        }
        public void karaoke2()
        {
            // Process the stream
            while (Bass.BASS_ChannelIsActive(_stream) == BASSActive.BASS_ACTIVE_PLAYING)
            {
                // Read audio data into buffer
                int bytesRead = Bass.BASS_ChannelGetData(_stream, buffer, bufferSize);
                if (bytesRead == -1)
                {
                    // Handle error
                    break;
                }

                // Invert phase of right channel (assuming stereo)
                for (int i = 0; i < bytesRead; i += 4)
                {
                    buffer[i + 2] = (byte)(255 - buffer[i + 2]);
                }

                // Output the modified buffer
                Bass.BASS_StreamPutData(_stream, buffer, bytesRead);
            }
        }
        private void peakEqValues()
        {
            _volumeEq = Convert.ToInt32(trackBarGain.Value);
            _freqEq = Convert.ToInt32(trackBarFreq.Value);
            labelFreq.Text = "Frequency : " + _freqEq.ToString() + " Hz       ";
            labelGain.Text = "Gain :  " + _volumeEq.ToString() + " db            ";
        }
        private void peakEQ()
        {
            peakEqValues();
            BASS_BFX_PEAKEQ pa = new BASS_BFX_PEAKEQ();
            //pa.fBandwidth = 8f; // 0.5; 1; 2; 3; 4; abre a gama de frequencias
            pa.fCenter = _freqEq;   // esta variaveis vem do trackbarFrq
            pa.fGain = _volumeEq;            
            Bass.BASS_FXSetParameters(_streamEQ, pa);
        }
        private void checkBoxEq_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEqOn.Checked) // se nao está seleccionado
            {
                checkBoxEqOn.ForeColor = Color.Red;                    
                checkBoxEqOn.Text = "Equalizer ON";
                _volumeEq = Convert.ToInt32(trackBarGain.Value);
                // Remover o efeito do _stream for EQ
                _streamEQ = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_PEAKEQ, 0);
                peakEQ();
            }
            else
            {
                checkBoxEqOn.ForeColor = Color.Black;
                checkBoxEqOn.Text = "Equalizer OFF";
                Bass.BASS_ChannelRemoveFX(_stream, _streamEQ);
            }
        }
        public void trackBarSpeed_Scroll(object sender, EventArgs e)
        {                        
            if (trackBarSpeed.Value >= -50 && trackBarSpeed.Value<=50)
            {                          
                _speed = trackBarSpeed.Value;
                if (_speed != 0)
                {
                    labelSpeed.ForeColor = Color.Red;
                    labelSpeed.Text="Speed: "+_speed.ToString();
                }
                else
                {
                    labelSpeed.ForeColor = Color.Black;
                    labelSpeed.Text = "Speed: " + _speed.ToString();
                    //labelSpeed.Text = trackBarSpeed.Value.ToString();
                }
                
                
                Bass.BASS_ChannelSetAttribute(_streamSpeed, BASSAttribute.BASS_ATTRIB_TEMPO, _speed);
            }            
        }           
       public void buttonOpenFile_Click(object sender, EventArgs e)        
        {            
                Bass.BASS_ChannelPause(_streamSpeed);
                buttonPlay.Text = "Play4";
                resetAllLabels();                
                _isPlaying= false;
                _musicFile = myFuntions.openFileTz();
                _stream = Bass.BASS_StreamCreateFile(_musicFile, 0L, 0L, BASSFlag.BASS_STREAM_DECODE);        
                //Stream for PITCHSHIFT
                _streamPitch = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_PITCHSHIFT, 0);
                //Stream for MONO STEREO
                _streamMono = Bass.BASS_ChannelSetFX(_stream, BASSFXType.BASS_FX_BFX_MIX, 0);
                //Stream for TEMPO, usamos este stream por cause do pitch
                _streamSpeed = BassFx.BASS_FX_TempoCreate(_stream, BASSFlag.BASS_FX_FREESOURCE);
        }           
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (!_isPlaying)
            {                
                timer1.Start();                  
                _isPlaying = true;
                buttonPlay.Text = "Pause1";                
                Bass.BASS_ChannelPlay(_streamSpeed, false);
            }
            else
            {
                Bass.BASS_ChannelPause(_streamSpeed);
                timer1.Stop();
                _isPlaying= false;
                buttonPlay.Text = "Play1";
            }                                      
        }
        private void buttonStop_Click(object sender, EventArgs e)
        {
            // Liberta a musica do stream
            _isPlaying = false;
            buttonPlay.Text = "Play2";
            Bass.BASS_ChannelSetPosition(_streamSpeed, 0);     //Faz reset para incio do Stream                                                       
            //Bass.BASS_ChannelPause(_streamSpeed);
            Bass.BASS_ChannelStop(_streamSpeed);           
            
            trackBarPosition.Value = 0;
            timer1.Stop();            
        }
       
        private void pitchShift(int _pitch)        
        {            
                //_pitchArrayValue = _pitchArrayIndex[trackBarTranspose.Value];
                BASS_BFX_PITCHSHIFT parametros = new BASS_BFX_PITCHSHIFT();
                Bass.BASS_FXGetParameters(_streamPitch, parametros);
                parametros.fPitchShift = _pitchArrayValue;  //Só funciona sendo float sem nenhum valor (pra nao ter prioridade fSemitone)
                parametros.fSemitones = _pitch;           //(0 won't change the pitch). Default = 0.)
                Bass.BASS_FXSetParameters(_streamPitch, parametros);          
        }       
 
        private void trackBarTransp2_Scroll(object sender, EventArgs e)
        {            
            _trackBarPitch = trackBarTranspose.Value; // define o valor o pitch        
            if(_trackBarPitch == 0)
            {
                Bass.BASS_FXReset(_streamPitch);
                labelTranspose.Text = "Transpose: " + trackBarTranspose.Value.ToString();
                labelTranspose.ForeColor = Color.Black;                
            }
            else
            {               
                labelTranspose.Text = "Transpose: " + trackBarTranspose.Value.ToString();
                labelTranspose.ForeColor = Color.Red;
            }            
            //myFuntions.pitchShift(_trackBarPitch, _pitchArrayValue, _streamPitch);                        
            pitchShift(_trackBarPitch);            
        }

        private void checkBoxLeft_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLeft.Checked)
            {                
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN1);                
                Bass.BASS_FXSetParameters(_streamMono, swap);
                labelBalance.ForeColor = Color.Red;                
                checkBoxLeft.BackColor = Color.Red;
                checkBoxCenter.Checked = false;
                checkBoxRight.Checked = false;  
                checkBoxRight.Enabled = false; // desligar para voltar sempre ao centro
            }
        }

        private void checkBoxRight_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRight.Checked)
            {                
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN2, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(_streamMono, swap);
                labelBalance.ForeColor= Color.Red;
                checkBoxRight.BackColor = Color.Red;
                checkBoxCenter.Checked = false;
                checkBoxLeft.Checked = false;
                checkBoxLeft.Enabled = false;
            }
        }

        private void checkBoxCenter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCenter.Checked)
            {
                BASS_BFX_MIX swap = new BASS_BFX_MIX(BASSFXChan.BASS_BFX_CHAN1, BASSFXChan.BASS_BFX_CHAN2);
                Bass.BASS_FXSetParameters(_streamMono, swap);
                labelBalance.ForeColor = Color.Black;
                checkBoxRight.BackColor = Color.White;
                checkBoxLeft.BackColor = Color.White;
                checkBoxLeft.Checked = false;
                checkBoxRight.Checked = false;
                checkBoxLeft.Enabled=true;
                checkBoxRight.Enabled = true;
            }            
        }

        private void trackBarPosition_Scroll(object sender, EventArgs e)
        {
            // Change the position of the stream based on the trackbar value
            if (_stream != 0)
            {
                long length = Bass.BASS_ChannelGetLength(_stream, BASSMode.BASS_POS_BYTES);
                long newPosition = (long)((double)trackBarPosition.Value / trackBarPosition.Maximum * length);
                Bass.BASS_ChannelSetPosition(_stream, newPosition, BASSMode.BASS_POS_BYTES);
            }
        }

        private void trackBarVolume_Scroll(object sender, EventArgs e)
        {
            _volume = (float)trackBarVolume.Value / trackBarVolume.Maximum;
            //_volume=trackBarVolume.Value;
            Bass.BASS_ChannelSetAttribute(_stream,BASSAttribute.BASS_ATTRIB_VOL, _volume);
            Bass.BASS_SetVolume(_volume);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about ab = new about();
            ab.ShowDialog();
        }

        private void panelPlayer_Paint(object sender, PaintEventArgs e) //Painel do menu Player Pa
        {
            
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Update trackbar position based on the stream position
            if (_stream != 0)
            {
                long position = Bass.BASS_ChannelGetPosition(_stream, BASSMode.BASS_POS_BYTES);
                long length = Bass.BASS_ChannelGetLength(_stream, BASSMode.BASS_POS_BYTES);

                if (length > 0)
                {
                    double percentage = (double)position / length;
                    int trackbarValue = (int)(percentage * trackBarPosition.Maximum);
                    trackBarPosition.Value = trackbarValue;
                }
            }
        }

        private void karaokeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            karaoke2();
        }

        private void trackBarFreq_Scroll(object sender, EventArgs e)
        {
            peakEQ();
        }

        private void trackBarGain_Scroll(object sender, EventArgs e)
        {
            if (trackBarGain.Value != 0)
            {
                peakEQ();
                checkBoxEqOn.Checked = true;
            }
            
        }

        private void equalizerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            equalizer eq = new equalizer();
            eq.ShowDialog();
        }

        private void monoStereoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monoStereo mono = new monoStereo();
            mono.ShowDialog();
        }

        private void pitchShiftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pitchshift ps = new pitchshift();
            ps.ShowDialog();
        }

        private void speedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            speed sp = new speed();
            sp.ShowDialog();
        }        

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            FontDialog fd = new FontDialog(); 
            
            if(fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;                 
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog coler = new ColorDialog();
            coler.ShowDialog();
            richTextBox1.SelectionColor = coler.Color;                
        }

        private void acordesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] linhas = richTextBox1.Lines;

            for (int i = 0; i < linhas.Length; i++)
            {
                string frase = linhas[i];
                // Contar numero de espaços e letras na linha
                int letras = frase.Count(c => c != ' ');
                int espacos = frase.Count(c => c == ' ');

                if (espacos > letras)
                {
                    richTextBox1.Select(richTextBox1.GetFirstCharIndexFromLine(i), linhas[i].Length);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.SelectionFont = new Font(richTextBox1.Font, FontStyle.Bold);
                }

            }
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open file dialog to select a text file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files |*.txt;*.odt|All files (*.*)|*.*";
            openFileDialog.Title = "Select a Text File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Read the selected file and display its contents
                string filePath = openFileDialog.FileName;

                string fileContent = File.ReadAllText(filePath);
                richTextBox1.Text = fileContent;


            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "RichText File|*.rtf|Text files |*.txt|All files|*.*";
            saveFileDialog.Title = "Save File";

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = saveFileDialog.FileName;  

                if(Path.GetExtension(filepath).Equals("*.txt", StringComparison.OrdinalIgnoreCase))
                    {
                    File.WriteAllText(filepath, richTextBox1.Text);
                }
                else
                {
                    richTextBox1.SaveFile(filepath);
                }
            }

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
                {
                    // Free resources when closing the form
                    Bass.BASS_ChannelRemoveFX(_stream, _streamPitch);
                    Bass.BASS_StreamFree(_stream);
                    Bass.BASS_Free();
                }

        private void ajudasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playPauseStopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayPauseStop pps = new PlayPauseStop();    
            pps.ShowDialog();
        }

        private void highPassEqToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Eq_HighPass eq_High = new Eq_HighPass();
            eq_High.ShowDialog();

        }
    }
}
