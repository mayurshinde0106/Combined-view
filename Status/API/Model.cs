using System;

namespace TRU.Employee.WebAPI.Models
{
    public class Tasks
    {
        public  int TaskID { get; set; }
        public string TaskName { get; set; } = string.Empty;
        public string Description { get; set; } 
        public string Status { get; set; }
        public DateTime DueDate { get; set; }
        public string Input {  get; set; }
    }
    public class TasksId
    {
        public string Input { get; set; }
        public int? TaskID { get; set; }
        public string Status { get; set; }
    }

    public class TasksStatus
    {

    }

}







///gggggggggggggggggggggggggggggggggggggggggggggggggg

namespace TRU.Employee.WebAPI.Models
{
    public class Login
    {
        public  string Username { get; set; }
        public string Password { get; set; }    
    }
}


///kjsdlfllllllllllllllllllllllllll;

namespace TRU.Employee.WebAPI.Models
{
    public class loginform
    {
        public string username { get; set; }
    }
}
