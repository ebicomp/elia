using System;
using System.ComponentModel.DataAnnotations;
using EliaGroup.API.Data;

namespace EliaGroup.API.Dtos.Assets
{
	public class AssetCreateDto
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

