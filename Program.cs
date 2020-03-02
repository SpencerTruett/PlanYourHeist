using System;
using System.Collections.Generic;

namespace PlanYourHeist {
    class Program {
        static void Main (string[] args) {
            List<Dictionary<string, string>> listOfTeamMembers = new List<Dictionary<string, string>> ();

            while (true) {

                Dictionary<string, string> teamMember = new Dictionary<string, string> ();
                Console.WriteLine ("Plan Your Heist!");
                Console.WriteLine ("Please Enter a Name...");
                string teamMemberName = Console.ReadLine ();
                teamMember.Add ("Name", teamMemberName);

                if (teamMemberName != "") {
                    Console.WriteLine ("Please Enter their Skill Level (1 - 10)...");
                    string teamMemberSkill = Console.ReadLine ();
                    teamMember.Add ("Skill", teamMemberSkill);

                    Console.WriteLine ("Please Enter their Courage Factor (0.0 - 2.0)...");
                    string teamMemberCourage = Console.ReadLine ();
                    teamMember.Add ("Courage", teamMemberCourage);

                    listOfTeamMembers.Add (teamMember);
                } else {
                    Console.WriteLine ("Please Enter the Bank's Difficulty (1-100)...");
                    string bankDifficultyLevel = Console.ReadLine ();
                    int bankNumber = int.Parse (bankDifficultyLevel);
                    int combinedSkillLevel = 0;

                    foreach (Dictionary<string, string> member in listOfTeamMembers) {
                        string skillLevel = member["Skill"];
                        int skillNumber = int.Parse (skillLevel);
                        combinedSkillLevel += skillNumber;

                        if (combinedSkillLevel >= bankNumber) {
                            Console.WriteLine ("You could pull off this heist!");
                        } else {
                            Console.WriteLine ("Not a chance. Recruit some more and try again.");
                        }
                    }
                    break;
                }

            }
        }
    }
}