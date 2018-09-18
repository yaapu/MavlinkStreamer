using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace MavlinkStreamer
{
    public partial class MainForm : Form
    {
        private String tlogFullPath = null;
        private long counter = 0;
        private bool isStreaming = false;
        private string[] serialPortNames = null;
        private string serialPort = null;

        public MainForm()
        {
            InitializeComponent();
            cbSerialPort.Items.Clear();
            getSerialPorts();
            foreach (string port in serialPortNames)
            {
                cbSerialPort.Items.Add(port); 
            }
        }

        private void btTLOG_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                tlogFullPath = openFileDialog.FileName;
                txtTlogFileName.Text = openFileDialog.SafeFileName;
                FileInfo fi = new System.IO.FileInfo(tlogFullPath);
                txtFileSize.Text = fi.Length.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isStreaming)
            {
                //stop
                isStreaming = false;
                btStart.Text = "START";
            }
            else
            {
                isStreaming = true;
                btStart.Text = "STOP";
                serialPort = cbSerialPort.Text;
                Thread t = new Thread(stream);
                t.Start();
            }
        }

        private void getSerialPorts()
        {
            // Get a list of serial port names.
            serialPortNames = SerialPort.GetPortNames();
        }

        private void stream()
        {
            SerialPort port = new SerialPort(serialPort, 57600, Parity.None, 8, StopBits.One);
            port.Open();
            counter = 0;
            // read from file or write to file
            using (FileStream fileStream = new FileStream(tlogFullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {

                BinaryReader binary = new BinaryReader(fileStream);
                byte[] buffer = new byte[64];
                buffer = binary.ReadBytes(64);
                while (buffer != null && buffer.Length > 0 && isStreaming)
                {
                    port.Write(buffer, 0, buffer.Length);
                    port.BaseStream.Flush();
                    counter += buffer.Length;
                    txtByteCount.Invoke((MethodInvoker)delegate { txtByteCount.Text = counter.ToString(); });
                    buffer = binary.ReadBytes(64);
                }
            }
            port.Close();
        }
    }
}
