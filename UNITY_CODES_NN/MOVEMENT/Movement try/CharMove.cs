using UnityEngine;

public class CharMove : MonoBehaviour
{
    [SerializeField] private float speed = 5.0f;

    //[SerializeField] private float xx = 2.0f;
    //[SerializeField] private float zz = 2.0f;


    //private Transform tranform = GameObject.Transform.position;

    private void Update()
    {
        //mine nn

        Vector3 bar = transform.position;

        //float xx = transform.position.x;
        //float yy = transform.position.y;
        //float zz = transform.position.z;
        float xx = bar.x;
        float yy = bar.y;
        float zz = bar.z;

        Debug.Log(bar);
        //Debug.Log(xx);
        //Debug.Log(yy);
        //Debug.Log(xx ,yy, zz);

        //Debug.Log(string.Format("WeaponNum = {0}", WeaponNum));
        Debug.Log(string.Format("x={0},y={0},z={0}", xx,yy,zz));


        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(horizontal, 0, vertical) * (speed * Time.deltaTime));
    }
}


/*Vector3 vector = new Vector3(0,1,0);
// Convert to float array
floats[] toFloat = new float[]{vector.x,vector.y,vector.z};
// Back to vector
vector = new Vector3 (toFloat[1], toFloat[2], toFloat[3]);
*/