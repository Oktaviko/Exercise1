using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        //Deklrasi array int dengan ukuran 20
        private int[] a = new int[20];
        //Deklarasi variabel int untuk menyimpan banyaknya data pada array
        private int n;
        
        //Fungsi / Method untuk menerima masukan
        public void read()
        {
            //Menerima angka untuk menentukan banyaknya data yang disimpan pada array
            while (true)
            {
                Console.Write("Masukkan banyaknya elemen pada array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray dapat mempunyai maksimal 20 elemen.\n");
            }
            Console.WriteLine("");
            Console.WriteLine("-------------");
            Console.WriteLine("Masukkan elemen array");
            Console.WriteLine("-------------");
            //Pengguna memasukkan elemen pada array
            for (int i = 0; i < n; i++)
            {
                Console.Write("--" + (i + 1) + "--");
                string s1 = Console.ReadLine();
                a[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            //Menampilkan array yang tersusun
            Console.WriteLine("");
            Console.WriteLine("---------");
            Console.WriteLine("Element array yang telah tersusun");
            Console.WriteLine("---------");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(a[j]);
            }
            Console.WriteLine("");
        }
        public void BubblesortArray()
        {
            //Pada pass i, bandingkan n-i elemen pertama dengan elemen selanjutnya
            for (int j = 0; j < n - 1; j++)
            {
                if (a[j] > a[j + 1])//Jika elemen tidak dalam ururtan yang benar
                {
                    //Tukar elemen
                    int temp;
                    temp = a[j];
                    a[j] = a[j + 1];
                    a[j + 1] = temp;
                }
            }
        }
        static void Main(string[] args)
        {
            //Creating the object of the Bubblesort class
            Program myList = new Program();
            //Memanggil fungsi untuk menerima elemen array
            myList.read();
            //Memanggil fungsi untuk mengurutkan array
            myList.BubblesortArray();
            //Memanggil fungsi untuk menampilkan array yang tersusun
            myList.display();
            //Exit
            Console.WriteLine("\n\nTekan tombol apa saja untuk keluar.");
            Console.Read();
        }
    }
}
