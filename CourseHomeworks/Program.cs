using System;

namespace CourseHomeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            //DICTIONARY KULLANIMI********
            Dictionary<int, string> schoolNumber = new Dictionary<int, string>();
            schoolNumber.Add(1, "Oskan");
            schoolNumber.Add(2, "Kemal");
            foreach (KeyValuePair<int, string> schoolnumber in schoolNumber)
            {
                Console.WriteLine("Numara:{0} Öğrenci:{1}", schoolnumber.Key, schoolnumber.Value);
            }
            //DICTIONARY KULLANIMI********
            //OUTPUT=Numara:1 Öğrenci:Oskan
            //       Numara: 2 Öğrenci: Kemal

            MyDictionary<int, string> ıdentitynumber = new MyDictionary<int, string>();
            ıdentitynumber.Add(321313, "Ali");
            Console.WriteLine(ıdentitynumber.Count);

            ıdentitynumber.Add(25879, "Mehmet");
            Console.WriteLine(ıdentitynumber.Count);

            ıdentitynumber.Add(98465, "Ayşe");
            Console.WriteLine(ıdentitynumber.Count);

            foreach (var tckimlikno in ıdentitynumber.Value)
            {
                Console.WriteLine(tckimlikno);
            }
        }
    }
}
