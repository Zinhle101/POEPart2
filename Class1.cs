using System;
using System.Collections;

namespace CyberSafetyBot
{
    public class ChatbotEngine
    {
        // Stores chatbot replies
        private ArrayList replies = new ArrayList();

        // Constructor
        public ChatbotEngine()
        {
            // Add chatbot responses

            replies.Add("Use strong passwords with symbols and numbers.");

            replies.Add("Never click suspicious email links.");

            replies.Add("Protect your personal information online.");

            replies.Add("Be careful of online scams and fake giveaways.");
        }

        // Main chatbot method
        public ArrayList GetResponse(string input, string tone)
        {
            ArrayList responses = new ArrayList();

            input = input.ToLower();
            string[] words = input.Split(' ');

            bool matched = false;

            foreach (string word in words)
            {
                string cleanWord = word.Trim().ToLower();

                if (cleanWord == "password")
                {
                    matched = true;

                    if (tone == "Friendly")
                    {
                        responses.Add("😊 Make sure you use strong passwords with symbols and numbers!");
                    }
                    else if (tone == "Professional")
                    {
                        responses.Add("Users should create strong passwords using symbols, numbers, and uppercase letters.");
                    }
                    else if (tone == "Serious")
                    {
                        responses.Add("Weak passwords place your accounts at risk.");
                    }
                }

                else if (cleanWord == "phishing")
                {
                    matched = true;

                    if (tone == "Friendly")
                        responses.Add("😊 Don’t click suspicious links — stay safe online!");
                    else if (tone == "Professional")
                        responses.Add("Users should avoid interacting with suspicious email links.");
                    else
                        responses.Add("Phishing attacks can compromise your data.");
                }

                else if (cleanWord == "privacy")
                {
                    matched = true;

                    if (tone == "Friendly")
                        responses.Add("😊 Protect your info online — don’t overshare!");
                    else
                        responses.Add("Maintain strong privacy practices to protect personal data.");
                }

                else if (cleanWord == "scam")
                {
                    matched = true;

                    if (tone == "Friendly")
                        responses.Add("😊 Be careful of fake giveaways and scams!");
                    else
                        responses.Add("Avoid online scams and verify sources before sharing information.");
                }
            }

            if (!matched)
            {
                responses.Add("I am not sure how to respond to that.");
            }

            return responses;
        }
    }
}