using DecoratorPattern;
using DecoratorPattern.Decorators;
using FactoryMethodPattern;
using FactoryMethodPattern.Factories;
using ObserverPattern;
using ObserverPattern.Subscribers;
using StrategyPattern;
using StrategyPattern.Strategies;

namespace DesignPatternImplementations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSrategyStart_Click(object sender, EventArgs e)
        {
            IStrategy strategy = new Road();

            if (rbWalking.Checked)
            {
                strategy = new Walking();
            }
            else if (rbPublicTransport.Checked)
            {
                strategy = new PublicTransport();
            }

            var start = new Point(2, 3);
            var end = new Point(5, 7);

            var navigator = new Navigator(strategy);

            var points = navigator.StartStrategy(start, end);

            foreach (Point point in points)
            {
                rtbOutput.AppendText($"X:{point.X} - Y:{point.Y}\r\n");
            }
        }

        private void btnObserverStart_Click(object sender, EventArgs e)
        {
            var publisher = new Publisher();

            var subscriber1 = new Subscriber1();
            var subscriber2 = new Subscriber2();
            var subscriber3 = new Subscriber3();

            publisher.Manager.AddSubscriber(subscriber1);
            publisher.Manager.AddSubscriber(subscriber2);
            publisher.Manager.AddSubscriber(subscriber3);

            publisher.State = DateTime.Now.ToString();

            rtbOutput.AppendText($"{subscriber1.State}\r\n");
            rtbOutput.AppendText($"{subscriber2.State}\r\n");
            rtbOutput.AppendText($"{subscriber3.State}\r\n");
        }

        private void btnDecoratorStart_Click(object sender, EventArgs e)
        {
            //Let's get a Gin lemon with Gin Mare and Lemon Soda
            Cocktail ginLemon = new GinLemon();

            var ginLemonWithGinMare = new GinMare(ginLemon);
            var ginLemonWithGinMareAndLemonSoda = new LemonSoda(ginLemonWithGinMare);

            rtbOutput.AppendText($"You choosed a: {ginLemon.GetDescription()} with Gin Mare and Lemon Soda\r\n");
            rtbOutput.AppendText($"Base cost of the cocktail: {ginLemon.GetCost()} Euro\r\n");
            rtbOutput.AppendText($"Final costs: {ginLemonWithGinMareAndLemonSoda.GetCost()} Euro\r\n");
        }

        private void btnFactoryMethodStart_Click(object sender, EventArgs e)
        {
            ITransport transport = null;

            if (rbShip.Checked)
            {
                transport = new ShipFactory().CreateTransport();
            }
            else if (rbTruck.Checked)
            {
                transport = new TruckFactory().CreateTransport();
            }

            rtbOutput.AppendText($"{transport?.DeliveryStart()}\r\n");
        }
    }
}