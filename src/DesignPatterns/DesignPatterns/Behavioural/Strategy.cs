namespace DesignPatterns.Behavioural;

public static class StrategyPattern
{
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    public class CreditCardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Pay {amount} by credit card");
    }

    public class PayPalPaymentStrategy : IPaymentStrategy
    {
        public void Pay(decimal amount) => Console.WriteLine($"Pay {amount} by PayPal");
    }

    public class PaymentProcessor
    {
        readonly IPaymentStrategy _paymentStrategy;

        public PaymentProcessor(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Process a payment of {amount}");
            _paymentStrategy.Pay(amount);
        }
    }

    public static void Execute()
    {
        Console.WriteLine($"[{nameof(StrategyPattern)} Pattern]");
        Console.WriteLine();

        var paymentStrategy = new CreditCardPaymentStrategy();
        var paymentProcessor = new PaymentProcessor(paymentStrategy);
        paymentProcessor.ProcessPayment((decimal)29.99D);
    }
}

