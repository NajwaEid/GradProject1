using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doctorManager : MonoBehaviour
{
	
	   	public GameObject im1,im2 ,im3, im4, im5 ,im6 ,im7 ,im8, im1_W ,im2_W ,im3_W ,im4_W ,im5_W ,im7_W,im8_W;
		
			   Vector2 im1InitiPos ,im2InitiPos, im3InitiPos, im4InitiPos, im5InitiPos , im7InitiPos ,im8InitiPos ;
			   
			   
			    public AudioSource source  ;
                 public AudioClip  correct ;
                 public AudioClip  incorrect ;
	
	
                 public int count1 =0; 
                  public GameObject Panel;



   
	void Start()
    {
        
	im1InitiPos   = im1.transform.position ;
	
	im2InitiPos = im2.transform.position ;
	
	im3InitiPos = im3.transform.position ;
	
	im4InitiPos  = im4.transform.position ;
	
	im5InitiPos = im5.transform.position ;
   
	
	im7InitiPos   = im7.transform.position ;
	im8InitiPos  = im8.transform.position ;
	
}



 public void Dragimg1()
   {
	   
	   
	  im1.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
   
 public void Dragimg2 ()
   {
	   
	   
	  im2.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
 public void Dragimg3()
   {
	   
	   
	  im3.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
 public void Dragimg4 ()
   {
	   
	   
	  im4.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 public void Dragimg5 ()
   {
	   
	   
	  im5.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 
   
   
   
 public void Dragimg7 ()
   {
	   
	   
	  im7.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 public void Dragimg8 ()
   {
	   
	   
	  im8.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
 
 public void Drop_img1()
 
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
		 im1.transform.position = im1InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
 
 
 
  
  public void Drop_im2()
 
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
		 im2.transform.position = im2InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }  
   


 public void Drop_img3()
 
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
		 im3.transform.position = im3InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }


 public void Drop_img4()
 
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
		 im4.transform.position = im4InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
  public void Drop_img5()
 
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
		 im5.transform.position = im5InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
 
 
 
 
   
 
 
  public void Drop_img7()
 
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
		 im7.transform.position = im7InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
  public void Drop_img8()
 
 {
	 float Distance =Vector3.Distance(im8.transform.position,im8_W.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		im8.transform.position= im8_W.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 im8.transform.position = im8InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
 
}
