using System.Drawing;

namespace OS_Practice6;
internal class Memory
{
    private const int MemorySize = 65536;
    private static int _freeMemorySize = MemorySize;
    const char sqr = '■';

    private static int TaskQueue()
    {
        Random taskQueueSize = new Random();
        return taskQueueSize.Next(16);
    }

    internal static void AddTask()
    {
        int queue = TaskQueue();
        Task task = new Task();
        for (int i = 0; i < queue; i++)
        {
            task.taskName += i;
            _freeMemorySize -= task.taskSize;
            Drawing(task.taskSize);
        }
    }

    private static void Drawing(int size)
    {
        Color clr;
        string memoryString = "";
        if (_freeMemorySize > 0)
        {
            for (int i = 0; i < size; i++)
            {
                memoryString += sqr;
            }

            if (size == 8)
            {
                clr = Color.Blue;
            }
            else if (size == 9)
            {
                clr = Color.Aqua;
            }
            else if (size == 10)
            {
                clr = Color.Magenta;
            }
            else
            {
                clr = Color.Red;
            }

            Window.textMemory.AppendText(memoryString, clr);
        }
        else
        {

        }
    }
}
