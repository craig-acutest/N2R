using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenPop.Pop3;
using OpenPop.Mime;
using System.Data;
using N2R.Utilities.Models;

namespace N2R.Utilities
{
    public static class Email
    {
        public static List<EmailModel> Read_Emails()
        {
            Pop3Client pop3Client;

            pop3Client = new Pop3Client();
            pop3Client.Connect("pop.gmail.com", 995, true);
            pop3Client.Authenticate("recent:generalcaw@gmail.com", "\"caw678\"");
            
            int count = pop3Client.GetMessageCount();
            List<EmailModel> emailList = new List<EmailModel>();
            List<string> errors = new List<string>();
            int counter = 0;
            for (int i = count; i >= count - 20; i--)
            {
                try
                {
                    if (pop3Client.GetMessage(i).Headers.ContentType.CharSet != "iso-8859-1")
                    {
                        Message message = pop3Client.GetMessage(i);

                        EmailModel email = new EmailModel();

                        email.ID = i;
                        email.Subject = message.Headers.Subject;
                        email.DateSent = message.Headers.DateSent;

                        OpenPop.Mime.MessagePart html = message.FindFirstHtmlVersion();
                        if (html != null)
                        {
                            email.Content = html.GetBodyAsText();
                        }
                        counter++;
                        emailList.Add(email);
                    }
                }
                catch(Exception ex)
                {
                    errors.Add(ex.ToString());
                }
            }

            return emailList;
        }
    }
}
