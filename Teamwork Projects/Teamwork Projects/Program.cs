namespace Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            List<TeamWork> allTeams = new List<TeamWork>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split("-");

                string creator = command[0];
                string teamName = command[1];

                TeamWork c = allTeams.Find((item) => item.TeamName == teamName);
                
                if(c != null)
                {
                    Console.WriteLine($"Team {creator} was already created!");
                    continue;
                }

                TeamWork tt = allTeams.Find((item) => item.Creator == creator);

                if(tt != null)
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }

                TeamWork teams = new TeamWork
                {
                    Creator = creator,
                    TeamName = teamName
                };

                Console.WriteLine($"Team {teams.TeamName} has been created by {teams.Creator}!");

                allTeams.Add(teams);
            }

            while (true)
            {
                string[] command = Console.ReadLine().Split("->");
                if (command[0] == "end of assigment")
                {
                    break;
                }

                string user = command[0];
                string teamName = command[1];

                TeamWork team = allTeams.Find((item) => item.TeamName == teamName);

                if (team == null)
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else
                {
                    TeamWork otherTeam = allTeams.Find((item) => item.Users.Contains(user));

                    if (otherTeam != null)
                    {
                        Console.WriteLine($"Member {user} cannot join {teamName}!");
                    }
                    else
                    {
                        team.Users.Add(user);
                    }
                }

            }

            List<TeamWork> emptyTeams = allTeams.Where((item) => item.Users.Count == 0).ToList();
            emptyTeams.Sort((a, b) => string.Compare(a.TeamName, b.TeamName));


            List<TeamWork> fullTeams = allTeams.Where((item) => item.Users.Count > 0).ToList();


        }
    }
}