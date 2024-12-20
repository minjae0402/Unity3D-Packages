using System;
using UnityEditor;
using UnityEngine;

public class ErrorMain : MonoBehaviour
{
    int a = 5, b = 0, c;
    void Start()
    {
        try
        {
            c = a / b;
        }
        catch (DivideByZeroException ie)
        {
            print(ie);
            b = 1;
            c = a / b;
        }
        finally
        {
            print(c);
        }
        //throw new Exception("Error : 일부러 오류를 발생시키기");
    }
}
