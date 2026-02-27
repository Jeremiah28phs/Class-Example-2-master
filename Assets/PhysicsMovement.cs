using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    // By making this private, it will not appear in the editor
    private Rigidbody rb;

    public float moveSpeed;
    public float turnSpeed;
    public float jumpForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Automatically looks for a Rigidbody component on the current GameObject
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // ------- Movement -------

        // Creates one vector where X is the input from A and D, and Z is the input from X and Y
        Vector3 movementInput = Vector3.right * Input.GetAxisRaw("Horizontal") + Vector3.forward * Input.GetAxisRaw("Vertical");

        // Start from current location, and then slightly adjusts the position by adding on the inputs scaled by speed and adjusted for framerate
        Vector3 targetPosition = rb.position + movementInput * moveSpeed * Time.deltaTime;

        // Moves the rigidbody to its target position
        rb.MovePosition(targetPosition);

        // ------- Rotation -------

        // Clockwise rotations
        if (Input.GetKey(KeyCode.E))
        {
            // Start from the current rotation, converting it to a Vector
            Vector3 currentRotation = rb.rotation.eulerAngles;

            // Add to the y-coordinate of the angle to rotate clockwise
            Vector3 targetRotation = currentRotation + Vector3.up * turnSpeed * Time.deltaTime;

            // Need to change the target rotation to a quaternion before passing it to rigidbody
            rb.MoveRotation(Quaternion.Euler(targetRotation));
        }

        // ------- Jumping -------

        // Add a force impulse to the player that pushes them upwards
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
