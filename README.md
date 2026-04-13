# 🛡️ Cybersecurity Awareness Chatbot (Part 1)

## 📌 Project Overview  
This project is a C# console-based chatbot designed to promote cybersecurity awareness among South African citizens. The chatbot interacts with users in a conversational manner and provides guidance on common online threats such as phishing, unsafe links, weak passwords, and scams.

The goal of this project is to simulate real-life scenarios where users may encounter cyber threats and educate them on how to stay safe online.

---

## ⚙️ Features Implemented  

- 🎧 Voice Greeting  
  Plays a `.wav` audio file when the program starts to welcome the user.

- 🖼️ ASCII Art Logo  
  Displays a cybersecurity-themed bot logo at startup.

- 💬 Interactive Chatbot  
  - Asks for the user’s name  
  - Personalizes responses  
  - Engages in a continuous conversation loop  

- 🧠 Cybersecurity Knowledge Base  
  The chatbot responds to questions about:
  - Password safety  
  - Phishing scams  
  - Suspicious links  
  - Public Wi-Fi risks  
  - Common South African scams  

- ⚠️ Input Validation  
  Ensures the user enters a valid name and handles empty or invalid inputs gracefully.

- 🎨 Enhanced Console UI  
  - Colored text output  
  - Decorative headers and dividers  
  - Typing effect for more natural interaction  

---

## 🗂️ Project Structure  

```
CyberAwarenessBot/
│
├── Program.cs       // Main program flow and conversation loop
├── User.cs          // Stores user information (name)
├── Chatbot.cs       // Handles UI elements (ASCII art, typing effect, headers)
├── BotBrain.cs      // Contains chatbot logic and responses
├── audio/
│   └── greeting.wav // Voice greeting file
└── README.md        // Project documentation
```

---

## ▶️ How to Run the Program  

### 1. Open the project  
Open the project folder in VS Code or your preferred IDE.

### 2. Restore dependencies (if needed)  
```
dotnet restore
```

### 3. Run the application  
```
dotnet run
```

---

## 🔊 Important Setup Note  

- Ensure the audio file is located in:  
```
audio/greeting.wav
```

- The file must be a valid `.wav` format for playback using `System.Media.SoundPlayer`.

---

## 💡 How to Use the Chatbot  

1. The program starts with a voice greeting and displays the bot logo.  
2. You will be asked to enter your name.  
3. The chatbot will greet you and show available topics.  
4. Type questions such as:
   - How are you?
   - What is your purpose?
   - Tell me about passwords
   - What is phishing?
   - Is public Wi-Fi safe?

5. To exit the chatbot, type:
```
exit
```

---

## 🧪 Example Interaction  

```
[BOT]: Dumelang! I am your security assistant.
[BOT]: To begin, may I ask what your name is?

[YOU]: John

Hello, John. It is vital for South Africans to stay safe online.

JOHN: tell me about phishing
BOT: ALERT: Be cautious of phishing messages...
```

---

## 🧱 Technologies Used  

- C# (.NET 9 Console Application)  
- System.Media (for audio playback)  
- Console UI formatting (colors, typing effects)

---

## 📈 Future Improvements (Part 2 & Final)  

- More advanced conversation handling  
- Better natural language understanding  
- Expanded cybersecurity topics  
- Improved UI/UX and interaction flow  

---

## 👤 Author  

Developed as part of a Programming POE (Part 1) focused on building a cybersecurity awareness chatbot.