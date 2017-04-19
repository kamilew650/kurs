using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KURSkonsola.CSharp_Udemy
{
    class Post
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        private uint UpVote;
        private uint DownVote;

        Post()
        {
            UpVote = 0;
            DownVote = 0;
            DateAdded = DateTime.Now;
        }

        public void VoteUp()
        {
            UpVote++;
        }

        public void VoteDown()
        {
            DownVote++;
        }

    }
}
