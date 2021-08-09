namespace StackOverflow
{
    public class Vote
    {
        static int TotalVote;

        public Vote(int totalVote = 0)
        {
            totalVote = TotalVote;
        }

        public void UpVote()
        {
            TotalVote++;
        }

        public void DownVote()
        {
            TotalVote--;
        }


    }
}