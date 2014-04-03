using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Npc : Entity
    {
        private int talk_choices;
        private int story_choice;
        private int disposition;
        /*story position refers to the point at which the character is at this character's story*/
        private int story_position;
        public class range
        {
            private int beginning;
            private int ending;
            public range(int beg, int end)
            {
                beginning = beg;
                ending = end;
            }
            public int get_beginning()
            {
                return beginning;
            }
            public int get_ending()
            {
                return ending;
            }
            public void increase_range()
            {
                ending++;
            }
            public void set_begin(int start)
            {
                beginning = start;
                ending = start;
            }
        }
        private range talk_range;
        private range story_range;
        public Npc(string i_name, string i_title, string i_race, string i_gender, string i_desc, int i_str, int i_end, int i_tch, int i_mstr, int i_mend, int i_log, int i_lor, int i_cun, int i_cha, int i_grth)
            : base(i_name, i_title, i_race, i_gender, i_desc, i_str, i_end, i_tch, i_mstr, i_mend, i_log, i_lor, i_cun, i_cha, i_grth)
        {
            talk_choices = 0;
            story_choice = 0;
            story_position = 0;
            talk_range = new range(0, 0);
            story_range = new range(0, 0);
        }
        private List<string> dialogue = new List<string>();
        private Random generator = new Random();

        /*Dialogue related methods*/
        public void populate_dialogue()
        {
            string read_line;
            System.IO.StreamReader file = new System.IO.StreamReader(getname() + "dialogue.txt");
            while ((read_line = file.ReadLine()) != null)
            {
                if (read_line[0] == 't')
                {
                    dialogue.Add( read_line.Substring(6));
                    talk_range.increase_range();
                    talk_choices++;
                    story_range.set_begin(talk_choices);
                }
                else if (read_line[0] == 's')
                {
                    dialogue.Add( read_line.Substring(6));
                    story_range.increase_range();
                    story_choice++;
                }
            }
            file.Close();
        }
        public string grabDialogue(string type)
        {
            string said = "blah";
            int case_number;
            if (type == "talk")
            {
                case_number = 0;
            }
            else if (type == "story")
            {
                case_number = 1;
                said = dialogue[generator.Next(story_range.get_beginning(), story_range.get_ending())];
            }
            else
            {
                case_number = 2;
            }
            switch (case_number)
            {
                case 0: /*standard talking*/
                    said = dialogue[generator.Next(talk_range.get_beginning(), talk_range.get_ending())];
                    break;
                case 1: /*story case*/
                    said = dialogue[generator.Next(story_range.get_beginning(), story_range.get_ending())];
                    break;
                default:
                    break;
            }
            
            return said;
        }
        /*DialogueMethods end*/
    }
}
