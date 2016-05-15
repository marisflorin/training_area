using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_ServiceCentre
{
    public enum Priority
    {
        High,
        Medium,
        Low
    }
    public struct Vehicle
    {
        public string owner;
        public string machineIdNumber;
        public string phoneNumber;
        public Priority priority;
    }
    public class Service
    {
        static void Main(string[] args)
        {
        }
        public static void SetPriority(ref Vehicle[] list)
        {
            int wall1 = 0, wall2 = list.Length - 1;
            int i = 0;
            Vehicle aux;
            while (i <= wall2)
            {
                switch (list[i].priority)
                {
                    case (Priority)0:
                        aux = list[i];
                        Shift(i, wall1, "right", ref list);
                        list[wall1] = aux;
                            ++wall1; ++i;                        
                        break;
                    case (Priority)1:
                        ++i;
                        break;
                    case (Priority)2:
                        aux = list[i];
                        Shift(i, list.Length-1, "left", ref list);
                        list[list.Length-1] = aux;
                        --wall2;                        
                        break;
                }
            }
        }

        public static void Shift(int index, int wall, string direction,ref Vehicle[] list)
        {
            switch (direction)
            {
                case "right":
                    for (int i = index; i > wall; i--)
                        list[i] = list[i - 1];
                    break;
                case "left":
                    for (int i = index; i < wall; i++)
                        list[i] = list[i + 1];
                    break;
            }
        }
    }
}