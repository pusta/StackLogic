using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace exercise_stackoverflow
{
    class StackLogic
    {
        /*
         * 
         * set private variables for the class 
         * 
         * 
         */
        private int _upvote;
        private int _downvote;
        private string _posttitle;
        private string _postcontent;


        //Class Constructor, used here to build the post content for demo pourposes
        public StackLogic()
        {
            _posttitle = "This is my post title!";
            _postcontent = "I'm learning to use classes, I hope this works!";
        }

        //Keep track of the overall post score.  Protect the Set so it cannot be changed outside of the class
        public int PostScore { get; private set; }
        
        //returns post title
        public string PostTitle()
        {
            return _posttitle;
        }

        //returns post content
        public string PostContent()
        {

            return _postcontent;
        }

        //Processes an upvote
        public void UpVote()
        {

            _upvote += 1;
            PostScore += 1;


        }

        //processes a downvote
        public void DownVote()
        {
            _downvote += 1; 
            PostScore -= 1;


        }
        //Returns the current upvote count
        public int GetUpVote()
        {
            return _upvote;

        }

        //Returns the current downvote count
        public int GetDownVote()
        {
            return _downvote;

        }

    }
}
