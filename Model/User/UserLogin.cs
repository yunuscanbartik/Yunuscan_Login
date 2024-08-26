using System;
using System.Collections.Generic;
using System.Text;

namespace Model.User
{
    public class UserLogin
    {
        public class Request : BaseRequest // kullanıcıdan istediğimiz
        {
            public string UserName { get; set; }
            public string UserPassword { get; set; }
        }
        public class Return : BaseResponse // kullanıcıdan bize geri gelen data
        {
            public ReturnData Data { get; set; }
        }
        public class ReturnData // sql den yada manuel veriler girilir
        {
            public string UserName {  get; set; }
            public string UserPassword { get; set; }

        }
    }
}
