using UnityEngine;

public class Movement : MonoBehaviour
{
  public float speed = 5f;
  private IMovementInput movementInput;

  void Start()
  {
    movementInput = GetComponent<IMovementInput>();
  }

  void Update()
  {
    Vector2 movementInputVector = movementInput.GetMovementInput();
    Vector3 movement = new Vector3(movementInputVector.x, 0, movementInputVector.y);
    Move(movement);
  }

  private void Move(Vector3 movement)
  {
    transform.Translate(movement * speed * Time.deltaTime);
  }
}