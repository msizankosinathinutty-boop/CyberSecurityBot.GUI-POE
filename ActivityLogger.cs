using System.Collections.Generic;
using System.Linq;
using CybersecurityAwarenessBot.Models;

namespace CybersecurityAwarenessBot.Services
{
    public class ActivityLogger
    {
        private readonly List<ActivityEntry> entries =
            new List<ActivityEntry>();

        public void Log(string description)
        {
            entries.Add(new ActivityEntry
            {
                Time = System.DateTime.Now,
                Description = description
            });
        }

        public List<ActivityEntry> GetRecent(int count)
        {
            return entries
                .OrderByDescending(x => x.Time)
                .Take(count)
                .ToList();
        }
    }
}