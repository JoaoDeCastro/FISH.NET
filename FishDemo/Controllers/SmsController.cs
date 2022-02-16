using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.AspNet.Mvc;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FishDemo.Controllers
{
    public class SmsController : TwilioController
    {
        // GET: Sms
        public ActionResult SendSms()
        {
            var accountSid = "ACaa4ef3fab036936163b66e93826cd02b";
            var accountAuth = "7eafe154abec920fd887b9b17f9d905f";

            TwilioClient.Init(accountSid, accountAuth);

            var from = new PhoneNumber("+17853775632");
            var to = new PhoneNumber("+12037880407");

            var message = MessageResource.Create(
                to: to,
                from: from,
                body: "Oi mamae, um bjo"
                );
            return Content(message.Sid);
            

        }
    }
}