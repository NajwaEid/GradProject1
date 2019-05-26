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

  

 
public class dragimg : MonoBehaviour  {
	
 
    public int count =0; 
	public int count1 =0; 
		public int cc =0; 
		
		public string str ;


 	  public List<int> firstlist = new List<int>();

	
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
			 public GameObject Panel6;
			  public GameObject Panel7;
			  
			  	  public Text txt;
				  
				  public String tableName; 
				    public string str2 ="qz" ;
				  
				  
				  

			  


     void Start()
    {
        
		 
		 time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 
		 
	
				str=PlayerPrefs.GetString("studentname");
				
				Debug.Log(str);


		 


	 
	 a1InitiPos = a1.transform.position ;
	
	 
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
   		//	string sqlQuery = "insert into " + tableName + "(fruitQT,fruitQR,fruitFailed) values ('" + timef + "','" + corr + "','" + count1 + "')";


         string sqlQuery = @" insert into " + tableName + "(fruitQT,fruitQR,fruitFailed) values ('" + timef + "','" + corr + "','" + count1 + "')"; 
  		  
		  Debug.Log(sqlQuery);
		 
		 dbcmd.CommandText=sqlQuery;

		 dbcmd.ExecuteNonQuery();
		  
		  Panel.SetActive(true); 
		    
			
			
         using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (fruitQR) FROM " + tableName  ;

           

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int idd = rdr.GetInt32(0);
                       firstlist.Add(idd);
			           Debug.Log(idd);

                    }         
                }
            }

             
         }
		 
		 
		  using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( fruitQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int idd1 = rdr1.GetInt32(0);
 			           Debug.Log(idd1);

                    }         
                }
            }

             
         } 
		   
		 
		 
		  
		  
		  




 
		  
		  

   }  
   
   
   else 
   {
	   
 
	   
	    string sqlQuery6 = @" insert into " + tableName + "(fruitQT,fruitQR,fruitFaild) values ('" + timef + "','" + ncorr + "','" + count1 + "')"; 
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

	
	
  public void open1_pannel6()
	
	{		
		if(Panel6!=null)
		Panel6.SetActive(true);
         count1++;
	

    }

	
	
  public void open1_pannel7()
	
	{		
		if(Panel7!=null)
			
		Panel7.SetActive(true); 
	     count1++;


    }

	public void relod(){
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);     
     }
	 
	 public void relod2(){
      SceneManager.LoadScene(154);     
     }
 
   

}