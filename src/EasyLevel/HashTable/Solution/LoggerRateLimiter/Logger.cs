using System.Collections.Generic;

namespace HashTable.Solution.LoggerRateLimiter
{
    public class Logger
    {
        private readonly Dictionary<string, int> _logDictionary;

        /** Initialize your data structure here. */
        public Logger()
        {
            _logDictionary = new Dictionary<string, int>();
        }

        /** Returns true if the message should be printed in the given timestamp, otherwise returns false.
            If this method returns false, the message will not be printed.
            The timestamp is in seconds granularity. */
        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!_logDictionary.ContainsKey(message))
            {
                _logDictionary.Add(message, timestamp);
                return true;
            }

            var previousTimestamp = _logDictionary[message];

            if (timestamp - previousTimestamp >= 10)
            {
                _logDictionary[message] = timestamp;
                return true;
            }

            return false;
        }
    }
}
