using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihanlist2
{

    public class Mahasiswa
    {
        public string Nim { get; set; }
        public string NamaMahasiswa { get; set; }
    }

    public class Dosen
    {
        public string Nik { get; set; }
        public string NamaDosen { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "1234";
            mhs1.NamaMahasiswa = "Erik";

            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "1235";
            mhs2.NamaMahasiswa = "Wely";

            Mahasiswa mhs3 = new Mahasiswa();
            mhs3.Nim = "1234";
            mhs3.NamaMahasiswa = "Jhono";

            Dosen dosen = new Dosen();
            dosen.Nik = "0043";
            dosen.NamaDosen = "Antonio";

            List<Mahasiswa> mahasiswalist = new List<Mahasiswa>();

            mahasiswalist.Add(mhs1);
            mahasiswalist.Add(mhs2);
            mahasiswalist.Add(mhs3);

            Mahasiswa mhs = mahasiswalist[1];

            Console.WriteLine("Nama  Nim");
            Console.WriteLine("=============="); 

            foreach (Mahasiswa mahasiswa in mahasiswalist)
            {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();

        }
    }
}
