using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedResource.Config
{
    public static class DBConfig
    {
        public static string bucket = "training";
        public static string scope = "store";
    }
    public static class DBCollection
    {
        public static string category = "category";
        public static string product = "product";
        public static string exchange = "exchange";
    }
}
