using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    int[] exp = new int[5];

    //컬렉션 : 리스트, 큐, 스택, 해시이블, 디너리, 어레이리스트

    //AttayList
    //List
    //HashTable

    Hashtable hashtable = new Hashtable();

    List<int> list = new List<int>();

    ArrayList arrayList = new ArrayList(); //상대적으로 연산량이 많음
    void Start()
    {
        arrayList.Add(1);
        arrayList.Add(2);
        arrayList.Add(4.5);

        arrayList.Remove(2);

        Debug.Log(arrayList.Count);
        Debug.Log(arrayList.Contains(1));

        for (int i = 0; i < arrayList.Count; i++)
        {
            Debug.Log(arrayList[i]);
        }
    }
}
