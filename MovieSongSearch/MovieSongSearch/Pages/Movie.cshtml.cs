using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDatabase;

namespace MovieSongSearch.Pages
{
    public class MovieModel : PageModel
    {
        private readonly ILogger<MovieModel> _logger;
        static readonly HttpClient client = new HttpClient();
        
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }
        public Movie movies;
        public MovieModel(ILogger<MovieModel> logger)
        {
            _logger = logger;
        }
        public async Task OnGetAsync(string query)
        {

            Query = query;
            
            if (!string.IsNullOrEmpty(query))
            {
                SearchCompleted = true;
                String s1 = "https://api.themoviedb.org/3/search/movie?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&query=";

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
    }
}
