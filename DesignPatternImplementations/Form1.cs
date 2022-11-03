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

            foreach(Point point in points)
            {
                rtbOutput.AppendText($"X:{point.X} - Y:{point.Y}\r\n");
            }
        }
    }
}