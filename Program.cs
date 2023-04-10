using System;
using System.Linq;

namespace DosenMod
{
    class Program
    {
        static void Main(string[] args)
        {
            Dosen dosen = new Dosen();
            Console.WriteLine("Default Dosen Pengampu: ");
            dosen.display();

            Console.WriteLine("\n\nMsukkan Nama dan NIK Dosen Baru: ");
            dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
            dosen.display();

            Console.WriteLine("\nMasukkan Mata KUliah Baru: ");
            dosen.addCourse(Console.ReadLine());
            dosen.display();

            Console.ReadLine();

        }
    }

}