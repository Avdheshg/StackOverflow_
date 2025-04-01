using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
    public interface ICommentable
    {
        void AddComment(Comment comment);
        List<Comment> GetComments();
    }
}
