using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieDatabase;
using Newtonsoft.Json;
using Popularity;

namespace MovieSongSearch.Pages
{
    public class PopularMovieApiModel : PageModel
    {
        static readonly HttpClient client = new HttpClient();
        public PopularMovies popMovie;

        public void OnGet()
        {

            String s1 = "https://api.themoviedb.org/3/movie/popular?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&page=1";

            var task = client.GetAsync(s1);

            HttpResponseMessage response = task.Result;

            if (response.IsSuccessStatusCode)
            {

                Task<string> readString = response.Content.ReadAsStringAsync();

                string jsonString = readString.Result;

                popMovie = PopularMovies.FromJson(jsonString);

            }
        }
        public async Task<string> apiCallAsync()
        {

            String s1 = "https://api.themoviedb.org/3/movie/popular?api_key=ca0f17e030221db0ccc79d1241d7d943&language=en-US&page=1";

            var task = client.GetAsync(s1);

            HttpResponseMessage response = task.Result;

            if (response.IsSuccessStatusCode)
            {

                Task<string> readString = response.Content.ReadAsStringAsync();

                string jsonString = readString.Result;

                popMovie = PopularMovies.FromJson(jsonString);

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
            responseJson = JsonConvert.SerializeObject(popMovie, Formatting.Indented, SerializerNullIgnoreDefaultIgnoreSetting);



            Console.WriteLine(responseJson);
            return responseJson;
        }
    }
}
