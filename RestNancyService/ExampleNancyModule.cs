using System;
using Nancy;
using Nancy.ModelBinding;
using System.IO;

namespace RestNancyService
{
    public class ExampleNancyModule : NancyModule
    {
        private static LogInformation logInformation = new LogInformation()
        {
            
        };

        public ExampleNancyModule()
        {

            Get["/logs"] = parameters =>
            {
                string feeds = string.Empty;
                using (StreamReader reader = new StreamReader("Output.json"))
                {
                    feeds = reader.ReadToEnd();
                    reader.Close();
                    return Response.AsJson(feeds);
                }                    
            };

            Post["/postlog"] = parameters =>
            {
                var post = this.Bind<LogInformation>(); //Breakpoint
                logInformation = post;
                var json = new Nancy.Json.JavaScriptSerializer().Serialize(logInformation);
                
                using (StreamWriter writer = new StreamWriter("Output.json"))
                {
                    writer.Write(json);
                    writer.Close();
                    return "Success";
                }
            };
        }
    }
}
