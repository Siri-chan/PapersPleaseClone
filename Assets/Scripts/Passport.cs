using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class Passport
{    /*
    Data Submitted @ https://forms.gle/FqxPo2uKjsJ4x4wd8
    */
    InfoGenerator gen = GlobalData.data.gen;
    public int[] credentials;
    // {Surname, Forename, Country, IssuingDay, IssuingMonth, IssuingYear, IssuingCity, Height, Weight, Printing Company, Gender, eMail, VisualFeatures(eventually),}
    public string surname, forename, country, printer, gender, email;
    public int issueDay, issueMonth, issueYear, weight, height;
    public Passport(){
        credentials = new int[12];
        int[] maxValue = new int[] {1, 1, 1, 31, 12, 2077, 1, 200, 145, 1, 1, 5, 1};
        int[] minValue = new int[] {0, 0, 0, 0, 0, 2067, 0, 150, 45, 0, 0, 0, 0};
        for(int i = 0; i < credentials.Length - 1; i++){
            credentials[i] = UnityEngine.Random.Range(minValue[i], maxValue[i] + 1);
        }
        surname = gen.GenerateSurname(credentials[0]);
        forename = gen.GenerateForename(credentials[1], credentials[10]);
        country = gen.GenerateCountry(credentials[2]);
        printer = gen.GeneratePrinter(credentials[9]);
        gender = gen.GenerateGender(credentials[10]);
        email = gen.GenerateEmail(credentials[11]);
        issueYear = credentials[5];
        issueMonth = credentials[4];
        issueDay = credentials[3];
        weight = credentials[8];
        height = credentials[7];
    }
}
