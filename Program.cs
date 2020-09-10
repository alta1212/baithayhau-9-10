using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace đếm_số_đối_xứng
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.OutputEncoding = Encoding.Unicode;
            //Console.WriteLine(kiemtrasodoixung()) ;
            // Console.WriteLine(songuyento()) ;
            sapxep();
             Console.ReadKey();
        }
      
        public static int kiemtrasodoixung()
        {   int dem=0;
            Console.WriteLine("nhập số phần tử muốn nhập");
            int i = int.Parse(Console.ReadLine());
            int[] arr1 = new int[i];
            for (int j=0;j<i;j++)
            {
                Console.WriteLine(string.Format("nhập phần tử số {0}",j+1));
                int so = int.Parse(Console.ReadLine());
                arr1[j] = so;
            }
          
            for (int k = 0; k < arr1.Length; k++)
            {
                string chuoinguoc="";
                int l = arr1[k].ToString().Length - 1;
                string chuoi = arr1[k].ToString();
                for (int s=l;s>=0;s--)
                {
                    chuoinguoc = chuoinguoc + chuoi[s];
                    if(chuoinguoc==chuoi&&l!=0)
                    {
                        dem++;
                    }    
                }
               
            }
            Console.WriteLine("số số đối xứng là : ");
            return dem;
        }
        public static int songuyento()
        {
            int dem=0;
            
            Console.WriteLine("nhập số phần tử muốn nhập");
            int i = int.Parse(Console.ReadLine());
            int[] arr1 = new int[i];
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(string.Format("nhập phần tử số {0}", j + 1));
                int so = int.Parse(Console.ReadLine());
                arr1[j] = so;
            }
            for (int k = 0; k < arr1.Length; k++)
            {
             
                int demso = 0;
                for (int j=2;j<=Math.Sqrt(arr1[k]);j++)
                {
                        if(arr1[k]<2)
                        {
                            break;
                        }    
                        if(arr1[k]%j==0)
                        {
                            demso ++;
                           
                        }
                        if (demso == 0)
                        {
                            dem++;
                            break;
                        }
                }    

            }
            Console.WriteLine("số số nguyên tố là : ");
            return dem;
            
        }
        public static int length()
        {
           
            Console.WriteLine("nhập số phần tử muốn nhập");
            int i = int.Parse(Console.ReadLine());
            int[] arr1 = new int[i];
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine(string.Format("nhập phần tử số {0}", j + 1));
                int so = int.Parse(Console.ReadLine());
                arr1[j] = so;
            }
            int mx = arr1[0];
            for (int k = 1; k < i; k++)
            {
                if (arr1[k] > mx)
                {
                    mx = arr1[i];
                }
            }
            int dem = 0;
            for(int k = 1; k < i; k++)
            {
                if (mx == arr1[k])
                    dem++;
            }    
   
            return dem;
        }
        public static string sapxep()
        {
            Console.WriteLine("nhập kích cỡ mảng 2 chiều");
            Console.WriteLine("chiều 1");
            int c1 = int.Parse(Console.ReadLine());
            Console.WriteLine("chiều 2");
            int c2 = int.Parse(Console.ReadLine());
            int[,] arr2 = new int[c1, c2];
           Random r2 = new Random();
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                   
                  //  Console.WriteLine("Phần tử số {0},{1}", i, j);
                    arr2[i, j] = r2.Next(1, 100);
                    //int.Parse(Console.ReadLine());
                }
            }
            string s = "";
            Console.WriteLine("mảng chưa sắp xếp :");
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    s = arr2[i, j].ToString();
                    Console.Write(s+"\t");
                }
                Console.WriteLine();
            }
            int[] sapxep = new int[c1 * c2];
            Console.WriteLine("mảng đã sắp xếp :");

            for (int i = 0; i < c1; i++)
                for (int j = 0; j < c2; j++)
                    sapxep[i * c1 + j] = arr2[i,j];
            for (int i = 0; i < c1*c2 - 1; i++)
                for (int j = i + 1; j < c1 * c2; j++)
                    if (sapxep[i] > sapxep[j])
                    {
                        int t = sapxep[i];
                        sapxep[i] = sapxep[j];
                        sapxep[j] = t;
                    }
            int index=-1;
            for (int i = 0; i < c1 ; i++)
                for (int j = 0; j < c1; j++)
                {  index++;
                    arr2[i, j]=sapxep[index] ;


                }
            for (int i = 0; i < c1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    s = arr2[i, j].ToString();
                    Console.Write(s + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
            return s;
           
        }
    }
}
