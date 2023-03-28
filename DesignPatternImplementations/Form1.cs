using CommandPattern.Commands;
using CommandPattern.Entities;
using CommandPattern.Interfaces;
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

        #region STRATEGY
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
        #endregion

        #region OBSERVER

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
        #endregion

        #region DECORATOR

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
        #endregion

        #region FACTORY METHOD
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
        #endregion

        #region COMMAND
        private void btnCommandLivingRoomLightsOn_Click(object sender, EventArgs e)
        {
            ICommand command = new LightOnCommand(new LivingRoomLigth());

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandLivingRoomLightsOff_Click(object sender, EventArgs e)
        {
            ICommand command = new LightOffCommand(new LivingRoomLigth());

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandKitchenLightsOn_Click(object sender, EventArgs e)
        {
            ICommand command = new LightOnCommand(new KitchenLigth());

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandKitchenLightsOff_Click(object sender, EventArgs e)
        {
            ICommand command = new LightOffCommand(new KitchenLigth());

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandAllLightsOn_Click(object sender, EventArgs e)
        {
            var commands = new List<ICommand>()
            {
                new LightOnCommand(new LivingRoomLigth()),
                new LightOnCommand(new KitchenLigth())
            };

            ICommand command = new AllLightsOnCommand(commands);

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandAllLightsOff_Click(object sender, EventArgs e)
        {
            var commands = new List<ICommand>()
            {
                new LightOnCommand(new LivingRoomLigth()),
                new LightOnCommand(new KitchenLigth())
            };

            ICommand command = new AllLightsOnCommand(commands);

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.UndoCommand()}\r\n");
        }

        private void btnCommandUndo_Click(object sender, EventArgs e)
        {
            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.UndoCommand()}\r\n");
        }
        #endregion
    }
}