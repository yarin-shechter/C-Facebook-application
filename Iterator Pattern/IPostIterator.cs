using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FacebookApplication.Iterator_Pattern
{
    internal interface IPostIterator
    {
        bool MoveNext();

        Post GetCurrent();

        void Reset();
    }
}
