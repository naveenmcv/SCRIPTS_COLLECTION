using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_moveKeyWithLimit_lookMouse_world : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public Transform camTrans;

    private void Update()
    {


        //*************************************************************************************************************** MOVE option 1 with limit

        // GetKey = continues,,       GetKeydown = 1 once only

        if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 5)
            //transform.position += Vector3.right;
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);   //world space

        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -5)
            //transform.position += Vector3.left;
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);   //world space

        if (Input.GetKey(KeyCode.UpArrow) && transform.position.z < 5)
            //transform.position += Vector3.forward;
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);   //world space

        if (Input.GetKey(KeyCode.DownArrow) && transform.position.z > -1)
            //transform.position += Vector3.back;
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.World);   //world space



        //**********************************************************************************************************    MOVE option 2 without limit
        /*

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        //movement in local space
        //transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));   //local space

        //movement in world space
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime), Space.World);   //world space

        */
        //********************************************************************************************************************* ROTATE
        
        //rotation on mouse hover from x and y
        Vector2 mouse_input = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //method 1
        //transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x - mouse_input.y, transform.rotation.eulerAngles.y + mouse_input.x, transform.rotation.eulerAngles.z);

        //method 2
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + new Vector3(-mouse_input.y, mouse_input.x, 0f));    //reversed - because its rotaton along axis

    }

}
  
