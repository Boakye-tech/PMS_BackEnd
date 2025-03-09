using System;
using System.Net;
using System.Text.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Web;
using Microsoft.Extensions.Configuration;
using Modules.Notification.Application.Dtos.Sms;
using Modules.Notification.Application.Interfaces;
using Microsoft.AspNetCore.Http;

namespace Modules.Notification.Infrastructure.Services
{
	public class SmsSender : ISmsSender
	{
        public IConfiguration _configuration { get; }

		public SmsSender(IConfiguration configuration)
		{
            _configuration = configuration;
		}

        public string SendMessage(SendSmsRequestDto smsRequest)
        {
            //throw new NotImplementedException();
            try
            {
                return sendSMS_Via_BECSMS(smsRequest.mobileNumber!, smsRequest.message_content!);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        public async Task<string> SendMessageAsync(SendSmsRequestDto smsRequest)
        {
            //throw new NotImplementedException();
            try
            {
                return await sendSMS_Via_mNotify(smsRequest.mobileNumber!, smsRequest.message_content!);

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }



        private string sendSMS_Via_BECSMS(string mobileNumber, string message)
        {
            try
            {
                string api_Key = _configuration["becsms:APIKey"]!;
                string sender_Id = _configuration["becsms:SenderId"]!;
                string phone_Number = mobileNumber;
                string message_to_send = message;

                string sendMessageUrl = _configuration["becsms:BaseUrl"] + "/smsapi?key=" + api_Key + "&to=" + phone_Number + "&msg=" + HttpUtility.UrlEncode(message_to_send) + "&sender_id=" + sender_Id;
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(sendMessageUrl);

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    string inputLine = reader.ReadLine()!.Trim();

                    var sms_response = JsonSerializer.Deserialize<BecsmsResponseDto>(inputLine);

                    return sms_response!.message is not null ? sms_response.code switch
                    {
                        1000 => sms_response.message,
                        1002 => sms_response.message,
                        1003 => sms_response.message,
                        1004 => sms_response.message,
                        1005 => sms_response.message,
                        1006 => sms_response.message,
                        1008 => "Empty message",
                        _ => string.Empty,

                    } : string.Empty;

                   
                }

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        private async Task<string> sendSMS_Via_mNotify(string mobileNumber, string message)
        {
            try
            {
                using (var _client = new HttpClient())
                {
                    string[] receivingNumber = new string[] { mobileNumber };

                    MNotifySmsRequestDto sendModel = new MNotifySmsRequestDto();

                    //sendModel.key = _configuration["mNotifySMS:UserKey"];
                    sendModel.recipient = receivingNumber;
                    sendModel.sender = _configuration["mNotifySMS:SenderId"];
                    sendModel.message = message;
                    sendModel.is_schedule = false;
                    sendModel.schedule_date = "";

                    var url = $"{_configuration["mNotifySMS:BaseUrl"]}?key={_configuration["mNotifySMS:UserKey"]}";

                    StringContent content = new StringContent(JsonSerializer.Serialize(sendModel), encoding: System.Text.Encoding.UTF8, "application/json");

                    using (var response = await _client.PostAsync(url, content))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();

                        var sendResponse = JsonSerializer.Deserialize<MNotifySmsResponseDto>(apiResponse);
                        return sendResponse!.status!;
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }





    }
}

