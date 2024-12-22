using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody myRigid;

    void Start()
    {
        myRigid = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            myRigid.angularVelocity = new Vector3(1, 0, 0);
        }
    }
}
