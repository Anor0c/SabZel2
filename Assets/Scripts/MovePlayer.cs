using UnityEngine.InputSystem;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    Vector2 stickDirection;
    Vector3 moveDirection;
    CharacterController controller;

    public float playerSpeed;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    public void OnMovePlayer(InputAction.CallbackContext obj)
    {
        stickDirection = obj.ReadValue<Vector2>();
    }
    private void FixedUpdate()
    {
        moveDirection = new Vector3(stickDirection.x, 0f, stickDirection.y);
        controller.Move(moveDirection * playerSpeed * Time.deltaTime);
    }
}
