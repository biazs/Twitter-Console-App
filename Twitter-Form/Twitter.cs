using System;
using System.Windows.Forms;
using TweetManager;

namespace Twitter_Form
{
    public partial class Twitter : Form
    {
        TweetManagerFile tm = new TweetManagerFile();
        public Twitter()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Twitter_Load(object sender, EventArgs e)
        {
            refreshTweets();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            string msg = tm.PostTweet(txtTweet.Text);
            lbStatus.Text = msg;
            refreshTweets();
        }

        void refreshTweets()
        {
            listTweets.Items.Clear();
            string[] tweets = tm.GetTweets();
            int tweetsCount = tm.TweetCounter();
            for (int i = 0; i < tweetsCount; i++)
                listTweets.Items.Add(tweets[i]);

        }
    }
}
