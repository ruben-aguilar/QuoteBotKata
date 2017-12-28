using System;
using System.Windows.Forms;

namespace QuoteBotKata
{
    public class QuotePublisher
    {
        public static QuotePublisher INSTANCE = new QuotePublisher();

        internal void publish(double proposal)
        {
            MessageBox.Show("You've pushed a dummy auction to a real ads platform, the business is upset!", "Big fail!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}