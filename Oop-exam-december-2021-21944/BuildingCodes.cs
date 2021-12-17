//Janaina Gomes da Silva - 21944 - Exam Oop dec 2021


namespace Oop_exam_december_2021_21944
{
    public class BuildingCodes
    {
        public BuildingCodes() { }

        public string BuildingCode { get; set; }
        public string BuildingLocation { get; set; }
        public int BuildingId { get; set; }

       

        public BuildingCodes(string BuildingCode, string BuildingLocation, int BuildingId)
        {
            this.BuildingId = BuildingId;
            this.BuildingCode = BuildingCode;
            this.BuildingLocation = BuildingLocation;
        }
    }



}
