using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EliaGroup.API.Data
{
	public class AssetType
	{
		public int Id { get; set; }
        public string? Type { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
    public class AssetTyepeConfiguration : IEntityTypeConfiguration<AssetType>
    {
        public void Configure(EntityTypeBuilder<AssetType> builder)
        {
            builder.HasMany(q => q.Assets)
                .WithOne(q => q.AssetType)
                .HasForeignKey(q => q.AssetTypeId);

        }
    }
}


