Cybersecurity Awareness Chatbot – Final POE

Student Number: ST10499797

Project Overview
The Cybersecurity Awareness Chatbot is a Windows Forms application developed in C#. It helps users learn about cybersecurity through an interactive chatbot, task assistant, cybersecurity quiz and activity log.

The final application combines the functionality developed in Part 1, Part 2 and Part 3 of the Programming 2A Portfolio of Evidence.

Features
Part 1 – Basic Chatbot
- Personalised voice greeting.
- Cybersecurity-themed ASCII artwork.
- Basic cybersecurity conversations.
- Input validation.
- Responses about password safety, phishing and safe browsing.

Part 2 – GUI and Chatbot Enhancements
- Windows Forms graphical user interface.
- Keyword recognition.
- Randomised chatbot responses.
- Conversation flow and memory.
- Sentiment detection.
- Generic collections and delegates.

Part 3 – Advanced Features
- Cybersecurity Task Assistant.
- Add, view, complete and delete tasks.
- Optional task reminders.
- MySQL database integration.
- Twelve-question cybersecurity quiz.
- Multiple-choice and true/false questions.
- Immediate answer feedback and final scoring.
- NLP-style command recognition using string processing.
- Activity Log showing recent user actions.
- Integration of all three POE parts.

Technologies Used
- C#
- .NET Windows Forms
- Visual Studio 2022
- MySQL
- MySql.Data
- Git and GitHub

Project Structure
The project uses separate folders to organise its responsibilities:
- Models: Application data classes.
- Data: Database configuration and task repository.
- Services: Chatbot, quiz, NLP and activity logging logic.
- Audio: Voice greeting audio file.
- GUI: Main Windows Forms interface.

Database Setup
1. Install and start MySQL Server.
2. Open MySQL Workbench or another MySQL client.
3. Run the supplied`database_setup.sql` script.
4. Open `DatabaseConfig.cs`.
5. Configure the local MySQL connection string.
6. Replace the password placeholder with your local MySQL password.
7. Run the application.

How to Use the Application
Chat Tab
Enter a message to interact with the cybersecurity chatbot. Ask questions about cybersecurity or use recognised commands.

Tasks Tab
Create cybersecurity tasks by entering a title and description. You can also set an optional reminder. Select tasks to complete or delete them.

Cyber Quiz Tab
Start the quiz and answer the cybersecurity questions. The application provides feedback and tracks your score.

Activity Log Tab
View recent actions performed during the application session. Use the refresh and show more options to display recent activities.

Example Chat Commands
- Add a task to review privacy settings.
- Remind me to update my password tomorrow.
- Start the cyber quiz.
- Show my tasks.
- What have you done for me?

GitHub Releases
- v1.0-part1 – Basic console chatbot.
- v2.0-part2 – GUI and enhanced chatbot functionality.
- v3.0-final – Final integrated application with MySQL, Tasks, Quiz, NLP and Activity Log.

GitHub Repository
Repository link: \[Paste your GitHub repository link here]

Conclusion
The final project demonstrates the development of a cybersecurity awareness application by combining C# programming, graphical user interface development, database integration, object-oriented programming and basic natural language processing techniques.


