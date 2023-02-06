using Newtonsoft.Json.Linq;
using System.Security.Principal;
using System.Web;

namespace Automation.Helpers
{
    internal class Utility
    {
        private Utility() {}
        public static int MinToMiliSec(int min) => min * 60 * 1000;
        public static void ResetConsole()
        {
            try
            {
                Console.SetWindowSize(66, 17);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Welcome onboard. Wait till we initialize ...!");
                Console.ResetColor();
            }
        }
        public static void ResetConsole(string start)
        {
            try
            {
                Console.SetWindowSize(66, 17);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                string username = WindowsIdentity.GetCurrent().Name.Split('\\')[1];
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Hey {username}, We're happy to have you ...!");
                Console.ResetColor();
            }
            Thread.Sleep(2500);
        }
        public static string CustomizesMessage(string name,string message)
        {
            string first_name = name!.Split(' ')[0];
            List<string> message_parts = message.Split(" ").ToList();
            string greeting = message_parts.First();
            message_parts.Remove(greeting);
            string message_body = string.Join(" ", message_parts);
            string customized_message = $"{greeting} {first_name},\n{message_body}";
            return customized_message;
        }

        public static string EncodeKeyword(string keyword) => HttpUtility.UrlEncode(keyword);
        public static void Interrupt()
        {
            int interval = new Random().Next(2, 4) * 1000;
            Thread.Sleep(interval);
        }

        public static void Interrupt(int interval)
        {
            int time = interval * 1000;
            Thread.Sleep(time);
        }

        public static string Clear(string text) => text.Replace('\n', ' ').Trim();
    }
}