using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stockTake
{
    public class temp
    {
        public string location { get; set; }
        public string name { get; set; }
        public string quanity { get; set; }
        public string price { get; set; }
        public string categories { get; set; }
        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
