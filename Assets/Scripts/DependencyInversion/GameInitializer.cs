using UnityEngine;

/*You can inject different ILogger implementations into the GameManager depending on your needs.*/


public class GameInitializer : MonoBehaviour
{
  public GameManager gameManager;

  void Awake()
  {
    // Initialize the logger
    ILogger logger = new ConsoleLogger();

    // Inject the dependency
    gameManager.Initialize(logger);
  }
}