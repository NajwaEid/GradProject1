  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class ran4 : MonoBehaviour
{ 

	  public List<int> firstlist = new List<int>();
	public List<int> usednumbers = new List<int>();
	public Button rand ;
	
	public string conn;
    public IDbConnection dbconn;
	public int count=0;
	 public static ran4 Instance;
	 
	 public Text timerText;
	private float startTime;

	 
	 public int f=1;
    // Start is called before the first frame update
    void Start()
    {
       
    }
	 void Awake()
 {
   int gameStatusCount = FindObjectsOfType<ran4>().Length;
   //Debug.Log(gameStatusCount);
   DontDestroyOnLoad(this.gameObject);
 }

	
		public void press()
		{
			int currentSceneIndex=SceneManager.GetActiveScene().buildIndex;
		string smallsec="ﻡﺎﻤﺤﻟﺍ";
		string smallsection="smallsection";
		string scenenum="scenenumber";
	   PlayerPrefs.SetString(smallsection,smallsec);
		PlayerPrefs.SetInt(scenenum,currentSceneIndex);
					conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
		
		IDbCommand dbcmd=dbconn.CreateCommand();
		IDbCommand dbcmd2=dbconn.CreateCommand();
		IDbCommand dbcmd3=dbconn.CreateCommand();
		IDbCommand dbcmd4=dbconn.CreateCommand();
		
		string sqlQuery="SELECT count(*) FROM bathroom" ;
		string sqlQuery2="SELECT * FROM bathroom";
		string sqlQuery4="DELETE FROM usedscenes";
		
		
		
		dbcmd.CommandText=sqlQuery;
		dbcmd2.CommandText=sqlQuery2;
		dbcmd4.CommandText=sqlQuery4;
		dbcmd4.ExecuteNonQuery();
		count = Convert.ToInt32(dbcmd.ExecuteScalar());
			IDataReader reader=dbcmd2.ExecuteReader();
		
		
		while(reader.Read())
		{
			int idd = reader.GetInt32(0);
			firstlist.Add(idd);
		}
			  
		   if (Instance == null)
        {
           DontDestroyOnLoad(this.gameObject);
            Instance = this;
			
			firstlist.Sort();
			
			int min0=firstlist[0];
			int max0=firstlist[firstlist.Count -1];
		
			max0=max0+1;
		int num=UnityEngine.Random.Range(min0,max0);
		usednumbers.Add(num);
		
			 for(int i=0;i<firstlist.Count;i++){    
   
          }
		  string sqlQuery3="INSERT INTO usedscenes (id) VALUES "+"("+num+")";
		  Debug.Log(sqlQuery3);
		  dbcmd3.CommandText=sqlQuery3;
		  dbcmd3.ExecuteNonQuery();
		  startTime=Time.time;
			AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(num);
        }
        else if (Instance != this)
        {
            Destroy (gameObject);
        }
		
		}



}
