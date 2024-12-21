using UnityEngine;

public class Test : MonoBehaviour
{
    bool num = false;

    Vector3 rotation;

    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            num = true;
        }
        // if (Input.GetKey(KeyCode.W))
        // {
        //     this.transform.position = this.transform.position + new Vector3(0, 0, 0.05f) * Time.deltaTime;
        // }
        // else if (Input.GetKey(KeyCode.A))
        // {
        //     this.transform.position = this.transform.position + new Vector3(-0.05f, 0, 0) * Time.deltaTime;
        // }
        // else if (Input.GetKey(KeyCode.D))
        // {
        //     this.transform.position = this.transform.position + new Vector3(0.05f, 0, 0) * Time.deltaTime;
        // }
        // else if (Input.GetKey(KeyCode.S))
        // {
        //     this.transform.position = this.transform.position + new Vector3(0, 0, -0.05f) * Time.deltaTime;
        // }

        //this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

        if (num)
        {
            this.transform.eulerAngles = transform.eulerAngles + new Vector3(90, 0, 0) * Time.deltaTime;
            Debug.Log(transform.eulerAngles);
            num = false;
        }
    }
}
