using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTfulClient
{
	public class Model
	{
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("phone")]
		public string Phone { get; set; }
		[JsonProperty("person")]
		public string Person { get; set; }
		[JsonProperty("street")]
		public string Street { get; set; }
		[JsonProperty("building")]
		public string Building { get; set; }
		[JsonProperty("appartment")]
		public string Appartment { get; set; }
	}
}
