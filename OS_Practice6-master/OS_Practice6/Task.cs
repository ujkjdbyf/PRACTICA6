namespace OS_Practice6
{
    internal class Task
    {
        internal string taskName = "Task №";
        internal int taskTime = TaskTime();
        internal int taskSize = TaskSize();
        private static int taskSize1 = TaskSize();
        internal int taskSizeInByte = taskSize1;
        internal int taskReservedByte = TaskReservedSize();

        private static int TaskSize()
        {
            Random taskSize = new Random();
            return taskSize.Next(1, 10);
        }

        private static int TaskTime()
        {
            Random taskTime = new Random();
            return taskTime.Next(0, 30);
        }

        private static int TaskReservedSize()
        {
            if (taskSize1 % 8 == 0)
            {
                return taskSize1;
            }
            else
            {
                return (taskSize1 / 8 + 1) * 8;
            }
        }
    }
}
