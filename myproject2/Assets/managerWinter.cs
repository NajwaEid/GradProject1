using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class managerWinter : MonoBehaviour
{
	
	public GameObject jaket , glove1 , glove2 ,hatWinter ,boot1, boot2 ,trouser ,jaketBlack , glove1Black ,glove2Black, hatWinterBlack ,boot1Black ,boot2Black ,trouserBlack ,tshirt ,Short,hatSummer;
   
   Vector2  jaketInitiPos ,glove1InitiPos, glove2InitiPos, hatWinterInitiPos, boot1InitiPos ,boot2InitiPos ,trouserInitiPos , tshirtInitiPos , ShortInitiPos ,hatSummerInitiPos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
    public AudioClip  incorrect ;
	
	public GameObject Panel;
	 public int count =0; 
	

	
    // Start is called before the first frame update
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
   



///////////////////////////////////////////////




public void Dropjaket()
 
 {
	 float Distance =Vector3.Distance(jaket.transform.position,jaketBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		jaket.transform.position=jaketBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count++;
		 
		 
	 }
	 
	 else 
	 {
		 jaket.transform.position = jaketInitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 



	
 }
 
 
 
 public void Dropglove1()
 
 {
	 float Distance =Vector3.Distance(glove1.transform.position,glove1Black.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 glove1.transform.position=glove1Black.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		count++;

		 
		 
	 }
	 
	 else 
	 {
		 glove1.transform.position = glove1InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 }
	 



	
 }
 
 

 
 
 public void Dropglove2()
 
 {
	 float Distance =Vector3.Distance(glove2.transform.position,glove2Black.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 glove2.transform.position=glove2Black.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 		 count++;

		 
		 
	 }
	 
	 else 
	 {
		glove2.transform.position = glove2InitiPos;
		
		 
		  source.clip =incorrect;
		 source.Play(); 
	 }
	 

 }
 
  
 
 public void DrophatWinter()
 
 {
	 float Distance =Vector3.Distance(hatWinter.transform.position,hatWinterBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 hatWinter.transform.position=hatWinterBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 		 count++;

		 
		 
	 }
	 
	 else 
	 {
		 hatWinter.transform.position = hatWinterInitiPos;
		 
		  
		  source.clip =incorrect;
		 source.Play(); 
	 }
	 

	
 }
 
 
 
 
 public void Dropboot1()
 
 {
	 float Distance =Vector3.Distance(boot1.transform.position,boot1Black.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 boot1.transform.position=boot1Black.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 		 count++;

		 
		 
	 }
	 
	 else 
	 {
		 boot1.transform.position = boot1InitiPos;
		 
		  
		  source.clip =incorrect;
		 source.Play(); 
	 }
	 



	
 }
 
 
 
 
 
 public void Dropboot2()
 
 {
	 float Distance =Vector3.Distance(boot2.transform.position,boot2Black.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 boot2.transform.position= boot2Black.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 		 count++;

				 
				 
				 
		 
		 
	 }
	 
	 else 
	 {
		 boot2.transform.position = boot2InitiPos;
		 
		  
		  source.clip =incorrect;
		 source.Play(); 
	 }
	 



	
 }
 
 
 
 
 
 
 
 
 
 
 
 public void Droptrouser()
 
 {
	 float Distance =Vector3.Distance(trouser.transform.position,trouserBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 trouser.transform.position=trouserBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 		 count++;

		 
		 
	 }
	 
	 else 
	 {
		 trouser.transform.position = trouserInitiPos;
		  
		  source.clip =incorrect;
		 source.Play(); 
	 }
	 


 }
 

 
 public void Droptshirt()
 
 {

 
	 		 tshirt.transform.position = tshirtInitiPos;
			  
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 public void DropShort()
 
 {

 
	 		Short.transform.position = ShortInitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
 
 
 public void DrophatSummer()
 
 {

 
	 		hatSummer.transform.position = hatSummerInitiPos;
			 
		  source.clip =incorrect;
		 source.Play(); 
	
 }
 
  
 void Update()
 
 {
	 
 if(count==7)
			 
Panel.SetActive(true); 
		 
  
 
   }
 
 
 
  
}
