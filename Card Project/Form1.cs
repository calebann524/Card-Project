using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
namespace Card_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //This is my Toolkit
            Graphics g = this.CreateGraphics();
            SolidBrush WordBrush = new SolidBrush(Color.White);
            Font WordFont = new Font("Courier New", 100, FontStyle.Bold);
           
            //Opening Screen
            g.Clear(Color.Black);
           
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //more tools
            Graphics g = this.CreateGraphics();
            SolidBrush WordBrush = new SolidBrush(Color.Red);
            Font WordFont = new Font("Courier New", 100, FontStyle.Bold);
            SolidBrush CreepyBrush = new SolidBrush(Color.Red);
            Font CreepyFont = new Font("Courier New", 20, FontStyle.Italic);
            SoundPlayer JigsawEntrance = new SoundPlayer(Properties.Resources.Creepy_Entrance);
            
           
            //Opening Screen

            //frame one
            g.DrawString("Happy", WordFont, WordBrush, 100, 100);
            Thread.Sleep(1000);

            //frame two
            g.Clear(Color.Black);
            g.DrawString("Birthday", WordFont, WordBrush, 100, 100);
            Thread.Sleep(2000);

            //frame three
            g.Clear(Color.Black);
            g.DrawString("Hope you like your games. . .", CreepyFont, CreepyBrush, 200, 100);
            Thread.Sleep(2000);
            
            //Frame four
            g.Clear(Color.Black);
            g.DrawString("Because I certainly will. . .", CreepyFont, CreepyBrush, 200, 100);
            Thread.Sleep(2000);

            //frame fight
            JigsawEntrance.Play();
            g.Clear(Color.Black);
            g.DrawImage(Properties.Resources.Jigsaw, 0, 0, 400, 700);
        }
    }
}
