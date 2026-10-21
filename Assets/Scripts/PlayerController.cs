using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    [SerializeField] public float speed = 5.0f;
    [SerializeField] public float turnSpeed;
    public InputAction MoveAction;
    public Vector2 moveInput;



    void FixedUpdate()
    {
        moveInput = MoveAction.ReadValue<Vector2>();
        //Move the v forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveInput.y);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * moveInput.x);
    }
}
