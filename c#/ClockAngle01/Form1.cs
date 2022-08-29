using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;

// OĞUZHAN ATAŞ 210401056
// CLOCK ANGLE


namespace ClockAngle01
{
    public partial class Form1 : Form
    {
        //Timer for real time clock
        Timer t = new Timer();

        //Drawing values of the clock
        int WIDTH = 300, HEIGHT = 300, secHAND = 140, minHAND = 110, hrHAND = 80;


        //Speech Library Objects

        SpeechRecognitionEngine sre = new SpeechRecognitionEngine();
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();


        private void when_recognized(object sender, SpeechRecognizedEventArgs e) //ENCODING THE RECOGNIZITIONS
        {
            switch (e.Result.Text)
            {
                case "hello":
                    txtcontent.Text += "\nHello" + Environment.NewLine;
                        break;
                case "hour one":
                    txtcontent.Text += "\nHour 1" + Environment.NewLine;
                    textboxhour.Text = "1";
                    break;
                case "hour two":
                    txtcontent.Text += "\nHour 2" + Environment.NewLine;
                    textboxhour.Text = "2";
                    break;
                case "hour three":
                    txtcontent.Text += "\nHour 3" + Environment.NewLine;
                    textboxhour.Text = "3";
                    break;
                case "hour four":
                     txtcontent.Text += "\nHour 4" + Environment.NewLine;
                    textboxhour.Text = "4";
                    break;
                case "hour five":
                    txtcontent.Text += "\nHour 5" + Environment.NewLine;
                    textboxhour.Text = "5";
                    break;
                case "hour six":
                    txtcontent.Text += "\nHour 6" + Environment.NewLine;
                    textboxhour.Text = "6";
                    break;
                case "hour seven":
                    txtcontent.Text += "\nHour 7" + Environment.NewLine;
                    textboxhour.Text = "7";
                    break;
                case "hour eight":
                    txtcontent.Text += "\nHour 8" + Environment.NewLine;
                    textboxhour.Text = "8";
                    break;
                case "hour nine":
                    txtcontent.Text += "\nHour 9" + Environment.NewLine;
                    textboxhour.Text = "9";
                    break;
                case "hour ten":
                    txtcontent.Text += "\nHour 10" + Environment.NewLine;
                    textboxhour.Text = "10";
                    break;
                case "hour eleven":
                    txtcontent.Text += "\nHour 11" + Environment.NewLine;
                    textboxhour.Text = "11";
                    break;
                case "hour twelve":
                    txtcontent.Text += "\nHour 12" + Environment.NewLine;
                    textboxhour.Text = "12";
                    break;
                case "hour thirteen":
                    txtcontent.Text += "\nHour 13" + Environment.NewLine;
                    textboxhour.Text = "13";
                    break;
                case "hour fourteen":
                    txtcontent.Text += "\nHour 14" + Environment.NewLine;
                    textboxhour.Text = "14";
                    break;
                case "hour fifteen":
                    txtcontent.Text += "\nHour 15" + Environment.NewLine;
                    textboxhour.Text = "15";
                    break;
                case "hour sixteen":
                    txtcontent.Text += "\nHour 16" + Environment.NewLine;
                    textboxhour.Text = "16";
                    break;
                case "hour seventeen":
                    txtcontent.Text += "\nHour 17" + Environment.NewLine;
                    textboxhour.Text = "17";
                    break;
                case "hour eigtheen":
                    txtcontent.Text += "\nHour 18" + Environment.NewLine;
                    textboxhour.Text = "18";
                    break;
                case "hour nineteen":
                    txtcontent.Text += "\nHour 19" + Environment.NewLine;
                    textboxhour.Text = "19";
                    break;
                case "hour twenty":
                    txtcontent.Text += "\nHour 20" + Environment.NewLine;
                    textboxhour.Text = "20";
                    break;
                case "hour twenty one":
                    txtcontent.Text += "\nHour 21" + Environment.NewLine;
                    textboxhour.Text = "21";
                    break;
                case "hour twenty two":
                    txtcontent.Text += "\nHour 22" + Environment.NewLine;
                    textboxhour.Text = "22";
                    break;
                case "hour twenty three":
                    txtcontent.Text += "\nHour 23" + Environment.NewLine;
                    textboxhour.Text = "23";
                    break;
                case "minute one":
                    txtcontent.Text += "\nMinute 1" + Environment.NewLine;
                    textboxmin.Text = "1";
                    break;
                case "minute two":
                    txtcontent.Text += "\nMinute 2" + Environment.NewLine;
                    textboxmin.Text = "2";
                    break;
                case "minute three":
                    txtcontent.Text += "\nMinute 3" + Environment.NewLine;
                    textboxmin.Text = "3";
                    break;
                case "minute four":
                    txtcontent.Text += "\nMinute 4" + Environment.NewLine;
                    textboxmin.Text = "4";
                    break;
                case "minute five":
                    txtcontent.Text += "\nMinute 5" + Environment.NewLine;
                    textboxmin.Text = "5";
                    break;
                case "minute six":
                    txtcontent.Text += "\nMinute 6" + Environment.NewLine;
                    textboxmin.Text = "6";
                    break;
                case "minute seven":
                    txtcontent.Text += "\nMinute 7" + Environment.NewLine;
                    textboxmin.Text = "7";
                    break;
                case "minute eight":
                    txtcontent.Text += "\nMinute 8" + Environment.NewLine;
                    textboxmin.Text = "8";
                    break;
                case "minute nine":
                    txtcontent.Text += "\nMinute 9" + Environment.NewLine;
                    textboxmin.Text = "9";
                    break;
                case "minute ten":
                    txtcontent.Text += "\nMinute 10" + Environment.NewLine;
                    textboxmin.Text = "10";
                    break;
                case "minute eleven":
                    txtcontent.Text += "\nMinute 11" + Environment.NewLine;
                    textboxmin.Text = "11";
                    break;
                case "minute twelve":
                    txtcontent.Text += "\nMinute 12" + Environment.NewLine;
                    textboxmin.Text = "12";
                    break;
                case "minute thirteen":
                    txtcontent.Text += "\nMinute 13" + Environment.NewLine;
                    textboxmin.Text = "13";
                    break;
                case "minute fourteen":
                    txtcontent.Text += "\nMinute 14" + Environment.NewLine;
                    textboxmin.Text = "14";
                    break;
                case "minute fifteen":
                    txtcontent.Text += "\nMinute 15" + Environment.NewLine;
                    textboxmin.Text = "15";
                    break;
                case "minute sixteen":
                    txtcontent.Text += "\nMinute 16" + Environment.NewLine;
                    textboxmin.Text = "16";
                    break;
                case "minute seventeen":
                    txtcontent.Text += "\nMinute 17" + Environment.NewLine;
                    textboxmin.Text = "17";
                    break;
                case "minute eighteen":
                    txtcontent.Text += "\nMinute 18" + Environment.NewLine;
                    textboxmin.Text = "18";
                    break;
                case "minute nineteen":
                    txtcontent.Text += "\nMinute 19" + Environment.NewLine;
                    textboxmin.Text = "19";
                    break;
                case "minute twenty":
                    txtcontent.Text += "\nMinute 20" + Environment.NewLine;
                    textboxmin.Text = "20";
                    break;
                case "minute twenty one":
                    txtcontent.Text += "\nMinute 21" + Environment.NewLine;
                    textboxmin.Text = "21";
                    break;
                case "minute twenty two":
                    txtcontent.Text += "\nMinute 22" + Environment.NewLine;
                    textboxmin.Text = "22";
                    break;
                case "minute twenty three":
                    txtcontent.Text += "\nMinute 23" + Environment.NewLine;
                    textboxmin.Text = "23";
                    break;
                case "minute twenty four":
                    txtcontent.Text += "\nMinute 24" + Environment.NewLine;
                    textboxmin.Text = "24";
                    break;
                case "minute twenty five":
                    txtcontent.Text += "\nMinute 25" + Environment.NewLine;
                    textboxmin.Text = "25";
                    break;
                case "minute twenty six":
                    txtcontent.Text += "\nMinute 26" + Environment.NewLine;
                    textboxmin.Text = "26";
                    break;
                case "minute twenty seven":
                    txtcontent.Text += "\nMinute 27" + Environment.NewLine;
                    textboxmin.Text = "27";
                    break;
                case "minute twenty eight":
                    txtcontent.Text += "\nMinute 28" + Environment.NewLine;
                    textboxmin.Text = "28";
                    break;
                case "minute twenty nine":
                    txtcontent.Text += "\nMinute 29" + Environment.NewLine;
                    textboxmin.Text = "29";
                    break;
                case "minute thirty":
                    txtcontent.Text += "\nMinute 30" + Environment.NewLine;
                    textboxmin.Text = "30";
                    break;
                case "minute thirty one":
                    txtcontent.Text += "\nMinute 31" + Environment.NewLine;
                    textboxmin.Text = "31";
                    break;
                case "minute thirty two":
                    txtcontent.Text += "\nMinute 32" + Environment.NewLine;
                    textboxmin.Text = "32";
                    break;
                case "minute thirty three":
                    txtcontent.Text += "\nMinute 33" + Environment.NewLine;
                    textboxmin.Text = "33";
                    break;
                case "minute thirty four":
                    txtcontent.Text += "\nMinute 34" + Environment.NewLine;
                    textboxmin.Text = "34";
                    break;
                case "minute thirty five":
                    txtcontent.Text += "\nMinute 35" + Environment.NewLine;
                    textboxmin.Text = "35";
                    break;
                case "minute thirty six":
                    txtcontent.Text += "\nMinute 36" + Environment.NewLine;
                    textboxmin.Text = "36";
                    break;
                case "minute thirty seven":
                    txtcontent.Text += "\nMinute 37" + Environment.NewLine;
                    textboxmin.Text = "37";
                    break;
                case "minute thirty eight":
                    txtcontent.Text += "\nMinute 38" + Environment.NewLine;
                    textboxmin.Text = "38";
                    break;
                case "minute thirty nine":
                    txtcontent.Text += "\nMinute 39" + Environment.NewLine;
                    textboxmin.Text = "39";
                    break;
                case "minute forty":
                    txtcontent.Text += "\nMinute 40" + Environment.NewLine;
                    textboxmin.Text = "40";
                    break;
                case "minute forty one":
                    txtcontent.Text += "\nMinute 41" + Environment.NewLine;
                    textboxmin.Text = "41";
                    break;
                case "minute forty two":
                    txtcontent.Text += "\nMinute 42" + Environment.NewLine;
                    textboxmin.Text = "42";
                    break;
                case "minute forty three":
                    txtcontent.Text += "\nMinute 43" + Environment.NewLine;
                    textboxmin.Text = "43";
                    break;
                case "minute forty four":
                    txtcontent.Text += "\nMinute 44" + Environment.NewLine;
                    textboxmin.Text = "44";
                    break;
                case "minute forty five":
                    txtcontent.Text += "\nMinute 45" + Environment.NewLine;
                    textboxmin.Text = "45";
                    break;
                case "minute forty six":
                    txtcontent.Text += "\nMinute 46" + Environment.NewLine;
                    textboxmin.Text = "46";
                    break;
                case "minute forty seven":
                    txtcontent.Text += "\nMinute 47" + Environment.NewLine;
                    textboxmin.Text = "47";
                    break;
                case "minute forty eight":
                    txtcontent.Text += "\nMinute 48" + Environment.NewLine;
                    textboxmin.Text = "48";
                    break;
                case "minute forty nine":
                    txtcontent.Text += "\nMinute 49" + Environment.NewLine;
                    textboxmin.Text = "49";
                    break;
                case "minute fifty":
                    txtcontent.Text += "\nMinute 50" + Environment.NewLine;
                    textboxmin.Text = "50";
                    break;
                case "minute fifty one":
                    txtcontent.Text += "\nMinute 51" + Environment.NewLine;
                    textboxmin.Text = "51";
                    break;
                case "minute fifty two":
                    txtcontent.Text += "\nMinute 52" + Environment.NewLine;
                    textboxmin.Text = "52";
                    break;
                case "minute fifty three":
                    txtcontent.Text += "\nMinute 53" + Environment.NewLine;
                    textboxmin.Text = "53";
                    break;
                case "minute fifty four":
                    txtcontent.Text += "\nMinute 54" + Environment.NewLine;
                    textboxmin.Text = "54";
                    break;
                case "minute fifty five":
                    txtcontent.Text += "\nMinute 55" + Environment.NewLine;
                    textboxmin.Text = "55";
                    break;
                case "minute fifty six":
                    txtcontent.Text += "\nMinute 56" + Environment.NewLine;
                    textboxmin.Text = "56";
                    break;
                case "minute fifty seven":
                    txtcontent.Text += "\nMinute 57" + Environment.NewLine;
                    textboxmin.Text = "57";
                    break;
                case "minute fifty eight":
                    txtcontent.Text += "\nMinute 58" + Environment.NewLine;
                    textboxmin.Text = "58";
                    break;
                case "minute fifty nine":
                    txtcontent.Text += "\nMinute 59" + Environment.NewLine;
                    textboxmin.Text = "59";
                    break;
                case "close the program":
                    txtcontent.Text += "\nGood byee" + Environment.NewLine;
                    Application.Exit();
                    break;
                case "i don't like you":
                    txtcontent.Text += "\n Then I quit";
                    Application.Exit();
                    break;
                case "use real time":
                    realtimecheckbox.Checked = true;
                    txtcontent.Text += "\n Switching the mode to real time." + Environment.NewLine;

                    break;
                case "use manual input":
                    realtimecheckbox.Checked = false;
                    txtcontent.Text += "\n Switching the mode to manual input." + Environment.NewLine;

                    break;
                case "random":
                    System.Random random = new Random();

                    int hhh = random.Next(23);
                    int mmm = random.Next(59);
                    int sss = random.Next(59);

                    textboxhour.Text = Convert.ToString(hhh);
                    textboxmin.Text = Convert.ToString(mmm);
                    textboxsec.Text = Convert.ToString(sss);
                    txtcontent.Text += "\n Random values typed succesfully." + Environment.NewLine;

                    break;
                case "update":
                    //create graphics
                    g = Graphics.FromImage(bmp);
                    txtcontent.Text += "\n Updated the clock succesfully."+Environment.NewLine;

                    // get time 
                    int ss = Convert.ToInt32(textboxsec.Text);
                    int mm = Convert.ToInt32(textboxmin.Text);
                    int hh = Convert.ToInt32(textboxhour.Text);
                    int hhc;
                    int mmc;
                    int[] handCoord = new int[2];

                    if (ss < 60 && mm < 60 && hh < 24)
                    {
                        // clear
                        g.Clear(Color.White);

                        //draw
                        g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                        //draw figure
                        g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                        g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                        g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                        g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                        //second hand
                        handCoord = msCoord(ss, secHAND);
                        g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                        //minute hand
                        handCoord = msCoord(mm, minHAND);
                        g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                        //hour hand

                        handCoord = hrCoord(hh % 12, mm, hrHAND);
                        g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                        //loading image
                        pictureBox1.Image = bmp;

                        //disp time
                        this.Text = "Clock Angle |  Custom Time - " + hh + ":" + mm + ":" + ss;

                        //dispose
                        g.Dispose();

                        //CALCULATING THE ANGLES
                        if (hh > 12 && hh <= 23)
                        {
                            hhc = hh - 12;
                        }
                        else
                        {
                            hhc = hh;
                        }

                        if (mm > 12 && mm <= 23)
                        {
                            mmc = mm - 12;
                        }
                        else
                        {
                            mmc = mm;
                        }


                        double angle1 = Math.Abs((-11 * mmc + 60 * hhc) / 2);
                        double angle2 = 360 - angle1;

                        //DISPLAYING ANGLES ON THE TEXTBOX

                        textBox7.Text = Convert.ToString(angle1);
                        textBox8.Text = Convert.ToString(angle2);

                    }
                    else
                    {
                        MessageBox.Show("Invalid input");
                    }

                    break;





            }
        }

