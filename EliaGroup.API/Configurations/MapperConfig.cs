using System;
using AutoMapper;
using EliaGroup.API.Data;
using EliaGroup.API.Dtos.Assets;
using EliaGroup.API.Dtos.AssetTypes;

namespace EliaGroup.API.Configurations
{
	public class MapperConfig:Profile
	{
		public MapperConfig()
		{
			CreateMap<AssetCreateDto, Asset>().ReverseMap();
			CreateMap<AssetUpdateDto, Asset>().ReverseMap();
			CreateMap<Asset, AssetReadOnlyDto>()
				.ForMember(q=>q.AssetTypeName , a=>a.MapFrom(map=>map.AssetType.Type))
				.ReverseMap();

            CreateMap<AssetTypeReadOnlyDto, AssetType>().ReverseMap();

        }
    }
}

