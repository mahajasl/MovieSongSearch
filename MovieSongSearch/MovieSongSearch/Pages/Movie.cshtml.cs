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
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
        }
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
                try {
                    var getMovieResponse = client.GetAsync("https://api.themoviedb.org/3/search/movie?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&query=" + query + "&page=1&include_adult=false");
                    HttpResponseMessage response = getMovieResponse.Result;

                    if (response.IsSuccessStatusCode)
                    {

                        Task<string> readString = response.Content.ReadAsStringAsync();

                        string movieResult = readString.Result;

                        movies = Movie.FromJson(movieResult);

                    }

                } catch(Exception ex)
                {
                    Console.WriteLine("\nException Caught!");
                    Console.WriteLine("Message :{0} ", ex.Message);
                }
                
            }
            else
            {
                SearchCompleted = false;
            }
        }
    }
}
