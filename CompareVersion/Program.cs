using System.Text.RegularExpressions;
namespace VC
{
    public class Program
    {
        static void Main(string[] args)
        {
            var regex = @"[0-9]+(\.[0-9]+)*";
            Regex rg = new Regex(regex);
            do
            {

                string version1, version2;
                Console.Write("Enter Version 1: ");
                version1 = Console.ReadLine();

                Console.Write("Enter Version 2: ");
                version2 = Console.ReadLine();


                int res = CompareVersion(version1, version2);
                if (res == 1)
                {
                    Console.WriteLine("{0} > {1}", version1, version2);
                    Console.WriteLine("returned: {0}", res);
                }
                else if (res == -1)
                {
                    Console.WriteLine("{0} < {1}", version1, version2);
                    Console.WriteLine("returned: {0}", res);
                }
                else
                {
                    Console.WriteLine("returned: {0}", res);
                }

                Console.Write("Exit Yes/No, enter y for yes and n for no : ");

            } while (Console.ReadLine() != "y");
        }
        public static int CompareVersion(string v1, string v2)
        {
            string[] v1Part = v1.Split('.');
            string[] v2Part = v2.Split('.');

            int n = Math.Max(v1Part.Length, v2Part.Length);

            for (int i = 0; i < n; i++)
            {
                int version1 = int.Parse(i < v1Part.Length ? v1Part[i] : "0");
                int version2 = int.Parse(i < v2Part.Length ? v2Part[i] : "0");

                if (version1 < version2) return -1;
                else if (version1 > version2) return 1;
            }

            return 0;

        }
    }

}
