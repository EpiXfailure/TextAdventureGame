using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAdventure
{
    public partial class Form1 : Form
    {
        public Player player1;
        public Npc Faraday;
        public Room testroom;
        public Room otherroom;
        public Form1()
        {
            InitializeComponent();
            Faraday = new Npc("Faraday", "Fairy Machinist", "Elf", "Female", "Faraday is a fairy with a lot of energy",
                                2, 2, 8, 7, 7, 8, 4, 8, 4, 4);
            testroom = new Room("Test Room", "A void white space for testing purposes.", "safe");
            otherroom = new Room("Other Room", "A second room to test moving", "safe");
            testroom.addperson(Faraday);
            Faraday.populate_dialogue();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            New_character creation = new New_character();
            creation.frm1 = this;
            creation.ShowDialog();
            if (player1 != null)
            {
                Hero_stats.Items.Add("Name: " + player1.getname());
                Hero_stats.Items.Add("Race: " + player1.get_race());
                Hero_stats.Items.Add("Strength: " + player1.get_stat("str").ToString());
                Hero_stats.Items.Add("Endurance: " + player1.get_stat("end").ToString());
                Hero_stats.Items.Add("Finnese: " + player1.get_stat("tch").ToString());
                Hero_stats.Items.Add("Mstrength: " + player1.get_stat("mstr").ToString());
                Hero_stats.Items.Add("Mendurance: " + player1.get_stat("mend").ToString());
                Hero_stats.Items.Add("Logic: " + player1.get_stat("log").ToString());
                Hero_stats.Items.Add("Lore: " + player1.get_stat("lor").ToString());
                Hero_stats.Items.Add("Cunning: " + player1.get_stat("cun").ToString());
                Hero_stats.Items.Add("Charisma: " + player1.get_stat("cha").ToString());
                Hero_stats.Items.Add("Growth: " + player1.get_stat("grth").ToString());
                testroom.addperson(player1);
            }
        }

        private void talk_Click(object sender, EventArgs e)
        {
            Dialogue.AppendText(player1.talk(Faraday) + "\n");
        }

        private void Examine_Click(object sender, EventArgs e)
        {
            Dialogue.AppendText(player1.Examine(Faraday) + "\n");
        }

    }
}
