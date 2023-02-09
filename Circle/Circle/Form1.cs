using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.CodeDom;
using System.Reflection;
using System.Threading;

namespace Circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        majors mj = new majors();
        minors min = new minors();
        harmonicaminor hmin = new harmonicaminor();
        melodicaminor mmin = new melodicaminor();
        SoundPlayer player = new SoundPlayer();
        SoundPlayer player2 = new SoundPlayer();
        public string[] notes = new string[24];
        static string[] mod = new string[7];
        static string[] chordss = new string[7];
        public void Play()
        {
            try
            {
                player.SoundLocation = @"wav\" + Chords.SelectedItem + ".wav";
                player.Play();
            }
            catch (Exception)
            {
            }
        }
        public void picturebox()
        {
            Positions.BackgroundImageLayout = ImageLayout.Stretch;
            Positions.ImageLocation = @"chords\" + chordss[0] + ".png";
           
        }
        public void picturebox2()
        {
            Positions.BackgroundImageLayout = ImageLayout.Stretch;
            Positions.ImageLocation = @"harmonicminor\" + chordss[0] + ".png";
        }
        public void picturebox3()
        {
            Positions.BackgroundImageLayout = ImageLayout.Stretch;
            Positions.ImageLocation = @"melodicminor\" + chordss[0] + ".png";
        }
        public void aktarma()
        {
            Scales.Items.AddRange(mod);
        }
        public void aktarma2()
        {
            Chords.Items.AddRange(chordss);
        }
        public void potentialchord()
        {
            potenchord.Text = chordss[0]+"-"+ chordss[3]+"-"+chordss[4];
        }
        interface Ieklenti
        {
            
            string typee { get; set; }
            string stypee { get; set; }
           
        }
        abstract class chord
        {
            abstract public void available_chords();
        }
        class harmonicaminor:chord,Ieklenti
        {
            public string typee { get; set; }
            public string stypee { get; set; }
            public override void available_chords()
            { 
                typee = "maj";
                stypee = "m";
                chordss[0] = mod[0] + typee;
                chordss[1] = mod[1] + "m7b5";
                chordss[2] = mod[2] + "aug";
                chordss[3] = mod[3] + stypee;
                chordss[4] = mod[4] + typee;
                chordss[5] = mod[5] + typee;
                chordss[6] = mod[6] + typee;
            }
        }
        class melodicaminor : chord, Ieklenti
        {
            public string typee { get; set; }
            public string stypee { get; set; }
            public override void available_chords()
            {
                typee = "maj";
                stypee = "m";
                chordss[0] = mod[0] + typee;
                chordss[1] = mod[1] + "m7b5";
                chordss[2] = mod[2] + "aug";
                chordss[3] = mod[3] + stypee;
                chordss[4] = mod[4] + typee;
                chordss[5] = mod[5] + typee;
                chordss[6] = mod[6] + typee;
            }
        }
        class majors:chord,Ieklenti
        {
            public string typee { get; set; }
            public string stypee { get; set; }
            public override void available_chords()
            {
                typee = "maj";
                stypee = "m";
                chordss[0] = mod[0] + typee;
                chordss[1] = mod[1] + stypee;
                chordss[2] = mod[2] + stypee;
                chordss[3] = mod[3] + typee;
                chordss[4] = mod[4] + typee;
                chordss[5] = mod[5] + stypee;
                chordss[6] = mod[6] + "m7b5";
            }
        }
        class minors:chord,Ieklenti
        {
            public string typee { get; set; }
            public string stypee { get; set; }
            public override void available_chords()
            {
                typee = "m";
                stypee = "maj";
                chordss[0] = mod[0] + typee;
                chordss[1] = mod[1] + "m7b5";
                chordss[2] = mod[2] + stypee;
                chordss[3] = mod[3] + typee;
                chordss[4] = mod[4] + typee;
                chordss[5] = mod[5] + stypee;
                chordss[6] = mod[6] + stypee;
            }
        }    
        public void ekle()
        {
            int second = 0;
            for (int i = 0; i <= 11; i++)
            {
                notes[i] = listBox1.Items[i].ToString();
            }
            for (int s = 12; s <= 23; s++)
            {
                notes[s] = listBox1.Items[second].ToString();
                second++;
            }
        }
        public void notess()
        {
            notalar.Text = mod[0] + "-" + mod[2] + "-" + mod[4];
        }
        public void major()
        {
            mod[0] = notes[listBox1.SelectedIndex];
            mod[1] = notes[listBox1.SelectedIndex+2];
            mod[2] = notes[listBox1.SelectedIndex+4];
            mod[3] = notes[listBox1.SelectedIndex+5];
            mod[4] = notes[listBox1.SelectedIndex+7];
            mod[5] = notes[listBox1.SelectedIndex+9];
            mod[6] = notes[listBox1.SelectedIndex+11];
            aktarma();
        }
        public void minor()
        {
            mod[0] = notes[listBox1.SelectedIndex];
            mod[1] = notes[listBox1.SelectedIndex + 2];
            mod[2] = notes[listBox1.SelectedIndex + 3];
            mod[3] = notes[listBox1.SelectedIndex + 5];
            mod[4] = notes[listBox1.SelectedIndex + 7];
            mod[5] = notes[listBox1.SelectedIndex + 8];
            mod[6] = notes[listBox1.SelectedIndex + 10];
            aktarma();
        }
        public void harmonicminor()
        {
            mod[0] = notes[listBox1.SelectedIndex];
            mod[1] = notes[listBox1.SelectedIndex + 2];
            mod[2] = notes[listBox1.SelectedIndex + 3];
            mod[3] = notes[listBox1.SelectedIndex + 5];
            mod[4] = notes[listBox1.SelectedIndex + 7];
            mod[5] = notes[listBox1.SelectedIndex + 8];
            mod[6] = notes[listBox1.SelectedIndex + 11];
            aktarma();
        }
        public void melodicminor()
        {
            mod[0] = notes[listBox1.SelectedIndex];
            mod[1] = notes[listBox1.SelectedIndex + 2];
            mod[2] = notes[listBox1.SelectedIndex + 3];
            mod[3] = notes[listBox1.SelectedIndex + 5];
            mod[4] = notes[listBox1.SelectedIndex + 7];
            mod[5] = notes[listBox1.SelectedIndex + 9];
            mod[6] = notes[listBox1.SelectedIndex + 11];
            aktarma();
        }
        private void ShowBut_Click(object sender, EventArgs e)
        {
           Scales.Text = "";
            if (option.SelectedItem == "Major")
            {
                Chords.Items.Clear();
                Scales.Items.Clear();
                major();
                notess();
                mj.available_chords();
                aktarma2();
                picturebox();
                potentialchord();
            }
            else if(option.SelectedItem == "Minör")
            {
                Chords.Items.Clear();
                Scales.Items.Clear();
                minor();
                notess();
                min.available_chords();
                aktarma2();
                picturebox();
                potentialchord();
            }
            else if (option.SelectedItem == "Harmonic Minör")
            {
                Chords.Items.Clear();
                Scales.Items.Clear();
                harmonicminor();
                notess();
                hmin.available_chords();
                aktarma2();
                picturebox2();
                potentialchord();
            }
            else if (option.SelectedItem == "Melodic Minör")
            {
                Chords.Items.Clear();
                Scales.Items.Clear();
                melodicminor();
                notess();
                mmin.available_chords();
                aktarma2();
                picturebox3();
                potentialchord();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ekle();
            f1.SelectedItem = "Am";
            f2.SelectedItem = "G";
            f3.SelectedItem = "F";
            f4.SelectedItem = "E";
        }

        private void Chords_SelectedIndexChanged(object sender, EventArgs e)
        {
            Play();
        }
        int i = 1;
        public void Start_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Stop();
                timer1.Enabled = false;
                i = 1;
                Start.Text = "Start";
                Start.BackColor = Color.LightGreen;
            }
           else if (timer1.Enabled == false)
            {
                timer1.Start();
                timer1.Enabled = true;
                i = 1;
                Start.Text = "Pause";
                Start.BackColor = Color.Snow;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i == 1)
            {
                player2.SoundLocation = @"rythm\" + f1.SelectedItem + ".wav";
                player2.Play();
                i++;
            }
            else if (i == 2)
            {
                player2.SoundLocation = @"rythm\" + f2.SelectedItem + ".wav";
                player2.Play();
                i++;
            }
            else if (i == 3)
            {
                player2.SoundLocation = @"rythm\" + f3.SelectedItem + ".wav";
                player2.Play();
                i++;
            }
            else if (i == 4)
            {
                player2.SoundLocation = @"rythm\" + f4.SelectedItem + ".wav";
                player2.Play();
                i = 1;
            }
        }
    }
}
