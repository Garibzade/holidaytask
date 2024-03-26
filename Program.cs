//task1

//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, -3, -4 };
//            ChangeArray(ref arr);

//        }
//        public static void ChangeArray(ref int[] arr)
//        {
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < 0)
//                {
//                    arr[i] = arr[i] * -1;

//                }
//                Console.WriteLine(arr[i]);
//            }

//        }
//    }
//}


//----------------------------------------------------------------------------------------------------------------
//task2



//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string word = "salam dunya";
//            SearcLetter(ref word);

//        }
//        static void SearcLetter(ref string a)
//        {
//            int count = 0;
//            for (int i = 0; i < a.Length; i++)
//            {
//                if (a[i] == 'a')
//                {
//                    count++;
//                }

//            }
//            if (count > 0)
//            {
//                Console.WriteLine("true");
//            }
//            else { Console.WriteLine("false"); }
//        }
//    }
//}

//----------------------------------------------------------------------------------------------------------------
//task3

//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] nums = { -21, 2, 3, 4, -50, 6, 7 };
//            Min(ref nums);



//        }
//        static void Min(ref int[] arr)
//        {
//            int check = arr[0];
//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] < check)
//                {
//                    check = arr[i];

//                }
//            }
//            Console.WriteLine(check);
//        }

//    }
//}

//----------------------------------------------------------------------------------------------------------------
//task4

//task4

//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int mainnum = 97312;
//            NumLength(ref mainnum);



//        }
//        public static void NumLength(ref int num)
//        {
//            int count = 0;
//            if (num == 0)
//            {
//                count = 1;
//            }
//            while (num != 0)
//            {
//                count++;
//                num = num / 10;
//            }
//            Console.WriteLine("reqemlerin sayi=" + count);
//        }


//    }
//}


//----------------------------------------------------------------------------------------------------------------
//task5


//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            string text = "azerbaycan";
//            VowelLetter(ref text);




//        }
//        public static void VowelLetter(ref string metn)
//        {
//            int count = 0;
//            for (int i = 0; i < metn.Length; i++)



//            {
//                if (metn[i] == 'a'|| 
//                    metn[i] == 'e' || 
//                    metn[i] == 'u' || 
//                    metn[i] == 'i' || 
//                    metn[i]=='o'||
//                    metn[i] == 'O'||
//                   metn[i]=='A'||
//                   metn[i] == 'U'||
//                   metn[i]=='E'||
//                   metn[i] == 'I')
//                {
//                    count++;


//                }


//            }
//            Console.WriteLine(count);


//        }


//    }
//}




//----------------------------------------------------------------------------------------------------------------
//task6


//namespace HolidayHomeTask
//{
//    internal class program
//    {
//        static void Main()
//        {
//            int[] nums = { 5, 5, 5, 5, 5 };
//            Medium(ref nums);


//        }

//        public static void Medium(ref int[] arr)
//        {

//            int sum = 0;
//            int num = 0;
//            int medium = 0;
//            for (int i = 0; i < arr.Length; i++)
//            {
//                num++;
//                sum += arr[i];
//                medium = sum / num;

//            }
//            Console.WriteLine(medium);
//        }

//    }
//}

//----------------------------------------------------------------------------------------------------------------
//task-project




//namespace HolidayHomeTask
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] names = { "ali", "akif", "aga" };
//                Console.WriteLine("1.Siyahiya bax");
//                Console.WriteLine("2.Siyahiya add elave et");
//                Console.WriteLine("3.Siyahida adi yoxla");
//                Console.WriteLine("4.Daxil edilmis indexdeki adi goster");
//                Console.WriteLine("0.Menudan cix");
//                Console.WriteLine("secim edin:");
//                int opinion = int.Parse(Console.ReadLine());

//                switch (opinion)
//                {
//                    case 1:
//                    Console.WriteLine("siyahidaki adlar-->");
//                    foreach (string name in names) Console.WriteLine(  name);
                        
//                    break;
//                    case 2:
//                    Console.WriteLine("bunu ede bilmedim");
//                    break;
//                    case 3:
//                    break;
//                    case 4:
//            }








//            }



//        }
//    }

//-------------------------------------------------------------------------------------------------------------



