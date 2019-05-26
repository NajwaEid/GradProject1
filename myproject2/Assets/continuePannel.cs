using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class continuePannel : MonoBehaviour
{
    // Start is called before the first frame update
 
 public GameObject Panel;
	
    public void open_pannel()
	
	{
		
		
		if(Panel!=null)
			
			{
				
				
				Panel.SetActive(true); 
		
		
	}
	
	
}


 public void close_pannel()
 {
	 
	 				Panel.SetActive(false); 

 }
 
 
 
 
 
 
 
 
 
}
