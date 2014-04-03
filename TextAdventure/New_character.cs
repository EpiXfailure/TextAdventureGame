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
    public partial class New_character : Form
    {
        private int[] char_stats;
        private int max_points = 53;
        private int set_points;
        public Form1 frm1;
        public New_character()
        {
            InitializeComponent();
            char_stats = new int[10] {5,5,5,5,5,5,5,5,5,5 };
            set_points = 50;
            free_points.Text = (max_points - set_points).ToString();
        }
        /* calc = 0 is for minus, 
        * calc = 1 is for plus 
        * calc = 2 is for submitting a character*/
        private bool valid(int calc)
        {

            if ((set_points == max_points && calc == 1) && (set_points > 0 ))
                return false;
            else
                return true;
        }
        private void strup_Click(object sender, EventArgs e)
        {
            if (char_stats[0] < 10 && valid(1))
            {
                char_stats[0]++;
                dis_str.Text = char_stats[0].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void dis_end_TextChanged(object sender, EventArgs e)
        {

        }
        private void min_str_Click(object sender, EventArgs e)
        {
            if (char_stats[0] > 0  && valid(0))
            {
                char_stats[0]--;
                dis_str.Text = char_stats[0].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void endup_Click(object sender, EventArgs e)
        {
            if (char_stats[1] < 10 && valid(1)){
                char_stats[1]++;
                dis_end.Text = char_stats[1].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_end_Click(object sender, EventArgs e)
        {
            if (char_stats[1] > 0  && valid(0))
            {
                char_stats[1]--;
                dis_end.Text = char_stats[1].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void finup_Click(object sender, EventArgs e)
        {
            if (char_stats[2] < 10 && valid(1))
            {
                char_stats[2]++;
                dis_fin.Text = char_stats[2].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_fin_Click(object sender, EventArgs e)
        {
            if (char_stats[2] > 0 && valid(0))
            {
                char_stats[2]--;
                dis_fin.Text = char_stats[2].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void mstrup_Click(object sender, EventArgs e)
        {
            if (char_stats[3] < 10 && valid(1))
            {
                char_stats[3]++;
                dis_mstr.Text = char_stats[3].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_mstr_Click(object sender, EventArgs e)
        {
            if (char_stats[3] > 0 && valid(0))
            {
                char_stats[3]--;
                dis_mstr.Text = char_stats[3].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void mendup_Click(object sender, EventArgs e)
        {
            if (char_stats[4] < 10 && valid(1))
            {
                char_stats[4]++;
                dis_mend.Text = char_stats[4].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_mend_Click(object sender, EventArgs e)
        {
            if (char_stats[4] > 0 && valid(0))
            {
                char_stats[4]--;
                dis_mend.Text = char_stats[4].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void logup_Click(object sender, EventArgs e)
        {
            if (char_stats[5] < 10 && valid(1))
            {
                char_stats[5]++;
                dis_log.Text = char_stats[5].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_log_Click(object sender, EventArgs e)
        {
            if (char_stats[5] > 0 && valid(0))
            {
                char_stats[5]--;
                dis_log.Text = char_stats[5].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void lorup_Click(object sender, EventArgs e)
        {
            if (char_stats[6] < 10 && valid(1))
            {
                char_stats[6]++;
                dis_lor.Text = char_stats[6].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_lor_Click(object sender, EventArgs e)
        {
            if (char_stats[6] > 0 && valid(0))
            {
                char_stats[6]--;
                dis_lor.Text = char_stats[6].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void cunup_Click(object sender, EventArgs e)
        {
            if (char_stats[7] < 10 && valid(1))
            {
                char_stats[7]++;
                dis_cun.Text = char_stats[7].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_cun_Click(object sender, EventArgs e)
        {
            if (char_stats[7] > 0 && valid(0))
            {
                char_stats[7]--;
                dis_cun.Text = char_stats[7].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void chaup_Click(object sender, EventArgs e)
        {
            if (char_stats[8] < 10 && valid(1))
            {
                char_stats[8]++;
                dis_cha.Text = char_stats[8].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_cha_Click(object sender, EventArgs e)
        {
            if (char_stats[8] > 0 && valid(0))
            {
                char_stats[8]--;
                dis_cha.Text = char_stats[8].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void grthup_Click(object sender, EventArgs e)
        {
            if (char_stats[9] < 10 && valid(1))
            {
                char_stats[9]++;
                dis_grth.Text = char_stats[9].ToString();
                set_points++;
                free_points.Text = (max_points - set_points).ToString();
            }
        }
        private void min_grth_Click(object sender, EventArgs e)
        {
            if (char_stats[9] > 0 && valid(0))
            {
                char_stats[9]--;
                dis_grth.Text = char_stats[9].ToString();
                set_points--;
                free_points.Text = (max_points - set_points).ToString();
            }
        }

        private void finish_Click(object sender, EventArgs e)
        {
            string gender = gender_select.Text;
            string race = race_select.Text;
            if (!valid(1) && gender != "" && race != "")
            {
                string newname = char_name.Text;
                if (newname == "")
                    newname = "No Name";
                frm1.player1 = new Player(newname, "Freshmeat", race, gender, ("A " + gender + " " + race + "."),
                                            char_stats[0], char_stats[1], char_stats[2], char_stats[3], char_stats[4], char_stats[5], char_stats[6], char_stats[7], char_stats[8], char_stats[9]);
                this.Close();
            }
        }
    }
}
