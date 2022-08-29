using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace GraphDesign2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            Pen pencil = new Pen(Color.Blue);
        }

     

        private void button2_Click_1(object sender, EventArgs e) // Background Color Change Program
        {
            DialogResult window;
            window = colorDialog1.ShowDialog();
            if (window == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                panel1.BackColor = Color.White;
            }
            
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //ComboBox text and label edits
        {                                   //Disables the unnecessary txtboxs and edits the labels
            if (comboBox1.Text == "Square")
            {
                textBox1.Enabled = true;
                label2.Text = "X";
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox6.Enabled = false;
            }
            if (comboBox1.Text == "Rectangle")
            {
                textBox1.Enabled = true;
                label2.Text = "X";
                textBox2.Enabled = true;
                label3.Text = "Y";
                textBox3.Enabled = false;
                textBox6.Enabled = false;
            }
            if (comboBox1.Text == "Parallelogram")
            {
                textBox1.Enabled = true;
                label2.Text = "bot";

                textBox2.Enabled = true;
                label2.Text = "h";

                textBox3.Enabled = true;
                label2.Text = "x";

                textBox6.Enabled = false;
            }
            if (comboBox1.Text == "Trapezoid")
            {
                textBox1.Enabled = true;
                label2.Text = "bot";
                textBox2.Enabled = true;
                label3.Text = "h";
                textBox3.Enabled = true;
                label4.Text = "Xl";
                textBox6.Enabled = true;
                label6.Text = "Xr";

            }
            if (comboBox1.Text == "Circle")
            {
                textBox1.Enabled = true;
                label2.Text = "r";
                textBox2.Enabled = false;
                label3.Text = "h"; 
                textBox3.Enabled = false;
                
                textBox6.Enabled = false;
                
            }
            if (comboBox1.Text == "Triangle")
            {
                textBox1.Enabled = true;
                label2.Text = "bot";
                textBox2.Enabled = true;
                label3.Text = "h";
                textBox3.Enabled = true;
                
                textBox4.Enabled = false;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) // Pen Color Change mypen
        {
            DialogResult window;
            window = colorDialog2.ShowDialog();
            if (window == DialogResult.OK)
            {
                Pen pencil = new Pen(colorDialog2.Color);

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)  //Create button
        {
            int x, y,h,r,bot;
            int xl, xr;
            float perimeter, area;
            


            if (comboBox1.Text == "Square") 
            {
                

                if (string.IsNullOrEmpty(textBox1.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    x = int.Parse(textBox1.Text);
                    Graphics s = this.CreateGraphics();
                    s.DrawRectangle(Pens.Blue, 400, 100, x, x);
                    area = x * x;
                    string a = Convert.ToString(area);
                    textBox4.Text = a; //Typing perimeter to textbox
                    perimeter = 4 * x;
                    string b = Convert.ToString(area); //Typing perimeter to textbox
                    textBox5.Text = b;
                }



            }
            if (comboBox1.Text == "Rectangle")
            {
               
                if (string.IsNullOrEmpty(textBox1.Text) == true | string.IsNullOrEmpty(textBox2.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    y = int.Parse(textBox2.Text);
                    x = int.Parse(textBox1.Text);
                    Graphics s = this.CreateGraphics();
                    s.DrawRectangle(Pens.Blue, 400, 100, y, x);
                    area = x * y;
                    string a = Convert.ToString(area);
                    textBox4.Text = a; //Typing perimeter to textbox
                    perimeter = 2 * x + 2 * y;
                    string b = Convert.ToString(perimeter); //Typing perimeter to textbox
                    textBox5.Text = b;
                }
            }
            if (comboBox1.Text == "Parallelogram")
            {
                
                if (string.IsNullOrEmpty(textBox1.Text) == true | string.IsNullOrEmpty(textBox2.Text) == true | string.IsNullOrEmpty(textBox3.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    //textbox encoding
                    bot = int.Parse(textBox1.Text);
                    h = int.Parse(textBox2.Text);
                    x = int.Parse(textBox3.Text);

                    //creating points
                    Point v1 = new Point(600, 600);
                    Point v2 = new Point(600 + bot, 600);
                    Point v3 = new Point(600 + x, 600 - h);
                    Point v4 = new Point(600 + bot + x, 600 - h);
                    //drawing the shape
                    Graphics trp = this.CreateGraphics();
                    trp.DrawLine(Pens.Blue, v1, v2);
                    trp.DrawLine(Pens.Blue, v2, v4);
                    trp.DrawLine(Pens.Blue, v3, v4);
                    trp.DrawLine(Pens.Blue, v3, v1);
                    //calculating area and perimeter
                    area = (bot * h);
                    float v1v2 = (float)((Math.Sqrt(Math.Pow(600 - (600 + bot), 2) + Math.Pow(600 - 600, 2)))); //bad coding example; better use to x1,y1 variables to determine points.               
                    float v2v3 = (float)((Math.Sqrt(Math.Pow(600 + bot - (600 + x), 2) + Math.Pow(600 - (600 - h), 2))));
                    float v3v4 = (float)((Math.Sqrt(Math.Pow((600 + x - (600 + bot + x)), 2) + Math.Pow(600 - h - (600 - h), 2))));
                    float v4v1 = (float)((Math.Sqrt(Math.Pow(600 - (600 + bot + x - 600), 2) + Math.Pow(600 - h - 600, 2)))); ;
                    perimeter = v1v2 + v2v3 + v3v4 + v4v1;
                    //sending values to the textbox
                    textBox4.Text = Convert.ToString(area);
                    textBox5.Text = Convert.ToString(perimeter);
                }
            }           
            if (comboBox1.Text == "Trapezoid")
            {
                
                if (string.IsNullOrEmpty(textBox1.Text) == true | string.IsNullOrEmpty(textBox2.Text) == true | string.IsNullOrEmpty(textBox3.Text) == true | string.IsNullOrEmpty(textBox6.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    //textbox encoding
                    bot = int.Parse(textBox1.Text);
                    h = int.Parse(textBox2.Text);
                    xl = int.Parse(textBox3.Text);
                    xr = int.Parse(textBox6.Text);
                    //creating points
                    Point v1 = new Point(600, 600);
                    Point v2 = new Point(600 + bot, 600);
                    Point v3 = new Point(600 + xl, 600 - h);
                    Point v4 = new Point(600 + bot - xr, 600 - h);
                    //drawing the shape
                    Graphics trp = this.CreateGraphics();
                    trp.DrawLine(Pens.Blue, v1, v2);
                    trp.DrawLine(Pens.Blue, v2, v4);
                    trp.DrawLine(Pens.Blue, v3, v4);
                    trp.DrawLine(Pens.Blue, v3, v1);
                    //calculating area and perimeter
                    area = ((bot + bot - xl - xr) * h) / 2;

                    float v1v2 = (float)((Math.Sqrt(Math.Pow(600 - 600 + bot, 2) + Math.Pow(600 - 600, 2)))); //bad coding example; better use to x1,y1 variables to determine points.               
                    float v2v3 = (float)((Math.Sqrt(Math.Pow(600 + bot - (600 + xl), 2) + Math.Pow(600 - 600 - 600 - h, 2))));
                    float v3v4 = (float)((Math.Sqrt(Math.Pow(600 + xl - (600 + bot - xr), 2) + Math.Pow(600 - h - (600 - h), 2))));
                    float v4v1 = (float)((Math.Sqrt(Math.Pow(600 - (600 + bot - xr - 600), 2) + Math.Pow(600 - h - 600, 2)))); ;
                    perimeter = v1v2 + v2v3 + v3v4 + v4v1;
                    //sending values to the textbox
                    textBox4.Text = Convert.ToString(area);
                    textBox5.Text = Convert.ToString(perimeter);
                }








            }
            if (comboBox1.Text == "Circle")
            {
                
                if (string.IsNullOrEmpty(textBox1.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    float pi = 3.14f;
                    r = int.Parse(textBox1.Text);
                    Graphics circ = this.CreateGraphics();
                    circ.DrawEllipse(Pens.Blue, 1000 - r, 500 - r, r + r, r + r);

                    perimeter = 2 * pi * r;
                    area = pi * r * r;

                    textBox4.Text = Convert.ToString(area);
                    textBox5.Text = Convert.ToString(perimeter);
                }
            }
            if (comboBox1.Text == "Triangle")
            {
                
                if (string.IsNullOrEmpty(textBox1.Text) == true | string.IsNullOrEmpty(textBox2.Text) == true)
                {
                    MessageBox.Show("Please enter a value");
                }
                else
                {
                    bot = int.Parse(textBox1.Text);
                    h = int.Parse(textBox2.Text);
                    Point v1 = new Point(500, 500);
                    Point v2 = new Point(500 + bot, 500);
                    Point v3 = new Point((bot / 2) + 500, 500 - h);
                    Graphics tri = this.CreateGraphics();
                    tri.DrawLine(Pens.Blue, v1, v2);
                    tri.DrawLine(Pens.Blue, v1, v3);
                    tri.DrawLine(Pens.Blue, v2, v3);

                    Point midofbot = new Point(500, (500 + bot) / 2);
                    // calculating the perimeter and area

                    area = (h + bot) / 2;

                    float v1v2len = (float)((Math.Sqrt(Math.Pow(500 - 500 + bot, 2) + Math.Pow(500 - 500, 2))));
                    float v2v3len = (float)((Math.Sqrt(Math.Pow(500 + bot - ((bot + 500) / 2), 2) + Math.Pow(500 - h, 2))));
                    float v1v3len = (float)((Math.Sqrt(Math.Pow(500 - bot + 500, 2) + Math.Pow(500 - h, 2))));
                    perimeter = v1v2len + v2v3len + v1v3len;

                    //sending values to the textbox
                    textBox4.Text = Convert.ToString(area);
                    textBox5.Text = Convert.ToString(perimeter);
                }


            }



        }
        // KEYPRESS REFERENCES
        // It makes txtboxes allow int only
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
                
                
                
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Paint(object sender, PaintEventArgs e) //Form Paint Event
        {
            
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        //KEYPRESS ENDS
    }
}
