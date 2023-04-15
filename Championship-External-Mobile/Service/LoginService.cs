using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using ChampionshipExternalMobile.Model;
using ChampionshipExternalMobile.Model.Request;
using ChampionshipExternalMobile.Model.Response;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace ChampionshipExternalMobile.Service
{
	public class LoginService : BaseService
    {
		public LoginService()
		{
            URL = $"{URL}api/user/";
        }

        public async Task<bool> Login(LoginRequest loginRequest)
        {
            try
            {
                string json = JsonConvert.SerializeObject(loginRequest);
                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient client = new HttpClient();

                URL = $"{URL}login";
                HttpResponseMessage resp = await client.PostAsync(URL, content);

                if (!resp.IsSuccessStatusCode)
                    return false;

                LoginResponse login = JsonConvert.DeserializeObject<LoginResponse>(resp.Content.ReadAsStringAsync().Result);

                var secretKey = "+KbPeShVkYp3s6v9y$B&E)H@McQfTjWn";
                var jwtDecoded = JWT.JsonWebToken.DecodeToObject<TokenStructure>(login.token, secretKey);

                Preferences.Set("Username", loginRequest.email);
                Preferences.Set("Password", loginRequest.password);
                Preferences.Set("token", login.token);
                Preferences.Set("userId", jwtDecoded.userId);

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<User> GetUserById(string userId)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("token", ""));

                URL = $"{URL}{userId}";
                HttpResponseMessage resp = await client.GetAsync(URL);

                if (!resp.IsSuccessStatusCode)
                    return null;

                User user = JsonConvert.DeserializeObject<User>(resp.Content.ReadAsStringAsync().Result);

                return user;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

