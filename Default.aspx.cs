using RedditSharp;
using RedditSharp.Things;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        try
        {
            //bam
            Reddit reddit = new Reddit("", "", true);
            //user name password
      //      Reddit reddit = new Reddit("", "", true);
            //string accesstoken fuck//

            //pick subreddit
            var subreddit = reddit.GetSubreddit("/r/awakened");
            subreddit.Subscribe();

            //get the last post found
            int postCount = SQLAwake.getIdCount();

            //skip to that last post
            var myposts = subreddit.Posts.Skip(SQLAwake.getIdCount());


            //loop the posts from that last post
            foreach (var post in myposts)
            {
                string title = post.Title;
                  int upvotes = post.Upvotes;
                string selfTextHtml = post.SelfTextHtml;
                string domain = post.Domain;
                //   VotableThing.DistinguishType mypostdis = post.Distinguished;
                DateTime postCreateDate = post.Created;
                int postCommentCount = post.CommentCount;
                Comment[] postComments = post.Comments;
                string authorName = post.AuthorName;
                string postText = post.SelfText;
                string postID = post.Id;

                //insert into DB
                if (SQLAwake.insertAwakened(postID, upvotes, title, domain, postCreateDate, postCommentCount, authorName, postText) == 0)
                {

                }

                //loop comments
                foreach (var comment in postComments)
                {
                    string commentAuthor = comment.Author;
                    DateTime commentCreated = comment.Created;
                    int commentGild = comment.Gilded;
                    int commentScore = comment.Score;
                    int commentVotes = comment.Upvotes;
                    string commentBody = comment.Body;
                    IList<Comment> postCommentsComments = comment.Comments;
                    string parentID = comment.ParentId;
                    string commentID = comment.Id;

                    if (SQLAwake.insertNewComment(parentID, commentID, commentVotes, title, domain, postCreateDate, postCommentCount, commentAuthor, commentBody) == 0)
                    {

                    }

                    foreach (var commentComment in postCommentsComments)
                    {
                        string commentCommentAuthor = commentComment.Author;
                        DateTime commentCommentCreated = commentComment.Created;
                        int commentCommentGild = commentComment.Gilded;
                        int commentCommentScore = commentComment.Score;
                        int commentCommentVotes = commentComment.Upvotes;
                        string commentCommentText = commentComment.Body;
                        IList<Comment> postCommentsCommentsComments = commentComment.Comments;
                        string commentParentID = commentComment.ParentId;
                        string commentCommentID = commentComment.Id;

                        if (SQLAwake.insertNewCommentReply(commentParentID, commentCommentID, commentCommentVotes, title, domain, commentCommentCreated, postCommentCount, commentCommentAuthor, commentCommentText) == 0)
                        {
                        }

                        foreach (var commentCommentComment in postCommentsCommentsComments)
                        {
                            string commentCommentCommentAuthor = commentCommentComment.Author;
                            DateTime commentCommentCommentCreated = commentCommentComment.Created;
                            int commentCommentCommentGild = commentCommentComment.Gilded;
                            int commentCommentCommentScore = commentCommentComment.Score;
                            int commentCommentCommentVotes = commentCommentComment.Upvotes;
                            string commentCommentCommentText = commentCommentComment.Body;
                            IList<Comment> postCommentsCommentsCommentsComments = commentCommentComment.Comments;

                            string commentCommentparentID = commentCommentComment.ParentId;
                            string commentCommentCommentID = commentCommentComment.Id;

                            if (SQLAwake.insertNewCommentReplyReply(commentCommentparentID, commentCommentCommentID, commentCommentCommentVotes, title, domain, commentCommentCommentCreated, postCommentCount, commentCommentCommentAuthor, commentCommentCommentText) == 0)
                            {
                            }

                            foreach (var commentCommentCommentComment in postCommentsCommentsCommentsComments)
                            {
                                string commentCommentCommentCommentAuthor = commentCommentCommentComment.Author;
                                DateTime commentCommentCommentCommentCreated = commentCommentCommentComment.Created;
                                int commentCommentCommentCommentGild = commentCommentCommentComment.Gilded;
                                int commentCommentCommentCommentScore = commentCommentCommentComment.Score;
                                int commentCommentCommentCommentVotes = commentCommentCommentComment.Upvotes;
                                string commentCommentCommentCommentText = commentCommentCommentComment.Body;
                                IList<Comment> postCommentsCommentsCommentsCommentsComments = commentCommentCommentComment.Comments;
                                string commentCommentCommentCommentparentID = commentCommentCommentComment.ParentId;
                                string commentCommentCommentCommentID = commentCommentCommentComment.Id;

                                if (SQLAwake.insertNewCommentReplyReplyReply(commentCommentCommentCommentparentID, commentCommentCommentCommentID, upvotes, title, domain, commentCommentCommentCommentCreated, postCommentCount, commentCommentCommentCommentAuthor, commentCommentCommentCommentText) == 0)
                                {
                                }


                                foreach (var commentCommentCommentCommentComment in postCommentsCommentsCommentsCommentsComments)
                                {
                                    string commentCommentCommentCommentCommentAuthor = commentCommentCommentCommentComment.Author;

                                    DateTime commentCommentCommentCommenttCommentCreated = commentCommentCommentCommentComment.Created;
                                    int commentCommentCommentCommenttCommentGild = commentCommentCommentCommentComment.Gilded;
                                    int commentCommentCommentCommenttCommentScore = commentCommentCommentCommentComment.Score;
                                    int commentCommentCommentCommenttCommentVotes = commentCommentCommentCommentComment.Upvotes;
                                    string commentCommentCommentCommentCommentText = commentCommentCommentCommentComment.Body;
                                    IList<Comment> postCommentsCommentsCommentstCommentCommentsComments = commentCommentCommentCommentComment.Comments;

                                    string commentCommentCommenttCommentCommentparentID = commentCommentCommentCommentComment.ParentId;
                                    string commentCommentCommentCommenttCommentID = commentCommentCommentCommentComment.Id;

                                    if (SQLAwake.insertNewCommentReplyReplyReplyReply(commentCommentCommenttCommentCommentparentID, commentCommentCommentCommenttCommentID, commentCommentCommentCommenttCommentVotes, title, domain, commentCommentCommentCommenttCommentCreated, postCommentCount, commentCommentCommentCommentCommentAuthor, commentCommentCommentCommentCommentText) == 0)
                                    {

                                    }

                                    foreach (var commentCommentCommentCommentCommentComment in postCommentsCommentsCommentstCommentCommentsComments)
                                    {
                                        string commentCommentCommentCommentCommentCommentAuthor = commentCommentCommentCommentCommentComment.Author;

                                        DateTime commentCommentCommentCommentCommentCommentCreated = commentCommentCommentCommentCommentComment.Created;
                                        int commentCommentCommentCommenCommentCommentGild = commentCommentCommentCommentCommentComment.Gilded;
                                        int commentCommentCommentCommentCommentCommentScore = commentCommentCommentCommentCommentComment.Score;
                                        int commentCommentCommentCommentCommentCommentVotes = commentCommentCommentCommentCommentComment.Upvotes;
                                        string commentCommentCommentCommentCommentCommentText = commentCommentCommentCommentCommentComment.Body;

                                        string commentCommentCommentCommentCommentParentID = commentCommentCommentCommentCommentComment.ParentId;
                                        string commentCommentCommentCommentCommentID = commentCommentCommentCommentCommentComment.Id;

                                        if (SQLAwake.insertNewCommentReplyReplyReplyReplyReply(commentCommentCommentCommentCommentParentID, commentCommentCommentCommentCommentID, commentCommentCommentCommentCommentCommentVotes, title, domain, commentCommentCommentCommentCommentCommentCreated, postCommentCount, commentCommentCommentCommentCommentCommentAuthor, commentCommentCommentCommentCommentCommentText) == 0)
                                        {

                                        }

                                       IList<Comment> postCommentsCommentsCommentstCommentCommentsCommentsComments = commentCommentCommentCommentCommentComment.Comments;

                                        foreach (var commentCommentCommentCommentCommentsCommentsComment in postCommentsCommentsCommentstCommentCommentsCommentsComments)
                                        {
                                            string commentCommentCommentCommentCommentCommentCommentAuthor = commentCommentCommentCommentCommentsCommentsComment.Author;

                                            DateTime commentCommentCommentCommentCommentCommentCommentCreated = commentCommentCommentCommentCommentsCommentsComment.Created;
                                            int commentCommentCommentCommenCommentCommentCommentGild = commentCommentCommentCommentCommentsCommentsComment.Gilded;
                                            int commentCommentCommentCommentCommentCommentCommentScore = commentCommentCommentCommentCommentsCommentsComment.Score;
                                            int commentCommentCommentCommentCommentCommentCommentVotes = commentCommentCommentCommentCommentsCommentsComment.Upvotes;
                                            string commentCommentCommentCommentCommentCommentCommentText = commentCommentCommentCommentCommentsCommentsComment.Body;

                                            string commentCommentCommentCommentCommentCommentParentID = commentCommentCommentCommentCommentsCommentsComment.ParentId;
                                            string commentCommentCommentCommentCommentCommentID = commentCommentCommentCommentCommentsCommentsComment.Id;

                                            if (SQLAwake.insertNewCommentReplyReplyReplyReplyReplyReply(commentCommentCommentCommentCommentCommentParentID, commentCommentCommentCommentCommentCommentID, commentCommentCommentCommentCommentCommentCommentVotes, title, domain, postCreateDate, postCommentCount, commentCommentCommentCommentCommentCommentCommentAuthor, commentCommentCommentCommentCommentCommentCommentText) == 0)
                                            {

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        catch
        {


        }

    }


}