        // center of the clock

        int cx, cy;

        Bitmap bmp;
        Graphics g;

        public Form1()
        {
            InitializeComponent();
        }

        private void realtimecheckbox_CheckedChanged(object sender, EventArgs e) // Closing the unnecesary txtboxes
        {
           if(realtimecheckbox.Checked)
            {
                textboxhour.Enabled = false;
                textboxmin.Enabled = false;
                textboxsec.Enabled = false;
                textboxhour.Clear();
                textboxmin.Clear();
                textboxsec.Clear(); 
                txtboxrealhour.Enabled = true;
                textboxrealmin.Enabled = true;
                textboxrealsec.Enabled = true;
                usevoicecheckbox.Enabled = false;
                updatebutton.Enabled = false;

            }
           else
            {
                textboxhour.Enabled = true;
                textboxmin.Enabled = true;
                textboxsec.Enabled = true;
                txtboxrealhour.Enabled = false;
                textboxrealmin.Enabled = false;
                textboxrealsec.Enabled = false;
                txtboxrealhour.Clear();
                textboxrealmin.Clear();
                textboxrealsec.Clear();
                usevoicecheckbox.Enabled = true;
                updatebutton.Enabled = true;
                this.Text = "Clock Angle |  ";
            }

        }

        private void realtimecheckbox_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void realtimecheckbox_CheckStateChanged(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = null;
           
            
        }
         //KEYPRESS EVENTS
         //PREVENTS ANY STRING INPUT
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void updatebutton_Click(object sender, EventArgs e) // Custom Hour Calculation
        {
            //create graphics
            g = Graphics.FromImage(bmp);

            // get time 
            int ss = Convert.ToInt32(textboxsec.Text);
            int mm = Convert.ToInt32(textboxmin.Text);
            int hh = Convert.ToInt32(textboxhour.Text);
            int hhc;
            int mmc;
            int[] handCoord = new int[2];

            if (ss < 60 && mm < 60 && hh < 24 )
            {
                // clear
                g.Clear(Color.White);

                //draw
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                //draw figure
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                //second hand
                handCoord = msCoord(ss, secHAND);
                g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //minute hand
                handCoord = msCoord(mm, minHAND);
                g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //hour hand

                handCoord = hrCoord(hh % 12, mm, hrHAND);
                g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //loading image
                pictureBox1.Image = bmp;

                //disp time
                this.Text = "Clock Angle |  Custom Time - " + hh + ":" + mm + ":" + ss;

                //dispose
                g.Dispose();

                //CALCULATING THE ANGLES
                if (hh > 12 && hh <= 23)
                {
                    hhc = hh - 12;
                }
                else
                {
                    hhc = hh;
                }

                if (mm > 12 && mm <= 23)
                {
                    mmc = mm - 12;
                }
                else
                {
                    mmc = mm;
                }


                double angle1 = Math.Abs((-11 * mmc + 60 * hhc) / 2);
                double angle2 = 360 - angle1;

                //DISPLAYING ANGLES ON THE TEXTBOX

                textBox7.Text = Convert.ToString(angle1);
                textBox8.Text = Convert.ToString(angle2);

            }
            else
            {
                MessageBox.Show("Invalid input");
            }
           

            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            sre.RecognizeAsync(RecognizeMode.Multiple);

            

            

            
        }

       

