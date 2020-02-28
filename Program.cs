using System;
using System.Collections.Generic;

namespace PlanYourHeist {
    class Program {
        static void Main (string[] args) {
            List<Dictionary<string, string>> listOfTeamMembers = new List<Dictionary<string, string>> ();

            Dictionary<string, string> teamMember = new Dictionary<string, string> ();

            Console.WriteLine ("Plan Your Heist!");
            Console.WriteLine ("Please Enter a Name...");
            string teamMemberName = Console.ReadLine ();
            teamMember.Add ("Name", teamMemberName);

            Console.WriteLine ("Please Enter their Skill Level (1 - 10)...");
            string teamMemberSkill = Console.ReadLine ();
            teamMember.Add ("Skill Level", teamMemberSkill);

            Console.WriteLine ("Please Enter their Courage Factor (0.0 - 2.0)...");
            string teamMemberCourage = Console.ReadLine ();
            teamMember.Add ("Courage", teamMemberCourage);

            listOfTeamMembers.Add (teamMember);

            foreach (Dictionary<string, string> member in listOfTeamMembers) {
                // Iterate the KeyValuePairs of the Dictionary
                foreach (KeyValuePair<string, string> memberInfo in member) {
                    Console.WriteLine ($"{memberInfo.Key}: {memberInfo.Value}");
                }

            }

        }
    }
}