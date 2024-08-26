using Model.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IService
    {
        
        UserLogin.Return Login(UserLogin.Request request);

    }
}
