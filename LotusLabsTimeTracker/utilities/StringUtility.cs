using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotusLabsTimeTracker.utilities
{
    class StringUtility
    {
        public String arrayToStringMessages(List<String> messages) {
            String concatinatedMessages = String.Empty;
            if (messages.Count > 0)
            {
                foreach (String message in messages)
                {
                    concatinatedMessages += message + "\n";
                }
            }
            return concatinatedMessages;
        }
    }
}
