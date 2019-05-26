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


public class milkQ : MonoBehaviour
{
 public int count =0; 
	public int count1 =0; 
		 


 
	
	  public string conn;
  public IDbConnection dbconn;
	
		
	public GameObject a1,a1Black ;
   
   Vector2  a1InitiPos ;
   
   public AudioSource source  ;
   public AudioClip  correct ;
    public AudioClip  incorrect ;
	
	public GameObject Panel;
	public GameObject Panelc;

   
    public DateTime time_now;
	 public DateTime time_now2;
	 public TimeSpan diff ;
	 public string timef ;
	 
	 int corr =1 ;
	 int ncorr =0; 

        public GameObject Panel1;
		 public GameObject Panel2;
		  public GameObject Panel3;
		   public GameObject Panel4;
		    public GameObject Panel5;
			 
			  
			  	  public Text txt;
				  
				  public String tableName; 
				    public string str2 ="qz" ;
					public string str ;

			  


     void Start()
    {
        
		 
		 time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 


	 
	 a1InitiPos = a1.transform.position ;
	 
	 str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);
	
	 
}
  

  
  
   
   
   
 public void Draga1 ()
   {
	   
	   
	  a1.transform.position=Input.mousePosition;
	   
   }
   
   
   
   
   
  
   
   


   
   public void Dropa1()
 
 {
	 float Distance =Vector3.Distance(a1.transform.position,a1Black.transform.position);
	 
	 

	 
	 if(Distance < 50)
	 {
		a1.transform.position=a1Black.transform.position ;
		
		
		 
		 source.clip =correct;
		 source.Play(); 
		 
		 count++ ;
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
        IDbCommand dbcmd=dbconn.CreateCommand();
	    
		 IDbCommand dbcmd2=dbconn.CreateCommand();
		 
		  IDbCommand dbcmd3=dbconn.CreateCommand();
		  
		  	  
		  string tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);







if(count1==0)
{
	
	
 
	
          string sqlQuery = @" insert into " + tableName + "(milkQT,milkQR,milkFailed) values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery);
		  dbcmd.CommandText=sqlQuery;
		  dbcmd.ExecuteNonQuery();
		  
		  Panel.SetActive(true); 
		    
}

 else 
   {
 
	   
	    string sqlQuery6 = @" insert into " + tableName + "(milkQT,milkQR,milkFailed) values ('" + timef + "','" + ncorr + "','" + count1 + "')"; 
  		  Debug.Log(sqlQuery6);
		  dbcmd3.CommandText=sqlQuery6;
		  dbcmd3.ExecuteNonQuery();
		  
	 
				string countt1  = count1.ToString();
   		      		 
		 
		 txt.text=countt1;
		  		  Panelc.SetActive(true); 
   }
		

		 
 }



 else 
	 {
		 a1.transform.position = a1InitiPos;
		 
		  source.clip =incorrect;
		 source.Play(); 
		 
	 } 
 
 }
 
 
 
 
 
 
 
 
 
  public void open1_pannel1()
	
	{		
		if(Panel1!=null)
		Panel1.SetActive(true); 
	
	     count1++;

    }
	
	
  public void open1_pannel2()
	
	{		
		if(Panel2!=null)
		Panel2.SetActive(true); 
		count1++;


    }
	
	
	
  public void open1_pannel3()
	
	{		
		if(Panel3!=null)
		Panel3.SetActive(true); 
	      count1++;


    }

	
	
	
  public void open1_pannel4()
	
	{		
		if(Panel4!=null)
		Panel4.SetActive(true); 
	    count1++;


    }

	
	
  public void open1_pannel5()
	
	{		
		if(Panel5!=null)
		Panel5.SetActive(true); 
	      count1++;


    }
	
	
	
	
	
	
	public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
    
}
