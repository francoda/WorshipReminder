using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WR.Models
{
    class DriveModel
    {
        //Credenciales API Drive
        private const string client_id = "968171515872-i5cl597a4cutvf57eei4575rj1tmt0nf.apps.googleusercontent.com";
        private const string client_secret = "WsrHeWGM4s_-Mzphnj4YP4Lm";

        public static string Access_token { get; set; }
        public static string Refresh_token { get; set; }

        public static async void AutorizateAsync()
        {
            // Generates state and PKCE values.
            string state = randomDataBase64url(32);
            string code_verifier = randomDataBase64url(32);
            string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
            // Creates a redirect URI using an available port on the loopback address.
            string redirectURI = $"http://{IPAddress.Loopback}:{GetRandomUnusedPort()}/";
            // Creates an HttpListener to listen for requests on that redirect URI.
            var http = new HttpListener();
            http.Prefixes.Add(redirectURI);
            http.Start();
            // Creates the OAuth 2.0 authorization request.
            string authorizationRequest = $"https://www.googleapis.com/oauth2/v1/certs?response_type=code&" +
                $"scope=openid%20profile&redirect_uri={Uri.EscapeDataString(redirectURI)}&client_id={client_id}&" +
                $"state={state}&code_challenge={code_challenge}&code_challenge_method=S256";
            // Opens request in the browser.
            System.Diagnostics.Process.Start(authorizationRequest);
            // Waits for the OAuth authorization response.
            var context = await http.GetContextAsync();
            // Sends an HTTP response to the browser.
            var response = context.Response;
            string responseString = string.Format("<html><head><meta http-equiv='refresh' content='10;" +
                "url=https://google.com'></head><body>Please return to the app.</body></html>");
            var buffer = Encoding.UTF8.GetBytes(responseString);
            response.ContentLength64 = buffer.Length;
            var responseOutput = response.OutputStream;
            Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
            {
                responseOutput.Close();
                http.Stop();
                Console.WriteLine("HTTP server stopped.");
            });
            // Checks for errors.
            if (context.Request.QueryString.Get("error") != null)
                return;
            if (context.Request.QueryString.Get("code") == null
                || context.Request.QueryString.Get("state") == null)
                return;
            // extracts the code
            var code = context.Request.QueryString.Get("code");
            var incoming_state = context.Request.QueryString.Get("state");
            // Compares the receieved state to the expected value, to ensure that
            // this app made the request which resulted in authorization.
            if (incoming_state != state)
                return;
            // Starts the code exchange at the Token Endpoint.
            PerformCodeExchange(code, code_verifier, redirectURI);
        }

        private static int GetRandomUnusedPort()
        {
            var listener = new System.Net.Sockets.TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }
        private async static void PerformCodeExchange(string code, string code_verifier, string redirectURI)
        {
            // builds the request
            string tokenRequestBody = $"code={code}&redirect_uri={Uri.EscapeDataString(redirectURI)}&client_id={client_id}&" +
                $"code_verifier={code_verifier}&client_secret={client_secret}&scope=&grant_type=authorization_code";
            // sends the request
            HttpWebRequest tokenRequest = (HttpWebRequest)WebRequest.Create("https://www.googleapis.com/oauth2/v4/token");
            tokenRequest.Method = "POST";
            tokenRequest.ContentType = "application/x-www-form-urlencoded";
            tokenRequest.Accept = "Accept=text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            byte[] _byteVersion = Encoding.ASCII.GetBytes(tokenRequestBody);
            tokenRequest.ContentLength = _byteVersion.Length;
            Stream stream = tokenRequest.GetRequestStream();
            await stream.WriteAsync(_byteVersion, 0, _byteVersion.Length);
            stream.Close();
            try
            {
                // gets the response
                WebResponse tokenResponse = await tokenRequest.GetResponseAsync();
                using (StreamReader reader = new StreamReader(tokenResponse.GetResponseStream()))
                {
                    // reads response body
                    string responseText = await reader.ReadToEndAsync();
                    // converts to dictionary
                    Dictionary<string, string> tokenEndpointDecoded = JsonConvert.DeserializeObject<Dictionary<string, string>>(responseText);
                    Access_token = tokenEndpointDecoded["access_token"];
                    Refresh_token = tokenEndpointDecoded["refresh_token"];
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.ProtocolError)
                {
                    var response = ex.Response as HttpWebResponse;
                    if (response != null)
                    {
                        using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                        {
                            // reads response body
                            string responseText = await reader.ReadToEndAsync();
                        }
                    }

                }
            }
        }
        /// <summary>
        /// Returns URI-safe data with a given input length.
        /// </summary>
        /// <param name="length">Input length (nb. output will be longer)</param>
        /// <returns></returns>
        private static string randomDataBase64url(uint length)
        {
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return base64urlencodeNoPadding(bytes);
        }
        /// <summary>
        /// Returns the SHA256 hash of the input string.
        /// </summary>
        /// <param name="inputStirng"></param>
        /// <returns></returns>
        private static byte[] sha256(string inputStirng)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
            System.Security.Cryptography.SHA256Managed sha256 = new System.Security.Cryptography.SHA256Managed();
            return sha256.ComputeHash(bytes);
        }
        /// <summary>
        /// Base64url no-padding encodes the given input buffer.
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        private static string base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }
    }
}
