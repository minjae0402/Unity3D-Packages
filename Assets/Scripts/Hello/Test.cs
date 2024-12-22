using UnityEditor.MPE;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] GameObject go_Camera;
    void Update()
    {
        // if (Input.GetKey(KeyCode.W))
        // {
        //     this.transform.LookAt(go_Camera.transform.position);
        // }
        transform.RotateAround(go_Camera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
