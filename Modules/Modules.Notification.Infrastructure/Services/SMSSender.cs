// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
using System.Net;
using System.Text.Json;
using System.Web;
using Microsoft.Extensions.Configuration;


namespace Modules.Notification.Infrastructure.Services
{
	public class SmsSender : ISmsSender
	{
        public IConfiguration _configuration { get; }

		public SmsSender(IConfiguration configuration)
		{
            _configuration = configuration;
		}


        public async Task<string> SendMessageAsync(SendSmsRequestDto smsRequest)
        {
            try
            {
                return await sendSMS_Via_mNotify(smsRequest.mobileNumber!, smsRequest.message_content!);
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

