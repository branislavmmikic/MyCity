using bot_backEnd.Models.AppModels;
using bot_backEnd.Models.DbModels;
using bot_backEnd.Models.ModelsWithPictures;
using bot_backEnd.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bot_backEnd.UI.Interfaces
{
    public interface ICommentUI
    {
        List<Comment> getComments();
        List<AppComment> getAppProposalsByPostId(int postID, int userID);
        AppReply AddComment(Comment comment);
        AppComment AddCommentWithImages(CommentWithImages comment);
        AppComment AddInstitutionComment(InstitutionCommentWithImage comment);
        bool DeleteComment(int commentID, int PostID);
        bool ChangeCommentText(CommentVM comment);
    }
}
