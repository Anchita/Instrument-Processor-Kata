using System;

namespace InstrumentProcessor
{
    public class MockTaskDispatcher : ITaskDispatcher
    {
        private readonly string _task;
        public int GetTaskCount { get; set; }

        public MockTaskDispatcher(string task)
        {
            _task = task;
        }

        public string GetTask()
        {
            GetTaskCount++;
            return _task;
        }

        public void FinishedTask(string task)
        {
            throw new NotImplementedException();
        }
    }
}
