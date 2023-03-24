using System;
namespace EliaGroup.API.Dtos.Assets
{
	public class AssetQuery
	{
		public string FromDate { get; set; }
		public string ToDate { get; set; }
		public string AssetName { get; set; }
	}
}

