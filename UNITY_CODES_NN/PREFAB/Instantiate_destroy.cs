using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate_destroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj1;

    public void On_clicknn1()
    {

        Instantiate(obj1, transform.position, transform.rotation);
        
    }

    public void destroyobj()
    {
        GameObject obj_to_destroy = GameObject.Find("Cube_aa(Clone)");

        Destroy(obj_to_destroy);
    }


    public void destroy_and_instantiate()
    {
        if (GameObject.Find("Cube_aa(Clone)") != null)
        {
            Debug.Log("found clone object");

            On_clicknn1();
            destroyobj();

            //it exists
        }

        else {
            Debug.Log("not found any clone");
        }
       


    }





}
