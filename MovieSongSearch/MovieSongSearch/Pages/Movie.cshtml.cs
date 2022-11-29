using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDatabase;
using Newtonsoft.Json;

namespace MovieSongSearch.Pages
{

    public class MovieModel : PageModel
    {
        /*private readonly ILogger<MovieModel> _logger;*/
        static readonly HttpClient client = new HttpClient();

        public bool SearchCompleted { get; set; }
        public string Query { get; set; }
        public Movie movies;
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
        /*public MovieModel()
        {
        }
        public MovieModel(ILogger<MovieModel> logger)
        {
            _logger = logger;
        } */
        public async Task OnGetAsync(string query)
        {

            Query = query;

            if (!string.IsNullOrEmpty(query))
            {
                SearchCompleted = true;
                String s1 = "https://api.themoviedb.org/3/search/movie?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&query=";
                HttpRequestMessage request = new HttpRequestMessage();

                var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();

                string movieApi = config["apikey"];

                request.RequestUri = new Uri("https://api.themoviedb.org/3/search/movie?api_key=" + movieApi + "&language=en-US&query=" + query + "&page=1&include_adult=false");
                String f = s1 + query + "&page=1&include_adult=false";

                var task = client.GetAsync(f);

                HttpResponseMessage response = task.Result;

                if (response.IsSuccessStatusCode)
                {

                    Task<string> readString = response.Content.ReadAsStringAsync();

                    string jsonString = readString.Result;

                    movies = Movie.FromJson(jsonString);

                }
            }
            else
            {
                SearchCompleted = false;
            }
        }
        public async Task<string> apiCallAsync()
        {
            String uriPathToFetchQueryResult = "https://api.themoviedb.org/3/search/movie?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&query=spiderman";
            Console.WriteLine("Hello World");
            var task = client.GetAsync(uriPathToFetchQueryResult);
            HttpResponseMessage response = task.Result;
                        
            if (response.IsSuccessStatusCode)
            {                Task<string> readString = response.Content.ReadAsStringAsync();



                string jsonString = readString.Result;



                movies = Movie.FromJson(jsonString);
            }
               string responseJson = "";
            JsonSerializerSettings SerializerNullIgnoreSetting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            };
            JsonSerializerSettings SerializerNullIgnoreDefaultIgnoreSetting = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Ignore
            };
            responseJson = JsonConvert.SerializeObject(movies, Formatting.Indented, SerializerNullIgnoreDefaultIgnoreSetting);



            Console.WriteLine(responseJson);





            return responseJson;
        }
    }
}
