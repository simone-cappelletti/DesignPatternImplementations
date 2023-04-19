using AdapterPattern;
using CommandPattern.Commands;
using CommandPattern.Entities;
using CommandPattern.Interfaces;
using DecoratorPattern;
using DecoratorPattern.Decorators;
using FacadePattern;
using FactoryMethodPattern;
using FactoryMethodPattern.Factories;
using IteratorPattern;
using ObserverPattern;
using ObserverPattern.Subscribers;
using StrategyPattern;
using StrategyPattern.Strategies;
using TemplateMethodPattern;

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
                new LightOffCommand(new LivingRoomLigth()),
                new LightOffCommand(new KitchenLigth())
            };

            ICommand command = new AllLightsOnCommand(commands);

            Common.houseRemoteController.SetCommand(command);

            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.ExecuteCommand()}\r\n");
        }

        private void btnCommandUndo_Click(object sender, EventArgs e)
        {
            rtbOutput.AppendText($"{DateTime.Now} - {Common.houseRemoteController.UndoCommand()}\r\n");
        }
        #endregion

        #region ADAPTER
        private void btnAdapterStart_Click(object sender, EventArgs e)
        {
            var stockMarketService = new StockMarketService();
            var adapter = new Adapter(stockMarketService);

            rtbOutput.AppendText($"Getting stock market service data: {stockMarketService.GetXmlData()}\r\n");
            rtbOutput.AppendText($"Getting adapter data: {adapter.GetJsonData()}\r\n");
        }
        #endregion

        #region FACADE
        private void btnFacadeStart_Click(object sender, EventArgs e)
        {
            IHomeTheater homeTheater = new HomeTheater(
                new FacadePattern.Entities.Amplifier(),
                new FacadePattern.Entities.Tuner(),
                new FacadePattern.Entities.StreamingPlayer(),
                new FacadePattern.Entities.Projector(),
                new FacadePattern.Entities.TheaterLights(),
                new FacadePattern.Entities.Screen(),
                new FacadePattern.Entities.PopcornPopper());

            rtbOutput.AppendText($"{homeTheater.TurnOnHomeTheater("The Lord of the rings")}\r\n");
            rtbOutput.AppendText("\r\n... 3 hours laters ...\r\n");
            rtbOutput.AppendText($"{homeTheater.TurnOfHomeTheater()}\r\n");
        }
        #endregion

        #region TEMPLATE METHOD
        private void btnTemplateMethodStart_Click(object sender, EventArgs e)
        {
            TeaBeverage tea = new TeaBeverage();
            CoffeBeverage coffee = new CoffeBeverage();

            rtbOutput.AppendText("TEA:\r\n");
            rtbOutput.AppendText(tea.PrepareCaffeineBeverage());
            rtbOutput.AppendText("\r\n");
            rtbOutput.AppendText("COFFEE:\r\n");
            rtbOutput.AppendText(coffee.PrepareCaffeineBeverage());
        }
        #endregion

        #region ITERATOR
        private void btnIteratorStart_Click(object sender, EventArgs e)
        {
            //Creating collection
            Collection collection = new Collection();

            collection[0] = new CollectionItem("Item 0");
            collection[1] = new CollectionItem("Item 1");
            collection[2] = new CollectionItem("Item 2");

            //Getting iterator
            IIterator iterator = collection.CreateIterator();

            //Setting iteration step
            var step = (int)nupIteratorStep.Value;

            if (step == 0)
            {
                step = 1;

                nupIteratorStep.Value = step;
            }

            iterator.Step = step;

            //Iterating collection
            rtbOutput.AppendText($"Iterating over collection:\r\n");

            for (CollectionItem item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                rtbOutput.AppendText($"{item.Name}\r\n");
            }

            rtbOutput.AppendText($"Iteration ended!\r\n");
        }
        #endregion
    }
}