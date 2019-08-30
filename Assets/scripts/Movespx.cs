using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movespx : MonoBehaviour
{
    public float target_kmth_ = 10f;
    public Transform target;
    public float Lookrotate = 0.01f;


    // Update is called once per frame
    void FixedUpdate()
    {

        //var rb = GetComponent<Rigidbody>();

     

        //var left = transform.TransformVector(Vector3.left);
        //var hori_left = new Vector3(left.x, left.y, left.z).normalized;
        //rb.AddTorque(Vector3.Cross(left, hori_left * 2f));

        //var forward = transform.TransformVector(Vector3.forward);
        //var hori_forward = new Vector3(forward.x, 0f, forward.z).normalized;
        //rb.AddTorque(Vector3.Cross(forward, hori_forward * 2f));

        //var force = (rb.mass * rb.drag * target_kmth_ / 3.6f) / (1f - rb.drag * Time.fixedDeltaTime);
        ////終端速度の計算　drag 抵抗
        //rb.AddRelativeForce(new Vector3(0f, 0f, force));


    }

    void Update()
    {
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(target.position - transform.position), Lookrotate);


        //targetに向かって進む
        transform.position += transform.forward * target_kmth_ ;

    }
}
