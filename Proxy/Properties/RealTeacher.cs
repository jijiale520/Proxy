using System;

namespace Proxy.Properties
{
    public class RealTeacher : ITeacher
    {
        public void HomeworkCorrecting()
        {
            Console.WriteLine("老师要批改作业啦！");
        }
    }
}