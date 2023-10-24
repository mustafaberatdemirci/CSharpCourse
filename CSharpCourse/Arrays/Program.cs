namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] students = new string[3];
            students[0] = "mustafa";
            students[1] = "berat";
            students[2] = "demirci";*/
            //string[] students = new string[3] { "Mustafa", "Berat", "Demirci" };
            //string[] students2 = { "mustafa", "berat", "demirci" };
            //foreach (var student in students)
            //{
            //    Console.WriteLine(student);
            //}

            string[,] regions = new string[5, 3]
            {
                {"İstanbul","İzmit","Yalova" },
                {"Ankara","Konya","Kırıkkale" },
                {"Antalya","Adana","Mersin" },
                {"Rize","Trabzon","Samsun" },
                {"İzmir","Muğla","Manisa" }
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("********");
            }
            Console.ReadLine();
        }
    }
}