using chat_winForm.Client.Api;
using System;

namespace chat_winForm.Service
{
    static class UserService
    {
        static public String Login(String userIdName, String password)
        {
            return UserApi.Login(userIdName, password);
        }
    }
}
