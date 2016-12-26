using System.Web.Mvc;
using PairingTest.Web.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using QuestionServiceWebApi;
using System;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Web.Script.Serialization;

namespace PairingTest.Web.Controllers
{
    public class QuestionnaireController : Controller
    {
        static HttpClient client = new HttpClient();
        string url = "http://localhost:50014/api/Questions";
        /* ASYNC ACTION METHOD... IF REQUIRED... */
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            HttpResponseMessage responseMessage = await client.GetAsync(url);
            List<QuestionnaireList> qAndAList = new List<QuestionnaireList>();
            QuestionnaireList question = new QuestionnaireList();

            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                var deserialized = JsonConvert.DeserializeObject<QuestionnaireViewModel>(responseData);
                
                return View(deserialized);
            }
            else
            {                    
                return View("Error");
            }                
        }

        public QuestionnaireController()
        {
            if (!TempData.ContainsKey("isRefresh"))
            {
                client.BaseAddress = new System.Uri(url);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                TempData.Add("isRefresh", true);
            }

        }

        //public ViewResult Index()
        //{
        //    return View(new QuestionnaireViewModel());
        //}
    }
}
