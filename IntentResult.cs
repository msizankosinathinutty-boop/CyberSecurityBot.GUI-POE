using System;

namespace CybersecurityAwarenessBot.Services
{
    public class IntentResult
    {
        public UserInent Intent { get; set; }

        publlic string TaskTitle { get; set; } = "";

        public DateTime? ReminderDate { get; set; }

    }
}