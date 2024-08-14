using UnityEngine;

[RequireComponent(typeof(InputManager))]
public class PlayerController : MonoBehaviour
{
    private Movement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<Movement>();
    }
}
