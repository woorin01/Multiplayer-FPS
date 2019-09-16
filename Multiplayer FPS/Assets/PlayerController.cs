using UnityEngine;

[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour
{
    //public Camera camera;

    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float mouseSensitivity;

    private PlayerMotor motor;
    //private Vector3 gap;

    private void Start()
    {
        motor = GetComponent<PlayerMotor>();
    }

    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 moveHorizontal = transform.right * x;
        Vector3 moveVertical = transform.forward * z;

        Vector3 velocity = (moveHorizontal + moveVertical).normalized * speed;
        motor.Move(velocity);

        float yRot = Input.GetAxisRaw("Mouse X");

        Vector3 rot = new Vector3(0f, yRot, 0f) * mouseSensitivity;

        motor.Rotate(rot);

        float xRot = Input.GetAxisRaw("Mouse Y") * -1;

        Vector3 cameraRot = new Vector3(xRot, 0f, 0f) * mouseSensitivity;

        motor.RotateCamera(cameraRot);
        //RotatePlayerAndCamera();
    }

    //private void RotatePlayerAndCamera()
    //{
    //    float x = Input.GetAxis("Mouse Y") * -1;
    //    float y = Input.GetAxis("Mouse X");

    //    Vector3 temp = new Vector3(x, y) * mouseSensitivity;

    //    //PlayerMotor.RotatePC(temp) { rot += temp; }
    //    gap += temp;
    //    //gap.x = Mathf.Clamp(gap.x, -90f, 90f);

    //    camera.transform.rotation = Quaternion.Euler(gap);
    //    transform.rotation = Quaternion.Euler(0f, gap.y, 0f);

    //}
}
//Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2));
//if(Physics.Raycast(ray.origin, ray.direction, out RaycastHit hit))
//{

//}