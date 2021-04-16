using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoGenerator : MonoBehaviour
{
    string[] surnames, forenames, maleForenames, femaleForenames, countries, printers, genders, emailPrefixes, emailSuffixes;
    // somehow need to do cities per country
    void Start(){
    GlobalData.data.gen = this;
    surnames = new string[] {"Doe", "Appleseed"};
    maleForenames = new string[] {"John", "David"};
    forenames = new string[] {"Sam", "Jesse"}; //(generic, eventually for n/b)
    femaleForenames = new string[] {"Sara", "Kira"};
    countries = new string[] {"Korea", "China"}; //make these fictional eventually
    printers = new string[] {"Teutonikus Ltd.", "JYL"}; 
    genders = new string[] {"Male", "Female"};
    emailPrefixes = new string[] {""};
    emailSuffixes = new string[] {"yawoo.rn", "baobao.kr"};
    }
    public string GenerateSurname(int i){
        return surnames[i];
    }    
    public string GenerateForename(int i, int gender){
        switch (gender){
        case(0):
        return maleForenames[i]; // add a chance for n/b people
        case(1):
        return femaleForenames[i];
        default:
        return forenames[i];
        }
    }    
    public string GenerateCountry(int i){
        return countries[i];
    }    
    public string GeneratePrinter(int i){
        return printers[i];
    }    
    public string GenerateGender(int i){
        return genders[i];
    }
    public string GenerateEmail(int i){
        string tmp = emailPrefixes[0]; // replace this with a method to customise based on name, maybe pass forename/surname in as well
        tmp = tmp + "@";
        return tmp + emailSuffixes[i];
    }
}
