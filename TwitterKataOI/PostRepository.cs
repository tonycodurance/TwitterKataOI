using System;
using System.Collections.Generic;

namespace TwitterKataOI
{
    public class PostRepository
    {
        private readonly List<Post> _posts;

        public PostRepository()
        {
            if (_posts == null)
                _posts = new List<Post>();
        }

        public virtual void Add(Post post)
        {
            _posts.Add(post);
        }

        public virtual List<Post> GetPosts()
        {
            return _posts;
        }
    }
}