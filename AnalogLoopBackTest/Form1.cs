using NationalInstruments.DAQmx;
using System;
using System.Windows.Forms;
// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace AnalogLoopBackTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadAnalogDataButton_Click(object sender, EventArgs e)
        {
            Task AnalogInputTask = new Task();
            AIChannel myAIChannel;

            myAIChannel = AnalogInputTask.AIChannels.CreateVoltageChannel(
                "dev1/ai0",
                "myAIChannel",
                AITerminalConfiguration.Differential,
                0,
                5,
                AIVoltageUnits.Volts);

            var AnalogSingleReader = new AnalogSingleChannelReader(AnalogInputTask.Stream);
            double AnalogDataIn = AnalogSingleReader.ReadSingleSample();

            outDatatextBox.Text = Convert.ToString(AnalogDataIn);

        }

        private void WriteAnalogDataButton_Click(object sender, EventArgs e)
        {
            Task AnalogOutTask = new Task();
            AOChannel myAOChannel;

            myAOChannel = AnalogOutTask.AOChannels.CreateVoltageChannel(
                "dev1/ao0",
                "myAOChannel",
                0,
                5,
                AOVoltageUnits.Volts);
            var AnalogSingleWriter = new AnalogSingleChannelWriter(AnalogOutTask.Stream);
            double AnalogDataOut;
            AnalogDataOut = Convert.ToDouble(inDataTextBox.Text);
            AnalogSingleWriter.WriteSingleSample(true, AnalogDataOut);
        }
    }
}
