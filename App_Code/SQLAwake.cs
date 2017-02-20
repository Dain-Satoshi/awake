using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class SQLAwake
{

    public static string connectionstring = "Data Source=ABCDEF;Initial Catalog=awake;Integrated Security=True";

    public SQLAwake()
    {
    }
    public static int insertAwakened(string id, int upvotes, string title,  string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
         string sqlCommand = "INSERT INTO [dbo].[NewPosts] ([id],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[postText]) VALUES(@id, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@id", SqlDbType.NVarChar);
                command.Parameters["@id"].Value = id;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }

    public static int insertNewComment(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string commentText)
    {
      string sqlCommand = "INSERT INTO [dbo].[NewComment] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @commentText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;


                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@commentText", SqlDbType.NVarChar);
                command.Parameters["@commentText"].Value = commentText;

                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }

    public static int insertNewCommentReply(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
      string sqlCommand = "INSERT INTO [dbo].[NewCommentReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title,@domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }

    public static int insertNewCommentReplyReply(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
       string sqlCommand = "INSERT INTO [dbo].[NewCommentReplyReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();

            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())
            }
        }
    }



    public static int getIdCount()
    {
       string sqlCommand = "select count(id) from NewPosts";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();

            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())

                {

                    try
                    {
                        if(reader.Read())
                        {

                            return reader.GetInt32(0);
                        }
                        else
                        {

                            return 0;
                        }

                    }

                    catch
                    {
                        return 0;
                    }// using (SqlDataReader reader = command.ExecuteReader())
                }
            }
        }
    }

    public static int insertNewCommentReplyReplyReply(string parentid, string commentid, int upvotes, string title,string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
        string sqlCommand = "INSERT INTO [dbo].[NewCommentReplyReplyReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();

            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {

                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;

                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }

    public static int insertNewCommentReplyReplyReplyReply(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {

        string sqlCommand = "INSERT INTO [dbo].[NewCommentReplyReplyReplyReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }


    public static int insertNewCommentReplyReplyReplyReplyReply(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
        string sqlCommand = "INSERT INTO [dbo].[NewCommentReplyReplyReplyReplyReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }

    public static int insertNewCommentReplyReplyReplyReplyReplyReply(string parentid, string commentid, int upvotes, string title, string domain, DateTime createTime, int postCommentCount, string authorName, string postText)
    {
        string sqlCommand = "INSERT INTO [dbo].[NewCommentReplyReplyReplyReplyReplyReply] ([parentid],[commentid],[upvotes],[title],[domain],[createTime],[postCommentCount],[authorName],[commentText]) VALUES(@ParentID,@CommentID, @Upvotes, @Title, @domain, @createTime, @postCommentCount, @authorName, @postText)";
        using (SqlConnection con = new SqlConnection(connectionstring))
        {
            con.Open();
            using (SqlCommand command = new SqlCommand(sqlCommand, con))
            {
                command.Parameters.Add("@ParentID", SqlDbType.NVarChar);
                command.Parameters["@ParentID"].Value = parentid;

                command.Parameters.Add("@CommentID", SqlDbType.NVarChar);
                command.Parameters["@CommentID"].Value = commentid;

                command.Parameters.Add("@Upvotes", SqlDbType.Int);
                command.Parameters["@Upvotes"].Value = upvotes;

                command.Parameters.Add("@Title", SqlDbType.NVarChar);
                command.Parameters["@Title"].Value = title;

                command.Parameters.Add("@domain", SqlDbType.NVarChar);
                command.Parameters["@domain"].Value = domain;

                command.Parameters.Add("@createTime", SqlDbType.DateTime2);
                command.Parameters["@createTime"].Value = createTime;

                command.Parameters.Add("@postCommentCount", SqlDbType.Int);
                command.Parameters["@postCommentCount"].Value = postCommentCount;

                command.Parameters.Add("@authorName", SqlDbType.NVarChar);
                command.Parameters["@authorName"].Value = authorName;

                command.Parameters.Add("@postText", SqlDbType.NVarChar);
                command.Parameters["@postText"].Value = postText;
                try
                {
                    return command.ExecuteNonQuery();
                }

                catch
                {
                    return 0;
                }// using (SqlDataReader reader = command.ExecuteReader())

            }
        }
    }


}