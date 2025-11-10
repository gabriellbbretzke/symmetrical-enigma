using Confluent.Kafka;

namespace Ecommerce.OrderService.Kafka
{
    public interface IKafkaProducer
    {
        Task ProduceAsync(string topic, Message<string, string> message);
    }

    public class KafkaProducer : IKafkaProducer
    {
        private readonly IProducer<string, string> _producer;
        public KafkaProducer()
        {
               var config = new ConsumerConfig
               {
                   BootstrapServers = "localhost:9092",
                   GroupId = "order-group",
                   AutoOffsetReset = AutoOffsetReset.Earliest
               };
            _producer = new ProducerBuilder<string, string>(config).Build();
        }

        public async Task ProduceAsync(string topic, Message<string, string> message)
        {
            _producer.ProduceAsync(topic, message);
        }
    }
}
