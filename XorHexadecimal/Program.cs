using System;
using System.Collections.Generic;

namespace XorHexadecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            HexString bdk1 = new HexString("28c06eb41c4dc9c3ae114831efcac7446c8747777fca8b145ecd31ff8480ae88");
            HexString bdk2 = new HexString("4d4abb9168114e349672b934d16ed201a919cb49e28b7f66a240e62c92ee007f");
            HexString bdk3 = new HexString("fce514f84f37934bc8aa0f861e4f7392273d71b9d18e8209d21e4192a7842058");

            const string expected = "996fc1dd3b6b14bcf0c9fe8320eb66d7e2a3fd874ccf767b2e939641b1ea8eaf";


            List<HexString> list = new List<HexString>
            {
                //list.Add(bdk1);
                bdk2,
                bdk3
            };

            //Primeiro item hexadecimal
            HexString hexString = new HexString("28c06eb41c4dc9c3ae114831efcac7446c8747777fca8b145ecd31ff8480ae88");
            foreach (var item in list)
            {
                hexString ^= item;
            }


            HexString actual = bdk1 ^ bdk2 ^ bdk3;

            Console.WriteLine("Expected: " + expected);
            Console.WriteLine("Actual  : " + actual.ToString().ToLower());
            Console.WriteLine("HexStr  : " + hexString.ToString().ToLower());

            Console.ReadLine();

            Console.WriteLine("Hello World!");
        }
    }
}
