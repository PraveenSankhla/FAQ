using FAQ.Shared;
using System.Net.Http.Json;
using System.Text.Json;
using static System.Net.WebRequestMethods;

namespace FAQ.Client.Services
{
    public interface IFAQ
    {
        Task<List<Filter>> GetTopic();
        Task<List<Filter>> GetCategory();
        Task<List<FAQs>> GetFAQ(FAQs faq);
    }

    public class FAQServices : IFAQ
    {
        private readonly HttpClient httpClient;
        public FAQServices(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<Filter>> GetTopic()
        {
            List<Filter> topics = new List<Filter>();
            try
            {
                topics = await httpClient.GetFromJsonAsync<List<Filter>>("Topic");
                return topics;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Filter>> GetCategory()
        {
            List<Filter> Category = new List<Filter>();
            try
            {
               Category = await httpClient.GetFromJsonAsync<List<Filter>>("Category");
                return Category;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<FAQs>> GetFAQ(FAQs faq)
        {
            List<FAQs> fAQs = new List<FAQs>();
            try
            {
                var response = await httpClient.PostAsJsonAsync("FAQ", faq);

                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    fAQs = await response.Content.ReadFromJsonAsync<List<FAQs>>();
                    //fAQs = JsonSerializer.Deserialize<List<FAQs>>(content);
                    return fAQs;
                }
                else
                {
                    throw new HttpRequestException($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
