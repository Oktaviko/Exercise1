using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class program
    {
        // Deklarasi array int dengan ukuran 50
        private int[] a = new int[50];
        // Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        //
        string x; 

        public void name()
        {
            Console.Write("Masukkan nama anda : ");
            string x = Console.ReadLine();
        }

        //fungsi / method
        public void read()
        {
            // Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan beberapa angka yang hendak diurutkan: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 50)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 50 element.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("*********************");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("*********************");

            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("~" + (i + 1) + "~");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("***********************************");
            Console.WriteLine("Bilangan disusun dari yang terkecil");
            Console.WriteLine("***********************************");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortarray()
        {
            for (int i = 1; i < n; i++) // For n - 1 passaes
            {
                // Pada pass i, bandingkan n - i elemen pertama dengan elemen selanjuutnya
                for (int j = 0; j < n - 1; j++)
                {
                    if (a[j] > a[j + 1]) // Jika elemen tidak dalam urutan yang benar
                    {
                        // Tukar elemen
                        int temp;
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // Creating the object of the BubbleSort class
            program myList = new program();

            // Pemanggilan fungsi untuk menerima elemen array
            myList.name();
            myList.read();
            // Pemanggilan fungsi untuk mengurutkan array
            myList.BubbleSortarray();
            // Pemanggilan fungsi untuk menampilkan array yang tersusun
            myList.display();
            // Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
