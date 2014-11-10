using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace RESTfulClient
{
	public class Service
	{
		WebClient client = new WebClient();
		
		public List<Model> getPerson(string phone, string address)
		{
			NameValueCollection values = new NameValueCollection
			{
			  {"phone", phone}
			};

			byte[] result = client.UploadValues(address, "POST", values);

			string res = Encoding.UTF8.GetString(result);

			return JsonConvert.DeserializeObject<List<Model>>(res);
		}
	}
}