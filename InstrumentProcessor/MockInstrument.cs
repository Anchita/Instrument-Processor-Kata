using System;

namespace InstrumentProcessor
{
    public class MockInstrument : IInstrument
    {
        public int ExecuteCount { get; set; }
        public string ExecutedTask { get; set; }

        public void Execute(string task)
        {
            ExecuteCount++;
            ExecutedTask = task;
        }

        public event EventHandler Finished;
        public event EventHandler Error;
    }
}
