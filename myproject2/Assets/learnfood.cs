 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class learnfood : MonoBehaviour
{
    public GameObject Panel;
	string bigsec="ﺀﺍﺬﻐﻟﺍ ﺓﺪﺣﻭ";
	string bigsection="bigsection";
    public void open1_pannel()
	
	{
		Debug.Log("i pressed on food menu");
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
