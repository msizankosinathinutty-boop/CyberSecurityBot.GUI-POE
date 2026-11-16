
using System;
using System.Text.RegularExpressions;

namespace CybersecurityAwarenessBot.Services
{
    public class NlpProcessor
    {
        public IntentResult DetectIntent(string rawInput)
        {
            string input = rawInput.Trim().ToLower();

            // Recognise activity log requests.
            if (ContainsAny(input,
                "show activity log",
                "show my activity",
                "recent actions",
                "what have you done for me"))
            {
                return new IntentResult
                {
                    Intent = UserIntent.ShowActivityLog
                };
            }

            // Recognise quiz requests.
            if (ContainsAny(input,
                "start quiz",
                "play quiz",
                "cyber quiz",
                "test my knowledge",
                "cybersecurity game"))
            {
                return new IntentResult
                {
                    Intent = UserIntent.StartQuiz
                };
            }

            // Recognise task viewing requests.
            if (ContainsAny(input,
                "show tasks",
                "show my tasks",
                "view tasks",
                "what tasks do i have"))
            {
                return new IntentResult
                {
                    Intent = UserIntent.ShowTasks
                };
            }

            // Recognise reminder requests.
            if (input.Contains("remind me to") ||
                input.Contains("set a reminder"))
            {
                return new IntentResult
                {
                    Intent = UserIntent.AddTaskWithReminder,
                    TaskTitle = ExtractTaskTitle(input),
                    ReminderDate = ExtractReminderDate(input)
                };
            }

            // Recognise ordinary task requests.
            if (ContainsAny(input,
                "add task",
                "add a task",
                "create task",
                "create a task",
                "new task"))
            {
                return new IntentResult
                {
                    Intent = UserIntent.AddTask,
                    TaskTitle = ExtractTaskTitle(input)
                };
            }

            // Allow the existing Part 2 chatbot
            // to handle normal cybersecurity questions.
            return new IntentResult
            {
                Intent = UserIntent.CybersecurityQuestion
            };
        }

        private bool ContainsAny(string input, params string[] phrases)
        {
            foreach (string phrase in phrases)
            {
                if (input.Contains(phrase))
                {
                    return true;
                }
            }

            return false;
        }

        public string ExtractTaskTitle(string input)
        {
            string title = input;

            // Remove common task command phrases.
            title = Regex.Replace(
                title,
                @"^(please\s+)?(add\s+(a\s+)?task(\s+to|\s*-\s*)?|" +
                @"create\s+(a\s+)?task(\s+to)?|new\s+task(\s+to)?|" +
                @"remind\s+me\s+to)\s*",
                "",
                RegexOptions.IgnoreCase);

            // Remove reminder wording at the end.
            title = Regex.Replace(
                title,
                @"\s+(tomorrow|in\s+\d+\s+days?)\.?$",
                "",
                RegexOptions.IgnoreCase);

            return title.Trim().TrimEnd('.');
        }

        public DateTime? ExtractReminderDate(string input)
        {
            if (input.Contains("tomorrow"))
            {
                return DateTime.Today.AddDays(1);
            }

            Match match = Regex.Match(
                input,
                @"in\s+(\d+)\s+days?",
                RegexOptions.IgnoreCase);

            if (match.Success)
            {
                int days = Convert.ToInt32(match.Groups[1].Value);

                return DateTime.Today.AddDays(days);
            }

            return null;
        }
    }
}