using System;
using NUnit.Framework;

namespace InstrumentProcessor
{
    public class Tests
    {
        [Test]
        public void InstrumentProcessorShouldGetNextTaskAndExecuteUsingInstrument()
        {
            var task1 = "task 1";
            var taskDispatcher = new MockTaskDispatcher(task1);
            var instrument = new MockInstrument();

            var instrumentProcessor = new InstrumentProcessor(taskDispatcher, instrument);
            instrumentProcessor.Process();

            Assert.AreEqual(1, taskDispatcher.GetTaskCount);
            Assert.AreEqual(1, instrument.ExecuteCount);
            Assert.AreEqual(task1, instrument.ExecutedTask);
        }


        [Test]
        public void InstrumentProcessorShouldHandleException()
        {
            var task1 = "task 1";
            var taskDispatcher = new MockTaskDispatcher(task1);
            var instrument = new ExceptionInstrument();

            var instrumentProcessor = new InstrumentProcessor(taskDispatcher, instrument);
            
            Assert.Throws<Exception>(() => instrumentProcessor.Process());
        }
    }
}