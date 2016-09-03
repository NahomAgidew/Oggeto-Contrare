/*
                                                          *******************************                          
                                               ***********                               ***********               
                                         ******                                                     ******         
                                     ****                                                                 ****     
                                   **                   OgettoContatore.cs                                    **   
                                 **                     Author: Nahom A.                                        ** 
                                 *                                                                               * 
                                 **                     MasterDevelopers Studios                                ** 
                                   **                                                                         **   
                                     ****                                                                 ****     
                                         ******                                                     ******         
                                               ***********                               ***********               
                                                          *******************************                          



*/

/*
		Copyright 2016 MasterDevelopers Studios.
*/
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class OgettoContrare : MonoBehaviour
{
    public List<string> Tags;
    static Dictionary<string, int> status = new Dictionary<string, int>();

    //Start counting before getting called quickly
    void Awake()
    {
        CountEntity();
    }

    void Update()
    {
        CountEntity();
    }

    private void CountEntity()
    {
        foreach (var obj in Tags)
        {
            try
            {
                if (!status.ContainsKey(obj))
                {
                    status.Add(obj, GameObject.FindGameObjectsWithTag(obj).Length);
                }
                else if (status.ContainsKey(obj))
                {
                    status[obj] = GameObject.FindGameObjectsWithTag(obj).Length;
                }
            }
            catch
            {
            }
        }
    }

    public static int GetObjectStatus(string tag)
    {
        int ret = 0;
        status.TryGetValue(tag, out ret);
        return ret;
    }
}
