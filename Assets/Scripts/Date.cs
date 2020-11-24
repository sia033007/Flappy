      using UnityEngine;
      using System.Collections;
      using System;
      using System.Globalization;
      using CodeStage.AntiCheat.ObscuredTypes;
      using CodeStage.AntiCheat.Detectors;
      using Random=UnityEngine.Random;
      
      public class Date : MonoBehaviour
      {
      DateTime currentDate;
      DateTime oldDate;
      public static bool click;
 
      void Start()
  {
      //Store the current time when it starts
      currentDate = System.DateTime.Now;
 
      var oldTimeString = ObscuredPrefs.GetString("sysString", "10");
 
      if(!string.IsNullOrWhiteSpace(oldTimeString))
      {
          //Grab the old time from the player prefs as a long
          if(long.TryParse(oldTimeString, out var temp))
          {
              //Convert the old time from binary to a DataTime variable
              var oldDate = DateTime.FromBinary(temp);
              var difference = currentDate.Subtract(oldDate);
              if(difference.TotalHours>Random.Range(4,5))
              {
                  click=true;
                  
              }
              else
              {
                  
              }
          }
      }
      else
      {
          Debug.Log("First start -> No");
      }
  }
 
  }