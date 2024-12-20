using UnityEngine;

abstract public class Parents : MonoBehaviour
{
    protected string Name;
    protected int age;

    protected virtual void Info()
    {
        print("나는 인간입니다. ");
    }
    abstract protected void PrintName();
}
