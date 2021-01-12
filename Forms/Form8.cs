using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;
using System.IO;

namespace Forms
{
    public partial class Form8 : Form
    {
        private Emulation _emulation;
        private Thread _repaintThread = null;
        private Image _busImage;
        private Image _busWaitImage;
        private Image _busStopImage;
        private Image _landingImage;
        private Image _overloadImage;
        private Image _needLandingImage;
        private Image _passenger;
        private Image _diedPassenger;
        private Bitmap myBitmap;
        public Form8()
        {
            InitializeComponent();
            panel1.Paint += panel1_Paint;
            
            _busImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\bus.png");
            _busStopImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\BusStop.png");
            _landingImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\Landing.png");
            _overloadImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\Overload.png");
            _needLandingImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\NeedLanding.JPG");
            _busWaitImage = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\busWait.png");
            _passenger = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\passenger.png"); 
            _diedPassenger  = Image.FromFile("C:\\Users\\admin\\Pictures\\прога\\для 8 проги\\DiedPassenger.png");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            myBitmap = new Bitmap(panel1.Width, panel1.Height);
            var g = Graphics.FromImage(myBitmap);

            if (_emulation==null)
            {
                return;
            }

            
            if (_emulation.Bus.IsWaiting())
            {
                g.DrawImage(_busWaitImage, _emulation.Bus.TargetCoordinates.X,
                    _emulation.Bus.TargetCoordinates.Y, 150, 100);
            }
            else if (_emulation.Bus.BusIsOverload)
            {
                g.DrawImage(_overloadImage, _emulation.Bus.TargetCoordinates.X,
                    _emulation.Bus.TargetCoordinates.Y, 180, 120);
            }
            else
            {
                g.DrawImage(_busImage, _emulation.Bus.TargetCoordinates.X,
                    _emulation.Bus.TargetCoordinates.Y, 180, 120);
            }
            


            foreach (var v in _emulation.BusStops)
            {
                for (var i = 0; i < v.Passengers.Count; i++)
                {
                    if(v.Passengers[i].IsDied)
                        g.DrawImage(_diedPassenger, v.MyCoordinates.X + i * 25,
                    v.MyCoordinates.Y + 125, 25, 10);
                    else
                        g.DrawImage(_passenger, v.MyCoordinates.X + i*20,
                    v.MyCoordinates.Y+ 100, 50, 35);
                }

                if (v.IsNeedLanding)
                {
                    g.DrawImage(_needLandingImage, v.MyCoordinates.X,
                        v.MyCoordinates.Y, 150,80);
                }
                else if (v.Landing)
                {
                    g.DrawImage(_landingImage, v.MyCoordinates.X,
                        v.MyCoordinates.Y, 150, 80);
                }
                else
                {
                    g.DrawImage(_busStopImage, v.MyCoordinates.X,
                        v.MyCoordinates.Y, 150, 80);
                }
            }
            panel1.Image = myBitmap;
        }

        private void PanelRepaint()
        {
            while (true)
            {
                panel1.Invalidate();
                Thread.Sleep(50);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (_repaintThread == null)
            {
                List<BusStop> BusStops = new List<BusStop>();
                int Step = 10;
                for (int i = 0; i < (int) BusStopsCount.Value; i++)
                {
                    BusStop bs1 = new BusStop(new Coordinates(4, 4 + 150 * i, Step), (int) WeightPanel.Value);
                    BusStops.Add(bs1);
                }
                Bus bus = new Bus(new Coordinates(panel1.Width / 2, panel1.Height / 2, Step),
                    new Coordinates(panel1.Width / 2, panel1.Height / 2, Step));
                _emulation = new Emulation(bus, BusStops);
                _emulation.Start();
                _repaintThread = new Thread(PanelRepaint);
                _repaintThread.Start();
                startButton.Text = @"Stop";
            }
            else
            {
                _emulation.Stop();
                _repaintThread.Abort();
                _repaintThread = null;
                startButton.Text = @"Start";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _emulation?.Stop();
            _repaintThread?.Abort();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}