﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;
public class PromjeniScenu : MonoBehaviour
{
   

    public void PocniScenuBela(bool PocniPrijelaz = false)
    {
        if( PocniPrijelaz == true)
        {
            StartCoroutine( UdiUigru());
           
        }
    }
   public IEnumerator UdiUigru()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("BelaScen1");
    }
}
