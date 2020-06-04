
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace Xamarinpreparcial2.Models
{
    using Newtonsoft.Json;

    public class Product
    {
        [JsonProperty(PropertyName = "productid")]
        public int ProductId { get; set; }



        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }



        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }
        

    }
}
