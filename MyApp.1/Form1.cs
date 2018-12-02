using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace MyApp._1
{
   
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BackColor = Color.LightGray;
            

        }

        public static int prim( int n)
        {
            if (n < 2) return 0;
            if (n == 2) return 1;
            if (n % 2 == 0) return 0;
            for (int i = 3; i * i <= n; i += 3)
                if (n % i == 0) return 0;
            return 1;
                
        }
        private void button3_Click(object sender, EventArgs e)
        {   
            string str = textbox.Text;
            
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsNumber(str[i]))
                {
                    label5.Text = "Caracterul introdus nu este un numar. Introduceti un numar.";
                    textbox.Text = "";
                    BackColor = Color.Yellow;
                    return;
                }

            }
            try
            {
                int x = int.Parse(textbox.Text);
                if (prim(x) == 1)
                {
                    BackColor = Color.Red;
                    label5.Text = "Numărul este prim.";
                }
                else
                {
                    BackColor = Color.Green;
                    label5.Text = "Numărul nu este prim.";
                }
            }
            catch
            {
                label5.Text = "Otherflow.";
                BackColor = Color.Yellow;
            }
            finally
            { }

            
        }
        public bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (button4.Text == "Auto:off") return;
            button3.PerformClick();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Auto:on") button4.Text = "Auto:off";
            else
            button4.Text = "Auto:on";
        }

        

        private void textbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }
    }
}
