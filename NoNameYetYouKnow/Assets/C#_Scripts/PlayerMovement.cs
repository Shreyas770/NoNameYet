using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 300f;

    Vector3 Velocity;

    public float gravity = -9.81f;

    public CharacterController PlayerMovementController;

    void Update()
    {

        playerMovement();

    }

    //Fuction shud be added in update 

    public void playerMovement()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");


        Velocity.y += gravity * Time.deltaTime;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        PlayerMovementController.Move(move * MoveSpeed * Time.deltaTime);
        PlayerMovementController.Move(Velocity * Time.deltaTime);


    }
}
