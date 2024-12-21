using System.Collections;
using UnityEngine;

public class Part : MonoBehaviour
{
    Coroutine myCoroutine1;
    Coroutine myCoroutine2;

    void Start()
    {
        myCoroutine1 = StartCoroutine(LoopA());
        myCoroutine2 = StartCoroutine(LoopB());
        StartCoroutine(Stop());
    }

    IEnumerator LoopA()
    {
        for (int i = 0; i < 100; i++)
        {
            print("i의 값 = " + i);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator LoopB()
    {
        for (int x = 0; x < 100; x++)
        {
            print("x의 값 = " + x);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator Stop()
    {
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine1);
        yield return new WaitForSeconds(2f);
        StopCoroutine(myCoroutine2);
    }

}
