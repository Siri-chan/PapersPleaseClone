using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class GlobalData : MonoBehaviour
{
    public static GlobalData data {get; private set;}
    public InfoGenerator gen;
    public IDController draw;
    private void Awake(){
        if(data==null){data = this;
        DontDestroyOnLoad(gameObject);}
        else {Destroy(gameObject);}
    }
}
