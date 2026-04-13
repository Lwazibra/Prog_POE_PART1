using System;
using System.Data.SqlTypes;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Speech.Synthesis;
using System.Threading;
using System.Speech.Synthesis.TtsEngine;



namespace POE_PART1
{
    public class Welcome 
    {
        public Welcome()
        {
           
            SpeechSynthesizer spec = new SpeechSynthesizer();

            spec.Volume = 100;
            spec.Rate = 0;





            string[] keywords = { "password", "phishing", "browsing", "purpose", "ask" };

            string[] responce = {"Password safety (also called \npassword security or password hygiene) is the practice of creating, using, and \nmanaging passwords in ways that protect your accounts from being hacked, stolen, or compromised.\r\n\r\n",
                "Phishing is a type of cyber attack that uses\nsocial engineering to trick people into revealing \nsensitive information (such as \npasswords, credit card details, bank accounts, or \nlogin credentials) or performing harmful actions \n(like clicking malicious links, downloading malware, \nor transferring money).\n\nAttackers impersonate trusted entities — like your bank, email provider (e.g., \nMicrosoft or Google), a colleague, government agency, or even a friend — to create \nbelievable \"bait.\" The goal is usually identity theft, financial fraud, account \ntakeover, or installing malware/ransomware.\r\n\r\n",
                "Safe browsing (also called secure\n web browsing or safe internet browsing) is the set of habits, tools, and browser features that protect \nyou from online threats while surfing the web. These threats include phishing \nsites, malware downloads, malicious ads, tracking, drive-by exploits, and data theft.\nIt goes beyond just avoiding bad links — it's about making your entire browsing \nexperience much harder for attackers to exploit, while reducing privacy risks like tracking \nby advertisers or ISPs.Safe browsing builds directly on the topics we've covered: strong password \nhygiene and recognizing phishing become far more effective when combined with secure browsing practices.\r\n\r\n",


                    "My purpose is to guide you and make you understand in terms of: Information Security",
                    "You can ask about anything involving Software, web devlopment, arrays, OOP, and debugging",
                    "I know the basics of Information Security and I will happily guide you towards the path of understanding it"
                    };

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                TypeText("Ask any question related to cyber security(such as \npassword safety, safe browsing)\n",25);
                string questions = Console.ReadLine().ToLower();

                string[] splitted = questions.Split(' ', ' ');
                bool found = true;

                if (questions == "leave")
                {
                    TypeText("bye bye",25);
                    break;
                }

                foreach (string s in splitted)
                {
                    for (int i = 0; i < keywords.Length; i++)
                    {
                        if (s == keywords[i])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");
                            Console.WriteLine("Chatbot: ");
                            TypeText(responce[i], 25);

                            Console.WriteLine("<<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>><<>>");

                        }

                    }
                    if (!found)
                    {
                        TypeText("enter software related topic", 25);
                        Console.WriteLine();
                    }
                }
           
            }

        }

        public void TypeText(string text, int delay)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }

}