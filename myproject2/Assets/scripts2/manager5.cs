using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.EventSystems;
using UnityEngine.UI;

 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
 

 

using System.Data;
 using System;
using UnityEngine.UI;
using Mono.Data.Sqlite;

public class manager5 : MonoBehaviour
{
	string currentlevel="currentlevel";
   public GameObject m1, m2 ,m3 ,m4 ,m5 ,m6 ,m7 ,m8,m9 ,m10 ,m11 ,m12 ,m1b,m2b,m3b,m4b,m5b,m6b,m7b,m8b,m9b,m10b,m11b,m12b ;
   
   Vector2   m1Pos ,m2Pos  ,m3Pos ,m4Pos ,m5Pos ,m6Pos ,m7Pos ,m8Pos ,m9Pos ,m10Pos ,m11Pos ,m12Pos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
   
   public int Truecount=0; 
   
   	 public Text txt;

   
   public int wrongCount =0; 
   
   
   public GameObject Panel;
		public GameObject Panelc;
		
		    public String tableName; 
				    public string str2 ="qz" ;
					public string str ;


	 public string conn;
     public IDbConnection dbconn;
 
     public DateTime time_now;
	 public DateTime time_now2;
	 public TimeSpan diff ;
	 public string timef ;
 
 
      int corr =1 ;
	 int ncorr =0; 
   
   
   
   
   
   

void Start()
{
	string lev="ﻲﻧﺎﺜﻟﺍ ﻯﻮﺘﺴﻤﻟﺍ";
		PlayerPrefs.SetString(currentlevel,lev);
 m1Pos =m1.transform.position ;
 m2Pos =m2.transform.position ;
 m3Pos =m3.transform.position ;
 m4Pos =m4.transform.position ;
 m5Pos =m5.transform.position ;
 m6Pos =m6.transform.position ;
 m7Pos =m7.transform.position ;
 m8Pos =m8.transform.position ;
 m9Pos =m9.transform.position ;
 m10Pos =m10.transform.position ;
 m11Pos =m11.transform.position ;
m12Pos =m12.transform.position ;

  time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 
		  str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);

	
		 
}
   
   public void Dragm1()
   {
	   
		   m1.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
    public void Dragm2()
   {
	   
	 m2.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
    public void Dragm3()
   {
	   
	   
	   m3.transform.position=Input.mousePosition;
	   
	   
   }
   
   
   
   
   
   
    public void Dragm4()
   {
	   
	m4.transform.position=Input.mousePosition;
	   
	   
   }
   
 
 
   public void Dragm5()
   {
	   
	m5.transform.position=Input.mousePosition;
	   
	   
   }
   
   
     public void Dragm6()
   {
	   
	m6.transform.position=Input.mousePosition;
	   
	   
   }
   
   
     public void Dragm7()
   {
	   
	m7.transform.position=Input.mousePosition;
	   
	   
   }
   
     public void Dragm8()
   {
	   
	m8.transform.position=Input.mousePosition;
	   
	   
   }
   
     public void Dragm9()
   {
	   
	m9.transform.position=Input.mousePosition;
	   
	   
   }
   
     public void Dragm10()
   {
	   
	m10.transform.position=Input.mousePosition;
	   
	   
   }
   
     public void Dragm11()
   {
	   
	m11.transform.position=Input.mousePosition;
	   
	   
   }
   
     public void Dragm12()
   {
	   
	m12.transform.position=Input.mousePosition;
	   
	   
   }
   

 public void Dropm1()
 
 {
	 float Distance =Vector3.Distance(m1.transform.position,m1b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m1.transform.position=m1b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  
		 Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
	 }
	 
	 else 
	 {
		 m1.transform.position = m1Pos;
		 
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 public void Dropm2()
 
 {
	 float Distance =Vector3.Distance(m2.transform.position,m2b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m2.transform.position=m2b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  
		 Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
	 }
	 
	 else 
	 {
		 m2.transform.position = m2Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm3()
 
 {
	 float Distance =Vector3.Distance(m3.transform.position,m3b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m3.transform.position=m3b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m3.transform.position = m3Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm4()
 
 {
	 float Distance =Vector3.Distance(m4.transform.position,m4b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m4.transform.position=m4b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m1.transform.position = m4Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm5()
 
 {
	 float Distance =Vector3.Distance(m5.transform.position,m5b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m5.transform.position=m5b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m5.transform.position = m5Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
   
   
   
 public void Dropm6()
 
 {
	 float Distance =Vector3.Distance(m6.transform.position,m6b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m6.transform.position=m6b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m6.transform.position = m1Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
   
   

 public void Dropm7()
 
 {
	 float Distance =Vector3.Distance(m7.transform.position,m7b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m7.transform.position=m7b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m7.transform.position = m7Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 

 
 
 public void Dropm8()
 
 {
	 float Distance =Vector3.Distance(m8.transform.position,m8b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m8.transform.position=m8b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m8.transform.position = m8Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }



 public void Dropm9()
 
 {
	 float Distance =Vector3.Distance(m9.transform.position,m9b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m9.transform.position=m9b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m9.transform.position = m9Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 
 public void Dropm10()
 
 {
	 float Distance =Vector3.Distance(m10.transform.position,m10b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m10.transform.position=m10b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m10.transform.position = m10Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 
 public void Dropm11()
 
 {
	 float Distance =Vector3.Distance(m11.transform.position,m11b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m11.transform.position=m11b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m11.transform.position = m11Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 public void Dropm12()
 
 {
	 float Distance =Vector3.Distance(m12.transform.position,m12b.transform.position);
	 
	 
	 if(Distance < 50)
	 {
		 m12.transform.position=m12b.transform.position;

		 source.clip =correct;
		 source.Play(); 
		 
		  Truecount++; 
		 
		  if(Truecount==12) 
			 done(); 
		 
		 
		 
		 
	 }
	 
	 else 
	 {
		 m12.transform.position = m1Pos;
		 		 wrongCount++;

	 }
	 
	 
	 
 }
 
 
 
 public void done()

  
  {
	  time_now2= System.DateTime.Now;
         Debug.Log(time_now2);
		 
		  diff = time_now2 - time_now ;
            Debug.Log(diff);
			
			
			timef =diff.ToString(@"hh\:mm");
             Debug.Log(timef);
   
             
            timef =diff.ToString(@"hh\:mm");
            Debug.Log(timef);
			
			
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd4=dbconn.CreateCommand();
		
		string tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);


		
	   
	  if(Truecount==12 && wrongCount==0) {
    	Debug.Log("finalllly");
		
		string sqlQuery4 = @" insert into " + tableName + "(HomeQT,HomeQR,HomeFailed) values ('" + timef + "','" + corr + "','" + wrongCount + "')"; 
  		 Debug.Log(sqlQuery4);
		 dbcmd4.CommandText=sqlQuery4;
		 dbcmd4.ExecuteNonQuery();
		 Panel.SetActive(true); 


	}
	
	
	 else {
		 
		  
	   Debug.Log(wrongCount);
	   
	   string sqlQuery6 = @" insert into " + tableName + "(HomeQT,HomeQR,HomeFailed)values ('" + timef + "','" + ncorr + "','" + wrongCount + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd4.CommandText=sqlQuery6;
		  dbcmd4.ExecuteNonQuery();
    		
		  string countt1  = wrongCount.ToString();
   		      
		    txt.text=countt1;
		  	Panelc.SetActive(true);   
	
	 }
	  
	  
	  
	  
	  
	  
  }
  
    
public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
  


 
 
 
 
 
   
   
}
