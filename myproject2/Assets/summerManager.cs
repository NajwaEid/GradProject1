using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summerManager : MonoBehaviour
{
   	public GameObject jaket , glove1 , glove2 ,hatWinter ,boot1, boot2 ,trouser ,tshirt ,Short,hatSummer ,tshirtBlack , ShortBlack ,summerHatBlack ;

	   Vector2  jaketInitiPos ,glove1InitiPos, glove2InitiPos, hatWinterInitiPos, boot1InitiPos ,boot2InitiPos ,trouserInitiPos , tshirtInitiPos , ShortInitiPos ,hatSummerInitiPos ;

	 public AudioSource source  ;
   public AudioClip  correct ;
    public AudioClip  incorrect ;
	
	
     public int count1 =0; 
  public GameObject Panel;

	   
	
	void Start()
    {
        
	jaketInitiPos  = jaket.transform.position ;
	
	glove1InitiPos= glove1.transform.position ;
	
	glove2InitiPos= glove2.transform.position ;
	
	hatWinterInitiPos = hatWinter.transform.position ;
	
	boot1InitiPos = boot1.transform.position ;
	boot2InitiPos = boot2.transform.position ;
	
	trouserInitiPos  = trouser.transform.position ;
	tshirtInitiPos  = tshirt.transform.position ;
	
	ShortInitiPos = Short.transform.position ;
	hatSummerInitiPos   = hatSummer.transform.position ;
	
		
	
	
	
}



 public void Dragjaket ()
   {
	   
	   
	  jaket.transform.position=Input.mousePosition;
	   
   }
   
   
   
    public void Dragglove1()
   {
	   
	   
	   glove1.transform.position=Input.mousePosition;
	   
   }
   
   
   
    public void Dragglove2()
   {
	   
	   
	   glove2.transform.position=Input.mousePosition;
	   
   }
   
   
   
    public void DraghatWinter()
   {
	   
	   
	   hatWinter.transform.position=Input.mousePosition;
	   
   }
   
   
   
    public void Dragboot1()
   {
	   
	   
	   boot1.transform.position=Input.mousePosition;
	   
   }
   
   
    public void Dragboot2()
   {
	   
	   
	   boot2.transform.position=Input.mousePosition;
	   
   }
   
   
    public void Dragtrouser()
   {
	   
	   
	  trouser.transform.position=Input.mousePosition;
	   
   }
   
   
    public void Dragtshirt()
   {
	   
	   
	   tshirt.transform.position=Input.mousePosition;
	   
   }
   
    public void DragShort()
   {
	   
	   
	   Short.transform.position=Input.mousePosition;
	   
   }
   
    public void DraghatSummer()
   {
	   
	   
	   hatSummer.transform.position=Input.mousePosition;
	   
   }
   
	
 
 
 


public void Droptshirt()
 
 {
	 float Distance =Vector3.Distance(tshirt.transform.position,tshirtBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		tshirt.transform.position=tshirtBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count1++;
		 
		 
	 }
	 
	 else 
	 {
		 tshirt.transform.position = tshirtInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 



	
 }
 
 
 
 
 public void DropShort()
 
 {
	 float Distance =Vector3.Distance(Short.transform.position,ShortBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		Short.transform.position=ShortBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		  count1++;
		 
		 
	 }
	 
	 else 
	 {
		 Short.transform.position = ShortInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 



	
 }
 
 
 
 public void DrophatSummer()
 
 {
	 float Distance =Vector3.Distance(hatSummer.transform.position,summerHatBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		hatSummer.transform.position= summerHatBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		  count1++;
		 
		 
	 }
	 
	 else 
	 {
		 hatSummer.transform.position = hatSummerInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 
 }
	 
///////////////////////

 
	  
 public void Dropjaket()
 
 {

 
	 		jaket.transform.position = jaketInitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 
  
 public void Dropglove1()
 
 {

 
	 		glove1.transform.position = glove1InitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 
 
  
 public void Dropglove2()
 
 {

 
	 		glove2.transform.position = glove2InitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
  
 public void DrophatWinter()
 
 {

 
	 	hatWinter.transform.position = hatWinterInitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 
  
 public void Dropboot1()
 
 {

 
	 		boot1.transform.position = boot1InitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
  
 public void Dropboot2()
 
 {

 
	 		boot2.transform.position = boot2InitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
  
 public void Droptrouser()
 
 {

 
	 		trouser.transform.position = trouserInitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 void Update()
 
 {
	 
 if(count1==3)
			 
Panel.SetActive(true); 
		 
  
 
   }
  
 
	
}
