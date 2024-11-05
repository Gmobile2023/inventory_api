namespace Inventory.Address.Dtos
{
    public class GetAllDistrictsForExcelInput
    {
		public string Filter { get; set; }

		public string DistrictCodeFilter { get; set; }

		public string DistrictNameFilter { get; set; }

		public int? StatusFilter { get; set; }


		 public string CityCityNameFilter { get; set; }

		 
    }
}