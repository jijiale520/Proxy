using System;

namespace Proxy.Properties
{
    public class MonitorProxy : ITeacher
    {
        private RealTeacher teacher;


        public MonitorProxy(RealTeacher _teacher)
        {
            this.teacher = _teacher;
        }
        
        public void HomeworkCorrecting()
        {
            SendMessage();
            this.teacher.HomeworkCorrecting();
        }

        private void SendMessage()
        {
            Console.WriteLine("将同学们的作业交给老师");
        }
    }
}