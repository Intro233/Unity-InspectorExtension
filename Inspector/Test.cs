using System.Collections;
using System.Collections.Generic;
using UniFramework.Editor;
using UnityEngine;

public class Test : MonoBehaviour
{
    [Label("是否在跑")]
    public bool isRun;

    [Button("跑起来")]
    public void Run()
    {
        Debug.Log("Run");
    }

}
