using Model.User;
using Service.Interfaces;
using System;
using System.Data.SqlClient;
using System.Net;

namespace Service
{
    public class UserService : IService
    {

        public UserLogin.Return Login(UserLogin.Request request)
        {
            UserLogin.Return result = new UserLogin.Return()
            {
                Data = null,
                ErrorCode = null,
                ResponseMessage = null,
                Status = false,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };

            SqlConnection sqlConnection = new SqlConnection("11111111111111");

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select UserName, UserPassword from User", sqlConnection);
            var reader = sqlCommand.ExecuteReader();
            UserLogin.ReturnData returnData = new UserLogin.ReturnData();
            if (reader.Read())
            {
                returnData.UserName = reader["UserName"].ToString().Trim();
                returnData.UserPassword = reader["UserPassword"].ToString().Trim();
            }
            if (returnData.UserPassword == request.UserPassword && returnData.UserName == request.UserName)
            {
                result.Status = true;
                result.StatusCode = System.Net.HttpStatusCode.OK;
            }


            return result;
        }
    }
}
