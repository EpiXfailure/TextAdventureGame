using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Room : Named_object
    {
        private List<Entity> residence = new List<Entity>();
        private List<Room> other_places = new List<Room>();
        private int number_of_people = 0;
        private string room_state; /*Can either be safe or hostile*/
       
        public Room(string i_name, string i_desc, string i_state) : base(i_name, i_desc)
        {
            room_state = i_state;
        }
        public void addroom(Room r_name)
        {
            if (r_name != null)
            {
                other_places.Add(r_name);
            }
        }
        public void addperson(Entity being_to_add)
        {
            if (being_to_add != null)
            {
                residence.Add(being_to_add);
                number_of_people++;
            }
        }

        public Entity get_person(string e_name)
        {
            Entity return_value = residence.Find(person => person.getname() == e_name);
            return return_value;
        }
        public void remove_person(string person_Name)
        {
            Entity mover = get_person(person_Name);
            residence.Remove(mover);
        }
    }
}
