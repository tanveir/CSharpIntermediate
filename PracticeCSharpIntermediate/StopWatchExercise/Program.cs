using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //StopWatch Class call
//            Console.WriteLine("Press any key to Start/Stop, Esc to Terminate");
//            var stopwatch = new Stopwatch();
//            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
//            {
//                stopwatch.OnOff();
//            }

            //Post Class Call
            var post = new Post("new title","new desc",DateTime.Now);
            //post.Description = "new description"
            post.DownVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.UpVote();
            post.DownVote();
            Console.WriteLine("Post Title: "+post.Title);
            Console.WriteLine("Post Desc: "+post.Description);
            Console.WriteLine("Post date: "+post.CreateDateTime);
            Console.WriteLine("Post vote level: "+post.Vote);
            



        }
    }
}
