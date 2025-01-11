using Unity.VisualScripting;
using UnityEngine;

public class codetest : MonoBehaviour
{
    [SerializeField]
    private int myPrivateField;
    [SerializeField]
    private float hello;
    private float _float;
    void Start()
    {
        _float = 0.0043f;
    }

    void Update()
    {
        //_float.Clone
    }
}
