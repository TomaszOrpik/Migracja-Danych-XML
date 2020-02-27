using System;

namespace Migracja_danych_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Tomek\\Desktop\\cs201-lab-Migracja-danych-via-XML-LinqToXML-master\\issues.xml";
            EksportImport ei = new EksportImport(path);
            Console.WriteLine("Save complete");
            Console.ReadKey();

            /*
             * otrzymuje path
             * przetwarza
             * daje console complete
             * szukamy pliku i sprawdzamy
             */
        }
    }
}
