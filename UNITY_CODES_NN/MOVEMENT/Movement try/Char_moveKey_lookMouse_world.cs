using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_moveKey_lookMouse_world : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;
    public Transform camTrans;

    private void Update()
    {
        
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        //movement in local space
        //transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));   //local space

        //movement in world space
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime), Space.World);   //world space

        //rotation on mouse hover from x and y
        Vector2 mouse_input = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x-mouse_input.y, transform.rotation.eulerAngles.y+mouse_input.x, transform.rotation.eulerAngles.z);

    }

}
  