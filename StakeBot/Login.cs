using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StakeBot
{
    public static class Login
    {

        public static void DoLogin(string username,string password,string TFA)
        {
            var client = new RestClient("https://api.stake.com/api/auth/login");

            var request = new RRequest(Method.POST);
            request.AddParameter("application/json", string.Format("{{\"username\":\"{0}\",\"password\":\"{1}\",\"tfa\":\"{2}\",\"captcha\":\"\"}}", username, password , TFA ), ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);

            if (response.IsSuccessful)
            {
                //login = JsonConvert.DeserializeObject<Login>(response.Content);
                MessageBox.Show("Login Successful!");
                //lblBalance.Text = login.user.balances.available_balance.ToString();
                //btnGo.Enabled = true;
            }
            else
            {

               List<Error>  error = JsonConvert.DeserializeObject<List<Error>>(response.Content);

                MessageBox.Show(error[0].message.ToString());
            }

        }

      
    }





}
