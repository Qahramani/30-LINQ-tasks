using System.Collections.Generic;

namespace _30_LINQ_exersices
{
    public class Students
    {
        public string Name { get; set; }
        public int Grade { get; set; }
        public int ItemId { get; set; }

        public List<Students> GtStuRec()
        {
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { ItemId = 1, Name = " Joseph ", Grade = 800 });
            stulist.Add(new Students { ItemId = 2, Name = "Alex", Grade = 458 });
            stulist.Add(new Students { ItemId = 3, Name = "Harris", Grade = 900 });
            stulist.Add(new Students { ItemId = 4, Name = "Taylor", Grade = 900 });
            stulist.Add(new Students { ItemId = 5, Name = "Smith", Grade = 458 });
            stulist.Add(new Students { ItemId = 6, Name = "Natasa", Grade = 700 });
            stulist.Add(new Students { ItemId = 7, Name = "David", Grade = 750 });
            stulist.Add(new Students { ItemId = 8, Name = "Harry", Grade = 700 });
            stulist.Add(new Students { ItemId = 9, Name = "Nicolash", Grade = 597 });
            stulist.Add(new Students { ItemId = 10, Name = "Jenny", Grade = 750 });
            return stulist;
        }
    }
}