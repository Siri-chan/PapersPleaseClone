using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/****************************************
PLOT
You are the Surpeme Leader of *nation* and you are tasked with deporting foregners who have overstayed their welcome.

*****************************************/

public class Game : MonoBehaviour
{
    Passport x;
    bool hasPassport = false;
    void Update() {
        if(!hasPassport){
            GenPassport();
        }
        else{
            DrawPassport(x);
        }
    }
    void GenPassport(){
        x = new Passport();
        //you can use x.credentials[i] to handle `if` statements with easier logic, then just use x.surname/forename/whatever for visual handling
        Debug.Log(" Name: " + x.forename + " " + x.surname + "\n Country: " + x.country + "\n Printing Company: " + x.printer + "\n Gender: " + x.gender + "\n Email: " + x.email);
        hasPassport = true;
    }
    public void OnConfirm(){
        Debug.Log("Confirmed!");
        hasPassport = false;
    }
    public void OnDeny() {
        Debug.Log("Denied!");
        hasPassport = false;
    }
    void DrawPassport(Passport p){
        //move this to a seperate script on a blank passport gameobject
        return;
    }
}
