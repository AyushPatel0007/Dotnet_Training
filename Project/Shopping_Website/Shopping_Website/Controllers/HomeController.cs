using Shopping_Website.IRepository;
using Shopping_Website.Models;
using Shopping_Website.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shopping_Website.Controllers
{
       
    
    public class HomeController : ApiController
    {
        //Shopping_DBEntities db = new Shopping_DBEntities();
         private IUserRepository userrepository = null;
        public HomeController(IUserRepository _userrepository)
        {
            this.userrepository = _userrepository;
        }


        //get all the role name for registration page
        [HttpGet]
        [Route("Home/GetAllRoles")]
        public IHttpActionResult GetAllRoles()
        {

            return Ok(userrepository.GetAllRoles());
        }

        //get the data by id
        [HttpGet]
        [Route("Home/SelectData/{id}")]
        public IHttpActionResult SelectData(int id)
        {

            return Ok(userrepository.SelectData(id)); ;
        }


        //update the user detial
        [HttpPut]
        [Route("Home/UpdateData")]
        public IHttpActionResult UpdateData(UserDetail item)
        {

            return Ok(userrepository.UpdateData(item));
        }




        //get  all user to check the exists at registration time
        [HttpGet]
        [Route("Home/Getalluser")]
        public List<UserDetail> GetAllUser()
        {
            return userrepository.GetAllUser();
        }


        //Insert the user in the user table

        [HttpPost]
        [Route("Home/InsertData")]

        public int InsertData(UserDetail userDetail)
        {
 
            // return userrepository.Insert(userDetail);
          
            return userrepository.InsertData(userDetail);
        }


        //Get the userdetail by user id

        [Route("Home/GetUser/{username}")]
        [HttpGet]
        public  UserDetail GetUser(string username)
        {
           
            return  userrepository.GetUser(username); 
        }


        //get the role detail by id
        [Route("Home/GetRole/{Role}")]
        [HttpGet]
        public string GetRole(int Role)
        {
             
            return userrepository.GetRole(Role);
        }


        //get the id of the role 

        [Route("Home/GetRolebyName/{Role}")]
        [HttpGet]
        public int GetRole(string Role)
        { 
            return userrepository.GetRole(Role);
        }


        //get all the user details 
        [HttpGet]
        [Route("Home/GetAllData")]
        public List<UserDetail> GetAllData()
        {
            
            return userrepository.GetAllData();
        }




    }
}
