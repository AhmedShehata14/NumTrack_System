using System;
using System.Collections.Immutable;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml.Linq;

namespace NumTrack_System
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string Tab = new string(' ', 50);
            List<int> ListOfNumbers = new List<int>();

            while (true)
            {
                PrintMenue();
                Console.Write(Tab + "Plase enter Choos:==> ");
                char inputChar = Convert.ToChar(Console.ReadLine().ToUpper());

                //الاضافة
                if (inputChar == 'A')
                {
                    int AddNumber = 0;
                    int Start = 0;
                    int End = ListOfNumbers.Count;
               
                    Console.Write(Tab + "Plase Enter The Number to Add : ==> ");
                    AddNumber = Convert.ToInt32(Console.ReadLine());

                    ListOfNumbers.Add(AddNumber);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Tab}======= output =====================");
                    Console.WriteLine(Tab + $"{AddNumber} added");
                    Console.WriteLine(Tab + "====================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }//عرض المحتوى
                else if (inputChar == 'P')
                {
                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "[] - The List is empty");
                        Console.WriteLine(Tab + "====================================\n");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.Write(Tab);

                        for (int i = 0; i < ListOfNumbers.Count; i++)
                        {
                            Console.Write(ListOfNumbers[i] + " ");
                        }
                        Console.WriteLine("\n" + Tab + "====================================\n");
                    }
                    Console.ReadKey();
                    Console.Clear();

                }//متوسط القيم
                else if (inputChar == 'M')
                {
                    int Sum = 0;
                    double Avg = 0;
                    int Start = 0;
                    int NumebrList = ListOfNumbers.Count;

                    if (NumebrList == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Tab + "The List is Empty!!");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    for (int i = Start; i < NumebrList; i++)
                    {
                        Sum += ListOfNumbers[i];
                    }
                    Avg = (double)Sum / NumebrList;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Tab}======= output =====================");
                    Console.WriteLine(Tab + $"Avg =  {Avg}");
                    Console.WriteLine(Tab + "====================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }//اضغر قيمة 
                else if (inputChar == 'S')
                {

                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "The List is Empty");
                        Console.WriteLine(Tab + "====================================\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    int Start = 0;
                    int End = ListOfNumbers.Count;
                    int SmalNumber = ListOfNumbers[0];

                    for (int i = Start; i < End; i++)
                    {
                        if (ListOfNumbers[i] < SmalNumber)
                        {
                            SmalNumber = ListOfNumbers[i];
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Tab}======= output =====================");
                    Console.WriteLine(Tab + $"The Smallest number is {SmalNumber}");
                    Console.WriteLine(Tab + "====================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }//اكبر قيمة
                else if (inputChar == 'L')
                {
                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "The List is Empty");
                        Console.WriteLine(Tab + "====================================\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    int Start = 0;
                    int End = ListOfNumbers.Count;
                    int LargNumber = ListOfNumbers[0];

                    for (int i = Start; i < End; i++)
                    {
                        if (ListOfNumbers[i] > LargNumber)
                        {
                            LargNumber = ListOfNumbers[i];
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Tab}======= output =====================");
                    Console.WriteLine(Tab + $"The Largest number is {LargNumber}");
                    Console.WriteLine(Tab + "====================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }//البحث
                else if (inputChar == 'F')
                {

                    int SearchNuber = 0;
                    int indexOfNumber = 0;
                    bool fla = false;

                    Console.Write($"{Tab}Plase enter The Number to search==> ");
                    SearchNuber = Convert.ToInt32(Console.ReadLine());

                    int Start = 0;
                    int End = ListOfNumbers.Count;

                    for (int i = Start; i < End; i++)
                    {
                        if (SearchNuber == ListOfNumbers[i])
                        {
                            indexOfNumber = i;
                            fla = true;
                            break;
                        }
                    }

                    if (fla == true)
                    {

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + $"Needed number in index {indexOfNumber}");
                        Console.WriteLine(Tab + "====================================\n");
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + $"Needed number not the List!!");
                        Console.WriteLine(Tab + "====================================\n");
                    }
                    Console.ReadKey();
                    Console.Clear();

                }//الاستبدال
                else if (inputChar == 'W')
                {
                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Tab + "The List is Empty !!");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(Tab + "Please enter the First Number: ");
                    int FNum1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write(Tab + "Please enter the Second Number: ");
                    int SNum2 = Convert.ToInt32(Console.ReadLine());
                    Console.ResetColor();

                    if (ListOfNumbers.Contains(FNum1) && ListOfNumbers.Contains(SNum2))
                    {
                        int index1 = ListOfNumbers.IndexOf(FNum1);
                        int index2 = ListOfNumbers.IndexOf(SNum2);

                        
                        int temp = ListOfNumbers[index1];
                        ListOfNumbers[index1] = ListOfNumbers[index2];
                        ListOfNumbers[index2] = temp;

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Tab}======= Output After Swapping =====================");
                        Console.Write(Tab);

                        foreach (var num in ListOfNumbers)
                        {
                            Console.Write(num + " ");
                        }

                        Console.WriteLine("\n" + Tab + "====================================================\n");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(Tab + "❌ One or both numbers not found in the list!");
                        Console.ResetColor();
                    }
                    Console.ReadKey();
                    Console.Clear();

                } //تصاعدى
                else if (inputChar == 'O')
                {

                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "The List is Empty");
                        Console.WriteLine(Tab + "====================================\n");

                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    int smallNumber = ListOfNumbers[0];
                    int StartI = 0;
                    int End = ListOfNumbers.Count;

                    for (int i = StartI; i < End; i++)
                    {
                        int StartJ = i + 1;
                        for (int j = StartJ; j < End; j++)
                        {
                            if (ListOfNumbers[i] > ListOfNumbers[j])
                            {
                                int SW;

                                SW = ListOfNumbers[j];
                                ListOfNumbers[j] = ListOfNumbers[i];
                                ListOfNumbers[i] = SW;
                            }
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n" + Tab + "Ascending sorting completed");
                    Console.Write(Tab + "Print List ? (Y/N)==> ");
                    char chack = Convert.ToChar(Console.ReadLine().ToLower());

                    if (chack == 'y')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.Write(Tab);

                        for (int i = StartI; i < End; i++)
                        {
                            Console.Write(ListOfNumbers[i] + " ");
                        }
                        Console.WriteLine("\n" + Tab + "====================================\n");

                    }
                    else if (chack == 'n')
                    {
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.ReadKey();
                    Console.Clear();

                }//الترتيب التنازلى Descending order
                else if (inputChar == 'E')
                {
                    if (ListOfNumbers.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "The List is Empty");
                        Console.WriteLine(Tab + "====================================\n");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    int LargeNumber = ListOfNumbers[0];
                    int StartI = 0;
                    int End = ListOfNumbers.Count;

                    for (int i = StartI; i < End; i++)
                    {
                        int StartJ = i + 1;
                        for (int j = StartJ; j < End; j++)
                        {
                            if (ListOfNumbers[i] < ListOfNumbers[j])
                            {
                                int SW;

                                SW = ListOfNumbers[j];
                                ListOfNumbers[j] = ListOfNumbers[i];
                                ListOfNumbers[i] = SW;
                            }
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("\n" + Tab + "Ascending sorting completed");
                    Console.Write(Tab + "Print List ? (Y/N)==> ");
                    char chack = Convert.ToChar(Console.ReadLine().ToLower());

                    if (chack == 'y')
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"\n{Tab}======= output =====================");

                        Console.Write(Tab);
                        for (int i = StartI; i < End; i++)
                        {
                            Console.Write(ListOfNumbers[i] + " ");
                        }
                        Console.WriteLine("\n" + Tab + "====================================\n");

                    }
                    else if (chack == 'n')
                    {
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    Console.ReadKey();
                    Console.Clear();
                }//الحذف
                else if (inputChar == 'C')
                {
                    ListOfNumbers.Clear();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n{Tab}======= output =====================");
                    Console.WriteLine(Tab + "List Clear successed");
                    Console.WriteLine(Tab + "====================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }//الانتهاء
                else if (inputChar == 'Q')
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"\n{Tab}\"Exiting program\":(Y/N) ==> ");
                    char Bo = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (Bo == 'N')
                    {
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"\n{Tab}======= output =====================");
                        Console.WriteLine(Tab + "Thank You My bro");
                        Console.WriteLine(Tab + "====================================\n");
                        break;
                    }
                }//لو دخل رقم غلط
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\n{Tab}======= output ============================");
                    Console.WriteLine($"{Tab}Plase enter Only Char ==> (P,A,M,S,L,F,C,Q)");
                    Console.WriteLine(Tab + "===========================================\n");
                    Console.ReadKey();
                    Console.Clear();

                }
            }
            Console.ForegroundColor = ConsoleColor.White;

        }//Fun للطباعة
        static void PrintMenue()
        {

            string Tab = new string(' ', 50);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\n");
            Console.WriteLine(Tab + "============= Min Menue ============\n");
            Console.WriteLine(Tab + "P - Print number               ");
            Console.WriteLine(Tab + "A - Add number                 ");
            Console.WriteLine(Tab + "M - Display Avrage of the numbers");
            Console.WriteLine(Tab + "S - Display the smallest number");
            Console.WriteLine(Tab + "L - Display the largest number ");
            Console.WriteLine(Tab + "E - Descending order           ");
            Console.WriteLine(Tab + "O - Ascending order            ");
            Console.WriteLine(Tab + "W - Swap tow Number            ");
            Console.WriteLine(Tab + "F - Find a number              ");
            Console.WriteLine(Tab + "C - Clear the whole list       ");
            Console.WriteLine(Tab + "Q - Quit                       ");
            Console.WriteLine(Tab + "====================================");

        }

    }

}
