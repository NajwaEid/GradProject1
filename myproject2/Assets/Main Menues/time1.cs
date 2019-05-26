 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
 using System;
using UnityEngine.UI;

 
 public class time1 : MonoBehaviour
{
      
	 DateTime currentDate;
    public string conn;
    public IDbConnection dbconn;
		public Button tim;
public DateTime timeN;
public static time1 Instance;
     
         
 
     void Start () {
		
         currentDate = System.DateTime.Now;
		 
         }
		 
		 
		 public void press()
		{
			
					timeN = System.DateTime.Now;         
					 Debug.Log("first :"+timeN);
 
                    string format = "yyyy-MM-dd HH:mm:ss";    

	 	    conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
         dbconn=(IDbConnection) new SqliteConnection(conn);
          dbconn.Open();
          IDbCommand dbcmd=dbconn.CreateCommand();	
		  string sqlQuery3 = @" insert into stu(tim) values ('" + timeN.ToString(format) + "')"; 
 		  Debug.Log(sqlQuery3);
		  dbcmd.CommandText=sqlQuery3;
		  dbcmd.ExecuteNonQuery();
 
		}
        
 
     
 }
 

