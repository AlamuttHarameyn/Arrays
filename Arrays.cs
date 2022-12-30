namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            {
                students[0] = "Gizem";
                students[1] = "Mehmet";
                students[2] = "Güven";

                string[] students2 = new[] {"Gizem","Mehmet","Güven" };  //Diziler yukarıdaki gibi satır satır da bu şekilde yanyana da gösterilebilir..

                foreach (var student in students) //Dizinin tüm elemanlarını görmek için kullanılır
                {
                    Console.WriteLine(student);
                }

                Console.WriteLine();
                Console.ReadLine();

            }
        }
    }
}