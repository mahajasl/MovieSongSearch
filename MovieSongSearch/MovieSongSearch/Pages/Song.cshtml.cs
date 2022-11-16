using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static System.Net.WebRequestMethods;
using SongDatabase;

namespace MovieSongSearch.Pages
{
    public class SongModel : PageModel
    {
        private readonly ILogger<SongModel> _logger;
        static readonly HttpClient client = new HttpClient();
        public bool SearchCompleted { get; set; }
        public string Query { get; set; }
        public Song songs;
        public SongModel(ILogger<SongModel> logger)
        {
            _logger = logger;
        }
        public async Task OnGetAsync(string query)
        {
            Query = query;
            if (!string.IsNullOrEmpty(query))
            {
                try
                {
                    SearchCompleted = true;
                    var getSongResponse = client.GetAsync("https://itunes.apple.com/search?term=" + query + "&resultCount=5");
                    HttpResponseMessage response = getSongResponse.Result;
                    if (response.IsSuccessStatusCode)
                    {
                        Task<string> readString = response.Content.ReadAsStringAsync();

                        string songResult = readString.Result;

                        songs = Song.FromJson(songResult);
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
