using System;

namespace InstrumentProcessor
{
    public class ExceptionInstrument : IInstrument
    {
        public void Execute(string task)
        {
            throw new Exception();
        }

        public event EventHandler Finished;
        public event EventHandler Error;
    }
}
