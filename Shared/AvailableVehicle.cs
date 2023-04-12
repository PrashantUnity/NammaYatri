using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NammaYatri.Shared
{
	public class AvailableVehicle
	{
		[Key]
		public string Id { get; set; }
		public VechileType VechileTypes { get; set; }
		public string StartTime { get; set; } = string.Empty;
		public string ReachTime { get; set; } = string.Empty;
		public string VehicleNumber { get; set; } = string.Empty;
		public float TotalDistance { get; set; }
		public double CostPerKm { get; set; }
		public double TotalCost { get; set; }
	}
}
