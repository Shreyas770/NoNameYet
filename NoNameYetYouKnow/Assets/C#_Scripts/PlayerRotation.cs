using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    [Range(1,300)]
    public float RotationSpeed;
    public Transform Player, Camera;
    public float MouseX, MouseY, XRotation;

    private void Start()
    {
        //Cursor will be locked and will not be seen if u add this line.
        Cursor.lockState = CursorLockMode.Locked;

    }

    private void Update()
    {
        //This line unlocks the curson when you press the ESCAPE key on our keyboard
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }


        float mouseX = Input.GetAxis("Mouse X") * RotationSpeed * Time.deltaTime;
        float MouseY = Input.GetAxis("Mouse Y") * RotationSpeed * Time.deltaTime;

        XRotation -= MouseY;
        XRotation = Mathf.Clamp(XRotation, -90, 90);

        transform.localRotation = Quaternion.Euler(XRotation, 0, 0);
        Player.Rotate(Vector3.up * mouseX);


    }
}
