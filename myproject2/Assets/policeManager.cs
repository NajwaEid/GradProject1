 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeManager: MonoBehaviour
{
	
	   	public GameObject im1,im2 ,im3, im4, im5 ,im6 ,im7 , im1_W ,im2_W ,im3_W ,im4_W ,im5_W ,im6_W ,im7_W;
		
			   Vector2 im11InitiPos ,im22InitiPos, im33InitiPos, im44InitiPos, im55InitiPos ,im66InitiPos ,im77InitiPos;
			   
			   
			    public AudioSource source  ;
                 public AudioClip  correct ;
                 public AudioClip  incorrect ;
	
	
                 public int count1 =0; 
                  public GameObject Panel;



   
	void Start()
    {
        
	im11InitiPos   = im1.transform.position ;
	
	im22InitiPos = im2.transform.position ;
	
	im33InitiPos = im3.transform.position ;
	
	im44InitiPos  = im4.transform.position ;
	
	im55InitiPos = im5.transform.position ;
    im66InitiPos  = im6.transform.position ;
	
	im77InitiPos   = im7.transform.position ;
	//im88InitiPos  = im8.transform.position ;
	
}



 public void Dragimg11()
   {
	   
	   
	  im1.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
   
 public void Dragimg22 ()
   {
	   
	   
	  im2.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
 public void Dragimg33()
   {
	   
	   
	  im3.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
 public void Dragimg44 ()
   {
	   
	   
	  im4.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 public void Dragimg55 ()
   {
	   
	   
	  im5.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 public void Dragimg66 ()
   {
	   
	   
	  im6.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 public void Dragimg77 ()
   {
	   
	   
	  im7.transform.position=Input.mousePosition;
	   
   }
   
   
  
   
 
 public void Drop_img11()
 
 {
	 float Distance =Vector3.Distance(im1.transform.position,im1_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im1.transform.position= im1_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im1.transform.position = im11InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
 
 
 
  
  public void Drop_im22()
 
 {
	 float Distance =Vector3.Distance(im2.transform.position,im2_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im2.transform.position= im2_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im2.transform.position = im22InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }  
   


 public void Drop_img33()
 
 {
	 float Distance =Vector3.Distance(im3.transform.position,im3_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im3.transform.position= im3_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im3.transform.position = im33InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }


 public void Drop_img44()
 
 {
	 float Distance =Vector3.Distance(im4.transform.position,im4_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im4.transform.position= im4_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im4.transform.position = im44InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
  public void Drop_img55()
 
 {
	 float Distance =Vector3.Distance(im5.transform.position,im5_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im5.transform.position= im5_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im5.transform.position = im55InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
 
 
  public void Drop_img66()
 
 {
	 float Distance =Vector3.Distance(im6.transform.position,im6_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im6.transform.position= im6_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im6.transform.position = im66InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
  public void Drop_img77()
 
 {
	 float Distance =Vector3.Distance(im7.transform.position,im7_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im7.transform.position= im7_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im7.transform.position = im77InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
   
 
}
