
    //Register Tasks
    [HttpPost]
    [Route("api/tasks")]
    public JsonResult RegisterTasks([FromBody] Tasks tk)
    {
       Tasks t=new Tasks();
        return common.RegisterTasks(tk);
    }


    //Get Task ById
    [HttpGet]
    [Route("api/tasksbyid/Input,Id,Status")]
    public JsonResult GetTaskById(TasksId tid)
    {
        return common.GetAllTasks(tid);
    }
 
    // POST: api/UploadImage
    [Route("api/UploadImage")]
    [HttpPost]
    public async Task<JsonResult> UploadImage(ICollection<IFormFile> files)
    {
        ImageParameter imageParameter = new ImageParameter();
        imageParameter.IssueId = 1234;
        imageParameter.ImageType = "Upload";
        return await common.UploadImage(imageParameter, files);
    }
    //Register Employee
    [Route("api/RegisterEmployee")]
    [HttpPost]
    public  JsonResult RegisterEmployee(Login log)
    {
        Login login = new Login();
        login.Username = log.Username;
        login.Password=log.Password;
        return  common.insertusername(log);
    }
    //Get employee for Login
    [HttpGet]
    [Route("api/GetEmployeeLogin")]
    public JsonResult GetEmployeesLogin(string username)
    {
        return common.Get_EmployeesLogin(username);
    }
    //Get All Employee
    [HttpGet]
    [Route("api/EmployeeLogin")]
    public JsonResult GetAllEmployeesLogin()
    {
        return common.GetAllEmployeeLogin();
    }

    // GET: api/EmployeeNames
    [HttpGet]
    [Route("api/GetAllEmployeeNames")]
    public JsonResult GetAllEmployeesNames()
    {
        return common.GetAllEmployeesNames();
    }
    //
   
    // GET: api/EmployeeRoles     
    [HttpGet]
    [Route("api/GetAllEmployeeRoles")]
    public JsonResult GetAllEmployeesRoles()
    {
        return common.GetAllEmployeesRoles();
    }
    
    // GET: api/EmployeeNamesByRole
    [HttpGet]
    [Route("api/GetAllEmployeeNames_ByRole")]
    public JsonResult GetAllEmployeesNames_ByRole(EmployeeRole employeeRole)
    {
        return common.GetAllEmployeesNames_ByRole(employeeRole);
