using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerAppWithCoreTC
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
            try
            {

                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "HAPPY";
            }
        }
    }
}
