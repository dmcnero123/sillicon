using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sillicon.Integration.jsonplaceholder.User
{
    public class Usuarioss
    {
       public int Id { get; set; }
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Avatar { get; set; }
    }
    /*
     public class UserResponse
    {
        public int Page { get; set; }
        public int PerPage { get; set; }
        public int Total { get; set; }
        public int TotalPages { get; set; }
        public List<User> Data { get; set; }
    }*/

}
