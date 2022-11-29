using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MovieExternalApi;

namespace MovieSongSearch.Pages
{
    public class MovieApiModel : PageModel
    {
      
        public MovieApi moviesApi;
        static readonly HttpClient client = new HttpClient();
        public async Task OnGet()
        { 
                String s1 = "https://is7024-finalproj-movieflex.azurewebsites.net/movieFlex/top250movies";
               
                var task = client.GetAsync(s1);

                HttpResponseMessage response = task.Result;

                if (response.IsSuccessStatusCode)
                {

                    Task<string> readString = response.Content.ReadAsStringAsync();

                    string jsonString = readString.Result;

                    moviesApi = MovieApi.FromJson(jsonString);

                }
           
        }
      
    }
}
