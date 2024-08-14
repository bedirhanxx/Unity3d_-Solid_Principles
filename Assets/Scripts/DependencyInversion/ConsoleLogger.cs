using UnityEngine;

/*
 * This class is a low-level implementation of ILogger, logging messages to the console.
*/

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Debug.Log(message);
    }
}
