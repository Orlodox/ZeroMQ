using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using ZeroMQ;

namespace ZMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string ReqRepClient(string address, string message)
        {
           // Socket to talk to server
            string answer = "Error";
            using (var context = new ZContext())
            using (var requester = new ZSocket(context, ZSocketType.REQ))
            {
                requester.Connect("tcp://"+address);

                for (int n = 0; n < 10; ++n)
                {
                    requester.Send(new ZFrame(message));

                    using (ZFrame reply = requester.ReceiveFrame())
                    {
                        answer= reply.ReadString();
                    }
                }
            }
            return answer;
        }

        void PubSubServer (string address, string msg)
        {
            // Prepare our context and publisher
            using (var context = new ZContext())
            using (var publisher = new ZSocket(context, ZSocketType.PUB))
            {
                publisher.Linger = TimeSpan.Zero;
                publisher.Bind("tcp://"+address);

                    using (var message = new ZMessage())
                    {
                        message.Add(new ZFrame(msg));
                        Thread.Sleep(1000);
                        publisher.Send(message);
                    }
            }
        }
        void WeatherUpd(string address, string zipCode, string temperature)
        {
            using (var context = new ZContext())
            using (var publisher = new ZSocket(context, ZSocketType.PUB))
            {
                publisher.Bind("tcp://" + address);

                while (true)
                {
                    // Send message to all subscribers
                    var update = string.Format("{0:D5} {1}", zipCode, temperature);
                    using (var updateFrame = new ZFrame(update))
                    {
                        publisher.Send(updateFrame);
                    }
                }
            }
        }

        void SyncSub(string address1, string address2, string endKeyword)
        {
            using (var context = new ZContext())
            using (var subscriber = new ZSocket(context, ZSocketType.SUB))
            using (var syncclient = new ZSocket(context, ZSocketType.REQ))
            {
                // First, connect our subscriber socket
                subscriber.Connect("tcp://"+address1);
                subscriber.SubscribeAll();

                // 0MQ is so fast, we need to wait a while…
                Thread.Sleep(1);

                // Second, synchronize with publisher
                syncclient.Connect("tcp://"+address2);

                // - send a synchronization request
                syncclient.Send(new ZFrame());

                // - wait for synchronization reply
                syncclient.ReceiveFrame();

                // Third, get our updates and report how many we got
                int i = 0;
                while (true)
                {
                    using (ZFrame frame = subscriber.ReceiveFrame())
                    {
                        string text = frame.ReadString();
                        if (text == endKeyword)
                        {
                            break;
                        }

                        frame.Position = 0;
                        ++i;
                    }
                }
            }
        }


        private void ReqRep_Click(object sender, EventArgs e)
        {
            Panel_ReqRep.Visible = true;
        }
        private void PubSub_Click(object sender, EventArgs e)
        {
            Panel_PubSub.Visible = true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Panel_WU.Visible = true;
        }
        private void SyncSub_Click(object sender, EventArgs e)
        {
            Panel_SS.Visible = true;
        }


        private void Menu_ReqRep_Click(object sender, EventArgs e)
        {
            Panel_ReqRep.Visible = false;
        }
        private void Menu_PubSub_Click(object sender, EventArgs e)
        {
            Panel_PubSub.Visible = false;
        }
        private void Menu_WU_Click(object sender, EventArgs e)
        {
            Panel_WU.Visible = false;
        }
        private void Menu_SS_Click(object sender, EventArgs e)
        {
            Panel_SS.Visible = false;
        }


        private void Go_ReqRep_Click(object sender, EventArgs e)
        {
            answer_ReqRep.Text = ReqRepClient(address_ReqRep.Text, message_ReqRep.Text);
        }
        private void Go_PubSub_Click(object sender, EventArgs e)
        {
           PubSubServer(address_PubSub.Text, message_PubSub.Text);
        }
        private void Go_WU_Click(object sender, EventArgs e)
        {
            WeatherUpd(address_WU.Text, textBox_ZipCode.Text, textBox_temp.Text);
        }
        private void Go_SS_Click(object sender, EventArgs e)
        {
            SyncSub(address1_SS.Text,address2_SS.Text,textBox_endKeyword.Text);
        }

       
    }
}
