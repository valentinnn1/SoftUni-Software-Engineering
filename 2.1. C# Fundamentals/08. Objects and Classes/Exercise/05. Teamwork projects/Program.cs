using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_projects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> listOfTeams = new List<Team>();
            listOfTeams = CreateAndAddTeamsToTheList(teamsCount, listOfTeams);
            listOfTeams = AddMembersToTheLists(listOfTeams);
            listOfTeams = listOfTeams.OrderByDescending(x => x.teamMembers.Count)
                          .ThenBy(y => y.teamName).ToList();
            List<string> disbandedTeams = new List<string>();
            for (int i = 0; i < listOfTeams.Count; i++)
            {
                if (listOfTeams[i].teamMembers.Count == 0)
                {
                    disbandedTeams.Add(listOfTeams[i].teamName);
                    continue;
                }
                PrintValidTeams(listOfTeams, i);
            }
            disbandedTeams.Sort();
            PrintDisbandedTeams(disbandedTeams);
        }

        private static List<Team> CreateAndAddTeamsToTheList(int teamsCount, List<Team> listOfTeams)
        {
            for (int currentTeam = 0; currentTeam < teamsCount; currentTeam++)
            {
                string[] tokens = Console.ReadLine().Split('-');
                string creator = tokens[0];
                string name = tokens[1];
                CreateTeamIfPossible(listOfTeams, creator, name);
            }
            return listOfTeams;
        }

        private static List<Team> AddMembersToTheLists(List<Team> listOfTeams)
        {
            string command = Console.ReadLine();
            while (command != "end of assignment")
            {
                string[] tokens = command.Split("->");
                string member = tokens[0];
                string name = tokens[1];
                AddMemberIfPossible(listOfTeams, member, name);
                command = Console.ReadLine();
            }
            return listOfTeams;
        }

        private static void CreateTeamIfPossible(List<Team> listOfTeams, string creator, string name)
        {

            if (listOfTeams.Any(x => x.teamCreator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
            }
            else if (listOfTeams.Any(x => x.teamName == name))
            {
                Console.WriteLine($"Team {name} was already created!");
            }
            else
            {
                listOfTeams.Add(new Team(creator, name));
                Console.WriteLine($"Team {name} has been created by {creator}!");
            }
        }

        private static void AddMemberIfPossible(List<Team> listOfTeams, string member, string name)
        {

            if (!listOfTeams.Any(y => y.teamName == name))
            {
                Console.WriteLine($"Team {name} does not exist!");
            }
            else if (listOfTeams.Any(x => x.teamMembers.Contains(member)) ||
                listOfTeams.Any(y => y.teamCreator == member))
            {
                Console.WriteLine($"Member {member} cannot join team {name}!");
            }
            else
            {
                int indexToAddAt = listOfTeams.FindIndex(x => x.teamName == name);
                listOfTeams[indexToAddAt].teamMembers.Add(member);
            }
        }

        private static void PrintValidTeams(List<Team> listOfTeams, int i)
        {
            Console.WriteLine(listOfTeams[i].teamName);
            Console.WriteLine($"- {listOfTeams[i].teamCreator}");
            listOfTeams[i].teamMembers.Sort();
            foreach (var member in listOfTeams[i].teamMembers)
            {
                Console.WriteLine($"-- {member}");
            }
        }

        private static void PrintDisbandedTeams(List<string> disbandedTeams)
        {
            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team);
            }
        }
    }

    class Team
    {
        public string teamCreator;
        public string teamName;
        public List<string> teamMembers = new List<string>();

        public Team()
        {

        }

        public Team(string creator, string name)
        {
            teamCreator = creator;
            teamName = name;
        }
    }
}
