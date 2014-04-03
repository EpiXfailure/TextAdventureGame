using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Entity : Named_object
    {
        private int str;
        private int end;
        private int tch;
        private int mstr;
        private int mend;
        private int log;
        private int lor;
        private int cun;
        private int cha;
        private int grth;
        private string title;
        private string race;
        private string gender;
        public Entity (string i_name, string i_title, string i_race, string i_gender, string i_desc, int i_str, int i_end, int i_tch, int i_mstr, int i_mend, int i_log, int i_lor, int i_cun, int i_cha, int i_grth) : base(i_name, i_desc)
        {
            gender = i_gender;
            title = i_title;
            str = i_str;
            end = i_end;
            tch = i_tch;
            mstr = i_mstr;
            mend = i_mend;
            log = i_log;
            lor = i_lor;
            cun = i_cun;
            cha = i_cha;
            grth = i_grth;
            race = i_race;
        }
        /*returns value of requested stat*/
        public int get_stat(string stat)
        {
            if (stat == "str")
                return str;
            else if (stat == "end")
                return end;
            else if (stat == "tch")
                return tch;
            else if (stat == "mstr")
                return mstr;
            else if (stat == "mend")
                return mend;
            else if (stat == "log")
                return log;
            else if (stat == "lor")
                return lor;
            else if (stat == "cun")
                return cun;
            else if (stat == "cha")
                return cha;
            else if (stat == "grth")
                return grth;
            else
                return 0;
        }
        /*returns entity title*/
        public string get_title()
        {
            return title;
        }
        public string get_gender()
        {
            return gender;
        }
        public string get_race()
        {
            return race;
        }
        /*moves entity to a new location*/
        /*Entity attacks*/
    }
}
