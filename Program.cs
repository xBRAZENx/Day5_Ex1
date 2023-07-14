using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDay5Ex1
{
    internal class Program
    {
        static ArrayList arrayList;
        public static void Main(string[] args)
        {
            arrayList = new ArrayList();
            arrayList.Add("apple");
            arrayList.Add("banana");
            arrayList.Add("cherry");
            arrayList.Add("date");
            arrayList.Add("elderberry");

            Console.WriteLine("Total number of elements: " + arrayList.Count);
            Program obj= new Program();
            obj.Display();
            obj.search("date");
            obj.insert("fig", 2);
            obj.Display();
            obj.delete("banana");
            obj.Display();
            Console.ReadKey(); 
        }
        public void search(string val)
        {
            Console.WriteLine($"Checking if the ArrayList contains the element \"{val}\"");
            int flag = 0;
            foreach (string item in arrayList) { if (item == val) flag = 1; }
            if (flag == 0) Console.WriteLine($"{val} not found"); else Console.WriteLine($"{val} found");

        }
        public void insert(string val,int pos)
        {
            arrayList.Insert(pos-1,val);
        }
        public void delete(string val)
        {
            arrayList.Remove(val);
        }
        public void Display()
        {
            Console.WriteLine("All elements:\t");
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }

    }
}
