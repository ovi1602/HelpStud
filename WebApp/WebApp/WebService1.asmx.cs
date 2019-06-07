using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApp
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Ovi\Desktop\proiect\WebApp\WebApp\App_Data\Database1.mdf;Integrated Security=True";
        SqlConnection myCon = new SqlConnection(conn);
        [WebMethod]
        public int logIn(string username, string password, ref int id, ref int isAdmin) {
            myCon.ConnectionString =conn;
            myCon.Open();
            string valString = "SELECT * FROM Users WHERE username = @val0 AND password = @val1";
            SqlCommand comm = new SqlCommand();
            comm.Connection = myCon;
            comm.CommandText = valString;
            comm.Parameters.AddWithValue("@val0", username);
            comm.Parameters.AddWithValue("@val1", password);
            SqlDataReader sdr = comm.ExecuteReader();


            if (sdr.Read())
            {
                sdr.Close();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Users WHERE username = '" + username + "'", myCon);
                int lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand Admin = new SqlCommand("SELECT isAdmin FROM Users WHERE username = '" + username + "'", myCon);
                int IsAdmin = (int)Admin.ExecuteScalar();
                myCon.Close();
                isAdmin = IsAdmin;
                id = lastId;
                return lastId;
            }
            else
                return 0;
        }
        [WebMethod]
        public string addUser(string username, string password, string email,string name)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();

                //Checking if there is already an user with the same username
                string valString = "SELECT * FROM Users WHERE username = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", username);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return "Username already exists";
                }
                sdr.Close();
                string valString2 = "SELECT * FROM Users WHERE email = @val1";
                SqlCommand comm2 = new SqlCommand();
                comm2.Connection = myCon;
                comm2.CommandText = valString2;
                comm2.Parameters.AddWithValue("@val1", email);
                SqlDataReader sdr2 = comm2.ExecuteReader();
                if (sdr2.Read())
                {
                    return "Email already exists!";
                }
                sdr2.Close();

                string commandText = "INSERT INTO Users (Id, username, password, isAdmin, email,name) VALUES (@val0, @val1, @val2, @val3,@val4,@val5)";

                //Next id
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Users", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", username);
                comm.Parameters.AddWithValue("@val2", password);
                comm.Parameters.AddWithValue("@val3", 0);
                comm.Parameters.AddWithValue("@val4", email);
                comm.Parameters.AddWithValue("@val5", name);


                comm.ExecuteNonQuery();
                myCon.Close();
                return "Succesfully registered";
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return xe.ToString();
            }
        }
        [WebMethod]
        public bool makeAdmin(string username)
        {
            myCon.ConnectionString =conn;
            myCon.Open();
            try
            {
                string commandText = "UPDATE Users SET isAdmin = 1 WHERE username = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", username);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        [WebMethod]
        public bool addFaculty(string name)
        {
            string commandText = "INSERT INTO Faculty (Id, name) VALUES (@val0, @val1)";
            try
            {
                myCon.ConnectionString =conn;
                myCon.Open();

                string valString = "SELECT * FROM Faculty WHERE name = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", name);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return false;
                }
                sdr.Close();

                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Faculty", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", name);

                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return false;
            }
        }
        [WebMethod]
        public bool deleteFaculty(string name)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            try
            {
                string commandText = "DELETE FROM Faculty WHERE name = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", name);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }

        }
        [WebMethod]
        public bool updateFaculty(string newName, string oldName)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            try
            {
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Faculty WHERE name = '" + oldName + "'", myCon);
                int idFaculty = (int)IdCommand.ExecuteScalar();
                string commandText = "Update Faculty set name =  @val0 WHERE id = @val1";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newName);
                comm.Parameters.AddWithValue("@val1", idFaculty);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [WebMethod]
        public string addPost(string username , string title, string content, string course, string link)
        {

            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand1 = new SqlCommand("SELECT id FROM Users WHERE username = '" + username + "'", myCon);
                int idUser= (int)IdCommand1.ExecuteScalar();

                SqlCommand IdCommand2 = new SqlCommand("SELECT id FROM Course WHERE name = '" + course + "'", myCon);
                int idCourse = (int)IdCommand2.ExecuteScalar();

                SqlCommand IdCommand3 = new SqlCommand("SELECT idFaculty FROM Course WHERE name = '" + course + "'", myCon);
                int idFac = (int)IdCommand3.ExecuteScalar();

                string commandText = "INSERT INTO Posts (Id, Title, Content, idUser, idFac, idCourse, sourceLink) VALUES (@val0, @val1, @val2, @val3, @val4, @val5, @val6)";

         
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Posts", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", lastId + 1);
                comm.Parameters.AddWithValue("@val1", title);
                comm.Parameters.AddWithValue("@val2", content);
                comm.Parameters.AddWithValue("@val3", idUser);
                comm.Parameters.AddWithValue("@val4", idFac);
                comm.Parameters.AddWithValue("@val5", idCourse);
                comm.Parameters.AddWithValue("@val6", link);

                comm.ExecuteNonQuery();
                myCon.Close();
                return "Post added!";
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return xe.ToString();
            }
        }
        [WebMethod]
        public string editPost(string title, string content,int id)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            try
            {
                    string commandText = "Update Posts set title =  @val0 , content = @val2  WHERE id = @val1";
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = myCon;
                    comm.CommandText = commandText;
                    comm.Parameters.AddWithValue("@val0", title);
                    comm.Parameters.AddWithValue("@val2", content);
                    comm.Parameters.AddWithValue("@val1", id);
                    comm.ExecuteNonQuery();
                
                myCon.Close();
                return "Edited!";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        [WebMethod ]
        public bool DeletePost(string title)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            try
            {
                string commandText = "DELETE FROM Posts WHERE Title = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", title);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [WebMethod]
        public string postedBy(string title)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            SqlCommand IdCommand = new SqlCommand("SELECT idUser FROM Posts WHERE Title = '" + title + "'", myCon);
            int lastId = (int)IdCommand.ExecuteScalar();
            SqlCommand IdCommand2 = new SqlCommand("SELECT username FROM Users WHERE id = '" + lastId + "'", myCon);
            string user = IdCommand2.ExecuteScalar().ToString();
            myCon.Close();
            return user;

        }
        [WebMethod]
        public string addCourse(int year, int semester, string faculty, string name)
        {

            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();

                string valString1 = "SELECT * FROM Faculty WHERE name = @val0";
                SqlCommand comm2 = new SqlCommand();
                comm2.Connection = myCon;
                comm2.CommandText = valString1;
                comm2.Parameters.AddWithValue("@val0", faculty);
                SqlDataReader sdr1 = comm2.ExecuteReader();
                if (!(sdr1.Read()))
                {
                    return "Faculty does not exist! Please insert a valid faculty!";
                }
                sdr1.Close();

                SqlCommand IdCommand1 = new SqlCommand("SELECT id FROM Faculty WHERE name = '" + faculty + "'", myCon);
                int idFac = (int)IdCommand1.ExecuteScalar();

                string valString = "SELECT * FROM Course WHERE name = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", name);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return "Course already exists!";
                }
                sdr.Close();

                string commandText = "INSERT INTO Course (Id, year, semester, name, idFaculty) VALUES (@val5, @val1, @val2, @val3, @val4)";
                int lastId;
                SqlCommand IdCommand = new SqlCommand("SELECT MAX(id) FROM Course", myCon);
                lastId = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val5", lastId + 1);
                comm.Parameters.AddWithValue("@val1", year);
                comm.Parameters.AddWithValue("@val2", semester);
                comm.Parameters.AddWithValue("@val3", name);
                comm.Parameters.AddWithValue("@val4", idFac);

                comm.ExecuteNonQuery();
                myCon.Close();
                return "Course added!";
            }
            catch (SqlException xe)
            {
                myCon.Close();
                return xe.ToString();
            }
        }
        [WebMethod]
        public string editCourseName(string newName, string oldName)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Course WHERE name = '" + oldName + "'", myCon);
                int idCourse = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Course set name =  @val0 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newName);
                comm.Parameters.AddWithValue("@val3", idCourse);

                comm.ExecuteNonQuery();
                myCon.Close();

                return "Edited!";
            }
            catch (Exception xe)
            {
                return xe.ToString();
            }
        }

        [WebMethod]
        public string editCourseYear(int newYear, string oldName)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Course WHERE name = '" + oldName + "'", myCon);
                int idCourse = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Course set year =  @val0 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newYear);
                comm.Parameters.AddWithValue("@val3", idCourse);

                comm.ExecuteNonQuery();
                myCon.Close();

                return "Edited!";
            }
            catch (Exception xe)
            {
                return xe.ToString();
            }
        }
        [WebMethod]
        public string editCourseSemester(int newSem, string oldName)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Course WHERE name = '" + oldName + "'", myCon);
                int idCourse = (int)IdCommand.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Course set semester =  @val0 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newSem);
                comm.Parameters.AddWithValue("@val3", idCourse);

                comm.ExecuteNonQuery();
                myCon.Close();

                return "Edited!";
            }
            catch (Exception xe)
            {
                return xe.ToString();
            }
        }

        [WebMethod]
        public string editCourseFaculty(string newFaculty, string oldName)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Course WHERE name = '" + oldName + "'", myCon);
                int idCourse = (int)IdCommand.ExecuteScalar();

                SqlCommand IdCommand2 = new SqlCommand("SELECT id FROM Faculty WHERE name = '" + newFaculty + "'", myCon);
                int idFac = (int)IdCommand2.ExecuteScalar();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Course set idFaculty =  @val0 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", idFac);
                comm.Parameters.AddWithValue("@val3", idCourse);

                comm.ExecuteNonQuery();
                myCon.Close();

                return "Edited!";
            }
            catch (Exception xe)
            {
                return xe.ToString();
            }
        }
        [WebMethod]
        public bool deleteCourse(string name)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            try
            {
                string commandText = "DELETE FROM Course WHERE name = @val0";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", name);
                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        [WebMethod]
        public DataSet getAllPosts()
        {
            myCon.ConnectionString = conn;
            myCon.Open();

            SqlCommand cmd = new SqlCommand("select title, content from Posts", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Posts");
            return ds;
        }
        [WebMethod]
        public DataSet getAllFaculties()
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();

                SqlCommand cmd = new SqlCommand("select * from Faculty", myCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Faculty");
                myCon.Close();
                return ds;
            }
            catch
            {
                return null;
            }
        }
        [WebMethod]
        public DataSet getAllCourses()
        {
            myCon.ConnectionString = conn;
            myCon.Open();

            //ArrayList arr = new ArrayList();

            SqlCommand cmd = new SqlCommand("select name from Course", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds,"Posts");
            myCon.Close();

            return ds;
        }
        [WebMethod]
        public DataSet getCourse(string facultate, int an, int semestru)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            int idFac;
            try
            {
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Faculty WHERE name = '" + facultate + "'", myCon);
                idFac = (int)IdCommand.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("SELECT name FROM Course WHERE year = @val0 AND semester = @val1 AND idFaculty = @val2", myCon);

                cmd.Parameters.AddWithValue("@val0", an);

                cmd.Parameters.AddWithValue("@val1", semestru);
                cmd.Parameters.AddWithValue("@val2", idFac);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Posts");
                myCon.Close();

                return ds;
            }
            catch
            {
                return null;
            }
        }
        //+
        [WebMethod]
        public bool editName(string newName, string username)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Users set name =  @val0 WHERE username = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newName);
                comm.Parameters.AddWithValue("@val3", username);

                comm.ExecuteNonQuery();
                myCon.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        [WebMethod]
        public string editUsername(string newUsername, string oldUsername)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Users WHERE username = '" + oldUsername + "'", myCon);
                int idUser = (int)IdCommand.ExecuteScalar();

                string valString = "SELECT * FROM Users WHERE username = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", newUsername);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return "Username already exists! Please use another!";
                }
                sdr.Close();

                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Users set username =  @val0 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", newUsername);
                comm.Parameters.AddWithValue("@val3", idUser);

                comm.ExecuteNonQuery();
                myCon.Close();
                return "Username Edited!";
           
            }
            catch 
            {
                return "Error!";
            }
    }
        [WebMethod]
        public string getUsernameById(int id)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT name FROM Users WHERE id = '" + id + "'", myCon);
                string User = (string)IdCommand.ExecuteScalar();
                myCon.Close();
                return User;
            }
            catch {
                myCon.Close();
                return "Unknown"; }
            
        }
        [WebMethod]
        public string editEmail(string newEmail, string username)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Users WHERE username = '" + username + "'", myCon);
                int idUser = (int)IdCommand.ExecuteScalar();

                string valString = "SELECT * FROM Users WHERE email = @val0";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", newEmail);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    return "Email already exists! Please use another!";
                }
                sdr.Close();

                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                string commandText = "Update Users set email =  @val1 WHERE Id = @val3";
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val1", newEmail);
                comm.Parameters.AddWithValue("@val3", idUser);

                comm.ExecuteNonQuery();
                myCon.Close();
                return "Email Edited!";

            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
        [WebMethod]
        public string editPassword(string newPassword, string oldPassword, string username)
        {
            try
            {

                myCon.ConnectionString = conn;
                myCon.Open();

                string valString = "SELECT * FROM Users WHERE password = @val0 AND username = @val2";
                SqlCommand comm1 = new SqlCommand();
                comm1.Connection = myCon;
                comm1.CommandText = valString;
                comm1.Parameters.AddWithValue("@val0", oldPassword);
                comm1.Parameters.AddWithValue("@val2", username);
                SqlDataReader sdr = comm1.ExecuteReader();
                if (sdr.Read())
                {
                    sdr.Close();
                    string commandText = "Update Users set password =  @val1 WHERE username = @val3";
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = myCon;
                    comm.CommandText = commandText;
                    comm.Parameters.AddWithValue("@val1", newPassword);
                    comm.Parameters.AddWithValue("@val3", username);
                    comm.ExecuteNonQuery();
                    return " Password Chaneged!";
                }
                myCon.Close();
                return "You have introduced a wrong password! Please try again!";
            }
            catch(Exception e)
            {
                return e.ToString();
            }
        }
        [WebMethod]
        public string getUserData(string username)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();
                string str;
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE username = '" + username + "'", myCon);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.Read())
                {
                    str = sdr["name"].ToString() + " " + sdr["email"].ToString();
                    return str;
                }
                else
                    return null;
            }
            catch
            {
                return "Error!";
            }
        }
        [WebMethod]
        public string insertImage(byte[] arr, string username)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();

                SqlCommand comm2 = new SqlCommand("Update Users set picture = NULL",myCon);
                comm2.ExecuteNonQuery();
                string commandText = "Update Users set picture=@val0 WHERE username = @val1";
                SqlCommand comm = new SqlCommand();
                comm.Connection = myCon;
                comm.CommandText = commandText;
                comm.Parameters.AddWithValue("@val0", arr);
                comm.Parameters.AddWithValue("@val1", username);
                comm.ExecuteNonQuery();

                myCon.Close();
               return "Image uploaded!";
              
            }
            catch(Exception e)
            {
                myCon.Close();
                return e.ToString();
            }
            
        }
        [WebMethod]
        public byte[] getImage(string username)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();
                SqlCommand cmd = new SqlCommand("Select picture from Users where username='" + username + "'", myCon);
                byte[] img = (byte[])cmd.ExecuteScalar();
                return img;
            }
            catch
            {
                return null;
            }
  
        }
        [WebMethod]
        public DataSet getPostByTitle(string title)
        {
            myCon.ConnectionString = conn;
            myCon.Open();

            SqlCommand cmd = new SqlCommand("select content from Posts where title = '" + title + "'", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Posts");
            return ds;
        }


        [WebMethod]
        public DataSet getComments(string title)
        {
            myCon.ConnectionString = conn;
            myCon.Open();
            SqlCommand IdCommand = new SqlCommand("SELECT id FROM Posts WHERE title = '" + title + "'", myCon);
            int idPost = (int)IdCommand.ExecuteScalar();

            SqlCommand cmd = new SqlCommand("select content, idUser from Commments where idPost = '" + idPost + "'", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Commments");
            return ds;
        }

        [WebMethod]
        public void postComment(string title, int idUser, string content)
        {
            myCon.ConnectionString = conn;
            myCon.Open();


            SqlCommand IdCommand2 = new SqlCommand("SELECT MAX(id) FROM Commments ", myCon);
            int lastId = (int)IdCommand2.ExecuteScalar();


            SqlCommand IdCommand = new SqlCommand("SELECT id FROM Posts WHERE title = '" + title + "'", myCon);
            int idPost = (int)IdCommand.ExecuteScalar();

            SqlCommand cmd = new SqlCommand("INSERT INTO Commments (id, idUser, idPost, content) VALUES (@val4, @val0, @val1, @val2)", myCon);

            cmd.Parameters.AddWithValue("@val0", idUser);

            cmd.Parameters.AddWithValue("@val1", idPost);

            cmd.Parameters.AddWithValue("@val2", content);

            cmd.Parameters.AddWithValue("@val4", lastId+1);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            cmd.ExecuteNonQuery();
        }


        [WebMethod]
        public DataSet getLinkByTitle(string title)
        {
            myCon.ConnectionString = conn;
            myCon.Open();

            SqlCommand cmd = new SqlCommand("select sourceLink from Posts where title = '" + title + "'", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Posts");
            return ds;
        }

        [WebMethod]
        public DataSet getPostById(int id)
        {
            myCon.ConnectionString = conn;
            myCon.Open();

            SqlCommand cmd = new SqlCommand("select content from Posts WHERE id = '" + id + "'", myCon);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Posts");
            return ds;
        }

        [WebMethod]
        public DataSet getTitleByCourse(string course)
        {
            try
            {
                myCon.ConnectionString = conn;
                myCon.Open();

                SqlCommand IdCommand = new SqlCommand("SELECT id FROM Course WHERE name = '" + course + "'", myCon);
                int idCourse = (int)IdCommand.ExecuteScalar();

                SqlCommand cmd = new SqlCommand("select title, content from Posts WHERE idCourse = '" + idCourse + "'", myCon);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "Posts");
                return ds;
            }
            catch
            {
                return null;
            }
        }

    }
}
