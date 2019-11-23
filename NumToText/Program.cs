using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace NumToText
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dict = new Dictionary<int, string>();
            Dict[0] = "";
            Dict[1] = "Mek";
            Dict[2] = "Erku";
            Dict[3] = "Erek";
            Dict[4] = "Chors";
            Dict[5] = "Hing";
            Dict[6] = "Vec";
            Dict[7] = "Yot";
            Dict[8] = "Ut";
            Dict[9] = "Iny";
            Dict[10] = "Tas";
            Dict[20] = "Qsan";
            Dict[30] = "Eresun";
            Dict[40] = "Qarasun";
            Dict[50] = "Hisun";
            Dict[60] = "Vacun";
            Dict[70] = "Yotanasun";
            Dict[80] = "Utanasun";
            Dict[90] = "Insun";
            Dict[100] = "Haryur";
            Dict[1000] = "Hazar";
            Dict[10000] = "Tas Hazar";
            Dict[100000] = "Haryur Hazar";
            Dict[1000000] = "Million";
            Console.WriteLine("Insert Your Number");
            int Num = int.Parse(Console.ReadLine());
            NumToText(Num,Dict);

        }
        static void NumToText(int Num, Dictionary<int, string> Dict)
        {
            int Number = Num;
            ArrayList list = new ArrayList();
            for (int i = 0; i < Num.ToString().Length; i++)
            {
                list.Add(Number % 10);
                Number /= 10;
            }
            list = Swap(list);

            while(list.Count != 2)
            {
                int b = (int) list[0];
                if (b == 0)
                {
                    list.RemoveAt(0);
                    continue;
                }
                Console.Write(Dict[b] + " " + Dict[Check(list.Count)] + " ");
                list.RemoveAt(0);
            }
            int a = (int)list[0];
            if (a == 0)
            {
                Console.WriteLine(Dict[(int)list[1]]);
                return;
            }
            int lefted = 10 * a + (int)list[1];
            int lefted_abs = (lefted / 10) * 10;
            int mnac = lefted - lefted_abs;
            Console.Write(Dict[lefted_abs] + Dict[mnac] + " ");
            Console.ReadLine();
        }
        static ArrayList Swap(ArrayList list)
        {
            int k = list.Count;
            ArrayList temp = new ArrayList();
            string Test = "";
            for (int i = 0; i < k; i++)
            {
                Test += list[i].ToString();
            }
            int Test2 = int.Parse(Test);
            for (int i = -1; i <= Test2+2; i++)
            {
                temp.Add(Test2 % 10);
                Test2 /= 10;
            }
            return temp;


        }
        static int Check(int Num)
        {
            switch (Num)
            {
                case 3:
                    return 100;
                case 4:
                    return 1000;
                case 5:
                    return 10000;
                case 6:
                    return 100000;
                case 7:
                    return 1000000;
                default:
                    return 0;
            }
        }
            static void CheckNum(int Num, Dictionary<int, string> Dict)
        {
            foreach (var item in Dict)
            {
                if (Num == item.Key)
                {
                    Console.WriteLine(item.Value);
                }
            }
        }
    }
}
