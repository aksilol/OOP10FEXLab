
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

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

        // SAVE TO TEXT FILE BUTTON
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "Text Files (*.txt)|*.txt";
                saveFile.Title = "Save Queue to Text File";
                saveFile.FileName = "Queue_Report.txt";
                saveFile.DefaultExt = "txt";
                saveFile.AddExtension = true;

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        StringBuilder content = new StringBuilder();

                        content.AppendLine("================================");
                        content.AppendLine("          KIOSK QUEUE");
                        content.AppendLine("================================");
                        content.AppendLine("Date: " + DateTime.Now);
                        content.AppendLine();

                        // PREPARING ORDERS
                        content.AppendLine("PREPARING ORDERS");
                        content.AppendLine("--------------------------------");

                        if (lstPreparing.Items.Count == 0)
                        {
                            content.AppendLine("No orders preparing.");
                        }
                        else
                        {
                            foreach (var item in lstPreparing.Items)
                            {
                                content.AppendLine(item.ToString());
                            }
                        }

                        content.AppendLine();

                        // READY ORDERS
                        content.AppendLine("READY / NOW SERVING ORDERS");
                        content.AppendLine("--------------------------------");

                        if (lstNowServing.Items.Count == 0)
                        {
                            content.AppendLine("No orders ready.");
                        }
                        else
                        {
                            foreach (var item in lstNowServing.Items)
                            {
                                content.AppendLine(item.ToString());
                            }
                        }

                        content.AppendLine();
                        content.AppendLine("================================");
                        content.AppendLine("          END OF REPORT");
                        content.AppendLine("================================");

                        // SAVE FILE
                        File.WriteAllText(
                            saveFile.FileName,
                            content.ToString(),
                            Encoding.UTF8
                        );

                        // OPEN SAVED FILE
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = saveFile.FileName,
                            UseShellExecute = true
                        });

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            "Unable to save or open the file.\n\n" + ex.Message,
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }

        private void Queue_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
