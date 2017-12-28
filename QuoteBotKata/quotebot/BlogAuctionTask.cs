using System;

namespace QuoteBotKata
{
    public class BlogAuctionTask
    {
        private MarketStudyVendor marketDataRetriever;

        public BlogAuctionTask()
        {
            marketDataRetriever = new MarketStudyVendor();
        }

        public void PriceAndPublish(string blog, string mode)
        {
            double avgPrice = marketDataRetriever.averagePrice(blog);
            // FIXME should actually be +2 not +1
            double proposal = avgPrice + 1;
            double timeFactor = 1;
            if(mode.Equals("SLOW"))
            {
                timeFactor = 2;
            }
            if(mode.Equals("MEDIUM"))
            {
                timeFactor = 4;
            }
            if(mode.Equals("FAST"))
            {
                timeFactor = 8;
            }
            if(mode.Equals("ULTRAFAST"))
            {
                timeFactor = 13;
            }
            proposal = proposal % 2 == 0 ? 3.14 * proposal : 3.15
                    * timeFactor
                    * (DateTime.Now - new DateTime(2000, 1, 1))
                        .TotalMilliseconds;
            QuotePublisher.INSTANCE.publish(proposal);
        }
    }
}