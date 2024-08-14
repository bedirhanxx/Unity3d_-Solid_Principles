using System.IO;

/*
 * In Unity3D, this can be demonstrated by having a high-level class (e.g., GameManager) depend on an abstraction
 * (e.g., ILogger) instead of directly depending on a concrete logging implementation.
 *
 * This class is a low-level implementation of ILogger, logging messages to a file.
*/

public class FileLogger : ILogger
{
  private string filePath;

  public FileLogger(string path)
  {
    filePath = path;
  }

  public void Log(string message)
  {
    File.AppendAllText(filePath, message + "\n");
  }
}