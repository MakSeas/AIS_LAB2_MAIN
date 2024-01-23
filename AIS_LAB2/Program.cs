using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AIS_LAB2_AGREGATE;
using AIS_LAB2_ELEMENT;

namespace AIS_LAB2
{
    internal class Program
    {
        public static FixedSizeBranch fixedBranch=new FixedSizeBranch(0,2,"Metal");
        public static FreeSizeBranch freeBranch = new FreeSizeBranch(0, "Metal");

        static void Main(string[] args)
        {
            freeBranch.AddNewDetail(new Detail(0, "Grip", "Wood", 1));
            freeBranch.AddNewDetail(new Detail(1, "Piston", "Metal", 2));

            fixedBranch.AddNewDetail(new Detail(0, "Silencer", "Metal", 1));
            fixedBranch.AddNewDetail(new Detail(1, "Foregrip", "Wood", 1));

            Console.WriteLine("Инициализировано");

            BranchHandling.GetFirstDetail(freeBranch); 
            BranchHandling.GetNextDetail(freeBranch);
        }
    }

    public static class BranchHandling
    {
        static int currentDetailIndex = 0;
        public static void GetFirstDetail(Branch theBranch)
        {
            Detail theDetail;

            if (theBranch.details.Count > 0)
                theDetail = theBranch.details[0];
            else 
                theDetail = null;

            Console.WriteLine($"Первая деталь - {theDetail.name}");
        }

        public static void GetNextDetail(Branch theBranch)
        {
            Detail theDetail;

            if (theBranch.details.Count > 1)
            {
                theDetail = theBranch.details[currentDetailIndex + 1];

                currentDetailIndex++;
            }
            else
                theDetail = null;

            Console.WriteLine($"Следующая деталь - {theDetail.name}");
        }
    }
}
