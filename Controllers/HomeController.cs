using DictionaryWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Policy;
using System.Web;
using System.Text.Json;


namespace DictionaryWebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        static readonly HttpClient client = new HttpClient();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index(string userword)
        {
            List<Word> searchedWord = null;
            bool InDictionary = false;
            
            //using (StreamReader sr = new("Nun.json"))
            //{
            //    string jsonString = sr.ReadToEnd();
            //    searchedWord = JsonSerializer.Deserialize<List<Word>>(jsonString);
            //    InDictionary = true;
            //}

            if (userword != null)
            {
                userword = userword.Trim();
                userword = userword.ToLower();
                try
                {
                    string response = await client.GetStringAsync($"https://api.dictionaryapi.dev/api/v2/entries/en/{userword.ToLower()}");
                    searchedWord = JsonSerializer.Deserialize<List<Word>>(response);
                    InDictionary = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            ViewBag.SearchedWord = searchedWord;
            ViewBag.InDictionary = InDictionary;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
