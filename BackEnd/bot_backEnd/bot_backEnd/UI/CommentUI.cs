using bot_backEnd.BL.Interfaces;
using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ModelsWithPictures;
using bot_backEnd.Models.ViewModels;
using bot_backEnd.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI
{
    public class CommentUI : ICommentUI
    {
        private readonly ICommentBL _iCommentBL;
        public CommentUI(ICommentBL iCommentBL)
        {
            _iCommentBL = iCommentBL;
        }
        public List<Comment> getComments()
        {
            return _iCommentBL.getComments();
        }
        public List<AppComment> getAppProposalsByPostId(int postID, int userID)
        {
            return _iCommentBL.getAppProposalsByPostId(postID, userID);
        }

        public AppReply AddComment(Comment comment)
        {
            return _iCommentBL.AddComment(comment);
        }

        public bool DeleteComment(int commentID, int PostID)
        {
            return _iCommentBL.DeleteComment(commentID, PostID);
        }

        public AppComment AddCommentWithImages(CommentWithImages comment)
        {
            return _iCommentBL.AddCommentWithImages(comment).Result.Value;
        }

        public AppComment AddInstitutionComment(InstitutionCommentWithImage comment)
        {
            return _iCommentBL.AddInstitutionComment(comment).Result.Value;
        }

        public bool ChangeCommentText(CommentVM comment)
        {
            return _iCommentBL.ChangeCommentText(comment);
        }
    }
}
