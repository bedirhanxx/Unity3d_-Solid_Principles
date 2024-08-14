/*
 * In Unity3D, this can be demonstrated by having a high-level class (e.g., GameManager) depend on an abstraction
 * (e.g., ILogger) instead of directly depending on a concrete logging implementation.
 */


public interface ILogger
{
  void Log(string message);
}