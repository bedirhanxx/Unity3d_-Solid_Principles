using UnityEngine;
/*
 *The high-level class that depends on the ILogger interface.
 * It doesn't care about the specific logging implementation it receives,
 * adhering to the Dependency Inversion Principle.
 */
public class GameManager : MonoBehaviour
{
  private ILogger logger;

  // Dependency Injection via a method
  public void Initialize(ILogger logger)
  {
    this.logger = logger;
  }

  void Start()
  {
    if (logger == null)
    {
      Debug.LogError("Logger is not initialized!");
      return;
    }

    logger.Log("Game started");
  }

  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Space))
    {
      logger.Log("Space key pressed");
    }
  }
}