using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quizPannel : MonoBehaviour
{
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
