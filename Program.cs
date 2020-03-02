using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Dictionary<string, string>> listOfTeamMembers = new List<Dictionary<string, string>>();

      Console.WriteLine("Plan Your Heist!");
      while (true)
      {

        Dictionary<string, string> teamMember = new Dictionary<string, string>();
        Console.Write("Please Enter a Name (Or leave blank to move on): ");
        string teamMemberName = Console.ReadLine();
        teamMember.Add("Name", teamMemberName);

        if (teamMemberName != "")
        {
          Console.Write("Please Enter their Skill Level (1 - 20): ");
          string teamMemberSkill = Console.ReadLine();
          teamMember.Add("Skill", teamMemberSkill);

          Console.Write("Please Enter their Courage Factor (0.0 - 2.0): ");
          string teamMemberCourage = Console.ReadLine();
          teamMember.Add("Courage", teamMemberCourage);

          listOfTeamMembers.Add(teamMember);

          Console.Clear();
        }
        else
        {
          Console.Write("Please Enter the Bank's Difficulty (1-100): ");
          string bankDifficultyLevel = Console.ReadLine();
          int bankNumber = int.Parse(bankDifficultyLevel);
          int combinedSkillLevel = 0;

          Console.Write("How many times would you like to run the scenario? ");
          string trialRuns = Console.ReadLine();
          int trialRunsNumber = int.Parse(trialRuns);
          int successfulRun = 0;
          int unsuccessfulRun = 0;

          foreach (Dictionary<string, string> member in listOfTeamMembers)
          {
            string skillLevel = member["Skill"];
            int skillNumber = int.Parse(skillLevel);
            combinedSkillLevel += skillNumber;
          }

          Console.Clear();
          for (int i = 0; i < trialRunsNumber; i++)
          {
            Random rand = new Random();
            int luckValue = rand.Next(-10, 11);
            int totalBankDifficulty = bankNumber + luckValue;

            Console.WriteLine($"Team's Combined Skill: {combinedSkillLevel}");
            Console.WriteLine($"Bank Difficulty: {totalBankDifficulty}");
            Console.WriteLine($"Luck Value: {luckValue}");

            if (combinedSkillLevel >= totalBankDifficulty)
            {
              Console.WriteLine("You could pull off this heist!");
              Console.WriteLine("----------");
              successfulRun += 1;
            }
            else
            {
              Console.WriteLine("Not a chance. Recruit some more and try again.");
              Console.WriteLine("----------");
              unsuccessfulRun += 1;
            }
          }
          Console.WriteLine("--------------------------------------");
          Console.WriteLine($"You succeeded {successfulRun} times! And Failed {unsuccessfulRun} times!");
          break;
        }

      }
    }
  }
}