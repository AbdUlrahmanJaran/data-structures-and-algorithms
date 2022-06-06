using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_structures_project
{
    public class Bucket
    {
        public string key;
        public string value;
        public Bucket Next;
        public Bucket(string key, string value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
