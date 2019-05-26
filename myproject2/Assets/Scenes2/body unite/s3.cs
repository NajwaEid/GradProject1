  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class s3 : MonoBehaviour
{
	
	List<int> firstlist2 = new List<int>();
	List<int> usednumbers = new List<int>();
	public Button nex ;
	public GameObject button;
	
	public string conn;
    public IDbConnection dbconn;
	
//	public Text timerText;
	public float startTime2;
	

    // Start is called before the first frame update
    void Start()
    {
		 Debug.Log("hello from scene 1 ");
		 
           firstlist2=  ran3.Instance.firstlist ;

		  
		  
	//	 Debug.Log(ran.Instance.f);
		  		 
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		
		IDbCommand dbcmd=dbconn.CreateCommand();
		string sqlQuery="SELECT * FROM usedscenes" ;
		dbcmd.CommandText=sqlQuery;
		
		IDataReader reader=dbcmd.ExecuteReader();
		
		
		
			while(reader.Read())
			{
				int idd = reader.GetInt32(0);
			   usednumbers.Add(idd);
			}
			
			int firstlist2count=firstlist2.Count;
			Debug.Log("list : "+firstlist2count);
			int usednumberscount=usednumbers.Count;
			Debug.Log("uesd : "+usednumberscount);
			
			
			if(firstlist2count == usednumberscount)
			{
				
				Debug.Log("EQUAL!");
				button.SetActive(false);
			}
			else
			{
				Debug.Log("NOT EQUAL!");
				button.SetActive(true);
			}
		  
		  
    }
	
	
	 
	
	public void press()
	{
		
		firstlist2.Sort();
		int min0=firstlist2[0];
		int max0=firstlist2[firstlist2.Count -1];
		max0=max0+1;
		int num;
		
			while(usednumbers.Contains(num=UnityEngine.Random.Range(min0,max0)))
			{
			}
			
			IDbCommand dbcmd2=dbconn.CreateCommand();
			  
			  string sqlQuery3="INSERT INTO usedscenes (id) VALUES "+"("+num+")";
			  dbcmd2.CommandText=sqlQuery3;
	    	  dbcmd2.ExecuteNonQuery();
						
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(num);
		
	}

    ////// Update is called once per frame
    
}
