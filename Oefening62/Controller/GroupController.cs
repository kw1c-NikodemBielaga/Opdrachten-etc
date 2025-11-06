using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oefening62.Model;

namespace Opdracht62.Controller
{
    class GroupController
    {
        private List<GroupModel> groupList = new List<GroupModel>();

        // Constrcutor, waarin dummy data aangemaakt word
        public GroupController()
        {
            // 3 groepen om de "database" alvast te vullen
            GroupModel group1 = new GroupModel { GroupCode = "IO2A4", GroupMentorName = "Thomas Visser", GroupYear = 2020 };
            GroupModel group2 = new GroupModel { GroupCode = "IO2B4", GroupMentorName = "Angela Lambregts", GroupYear = 2020 };
            GroupModel group3 = new GroupModel { GroupCode = "IO2C4", GroupMentorName = "Paula de Ruiter", GroupYear = 2020 };

            groupList.Add(group1);
            groupList.Add(group2);
            groupList.Add(group3);
        }

        /// <summary>
        /// Voeg een GroupModel aan de database toe
        /// </summary>
        /// <param name="GroupModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Create(GroupModel group)
        {
            groupList.Add(group);
            return 1;
        }

        /// <summary>
        /// Lees alle GroupenBO's uit de database uit
        /// </summary>
        /// <returns>De List met alle GroupModel objecten</returns>
        public List<GroupModel> Read()
        {
            return groupList;
        }

        /// <summary>
        /// Update een bestaande GroupModel in de database
        /// </summary>
        /// <param name="GroupModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Update(GroupModel group)
        {
            int index = groupList.FindIndex(s => s.GroupCode == group.GroupCode);

            if (index != 0)
            {
                // Record gevonden, dus doe een update
                groupList[index] = group;
                return 1;
            }
            else
            {
                // Geen record gevonden, dus doe niets
                return 0;
            }
        }


        /// <summary>
        ///  Verwijder de gegeven GroupModel uit de database
        /// </summary>
        /// <param name="GroupModel"></param>
        /// <returns>Het aantal rows affected</returns>
        public int Delete(GroupModel group)
        {
            bool result = groupList.Remove(group);

            if (result == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
