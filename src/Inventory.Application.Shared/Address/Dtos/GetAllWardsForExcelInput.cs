namespace Inventory.Address.Dtos
{
    public class GetAllWardsForExcelInput
    {
		public string Filter { get; set; }

		public string WardCodeFilter { get; set; }

		public string WardNameFilter { get; set; }

		public int? StatusFilter { get; set; }


		 public string DistrictDistrictNameFilter { get; set; }

		 
    }
}