using UnityEngine;

public class children1 : Parents
{
    string schoolName;

    void Start()
    {
        schoolName = "인천하늘고등학교";
        Name = "민승재";
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
