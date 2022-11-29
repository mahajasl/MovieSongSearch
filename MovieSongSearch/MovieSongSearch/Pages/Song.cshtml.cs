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
                SearchCompleted = true;
                String s1 = "https://itunes.apple.com/search?term=";
                String f = s1 + query + "&resultCount=5";
                var task = client.GetAsync(f);
                HttpResponseMessage response = task.Result;
                if (response.IsSuccessStatusCode)
                {
                    Task<string> readString = response.Content.ReadAsStringAsync();

                    string getMusicDetails = readString.Result;

                    songs = Song.FromJson(getMusicDetails);
                }

            }
            else
            {
                SearchCompleted = false;
            }

        }
    }
}
