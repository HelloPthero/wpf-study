using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTestProject.Common;
using WPFTestProject.DataAccess.DataEntity;

namespace WPFTestProject.Model
{
    public class UserModel:BaseNotify
    {
        private string _avatar;

        public string Avatar 
        {
            get { return _avatar; }
            set { _avatar = value; this.DoNotify(); }
        }

        private string _userName;

        public string UserName
        {   
            get { return _userName; }
            set { _userName = value; this.DoNotify(); }
        }

        private int _gender;

        public int Gender
        {
            get { return _gender; }
            set { _gender = value; this.DoNotify(); }
        }

        public UserModel(UserEntity user)
        {
            Avatar = user.Avatar;
            UserName = user.UserName;
            Gender = user.Gender;

        }

    }
}
