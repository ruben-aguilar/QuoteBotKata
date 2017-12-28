using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace QuoteBotKata.quotebot
{
    public class TechBlogs
    {
        public static List<string> listAllBlogs()
        {
            try
            {
                Thread.Sleep(5000);// Access to DB are very slow
            } catch (ThreadInterruptedException e)
            {
                MessageBox.Show(e.Message, "Unexpected ecxeptoin", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return new List<string> { "HackerNews", "Reddit", "TechCrunch", "BuzzFeed",
                "TMZ", "TheHuffPost", "GigaOM" };
        }
    }
}