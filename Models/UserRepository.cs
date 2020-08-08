using Dapper;
using System.Data;

namespace SynergyWebApp.Models
{
    public class UserRepository : IUser
    {
        private readonly IDbConnection _conn;
        public UserRepository(IDbConnection conn)
        {
            _conn = conn;
        }



        // user_id user_name user_email first_name
        public void insertUser(User userToInsert)
        {
            _conn.Execute("INSERT INTO user (USER_NAME, USER_EMAIL, FIRST_NAME) VALUES (@user_name, @first_name)",
            new
            {
                user_name = userToInsert.userName,

                first_name = userToInsert.first_name


            });

        }
    }
}
