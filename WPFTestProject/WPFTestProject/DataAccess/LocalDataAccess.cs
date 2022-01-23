using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestProject.Common;
using WPFTestProject.DataAccess.DataEntity;
using WPFTestProject.Model;

namespace WPFTestProject.DataAccess
{
    public class LocalDataAccess
    {
        private static LocalDataAccess instance;
        private LocalDataAccess() { }

        public static LocalDataAccess GetInstance()
        {
            return instance ?? (instance = new LocalDataAccess());
        }


        //数据库连接
        SqlConnection conn;
        //数据库命令
        SqlCommand comm;
        //1、表示用于填充 DataSet 和更新 SQL Server 数据库的一组数据命令和一个数据库连接。
        //2、在SqlDataAdapter和DataSet之间没有直接连接。当完成SqlDataAdpater.Fill(DataSet) 调用后，两个对象之间就没有连接了
        SqlDataAdapter adapter;


        //释放资源
        private void Dispose()
        {
            if (adapter != null)
            {
                adapter.Dispose();
                adapter = null;
            }
            if (comm != null)
            {
                comm.Dispose();
                comm = null;
            }
            if (conn != null) {
                conn.Close();
                conn.Dispose();
                conn = null;

            }

        }


        private bool DBConnection()
        {
            //ConfigurationManager  配置管理器
            string connStr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            if (conn == null)
            {
                conn = new SqlConnection(connStr);
            }
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public UserEntity CheckUserInfo(string userName,string password)
        {
            //无数据库情况下测试
            //return new UserEntity("Pthero","123");
            try
            {
                //连接成功
                if (DBConnection())
                {
                    string sqlusers = "select * from users where username = @username and password =@password and is_validation = 1";

                    adapter = new SqlDataAdapter(sqlusers, conn);

                    //通过参数传递防止依赖注入 预编译 
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar) { Value = userName });
                    //adapter.SelectCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = MD5Provider.GetMD5String(password) });
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@password", SqlDbType.VarChar) { Value = password });
                    DataTable usertable = new DataTable();

                    int count = adapter.Fill(usertable);

                    if (count <= 0)
                    {
                        throw new Exception("用户名或密码不正确");
                    }
                    //foreach(DataRow dr in usertable.AsEnumerable()){}
                    DataRow dr = usertable.Rows[0];
                    if (dr.Field<bool>("is_can_login") == false)
                    {
                        throw new Exception("当前用户没有权限访问此平台");
                    }

                    UserEntity user = new UserEntity();
                    user.UserName = dr.Field<string>("username");
                    user.RealName = dr.Field<string>("realname");
                    user.Password = dr.Field<string>("password");
                    user.Avatar = dr.Field<string>("avatar");
                    user.Gender = dr.Field<int>("gender");

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //清理资源
                this.Dispose();
            }
            return null;
        }


        public List<CourseModel> GetCourseList()
        {
            //无数据库情况下测试
            //return new UserEntity("Pthero","123");
            try
            {
                //连接成功
                if (DBConnection())
                {
                    string sqlusers = "select * from courses";

                    adapter = new SqlDataAdapter(sqlusers, conn);

                    DataTable courseTable = new DataTable();

                    int count = adapter.Fill(courseTable);

                    var result = new List<CourseModel>();
                    foreach(DataRow dr in courseTable.AsEnumerable())
                    {
                        CourseModel item = new CourseModel();
                        item.Id = dr.Field<int>("id");
                        item.Name = dr.Field<string>("name");
                        item.Introduce = dr.Field<string>("introduce");
                        item.CoverLink = dr.Field<string>("coverlink");
                        item.Link = dr.Field<string>("link");
                        item.StartDate = dr.Field<DateTime>("startdate");
                        item.EndDate = dr.Field<DateTime>("enddate");
                        item.IsFinished = dr.Field<bool>("isfinished");
                        item.TechType = dr.Field<int>("techtype");
                        result.Add(item);
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //清理资源
                this.Dispose();
            }
            return null;
        }


        public List<TechnologyModel> GetTechnologyList() 
        {
            try
            {
                //连接成功
                if (DBConnection())
                {
                    string sqlusers = "select * from technology";

                    adapter = new SqlDataAdapter(sqlusers, conn);

                    DataTable courseTable = new DataTable();

                    int count = adapter.Fill(courseTable);

                    var result = new List<TechnologyModel>();
                    foreach (DataRow dr in courseTable.AsEnumerable())
                    {
                        TechnologyModel item = new TechnologyModel();
                        item.TechName = dr.Field<string>("name");
                        item.Id = dr.Field<int>("id");
                        result.Add(item);
                    }

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //清理资源
                this.Dispose();
            }
            return null;
        }


        public bool CheckCourseCanFinish(int courseId)
        {
            try
            {
                //连接成功
                if (DBConnection())
                {
                    string sqlusers = "select * from courses where id = @courseId and isfinished = 0";

                    adapter = new SqlDataAdapter(sqlusers, conn);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@courseId", SqlDbType.Int) { Value = courseId });

                    DataTable courseTable = new DataTable();

                    int count = adapter.Fill(courseTable);

                    if (count == 1)
                        return true;


                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                //清理资源
                this.Dispose();
            }
            return false;
        }


        public bool CourseFinish(int courseId)
        {
            try
            {
                if (DBConnection())
                {
                    var sql = "update courses set isfinished = 1 where id = @courseId";
                    adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@courseId", SqlDbType.Int) { Value = courseId });
                    DataTable courseTable = new DataTable();

                    int count = adapter.Fill(courseTable);

                    if (count == 1)
                        return true;


                    return false;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            return false;
        }

        public bool CreateCourse(CourseModel model)
        {
            try
            {
                if (DBConnection())
                {
                    var sql = "insert into courses (name,introduce,link,techtype,coverlink,startdate,enddate,isfinished) values(@name,@introduce,@link,@type,'','2022-01-01','2022-01-01',0);"; 
                    adapter = new SqlDataAdapter(sql, conn);
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.VarChar) { Value = model.Name });
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@introduce", SqlDbType.VarChar) { Value = model.Introduce });
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@link", SqlDbType.VarChar) { Value = "" });
                    adapter.SelectCommand.Parameters.Add(new SqlParameter("@type", SqlDbType.Int) { Value = model.TechType });
                    DataTable courseTable = new DataTable();

                    int count = adapter.Fill(courseTable);

                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                this.Dispose();
            }
            return true;
        }
    }
}
