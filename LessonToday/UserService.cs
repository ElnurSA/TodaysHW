using System;
using LessonToday.Models;

namespace LessonToday
{
	public class UserService
	{
        public void ShowUsers()
        {

            var result = GetAllUser();

            foreach (var item in result)
            {
                Console.WriteLine(item.fullName);
            }
        }

        public User GetUserById(int id)
        {
            User[] users = GetAllUser();

            var user = users.FirstOrDefault(m => m.id == id);

            return user;
        }

        public User[] GetAllUser()
        {
            User user1 = new User
            {
                id = 1,
                fullName = "Aqshin Veliyev",
                age = 25
            };

            User user2 = new User
            {
                id = 2,
                fullName = "Haci Ehmadov",
                age = 28
            };

            User user3 = new User
            {
                id = 3,
                fullName = "Metanet Abbasova",
                age = 21
            };

            User user4 = new User
            {
                id = 4,
                fullName = "Meryem Eliyeva",
                age = 23
            };

            User[] people = { user1, user2, user3, user4 };

            return people;

        }
    }
}

