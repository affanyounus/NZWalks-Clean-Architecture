using System;
namespace NZWalks.API.Models.Domain
{
	public class Region
	{
		public Region()
		{
		}

		public Region(Guid id, string name, string code, string? regionImageUrl)
		{
			Id = id;
			Name = name;
			Code = code;
			RegionImageUrl = regionImageUrl;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string? RegionImageUrl { get; set; }
	}
}

