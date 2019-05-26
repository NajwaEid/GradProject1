 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newGameShow : MonoBehaviour
{
   public GameObject Panel;
   string sname;
   
     void Start()
    {
		sname=PlayerPrefs.GetString("studentname");
		Debug.Log("The name of student is : "+sname);
        
    }
  
	
    public void open1_pannel()
	
	{
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

