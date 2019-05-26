using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager4 : MonoBehaviour
{
  string currentlevel="currentlevel";
   public GameObject knife, foridge ,cooker ,gaz ,blender ,pan ,knifeBlack , foridgeBlack ,cookerBlack,gazBlack ,blenderBlack ,panBlack ;
   
   Vector2  knifeInitiPos ,foridgeInitiPos,cookerInitiPos, gazInitiPos ,blenderInitiPos ,panInitiPos  ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   
   
    void Start()
{
	string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
		   string bigsec="ﺦﺒﻄﻤﻟﺍ";
	string bigsection="bigsection";
	PlayerPrefs.SetString(bigsection,bigsec);
	PlayerPrefs.DeleteKey("smallsection");
	
	 int currentSceneIndex=137;
	 string scenenum="scenenumber";
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
	
	knifeInitiPos  = knife.transform.position ;
	
	foridgeInitiPos= foridge.transform.position ;
	
	cookerInitiPos= cooker.transform.position ;
	
	gazInitiPos = gaz.transform.position ;
	
	blenderInitiPos = blender.transform.position ;
	panInitiPos  = pan.transform.position ;
	
	
}


	 public void Dragknife()
   {
	   
	   
	   knife.transform.position=Input.mousePosition;
	   
   }
   
   
   
	 public void Dragcooker()
   {
	   
	   
	   cooker.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
	 public void DragGas()
   {
	   
	   
	   gaz.transform.position=Input.mousePosition;
	   
   }
   
   
   
	 public void Dragblender()
   {
	   
	   
	   blender.transform.position=Input.mousePosition;
	   
   }
   
   
	 public void DragPan()
   {
	   
	   
	   pan.transform.position=Input.mousePosition;
	   
   }
   
   
	 public void Dragforidge()
   {
	   
	   
	   foridge.transform.position=Input.mousePosition;
	   
   }
   
   //////////////////////////////////////////////////////////////////////////////

public void Dropknife()
 
 {
	 float Distance =Vector3.Distance(knife.transform.position,knifeBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 knife.transform.position=knifeBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 knife.transform.position = knifeInitiPos;
	 }
	 



	
 }
public void Dropforidge()
 
 {
	 float Distance =Vector3.Distance(foridge.transform.position,foridgeBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 foridge.transform.position=foridgeBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 foridge.transform.position = foridgeInitiPos;
	 }
	 
	 
	 
	 
 }
 
 
 
 
 public void DropCooker()
 
 {
	 float Distance =Vector3.Distance(cooker.transform.position,cookerBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		cooker.transform.position=cookerBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 cooker.transform.position = cookerInitiPos;
	 }
	 
	 
	 
	 
 }
 
 
 public void DropGaz()
 
 {
	 float Distance =Vector3.Distance(gaz.transform.position,gazBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
	gaz.transform.position=gazBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 gaz.transform.position = gazInitiPos;
	 }
	 
	 
	 
	 
 }
 
 
 
 
 
 public void DropBlender()
 
 {
	 float Distance =Vector3.Distance(blender.transform.position,blenderBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 blender.transform.position=blenderBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		blender.transform.position = blenderInitiPos;
	 }
	 
	 
	 
	 
 }
 
 public void DropPan()
 
 {
	 float Distance =Vector3.Distance(pan.transform.position,panBlack.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		pan.transform.position=panBlack.transform.position;
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 
	 }
	 
	 else 
	 {
		 pan.transform.position = panInitiPos;
	 }
	 
	 
	 
	 
 }
 
 
 
 
 

}
