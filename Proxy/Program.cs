using Proxy.Properties;

namespace Proxy
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MonitorProxy monitorProxy = new MonitorProxy(new RealTeacher());
            monitorProxy.HomeworkCorrecting();
        }
    }
}