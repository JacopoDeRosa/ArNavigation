using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SessionData
{
   private static string _userName;
   private static int _domandeSbagliate;
   private static float _timeAtStart; 

    public static string UserName { get => _userName; }

    public static void StartNewSession(string name)
    {
        _userName = name;
        _domandeSbagliate = 0;
        _timeAtStart = Time.time;
    }

    public static void IncreaseWrongQuestions()
    {
        _domandeSbagliate++;
    }

    public static string GetSessionData()
    {
        string data = "Dati test app AR di " + _userName + ": \n \n";
        
        data += "Numero di risposte sbagliate " + _domandeSbagliate + " \n";
        TimeSpan time = TimeSpan.FromSeconds(Time.time - _timeAtStart);
        data += "Tempo Totale impiegato: " + time.ToString("hh':'mm':'ss");

        return data;
    }
}
