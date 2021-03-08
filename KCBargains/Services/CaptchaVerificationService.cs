using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace KCBargains.Services
{
    public class CaptchaVerificationService
    {
        private CaptchaSettings captchaSettings;
        private ILogger<CaptchaVerificationService> logger;

        public string ClientKey => captchaSettings.ClientKey;

        public CaptchaVerificationService(IOptions<CaptchaSettings> captchaSettings, ILogger<CaptchaVerificationService> logger)
        {
            this.captchaSettings = captchaSettings.Value;
            this.logger = logger;
        }

        public async Task<bool> IsCaptchaValid(string token)
        {
            var result = false;

            var googleVerificationUrl = "https://www.google.com/recaptcha/api/siteverify";

            try
            {
                using var client = new HttpClient();

                var response = await client.PostAsync($"{googleVerificationUrl}?secret={captchaSettings.ServerKey}&response={token}", null);
                var jsonString = await response.Content.ReadAsStringAsync();
                var captchaVerfication = JsonConvert.DeserializeObject<CaptchaVerificationResponse>(jsonString);

                result = captchaVerfication.success;
            }
            catch (Exception e)
            {
                // fail gracefully, but log
                logger.LogError("Failed to process captcha validation", e);
            }

            return result;
        }

        internal class CaptchaVerificationResponse
        {
            [JsonProperty]
            internal bool success { get; set; }
            [JsonProperty]
            internal DateTime challenge_ts { get; set; }  // timestamp of the challenge load (ISO format yyyy-MM-dd'T'HH:mm:ssZZ)
            [JsonProperty]
            internal string hostname { get; set; }        // the hostname of the site where the reCAPTCHA was solved
            [JsonProperty]
            internal string[] error_codes { get; set; }   // optional
        }
    }
}
