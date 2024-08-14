using UnityEngine;

[RequireComponent(typeof(AIInputManager))]
public class AIController : MonoBehaviour
{
    private Movement playerMovement;

    void Start()
    {
        playerMovement = GetComponent<Movement>();
    }
}
