using System;
using System.Threading;

namespace StopWatchExercise
{
    public class Post
    {

        public Post(string title, string description, DateTime createdatetime)
        {
            Title = title;
            Description = description;
            CreateDateTime = createdatetime;
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreateDateTime { get; private set; }
        public int Vote { get; set; }

        public void UpVote()
        {
            Vote += 1;
            Console.WriteLine("Add Votes: Vote count " + Vote);
        }
        public void DownVote()
        {
            if (Vote <= 1)
            {
                Vote = 0;
                Console.WriteLine("Votecount is Zero cant remove anymore");
            }
            else
            {
                Vote -= 1;
            }
            Console.WriteLine("Remove Votes: Count: " + Vote);
        }

    }
}