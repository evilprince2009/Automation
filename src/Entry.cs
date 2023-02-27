using Automation.Parser;
using Automation.Helpers;
using Automation.MenuHandlers;
using Newtonsoft.Json.Linq;
using System;

namespace Automation
{
    class Entry
    {
        static async Task Main()
        {
            try
            {
                IParser parser = new JobParser(auth_file, keywords_buffer, country_code, deliverable_messages[0], deliverable_messages[1], timeout, headless);

                await parser.Parse(credentials[0], credentials[1]);
            }
            catch (Exception)
            {
                Console.WriteLine("Our application is OK. Restoring stable internet connection might resolve this issue.");
            }
        }
    }
}