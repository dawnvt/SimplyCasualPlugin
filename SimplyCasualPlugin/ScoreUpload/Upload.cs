﻿using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimplyCasualPlugin.ScoreUpload
{
    public class Upload
    {
        public Upload()
        {
            
        }

        private static async Task Main()
        {
            HttpClient client = new HttpClient();
            
            try
            {
                HttpResponseMessage response = await client.PutAsync();
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                
                Console.WriteLine(responseBody);
            }
            
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}