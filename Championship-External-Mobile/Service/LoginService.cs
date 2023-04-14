using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ChampionshipExternalMobile.Model.Request;
using ChampionshipExternalMobile.Model.Response;
using Newtonsoft.Json;

namespace ChampionshipExternalMobile.Service
{
	public class LoginService : BaseService
    {
		public LoginService()
		{
		}

        public async Task<string> Login(LoginRequest loginRequest)
        {
            try
            {
                var json = JsonConvert.SerializeObject(loginRequest);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();

                URL = $"{URL}api/user/login";
                var resp = await client.PostAsync(URL, content);

                if (!resp.IsSuccessStatusCode)
                    return null;

                var login = JsonConvert.DeserializeObject<LoginResponse>(resp.Content.ReadAsStringAsync().Result);
                return login.token;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

