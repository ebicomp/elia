using System;
using System.ComponentModel.DataAnnotations;

namespace EliaGroup.API.Dtos.Assets
{
	public class AssetUpdateDto
	{
        [Required]
        [StringLength(250)]
        public string? Name { get; set; }
        [Required]
        public int AssetTypeId { get; set; }
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
    }
}

