using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class ServiceBusTopicTrigger1
    {
        private readonly ILogger<ServiceBusTopicTrigger1> _logger;

        public ServiceBusTopicTrigger1(ILogger<ServiceBusTopicTrigger1> log)
        {
            _logger = log;
        }

        [FunctionName("ServiceBusTopicTrigger1")]
        public void Run([ServiceBusTrigger("testepmpaas_servicebus_topic", "mysubscription", Connection = "testepmpaasservicebusnamespace_SERVICEBUS")]string mySbMsg)
        {
            _logger.LogInformation($"C# ServiceBus topic trigger function processed message: {mySbMsg}");
        }
    }
}
