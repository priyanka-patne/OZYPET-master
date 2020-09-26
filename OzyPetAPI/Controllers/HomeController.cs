using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OzyPetAPI.Utilities;

namespace OzyPetAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        [HttpGet]
        public  JsonResult GetCustomer()
        {
            try
            {
                
                DataSet dsMaster = GetAllMasterDetails();
                JsonResponse jsonResponse = new JsonResponse();
                jsonResponse.status = Constants.ResponseStatus.RequestSuccess;
                jsonResponse.message = Constants.ResponseMessage.Success;
            //    string json = JsonConvert.SerializeObject(dsMaster, Formatting.Indented);
                return Json(jsonResponse);

                
            }
            catch
            {
                throw;
            }
        }

        public DataSet GetAllMasterDetails()
        {

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection("DatabaseConnection"))
            {
                SqlCommand sqlComm = new SqlCommand("GetAlllistForHome", conn);
               

                sqlComm.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = sqlComm;

                da.Fill(ds);

                return ds;
            }
        }
       
    

}
}
