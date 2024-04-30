namespace MeetingApp.Models
{
    public static class Repository
    {
        private static List<UserInfo> _users = new List<UserInfo>();
        public static List<UserInfo> Users{
            get{
                return _users;
            }
        }

        public static void CreateUser(UserInfo user)
        {
            user.Id = _users.Count + 1; 
            _users.Add(user);
        }

        static Repository()
        {
            _users.Add(new UserInfo(){Id = 1, Name = "Görkem", Phone = "543 872 61 77", Email = "gorkemkayas@hotmail.com", WillAttend= "true"});
            _users.Add(new UserInfo(){Id = 2, Name = "Ali", Phone = "433 732 64 12", Email = "aliii_12@hotmail.com", WillAttend= "false"});
            _users.Add(new UserInfo(){Id = 3, Name = "Mehmet", Phone = "170 412 36 56", Email = "mhmtkng01@hotmail.com", WillAttend= "indecisive"});
            _users.Add(new UserInfo(){Id = 4, Name = "Barış", Phone = "543 101 42 72", Email = "marmarisli00047@hotmail.com", WillAttend= "true"});
            _users.Add(new UserInfo(){Id = 5, Name = "Eyüp", Phone = "543 857 10 89", Email = "besyocudayii06@hotmail.com", WillAttend= "true"});
            _users.Add(new UserInfo(){Id = 6, Name = "Gürkan", Phone = "543 645 12 64", Email = "onyekuru1905@hotmail.com", WillAttend= "true"});
        }

        public static UserInfo? GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}