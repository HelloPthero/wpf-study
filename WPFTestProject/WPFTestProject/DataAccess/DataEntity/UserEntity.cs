using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTestProject.DataAccess.DataEntity
{
    public class UserEntity
    {
        public string UserName { get; set; }

        public string RealName { get; set; }

        public string Password { get; set; }

        //头像
        public string Avatar { get; set; }

        public int Gender { get; set; }

        //public UserEntity(string name,string password)
        //{
        //    this.UserName = name;
        //    this.Password = password;
        //}
    }
}
