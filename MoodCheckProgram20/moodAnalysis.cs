using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodCheckProgram20
{
    public class moodAnalysis
    {
        public string message;

        public moodAnalysis(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            try
            {
                if (message.ToLower().Contains("sad"))
                {
                    return "SAD";
                }
                else
                    return "HAPPY";
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null Message Provided");
                return "Happy";
            }

        }
    }
}
