using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Test
{
    public void Speak(string str)
    {
        Debug.Log("Test1" + str);
    }
}
namespace MrTang
{
    public class Test2
    {
        public void Speak(string str)
        {
            Debug.Log("Test2" + str);
        }
    }
}
public enum E_MyEnum
{ 
Idle,
Move,
Atk
}
public class LuaCallCSharp : MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
