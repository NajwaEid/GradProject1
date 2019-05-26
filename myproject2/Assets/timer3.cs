 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
 using System;
using UnityEngine.UI;


public class timer3 : MonoBehaviour
{
	
 public DateTime time_start;
 DateTime time_now;
 DateTime time_now3;

 DateTime last_time;
  public string conn;
  public IDbConnection dbconn;
 	public Button tim;
	public TimeSpan diff ;
	public string timef ;
	
	
	  public String tableName; 
	public string str2 ="progress" ;
	public string str ;
	public string str3 ;

	
	 //  public Text txt;
 
    // Update is called once per frame
	
	
	
	
	
   void Start()
{
	
   time_now= System.DateTime.Now;
         Debug.Log(time_now);
		 
		   
		  

		 
		  str=PlayerPrefs.GetString("studentname");
				
			Debug.Log(str);

 }
     
	 
	 public void calc()
    {
		
		//time_start=time1.Instance.timeN;
		
		//Debug.Log("second :"+time_start);
		


	 	conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd=dbconn.CreateCommand();
			
		
		 string sqlQuery3="SELECT * FROM stu"; 
	 
		  dbcmd.CommandText=sqlQuery3;
		  dbcmd.ExecuteNonQuery();
		  		IDataReader reader=dbcmd.ExecuteReader();
		
while(reader.Read())
{
string SDate =reader.GetString(0);
DateTime oldDate = DateTime.Parse(SDate);
Debug.Log(oldDate);


time_now= System.DateTime.Now;
Debug.Log(time_now);
  
  diff = time_now - oldDate;
 Debug.Log(diff);
 
 
 
 
timef =diff.ToString(@"hh\:mm");
Debug.Log(timef);

 
 
 }      
reader.Close();
reader=null; 

  string tableName = String.Concat(str, str2);  
		   
		  Debug.Log(tableName);

		  
		  
   time_now3= System.DateTime.Now;
          
		 
		  string format = "yyyy-MM-dd ";  
		  
		  string currentDate = time_now3.ToString(format);

		  str3=PlayerPrefs.GetString("bigsection");
				
				Debug.Log(str3);

  	 
;
		   string sqlQuery4 = @" insert into " + tableName + "(date,learntime,currentlevel) values ('" + currentDate + "','" + timef +"','" + str3 +"')"; 
 		  Debug.Log(sqlQuery4);
		 dbcmd.CommandText=sqlQuery4;
		  dbcmd.ExecuteNonQuery();
		 

		  
		  
		  
		/*  string sqlQuery5="SELECT * FROM timeT"; 
	 
		  dbcmd.CommandText=sqlQuery5;
		  dbcmd.ExecuteNonQuery();
		  		IDataReader reader1=dbcmd.ExecuteReader();  
		  
		    
		  while(reader1.Read())
    {
        
		string time =reader1.GetString(0);
	   
         //  txt.text=time;
 

  	 
          }     */  
		   
		  
		  
 }

 
 
 
}
