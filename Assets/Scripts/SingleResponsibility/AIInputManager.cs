using UnityEngine;

public class AIInputManager : MonoBehaviour, IMovementInput
{
  public Vector2 GetMovementInput()
  {
    // AI logic to determine movement direction
    // Example: Move towards a target
    Vector2 aiMovement = new Vector2(1, 0); // Move right
    return aiMovement;
  }
}