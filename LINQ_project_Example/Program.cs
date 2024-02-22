using LINQ_project_Example.LinqMetods;

namespace LINQ_project_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Buxgalter> ListBuxgalters = new List<Buxgalter>()
            {
                new Buxgalter() {Id = 1, BName = "Maqsud", PLid = 3},
                new Buxgalter() {Id = 2, BName = "Maqsud_2", PLid = 0},
                new Buxgalter() {Id = 3, BName = "Maqsud_3", PLid = 2},
                new Buxgalter() {Id = 4, BName = "Maqsud_4", PLid = 3},
                new Buxgalter() {Id = 5, BName = "Maqsud_5", PLid = 5},
                new Buxgalter() {Id = 6, BName = "Maqsud_6", PLid = 4},
                new Buxgalter() {Id = 7, BName = "Maqsud_7", PLid = 0},
                new Buxgalter() {Id = 8, BName = "Maqsud_8", PLid = 1},
                new Buxgalter() {Id = 9, BName = "Maqsud_9", PLid = 2},
                new Buxgalter() {Id = 10, BName = "Maqsud_10", PLid = 1},
                new Buxgalter() {Id = 11, BName = "Maqsud_11", PLid = 5},
                new Buxgalter() {Id = 12, BName = "Maqsud_12", PLid = 4},
                new Buxgalter() {Id = 14, BName = "Maqsud_13", PLid = 3},
                new Buxgalter() {Id = 15, BName = "Maqsud_14", PLid = 1},
                new Buxgalter() {Id = 16, BName = "Maqsud_15", PLid = 0}
            };


            List<ProgrammingLanguage> ListProgrammingLanguages = new List<ProgrammingLanguage>()
            {
                new ProgrammingLanguage() {Id = 0, Name = "Hech qanday dasturlash tilini bilmaydi"},
                new ProgrammingLanguage() {Id = 1, Name = "C#"},
                new ProgrammingLanguage() {Id = 2, Name = "Flutter"},
                new ProgrammingLanguage() {Id = 3, Name = "Go"},
                new ProgrammingLanguage() {Id = 4, Name = "Python"},
                new ProgrammingLanguage() {Id = 5, Name = "Java"}
            };



            // Task 1.
            var BuxgalterKnowProgrammingLanguage = ListBuxgalters.Where(x => x.PLid != 0)
                .Join(ListProgrammingLanguages, bux => bux.PLid, plID => plID.Id, (bux, piID) => new { bux, piID });

            foreach(var item  in BuxgalterKnowProgrammingLanguage)
            {
                Console.WriteLine();
                //Console.WriteLine($"Id: {item.bux.Id},  Name: {item.bux.BName},  Programming language: {item.piID.Name}");
            }

            // Task 2.
            var BuxgalterKnowCsharp = ListBuxgalters.Where(x => x.PLid != 0)
                .Join(ListProgrammingLanguages, bux => bux.PLid, plID => plID.Id, (bux, piID) => new { bux, piID }).Where(x => x.piID.Name == "C#");

            foreach (var item in BuxgalterKnowCsharp)
            {
                Console.WriteLine();
                //Console.WriteLine($"Id: {item.bux.Id},  Name: {item.bux.BName},  Programming language: {item.piID.Name}");
            }

            // Task 3.
            var task3 = ListBuxgalters
                .Join(ListProgrammingLanguages, bux => bux.PLid, plID => plID.Id, (bux, piID) => new { bux, piID });

            foreach (var item in task3)
            {
                Console.WriteLine();
                Console.WriteLine($"{item.piID.Name} => {item.bux.BName}");
            }


        }
    }
}
