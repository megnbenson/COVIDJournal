using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CovidJournal.Models
{
	//public static class CovidEntryViewModel
	//{

 //       public static Tuple<String, String> Test(CovidEntry[] x)
 //       {
	//		double count = 1000, y = 100;
	//		Random random = new Random();
	//		List<DataPoint> dataPoints = new List<DataPoint>();

	//		for (int i = 0; i < count; i++)
	//		{
	//			y += random.Next(-10, 11);
	//			dataPoints.Add(new DataPoint(i, y));
	//		}

	//		ViewBag.DataPoints = JsonConvert.SerializeObject(dataPoints);

	//	}
 //   }

	//DataContract for Serializing Data - required to serve in JSON format
	[DataContract]
	public class DataPoint
	{
		public DataPoint(double x, double y)
		{
			this.X = x;
			this.Y = y;
		}

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "x")]
		public Nullable<double> X = null;

		//Explicitly setting the name to be used while serializing to JSON.
		[DataMember(Name = "y")]
		public Nullable<double> Y = null;
	}
}

