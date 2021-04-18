using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class IDController : MonoBehaviour
{
    public TMPro.TMP_Text cardHolder, sex, countryCity, weight, height, issueDate;
    void Start()
    {
        GlobalData.data.draw = this;
    }
    public void DrawPassport(Passport p){
        cardHolder.text = p.forename + " " + p.surname;
        sex.text = p.gender;
        countryCity.text = p.country + " \n " + "City";
        weight.text = p.weight + "kg";
        height.text = p.height + "cm";
        issueDate.text = p.issueYear + "-" + p.issueMonth + "-" + p.issueDay;
        return;
    }
}
