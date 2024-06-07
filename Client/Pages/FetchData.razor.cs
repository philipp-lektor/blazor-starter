using BlazorApp.Shared;
using System.Net.Http.Json;

namespace BlazorApp.Client.Pages
{
    public partial class FetchData
    {
        private WeatherForecast[] forecasts = new WeatherForecast[] { };

        protected override async Task OnInitializedAsync()
        {
            try
            {
                forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("/api/WeatherForecast") ?? new WeatherForecast[] { };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
