using UnityEngine;

public class InputManager : MonoBehaviour, IMovementInput
{
  public Vector2 GetMovementInput()
  {
    float moveHorizontal = Input.GetAxis("Horizontal");
    float moveVertical = Input.GetAxis("Vertical");
    return new Vector2(moveHorizontal, moveVertical);
  }
}