using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Kiosk
{

    public partial class Queue : Form
    {

        public Queue()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            timer1.Start();

            DisplayQueue();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var order in QueueStore.Orders)
            {
                if (order.Status == OrderStatus.Preparing)
                {
                    double elapsedSeconds =
                        (DateTime.Now - order.OrderDate).TotalSeconds;

                    if (elapsedSeconds >= 10)
                    {
                        order.Status = OrderStatus.NowServing;
                    }
                }
            }

            DisplayQueue();
        }
        private void DisplayQueue()
{
    lstPreparing.Items.Clear();
    lstNowServing.Items.Clear();

    foreach (var order in QueueStore.Orders)
    {
        string orderInfo =
            order.OrderNumber + " - ₱" +
            order.TotalAmount.ToString("0.00");

        if (order.Status == OrderStatus.Preparing)
        {
           lstPreparing.Items.Add(orderInfo);
        }
        else if (order.Status == OrderStatus.NowServing)
        {
            lstNowServing.Items.Add(orderInfo);
        }
    }
}
        private void Queue_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