        private void btnStop_Click(object sender, EventArgs e)
        {
            sre.RecognizeAsyncStop();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Random random = new Random();

            int hh = random.Next(23);
            int mm = random.Next(59);
            int ss = random.Next(59);

            textboxhour.Text = Convert.ToString(hh);
            textboxmin.Text = Convert.ToString(mm);
            textboxsec.Text = Convert.ToString(ss);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // event log text newline

            txtcontent.Text +=Environment.NewLine;

            // creting the Bitmap

            bmp = new Bitmap(WIDTH + 1, HEIGHT + 1);

            //center

            cx = WIDTH / 2;
            cy = HEIGHT / 2;

            //backcolor 

            this.BackColor = Color.White;

            //timer

            t.Interval = 1000;   //ms
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            // VOICE RECOG

            Choices choi = new Choices(); // COMMAND DECLARATION
            choi.Add(new string[] { "hello", "hour one", "hour two", "hour three", "hour four", "hour five", "hour six", "hour seven", "hour eight", "hour nine", "hour ten", "hour eleven", "hour twelve", "hour thirteen", "hour fourteen", "hour fifteen" });
            choi.Add(new string[] {"hour sixteen", "hour seventeen", "hour eighteen", "hour nineteen", "hour twenty", "hour twenty one", "hour twenty two", "hour twenty three"});
            choi.Add(new string[] { "hello", "minute one", "minute two", "minute three", "minute four", "minute five", "minute six", "minute seven", "minute eight", "minute nine", "minute ten", "minute eleven", "minute twelve", "minute thirteen", "minute fourteen", "minute fifteen" });
            choi.Add(new string[] { "minute sixteen", "minute seventeen", "minute eighteen", "minute nineteen", "minute twenty", "minute twenty one", "minute twenty two", "minute twenty three" });
            choi.Add(new string[] { "minute twenty four", "minute twenty five ", "minute twenty six", "minute twenty seven", "minute twenty eight", "minute twenty nine" });
            choi.Add(new string[] { "minute thirty", "minute thirty one", "minute thirty two", "minute thirty three", "minute thirty four", "minute thirty five ", "minute thirty six", "minute thirty seven", "minute thirty eight", "minute thirty nine" });
            choi.Add(new string[] { "minute forty", "minute forty one", "minute forty two", "minute forty three", "minute forty four", "minute forty five ", "minute forty six", "minute forty seven", "minute forty eight", "minute forty nine" });
            choi.Add(new string[] { "minute fifty", "minute fifty one", "minute fifty two", "minute fifty three", "minute fifty four", "minute fifty five ", "minute fifty six", "minute fifty seven", "minute fifty eight", "minute fifty nine" });
            choi.Add(new string[] { "I don't like you","close the program","update","use real time", "use manual input","random"});






            GrammarBuilder gbuilder = new GrammarBuilder();
            gbuilder.Append(choi);
            Grammar grammar = new Grammar(gbuilder);
            sre.LoadGrammarAsync(grammar);
            sre.SetInputToDefaultAudioDevice();
            sre.SpeechRecognized += when_recognized;

        }

