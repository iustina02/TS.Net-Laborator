using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorul_1_3
{
    public partial class Form1 : Form
    {
        int nr_prim_1 = 2;
        public Form1()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;

            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.WorkerSupportsCancellation = true;
        }


        private void startAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                // Start the asynchronous operation
                backgroundWorker1.RunWorkerAsync();
                first_start_time.Text = DateTime.Now.ToString("hh:mm:s:ms");
                backgroundWorker2.RunWorkerAsync();
                second_start_time.Text = DateTime.Now.ToString("hh:mm:s:ms");
            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel.Text = ("Non-prime: " + e.ProgressPercentage.ToString());

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int n = 86231234;
            bool prime;
            for (int i = n - 1; i > 1; i--)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    //System.Threading.Thread.Sleep(200);
                    prime = true;
                    if (i <= 1)
                        prime = false;
                    else if (i % 2 == 0)
                        prime = false;

                    int N = (int)(Math.Sqrt(i) + 0.5);

                    for (int j = 3; j <= N; j += 2)
                        if (i % j == 0)
                            prime = false;

                    if (prime == true)
                    {
                        nr_prim_1 = i;
                        break;
                    }
                    worker.ReportProgress(i);
                }
            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel.Text = "Prime: " + nr_prim_1.ToString();
                first_end_time.Text = DateTime.Now.ToString("hh:mm:s:ms");
            }
        }


        private void cancelAsyncButton_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                // Cancel the asynchronous operation.
                backgroundWorker1.CancelAsync();
                backgroundWorker2.CancelAsync();
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int n = 86231234;
            int prime;
            for (int i = n - 1; i > 1; i--)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    prime = 1;
                    if (i % 2 == 0)
                        prime = 0;
                    for (int j = 3; j < i; j++)
                    {
                        if (i % j == 0)
                            prime = 0;
                    }
                    if (i == 2)
                        prime = 1;
                    if (prime == 1)
                    {
                        nr_prim_1 = i;
                        break;
                    }
                    worker.ReportProgress(i);
                }

            }
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            resultLabel2.Text = ("Non-prime: " + e.ProgressPercentage.ToString());
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                resultLabel2.Text = "Canceled!";
            }
            else if (e.Error != null)
            {
                resultLabel2.Text = "Error: " + e.Error.Message;
            }
            else
            {
                resultLabel2.Text = "Prime: " + nr_prim_1.ToString();
                second_end_time.Text = DateTime.Now.ToString("hh:mm:s:ms");
            }
        }
    }
}
