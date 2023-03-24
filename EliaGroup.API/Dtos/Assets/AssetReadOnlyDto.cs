using System;
using System.ComponentModel.DataAnnotations;

namespace EliaGroup.API.Dtos.Assets
{
	public class AssetReadOnlyDto
	{
        public int Id { get; set; }
        public string? Name { get; set; }
        public int AssetTypeId { get; set; }
        public string? AssetTypeName { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

    }
}