        private void t_Tick(object sender,EventArgs e) // REAL TIME CLOCK 
        {
            if (realtimecheckbox.Checked)
            {
               

                //create graphics
                g = Graphics.FromImage(bmp);

                // get time 
                int ss = DateTime.Now.Second;
                int mm = DateTime.Now.Minute;
                int hh = DateTime.Now.Hour;
                int hhc;
                int mmc;

                int[] handCoord = new int[2];

                // clear
                g.Clear(Color.White);

                //draw
                g.DrawEllipse(new Pen(Color.Black, 1f), 0, 0, WIDTH, HEIGHT);

                //draw figure
                g.DrawString("12", new Font("Arial", 12), Brushes.Black, new PointF(140, 2));
                g.DrawString("3", new Font("Arial", 12), Brushes.Black, new PointF(286, 140));
                g.DrawString("6", new Font("Arial", 12), Brushes.Black, new PointF(142, 282));
                g.DrawString("9", new Font("Arial", 12), Brushes.Black, new PointF(0, 140));

                //second hand
                handCoord = msCoord(ss, secHAND);
                g.DrawLine(new Pen(Color.Red, 1f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //minute hand
                handCoord = msCoord(mm, minHAND);
                g.DrawLine(new Pen(Color.Black, 2f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //hour hand

                handCoord = hrCoord(hh % 12, mm, hrHAND);
                g.DrawLine(new Pen(Color.Gray, 3f), new Point(cx, cy), new Point(handCoord[0], handCoord[1]));

                //loading image
                pictureBox1.Image = bmp;

                //disp time
                this.Text = "Clock Angle |  Current Time - " + hh + ":" + mm + ":" + ss;

                //dispose
                g.Dispose();

                //CALCULATING THE ANGLE
                    if(hh>12 && hh<=23)
                {
                    hhc = hh - 12;
                }
                    else
                {
                    hhc = hh;
                }

                if (mm > 12 && mm <= 23)
                {
                    mmc = mm - 12;
                }
                else
                {
                    mmc = mm;
                }

                
                double angle1 = Math.Abs((-11 * mmc + 60 * hhc) / 2);
                double angle2 = 360 - angle1;

                //DISPLAYING ANGLES AND ANGLES ON THE TEXTBOX

                textboxrealmin.Text = Convert.ToString(mm);
                txtboxrealhour.Text = Convert.ToString(hh);
                textboxrealsec.Text = Convert.ToString(ss);

                textBox7.Text = Convert.ToString(angle1);
                textBox8.Text = Convert.ToString(angle2);







            }
        }

            private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        //Coordinates of Minute and second Hand
        
        private int[] msCoord(int val, int hlen)
        {
            int[] coord = new int[2];
            val *= 6; // each minute and second make 6 degree

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));

            }
            else 
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));

            }
            return coord;

        }

        // coord for hour hand

        private int[] hrCoord(int hval, int mval, int hlen)
        {
            int[] coord = new int[2];

            //each hour makes 30 degree
            //each min makes 0.5 degree
            int val = (int)((hval * 30) + (mval * 0.5));

            if (val >= 0 && val <= 180)
            {
                coord[0] = cx + (int)(hlen * Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));

            }
            else
            {
                coord[0] = cx - (int)(hlen * -Math.Sin(Math.PI * val / 180));
                coord[1] = cy - (int)(hlen * Math.Cos(Math.PI * val / 180));

            }
            return coord;
        }


   

    }
}
