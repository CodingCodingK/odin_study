using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]//可以直接在Project右键创建
public class MySciptObj : ScriptableObject
{
    public List<MyObj> myObjs;
}

[Serializable]
public class MyObj
{
    public int age;
    public string name;
}