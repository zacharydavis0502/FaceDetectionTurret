using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Diagnostics;
using System.Media;
using System.IO;
using System.Threading;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace FaceDetectionCoronaTurret
{ 
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechSynthesizer cortana = new SpeechSynthesizer();

        public Stopwatch watch { get; set; }
        public Stopwatch pumpWatch { get; set; }
        
        //public SoundPlayer player = new SoundPlayer(@"C:\\Users\\Zach\\Desktop\\=sounds=\\sorry.wav"); 
        private Random random = new Random(); //For picking random noise
        private Stopwatch soundWatch = new Stopwatch();
        
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filter;
        VideoCaptureDevice device;

        private void Form1_Load(object sender, EventArgs e)
        {
            watch = Stopwatch.StartNew();
            pumpWatch = Stopwatch.StartNew();
            port.Open();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in filter)
                comboBox1.Items.Add(device.Name);
            comboBox1.SelectedIndex = 0;
            device = new VideoCaptureDevice();

            Choices cmd = new Choices();
            cmd.Add(new string[] { "turn on", "shutdown","stop listening", "sanatize", "hey"});
            GrammarBuilder builder = new GrammarBuilder();
            builder.Append(cmd);
            Grammar grammar = new Grammar(builder);
            sre.LoadGrammarAsync(grammar);
            sre.SetInputToDefaultAudioDevice();
            cortana.SetOutputToDefaultAudioDevice();
            sre.RecognizeAsync(RecognizeMode.Multiple);
            sre.SpeechRecognized += sre_SpeechRecognized;
            
        }

        void sre_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (voiceRecBox.Checked == true)
            {
                switch (e.Result.Text)
                {
                    case "turn on":

                        cortana.Speak("Powering on turret");

                        TurnOn();

                        //secondForm.Activate();
                        break;

                    case "shutdown":

                        cortana.Speak("Powering off turret");
                        //firstForm.Activate();
                        TurnOff();
                        //secondForm.Activate();
                        break;

                    case "stop listening":
                        cortana.Speak("Toggling voice commands");

                        turnOffVoiceRecog();
                        break;

                    case "sanatize":
                        pump();
                        break;

                    case "hey":
                        look();
                        break;
                }
            }
            else
                sre.RecognizeAsyncStop();
        }
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.2, 1);

            if (enableRecogBox.Checked == true)
            {
                foreach (Rectangle rectangle in rectangles)
                {

                    if (sendToPort.Checked == true)
                        WriteToPort(new Point(rectangle.X, rectangle.Y));

                    xPos.Invoke(new Action(() => xPos.Text = rectangle.X.ToString()));
                    yPos.Invoke(new Action(() => yPos.Text = rectangle.Y.ToString()));
                  


                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (Pen pen = new Pen(Color.Green, 3))
                        {
                            graphics.DrawRectangle(pen, rectangle);
                        }

                    }
            
                }

            }
            pic.Image = bitmap;
        }
  
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[comboBox1.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
        }

        public void WriteToPort(Point coordinates)
        {
            if (watch.ElapsedMilliseconds > 15)
            {
                watch = Stopwatch.StartNew();

                port.Write(String.Format("X{0}Y{1}",
                ((coordinates.X / (pic.Width / 78)) + 51),
                (coordinates.Y / (pic.Height / (78)) + 51)));

                outputBox.Invoke(new Action(() => outputBox.AppendText(String.Format("X{0}Y{1}\n",
                ((coordinates.X / (pic.Width / 78)) + 51),
                (coordinates.Y / (pic.Height / (78)) + 51)))));
                
            }
        }

        public void pump()
        {
            if (pumpWatch.ElapsedMilliseconds > 1500)
            {
                pumpWatch = Stopwatch.StartNew();
                port.Write("f");
                outputBox.AppendText("f\n");
            }
        }



        private void pumpBtn_Click(object sender, EventArgs e)
        {
            pump();
        }
        
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sendToPort.Checked == true)
                WriteToPort(new Point(e.X, e.Y));

            //if (mouseOverArea(pictureBox1) == false)
                //port.Write("r");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mouseOverArea(pictureBox1) & sendToPort.Checked == true )
            {
                pump();
            }
        }

        private bool mouseOverArea (PictureBox area)
        {
            if (area.ClientRectangle.Contains(area.PointToClient(Cursor.Position)))
            {
                return true;
            }
            return false;
        }

        private void TurnOn()
        {
            enableRecogBox.Checked = true;
            sendToPort.Checked = true;
        }
        private void TurnOff()
        {
            enableRecogBox.Checked = false;
            sendToPort.Checked = false;
        }
        private void turnOffVoiceRecog()
        {
            voiceRecBox.Checked = false;
        }

        
        private void sad()
        {
            port.Write("s");
            
            //player.Play();
        }
        
        private void look()
        {
            port.Write("l");
        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {
            outputBox.ScrollToCaret();
        }
    }

}
