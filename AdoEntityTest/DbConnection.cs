using System;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Threading.Tasks;
using AdoEntityTest.Entity;
using Ado.Entity;

namespace AdoEntityTest
{
   
    class DbConnection
    {
        string connectionString = "Data Source=DESKTOP-I6BQDAR\\SQLEXPRESS;Initial Catalog=AdoEntityTest;Integrated Security=True";
        private IConnection connection;
        public DbConnection()
        {
            connection = new Connection(connectionString);
            
            
        }
        internal void getusers()
        {
            var result = connection.GetDataByQuery<Users>("select * from Users");
        }
        internal bool AddUser()
        {
            Users user = new Users
            {
                Id=11,
                Name="Nihar M",
                IsActive=true,
                Salary=15767.28,
                Age=29,
                DOB=DateTime.Now.AddYears(-29)

            };
            return connection.AddEntry<Users>(user);
        }
        internal void AddUserList()
        {
            Users user = new Users
            {
                Id = 12,
                Name = "Sarkar",
                IsActive = true,
                Salary = 19867.28,
                Age = 29,
                DOB = DateTime.Now.AddYears(-29)

            };
            List<Users> userList = new List<Users>();
            userList.Add(user);
            var result = connection.AddEntry<Users>(userList);
        }
        internal void UpdateUser()
        {
            var data = connection.GetDataByQuery<Users>("select * from Users");
            var user=data.FirstOrDefault();
            user.IsActive = false;
            var result=connection.UpdateEntry<Users>(user);
        }
        internal void UpdateUserList()
        {
            var data = connection.GetDataByQuery<Users>("select * from Users");
            data.LastOrDefault().IsActive = false;
            var result = connection.UpdateEntry<Users>(data);
        }
    }
}
