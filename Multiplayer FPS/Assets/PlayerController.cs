using UnityEngine;
using System.Collections.Generic;
using System;
using System.Collections;

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

        Apple a = new Apple();
        a.Move();//basic move!
        a.HideMethod();//짭탱사과 
        a.Same();//all the same

        Berry b = new Berry();
        b.Move();//berry move
        b.HideMethod();//짭탱베리
        b.Same();//all the same

        Fruit aa = new Apple();
        aa.Move();//basic move!
        aa.HideMethod();//원조
        aa.Same();//all the same

        Fruit bb = new Berry();
        bb.Move();//berry move
        bb.HideMethod();//원조
        bb.Same();//all the same

        int i = 10;
        int sum = i.MyDoublePlus(20);
        Debug.Log(sum);

        string s = "4";
        bool bo = s.MyStringParase();
        Debug.Log(bo);
       
        transform.ResetTransformation();
        string sss = "a";
        Debug.Log(sss.GetT<string>());
        Debug.Log(sss.GetT());

        //string.GetT<int>()는 안된다. 왜냐하면 <>안에 자료형을 넣기 전에는 GetT는 T를 위한 확장 메서드가 된다(이 말은 모두를 위한 확장 메서드가 된다는 말이다)
        //하지만 <>안에 자료형을 넣게 되면 this T t 부분에서 T가 <>안에 넣은 자료형으로 바뀌면서 <>안에 넣은 자료형을 위한 확장 메서드가 되버린다
        //그래서 string.GetT<int>()를 하게 되면 int를 위한 확장 메서드가 되고 string에는 GetT에 대한 확장 메서드 정의가 포함 되어 있지 않기 때문에 오류가 난다

        List<int> ac = new List<int>();
        ac.Add(10);
        ac.Add(100);

        foreach(int bbb in ac)
        {
            Debug.Log(bbb);
        }
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