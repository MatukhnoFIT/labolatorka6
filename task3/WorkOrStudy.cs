using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class WorkOrStudy : Person
    {
        public WorkOrStudy()
        {
            Do();
        }
        public override void Do()
        {
            if (age >= 18)
            {
                Console.Write(name);
                IWhatDo.Work();
            }
            else if (age < 18)
            {
                Console.Write(name);
                IWhatDo.Study();
            }
        }
    }
}
