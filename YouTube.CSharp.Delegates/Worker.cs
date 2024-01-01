namespace YouTube.CSharp.Delegates
{
    public class Worker
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
    }

    public class WorkersData
    {
        public List<Worker> workers = new()
        {
            new(){Name="Michael",Experience = 1,Salary = 1250},
            new(){Name="Gordon",Experience = 2,Salary = 1450},
            new(){Name="Amanda",Experience = 3,Salary = 1750},
            new(){Name="Rachel",Experience = 4,Salary = 1950},
            new(){Name="Jimmy",Experience = 5,Salary = 2250},
            new(){Name="Bobby",Experience = 6,Salary = 2450},
            new(){Name="James",Experience = 7,Salary = 2650},
            new(){Name="Jack",Experience = 8,Salary = 2850}
        };
    }
}
