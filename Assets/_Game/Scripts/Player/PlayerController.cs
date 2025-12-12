using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    PlayerInput playerInput;

    public Transform cameraTransform;
    public float speed = 3f;
    public bool isAttack = false;

    private void Awake()
    {
        playerInput = new PlayerInput();

        playerInput.Player.Enable();
    }

    public Vector2 GetMoveDirection()
    {
        Vector2 inputVector = playerInput.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }

    public void OnAttack(InputAction.CallbackContext ctx)
    {
        if (ctx.performed) 
            isAttack = true;
    }

    public void CharacterMove()
    {
        //cameraTransform.forward
    }
}
