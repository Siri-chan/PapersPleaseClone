using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputTest : MonoBehaviour
{
    public void OnConfirm(){
        Debug.Log("Confirm");
    }
    public void OnDeny() {
        Debug.Log("Input!");
    }
}
