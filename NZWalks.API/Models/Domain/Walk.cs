﻿using System;
namespace NZWalks.API.Models.Domain
{
	public class Walk
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public double LengthInKm { get; set; }
		public string? WalkImageUrl { get; set; }

		//Foreign Keys
		public Guid DifficultyId { get; set; }
		public Guid RegionId { get; set; }


		// One-to-One Navigation for difficulty and region
		public Difficulty Difficulty { get; set; }
		public Region Region { get; set; }

	}
}

