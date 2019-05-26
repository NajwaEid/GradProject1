using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnbody : MonoBehaviour
{ 

  
	   public GameObject Panel;
	string bigsec="ﻢﺴﺠﻟﺍ ﺓﺪﺣﻭ";
	string bigsection="bigsection";
	   
	
	public void open1_pannel()
	
	{
		Debug.Log("i pressed on body menu");
		PlayerPrefs.SetString(bigsection,bigsec);
		if(Panel!=null)
		{
	       Panel.SetActive(true); 
        }

	
}


 public void close1_pannel()
 {
       Panel.SetActive(false); 

 }
	
	
	
}
