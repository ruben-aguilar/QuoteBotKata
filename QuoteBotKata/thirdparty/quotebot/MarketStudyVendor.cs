using System;
using System.Windows.Forms;

namespace QuoteBotKata
{
    public class MarketStudyVendor
    {
        public double averagePrice(string blog)
        {
            if(Environment.GetEnvironmentVariable("license") == null)
            {
                MessageBox.Show("Missing license !",
                        "Stupid license", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw new SystemException("");
            }
            return ((double)blog.GetHashCode() * new Random().NextDouble());
        }
    }
}