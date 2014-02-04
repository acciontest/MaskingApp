using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskingApp
{
    public class Jsonpayload
    {
        public class AppPackage
        {
            public string id { get; set; }
        }

        public class Question
        {
            public string name { get; set; }
            public string answer { get; set; }

            public Question()
            {
            }

            public Question(string Name, String Answer)
            {
                this.name = Name;
                this.answer = Answer;
            }
        }
        public class datac
        {
            public string key;
            public string value;
        }      
    }
    public class RootObject
    {
        public Jsonpayload.AppPackage appPackage = new Jsonpayload.AppPackage();
        public string userId { get; set; }
        public string appName { get; set; }
        public List<Jsonpayload.Question> questions = new List<Jsonpayload.Question>();
        public string jobName { get; set; }
    }
}
