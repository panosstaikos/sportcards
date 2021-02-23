using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matchinggame
{
    public partial class Form1 : Form
    {

        ctries tr = new ctries();
        finform ms = new finform();

       

        //variables
        Random Location1 = new Random();
        List<Point> newpoints = new List<Point>();
        PictureBox guess1;
        PictureBox guess2;
        public Form1(string rtbx)
        {
            
            InitializeComponent();
            label5.Text = rtbx;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load a file
            richTextBox2.LoadFile("scoresfile.txt", RichTextBoxStreamType.PlainText);

            //put the pictureboxes randomly
            foreach (PictureBox photo in Cardspanel.Controls)
            {
                photo.Enabled = true;
                newpoints.Add(photo.Location);
            }

            foreach(PictureBox photo in Cardspanel.Controls)
            {
                int next = Location1.Next(newpoints.Count);
                Point p = newpoints[next];
                photo.Location = p;
                newpoints.Remove(p);
            }

            timer1.Start();
            timer2.Start();
            //put images in pictureboxes
            pictureBox1.Image = Properties.Resources.football;
            pictureBox2.Image = Properties.Resources.football;
            pictureBox3.Image = Properties.Resources.basketball;
            pictureBox4.Image = Properties.Resources.basketball;
            pictureBox5.Image = Properties.Resources.rugby;
            pictureBox6.Image = Properties.Resources.rugby;
            pictureBox7.Image = Properties.Resources.tennis;
            pictureBox8.Image = Properties.Resources.tennis;
            pictureBox9.Image = Properties.Resources.baseball;
            pictureBox10.Image = Properties.Resources.baseball;
            pictureBox11.Image = Properties.Resources.volleyball;
            pictureBox12.Image = Properties.Resources.volleyball;
            pictureBox14.Image = Properties.Resources.golf;
            pictureBox15.Image = Properties.Resources.golf;
            pictureBox16.Image = Properties.Resources.billiard;
            pictureBox17.Image = Properties.Resources.billiard;           
   
            

            



            }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
            timer1.Stop();
            foreach (PictureBox photo in Cardspanel.Controls)
            {
                photo.Enabled = true;
                photo.Cursor = Cursors.Hand;
                photo.Image = Properties.Resources.questionmark2;
            }
        }
        
        private void timer2_Tick(object sender, EventArgs e)
        {
            //countingdown
            int secondtimer = Convert.ToInt32(label7.Text);
            secondtimer = secondtimer-1;
            label7.Text = Convert.ToString(secondtimer);
            if(secondtimer == 0)
            {
                timer2.Stop();
                timer4.Start();
                


            }
            
        }
        private void timer4_Tick(object sender, EventArgs e)
        {
            //counting the time 
            int count1 = Convert.ToInt32(label8.Text);
            count1 = count1 + 1;
            label8.Text = Convert.ToString(count1);
            if(countpic == 8)
            {
                timer4.Stop();
                //class
                tr.cntries(countries);
                
                
                //save the elements to the file and show the with a messagebox

                ms.message("You won "+ label5.Text + "\n" + "Your time is " +label8.Text + "\n" + "Your tries are " +  countries/2);
                if ((countries / 2) < 10)
                {
                    richTextBox2.Text = richTextBox2.Text + Environment.NewLine +"0"+countries/2 +" " + label5.Text;
                }
                else
                {
                    richTextBox2.Text = richTextBox2.Text + Environment.NewLine +countries/2 +" " + label5.Text;
                }
               
                richTextBox2.SaveFile("scoresfile.txt", RichTextBoxStreamType.PlainText);
                string rtb = richTextBox2.Text;
                
                //go to final form from form1
                finalform fform = new finalform(rtb,countries);
                fform.Show();
                this.Hide();
            }


        }
        //variables
        int countpic = 0;
        int countries = 0;

        //how the pictures turn
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.football;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox1;
            }
            else if(guess1 !=null && guess2 == null)
            {
                guess2 = pictureBox1;
            }
            if(guess1 != null && guess2 !=null)
            {
                if(guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    countpic = countpic + 1;
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.football;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox2;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox2;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    countpic = countpic + 1;
                }
                else
                {
                    timer3.Start(); 
                }
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.basketball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox3;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox3;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    countpic = countpic + 1;
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.basketball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox4;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox4;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox3.Enabled = false;
                    pictureBox4.Enabled = false;
                    countpic = countpic + 1;
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.rugby;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox5;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox5;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    countpic = countpic + 1;
                }
                else
                {
                    timer3.Start();
                }
                
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.rugby;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox6;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox6;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox5.Enabled = false;
                    pictureBox6.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }
               
            }
        }

        private void picturebox7_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.tennis;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox7;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox7;
            }
            if (guess1 != null && guess2!= null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox8_Click_1(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.tennis;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox8;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox8;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox7.Enabled = false;
                    pictureBox8.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.Image = Properties.Resources.baseball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox9;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox9;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.Image = Properties.Resources.baseball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox10;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox10;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox9.Enabled = false;
                    pictureBox10.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox11.Image = Properties.Resources.volleyball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox11;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox11;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.Image = Properties.Resources.volleyball;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox12;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox12;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox11.Enabled = false;
                    pictureBox12.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox14.Image = Properties.Resources.golf;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox14;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox14;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox14.Enabled = false;
                    pictureBox15.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.Image = Properties.Resources.golf;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox15;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox15;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox14.Enabled = false;
                    pictureBox15.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            pictureBox16.Image = Properties.Resources.billiard;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox16;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox16;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox16.Enabled = false;
                    pictureBox17.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            pictureBox17.Image = Properties.Resources.billiard;
            countries = countries + 1;
            if (guess1 == null)
            {
                guess1 = pictureBox17;
            }
            else if (guess1 != null && guess2 == null)
            {
                guess2 = pictureBox17;
            }
            if (guess1 != null && guess2 != null)
            {
                if (guess1.Tag == guess2.Tag)
                {
                    guess1 = null;
                    guess2 = null;
                    pictureBox16.Enabled = false;
                    pictureBox17.Enabled = false;
                    countpic = countpic + 1;

                }
                else
                {
                    timer3.Start();
                }

            }
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            //if the pictureboxes are different 
            guess1.Image = Properties.Resources.questionmark2;
            guess2.Image = Properties.Resources.questionmark2;
            guess1 = null;
            guess2 = null;
        }

        OpenFileDialog newfile = new OpenFileDialog();
        

      

        
    }
}
