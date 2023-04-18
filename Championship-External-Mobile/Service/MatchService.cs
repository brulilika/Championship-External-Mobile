using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ChampionshipExternalMobile.Model;
using Newtonsoft.Json;
using Xamarin.Essentials;

namespace ChampionshipExternalMobile.Service
{
	public class MatchService : BaseService
    {
		public MatchService()
		{
        }

        public async Task<List<Match>> GetMatches(string userId)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("token", ""));

                URL = $"{URL}getByRefereeId/{userId}";
                HttpResponseMessage resp = await client.GetAsync(URL);

                if (!resp.IsSuccessStatusCode)
                    return new List<Match>();

                List<Match> matches = JsonConvert.DeserializeObject<List<Match>>(resp.Content.ReadAsStringAsync().Result);

                return matches;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<MatchDetail> GetMatchesById(string matchId)
        {
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Preferences.Get("token", ""));

                URL = $"{URL}getMatchById/{matchId}";
                HttpResponseMessage resp = await client.GetAsync(URL);

                if (!resp.IsSuccessStatusCode)
                    return null;

                MatchDetail matchDetail = JsonConvert.DeserializeObject<MatchDetail>(resp.Content.ReadAsStringAsync().Result);

                return matchDetail;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

