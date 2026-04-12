namespace CyberAwarenessBot
{
    public class BotBrain
    {
   public string GetResponse(string userInput)
{
    if (string.IsNullOrWhiteSpace(userInput))
        return "I'm here! Please ask me a question.";

    string cleanInput = userInput.ToLower().Trim();

    // Personality & Purpose (Requirement  4)
    if (cleanInput.Contains("how are you"))
    {
        return "I'm functioning perfectly and ready to secure South Africa! How are you doing today?";
    }
    else if (cleanInput.Contains("purpose") || cleanInput.Contains("who are you"))
    {
        return "My purpose is to be your digital shield. I'm here to educate South African citizens on how to spot and stop cyber attacks.";
    }
    else if (cleanInput.Contains("what can i ask") || cleanInput.Contains("help"))
    {
        return "You can ask me about: \n- 🔐 Password safety\n- 📧 Phishing scams\n- 🔗 Suspicious links\n- 📶 Public Wi-Fi\n- 🇿🇦 Common SA scams";
    }

    // Cybersecurity Topics (still requirement 4 for added Variety)
    else if (cleanInput.Contains("password"))
    {
        return "TIP:  Use strong, unique passwords or passphrases such as “StrongCoffee2026!”. A good password should be at least 8–12 characters long and include a mix of uppercase and lowercase letters, numbers, and symbols. Avoid using personal information like your name or birthdate, and do not reuse the same password across multiple accounts, as this increases your risk if one account is compromised.";
    }
    else if (cleanInput.Contains("phishing"))
    {
        return "ALERT: Be cautious of phishing messages that try to trick you into revealing sensitive information like passwords or banking details. These messages often create a sense of urgency or appear to come from trusted sources such as banks or popular companies. Always check the sender’s email address carefully, avoid clicking on suspicious links, and never share personal information through email or messages unless you are absolutely sure the source is legitimate.";
    }
    else if (cleanInput.Contains("link"))
    {
        return "SAFE CHECK: Before clicking any link, take a moment to verify where it actually leads. You can do this by hovering over the link to preview the URL and checking if it matches the official website. Be cautious of links that look slightly misspelled or unfamiliar, as cybercriminals often use fake websites to steal information. When in doubt, avoid clicking the link and instead visit the website directly through a trusted source.";
    }
    else if (cleanInput.Contains("wifi") || cleanInput.Contains("public"))
    {
        return "📶 WIFI: Be cautious when using public or free Wi-Fi networks, as they are often unsecured and can be exploited by cybercriminals to intercept your data. Avoid accessing sensitive information such as online banking or entering passwords while connected to public Wi-Fi. If you must use it, consider using a VPN for added security and always ensure websites use HTTPS to help protect your information.";

    }
    else if (cleanInput.Contains("whatsapp") || cleanInput.Contains("scam"))
    {
        return "🇿🇦 SA ALERT: Be aware of common scams on WhatsApp, such as “Hi Mum” messages where someone pretends to be a family member in trouble, or fake investment opportunities promising quick profits. Scammers often try to create urgency or emotional pressure to get you to send money or share personal information. Always verify the identity of the sender through a trusted method, never send money to unknown contacts, and report and block suspicious accounts immediately!";
    }

    // 3. Default Response (Requirement #5)
    else
    {
        return "I'm not quite sure about that. Try asking 'What can I ask you about?' for a list of topics I know!";
    }
} 

}
}