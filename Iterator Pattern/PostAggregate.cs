using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookApplication.Iterator_Pattern;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.Server
{
    internal class PostAggregate
    {
        private readonly FacebookObjectCollection<Post> r_Posts = null;

        public PostAggregate(FacebookObjectCollection<Post> i_Posts)
        {
            this.r_Posts = i_Posts;
        }

        internal IPostIterator GetPostIterator()
        {
            return new FeedIterator(this);
        }

        private class FeedIterator : IPostIterator
        {
            private int m_IteratorPosition = 0;
            private readonly PostAggregate m_Parent;

            internal FeedIterator(PostAggregate i_Parent)
            {
                this.m_Parent = i_Parent;
            }

            public bool MoveNext()
            {
                return (++this.m_IteratorPosition) < this.m_Parent.r_Posts.Count;
            }

            public Post GetCurrent()
            {
                return this.m_Parent.r_Posts[m_IteratorPosition];
            }

            public void Reset()
            {
                this.m_IteratorPosition = 0;
            }
        }
    }
}
