using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Player : Entity
    {
        public Player(string i_name, string i_title, string i_race, string i_gender, string i_desc, int i_str, int i_end, int i_tch, int i_mstr, int i_mend, int i_log, int i_lor, int i_cun, int i_cha, int i_grth)
            : base ( i_name,  i_title, i_race, i_gender,  i_desc,  i_str,  i_end,  i_tch,  i_mstr,  i_mend,  i_log,  i_lor, i_cun, i_cha, i_grth)
        {
        }
        /*player looks at a named object.  This can be a item or entity or even oneself*/
        public string Examine(Named_object look_at)
        {
            string object_description = look_at.getdesc();
            return object_description;
        }
        public string talk(Npc buddy)
        {
            if (buddy != null)
                return buddy.grabDialogue("talk");
            else
                return "No one is here.\n";
        }
    }
}
