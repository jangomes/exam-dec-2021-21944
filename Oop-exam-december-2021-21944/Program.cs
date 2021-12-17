//Janaina Gomes da Silva - 21944 - Exam Oop dec 2021
using System;
using System.Collections.Generic;


namespace Oop_exam_december_2021_21944
{
    class Program
    {
        static List<BuildingCodes> buildingCodes;

        static void Main(string[] args)
        {
            buildingCodes = new List<BuildingCodes>();
            buildingCodes.Add(new BuildingCodes("G56", "Dorset Street", 3));
            buildingCodes.Add(new BuildingCodes("G57", "Parnel Street", 2));
            buildingCodes.Add(new BuildingCodes("G58", "O'Connell Street", 1));
            foreach (BuildingCodes p in buildingCodes)
            {



                buildingCodes.Sort(delegate (BuildingCodes ID1, BuildingCodes ID2)
                {
                    return ID1.BuildingId.CompareTo(ID2.BuildingId);
                });
                buildingCodes.ForEach(delegate (BuildingCodes p)
                {
                    Console.WriteLine(String.Format("{0} {1}", "Code: "+ p.BuildingCode,"Location: " + p.BuildingLocation, "ID: " + p.BuildingId));
                });
            
            
            }
            Console.ReadKey();
        }
    }
}
