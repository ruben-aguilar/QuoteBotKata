using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuoteBotKata.quotebot
{
    class AdSpace
    {
        private static Dictionary<String, List<String>> cache = new Dictionary<string, List<string>>();

        public static List<String> AdSpaces
        {
            get
            {
                if(cache.ContainsKey("blogs list"))
                {
                    return cache["blogs list"];
                }

                //FIXME: only return blogs that start with a 'T'
                List<String> listAllBlogs = TechBlogs.listAllBlogs();
                cache["blogs list"] = listAllBlogs;
                return listAllBlogs;
            }
        }
    }
}
