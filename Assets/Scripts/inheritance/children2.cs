using UnityEngine;

public class children2 : Parents
{
    string schoolName;

    void Start()
    {
        schoolName = "선린인터넷고 등학교";
        Name = "강민재";
        age = 17;

        Info();
        PrintName();
    }

    protected override void Info()
    {
        base.Info();
    }

    protected override void PrintName()
    {
        print(schoolName);
        print(Name);
        print(age);
    }

}
