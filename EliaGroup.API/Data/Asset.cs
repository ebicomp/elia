using System;
using System.ComponentModel.DataAnnotations;

namespace EliaGroup.API.Data
{
	public class Asset
	{
		public int Id { get; set; }
		public string? Name { get; set; }
		public AssetType? AssetType { get; set; }
		public int AssetTypeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
	}
}

