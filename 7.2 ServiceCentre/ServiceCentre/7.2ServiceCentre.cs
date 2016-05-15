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
            while (i <= wall2)
            {
                switch (list[i].priority)
                {
                    case (Priority)0:
                        if (list[wall2].priority == (Priority)2) --wall2;
                        else
                        {
                            if (i > wall1) Swap(ref list[wall1], ref list[i]);
                            ++wall1; ++i;
                        }
                        break;
                    case (Priority)1:
                        ++i;
                        break;
                    case (Priority)2:
                        Swap(ref list[wall2], ref list[i]);
                        --wall2;
                        break;
                }
            }
        }
        public static void Swap(ref Vehicle first, ref Vehicle second)
        {
            Vehicle aux = first;
            first = second;
            second = aux;
        }
    }
}