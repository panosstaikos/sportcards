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

namespace matchinggame
{
    public partial class finalform : Form
    {
        //variables
        int usertries;
        string name;
        public finalform( string rtb,int tries) 
        {
            InitializeComponent();
            richTextBox1.Text = rtb;
            name = rtb; 
            usertries = tries;
            
        }

        

        private void finalform_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sort
            int counter = 0;
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(@"scoresfile.txt");
            List<string> list = new List<string>();
            while ((line = file.ReadLine()) != null)
            {
                listBox1.Items.Add(line);
                list.Add(string.Intern(line));
                counter++;
            }
            string[] arr = list.ToArray();
            Array.Sort(arr);

            foreach (string item in arr)
            {

                listBox2.Items.Add(item);

            }

            List<string> lt = new List<string>();
            string str = null;
            foreach (var item in listBox2.Items)
            {

                lt.Add(item.ToString()); 
                str += item + "\r\n";    
            }
            MessageBox.Show(lt[1] + "\n" + lt[2] + "\n" + lt[3] + "\n" + lt[4] + "\n" + lt[5] + "\n" + lt[6] + "\n" + lt[7] + "\n" + lt[8] + "\n" +lt[9] + "\n" +lt[10]);





        }


        private void button2_Click(object sender, EventArgs e)
        {
            //yes button (play again)
            Welcomepage wform = new Welcomepage();
            wform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //close button (no)
            this.Close();
        }
    }

   
}
