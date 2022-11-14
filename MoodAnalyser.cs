using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MoodAnalyzerAppWithCore
{
    public class MooodAnalyse
    {
        private string message;
        ///<summary>
        ///Parameterised Constructor
        ///<summary>
        ///param name="message"></param
        public MooodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPAY";
            }
        }
    }
}
