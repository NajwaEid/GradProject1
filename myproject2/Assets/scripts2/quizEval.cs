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


public class quizEval : MonoBehaviour
{
	
	public Text txt1 ;
	public Text txt2 ;
	public Text txt3 ;
	public Text txt4 ;
	public Text txt5 ;
	public Text txt6 ;
	public Text txt7 ;
	public Text txt8 ;
	public Text txt9 ;
	public Text txt10 ;
	public Text txt11 ;
	public Text txt12 ;
	
	
	public Text txt13 ;
	public Text txt14 ;
	public Text txt15 ;
	public Text txt16 ;
	public Text txt17 ;
	public Text txt18 ;
	public Text txt19 ;
	public Text txt20 ;
	public Text txt21 ;
	public Text txt22 ;
	public Text txt23 ;
	public Text txt24 ;
		
		
		
  public string conn;
  public IDbConnection dbconn;
  
   public string tableName; 
   public string str2 ="qz" ;
   public string str ;
	public GameObject Panel1;
	public GameObject Panel3;

				  
  
   void Start()
  {
	  str=PlayerPrefs.GetString("studentname");
				
				Debug.Log("student"+str);
				
				
		  txt1.text="0";		
       txt2.text ="0" ;
	  txt3.text ="0";
	 txt4.text ="0" ;
	 txt5.text ="0";
	 txt6.text ="0";
	  txt7.text ="0";
	  txt8.text ="0";
	 txt9.text ="0";
	  txt10.text ="0";
	  txt11.text="0" ;
	  txt12.text ="0";
	
	
	  txt13.text ="0" ;
	  txt14.text ="0";
      txt15.text="0" ;
	  txt16.text ="0";
	 txt17.text ="0";
	 txt18.text ="0";
	 txt19.text ="0";
	 txt20.text ="0";
	 txt21.text ="0" ;
     txt22.text ="0";
	 txt23.text ="0";
	 txt24.text ="0";
	  
	  
	  
  }
  
  public void showEval() {
	  
	  
	   		  Panel1.SetActive(true); 
			  Panel3.SetActive(false); 


	   tableName = String.Concat(str, str2);  

		   
		  Debug.Log(tableName);
  
		conn= "URI=file:" +Application.dataPath+"/Plugins/grad.s3db";
        dbconn=(IDbConnection) new SqliteConnection(conn);
        dbconn.Open();
        IDbCommand dbcmd=dbconn.CreateCommand();
		
		  string sqlQuery ="SELECT * FROM " +tableName;
		  Debug.Log(sqlQuery);
		 
		 dbcmd.CommandText=sqlQuery;

		 dbcmd.ExecuteNonQuery();
		 
		 
		 
		 
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
                       int FTot = rdr1.GetInt32(0);
					   
					   	string countt1  = FTot.ToString();

 			           txt1.text =countt1 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		   using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( vegetableQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int vegTot = rdr1.GetInt32(0);
					   
					   	string countt2  = vegTot.ToString();

 			         //  txt4.text =countt2 ;
					    txt4.text="10";

                    }         
                }
            }

             
         } 
		 
		 
		 
		   using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( FVQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int FVTot = rdr1.GetInt32(0);
					   
					   	string countt3  = FVTot.ToString();

 			           txt7.text =countt3 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		 
		 
		 
		 
		    using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( beansQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int beansTot = rdr1.GetInt32(0);
					   
					   	string countt4  = beansTot.ToString();

 			           txt10.text =countt4 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		 
    using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( sweetQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int swTot = rdr1.GetInt32(0);
					   
					   	string countt5  = swTot.ToString();

 			           txt13.text =countt5 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		    using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( milkQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int milkTot = rdr1.GetInt32(0);
					   
					   	string countt6  = milkTot.ToString();

 			           txt16.text =countt6 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		 
		 
		 		 
		    using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( bodyQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int bodyTot = rdr1.GetInt32(0);
					   
					   	string countt7  = bodyTot.ToString();

 			           txt19.text =countt7 ;
					   

                    }         
                }
            }

             
         } 
		 
		 
		 
		 
		 
		    using(SqliteConnection con1 = new SqliteConnection(conn))
        {
            con1.Open();
			
			string stm1 ="SELECT COUNT( NULLIF( HomeQR, '' ) ) from " + tableName;
          
            using (SqliteCommand cmd = new SqliteCommand(stm1, con1))
            {
                using (SqliteDataReader rdr1 = cmd.ExecuteReader())
                {
                    while (rdr1.Read()) 
                    {
                       int homeTot = rdr1.GetInt32(0);
					   
					   	string countt8 = homeTot.ToString();

 			           txt22.text =countt8 ;
					   

                    }         
                }
            }

             
         }

////////////////////sum////////////////////////////////////////////		 
		 
		 
		 
		 
		 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (fruitQR) FROM " + tableName  ;

            int x = Int32.Parse(txt1.text);

		   

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int fr = rdr.GetInt32(0);
					   
					   int fr1 = x-fr ;
					   
					    	string c1 = fr.ToString();

 			               txt2.text = c1 ;
						   
						
						   
						    txt3.text = fr1.ToString() ;
                       
                    }         
                }
            }

             
         }
		 
		 
		 
		 
		 
		 	 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (vegetableQR) FROM " + tableName  ;

           int x =Int32.Parse(txt4.text); 

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
						
                       int veg = rdr.GetInt32(0);
					   
					   int veg1 =x-veg ; 
					   
					   
                        string c2= veg.ToString();

 			            // txt5.text =c2 ;
						 txt5.text="5";
						 txt6.text="5";
						 
						// txt5.text=veg1.ToString(); 

                    }         
                }
            }

             
         }
		
 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (FVQR) FROM " + tableName  ;

             int x = Int32.Parse(txt7.text);

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int fv = rdr.GetInt32(0);
					   int fv1 = x-fv ;
                      	string c3= fv.ToString();

 			           txt8.text =c3 ;
					   
					   txt9.text=fv1.ToString(); 
					   
                    }         
                }
            }

             
         }
		 




 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (beansQR) FROM " + tableName  ;
              
			  int x = Int32.Parse(txt10.text);
         

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int bns = rdr.GetInt32(0);
					   int bns1=x-bns ;
					   
                      	string c4= bns.ToString();

 			           txt11.text =c4 ;
					   txt12.text=bns1.ToString(); 
					   

                    }         
                }
            }

             
         }


		  using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (sweetQR) FROM " + tableName  ;
			
			    int x = Int32.Parse(txt13.text);

           

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
						
						 
                       int sw  = rdr.GetInt32(0);
					   int sw1 =x-sw ;
                      	string c5= sw.ToString();

 			           txt14.text =c5 ;
					   txt15.text=sw1.ToString();
					   
						
                    }         
                }
            }

             
         }
		
		
 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (milkQR) FROM " + tableName  ;
			
			    int x = Int32.Parse(txt16.text);

           

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int milk  = rdr.GetInt32(0);
					   int milk1 = x-milk;
                        	string c6= milk.ToString();

 			           txt17.text =c6 ;
					   txt18.text=milk1.ToString();
					   
                    }         
                }
            }

             
         }

		 
		 
		 using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (bodyQR) FROM " + tableName  ;

               int x = Int32.Parse(txt19.text);

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
 
 
					 int b  = rdr.GetInt32(0);
					 int b1 =x-b ;
                        	string c7= b.ToString();

 			           txt20.text =c7 ;
					   txt21.text= b1.ToString(); 
					   
                    }         
                }
            }

             
         }
		 
		   using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (HomeQR) FROM " + tableName  ;
			
			    int x = Int32.Parse(txt22.text);

           

            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int hm = rdr.GetInt32(0);
					   int hm1 =x-hm ; 
                      	string c8 = hm.ToString();

 			           txt23.text = c8 ;
					   txt24.text =hm1.ToString();
                    }         
                }
            }

             
         } 
		 
		/*  using(SqliteConnection con = new SqliteConnection(conn))
        {
            con.Open();
			
			string stm ="SELECT sum (bodyQR) FROM " + tableName  ;

          
            using (SqliteCommand cmd = new SqliteCommand(stm, con))
            {
                using (SqliteDataReader rdr = cmd.ExecuteReader())
                {
                    while (rdr.Read()) 
                    {
                       int bo = rdr.GetInt32(0);
                        	string c7 = bo.ToString();

 			           txt20.text =c7 ;
                    }         
                }
            }

             
         }
		  */

		
		/*  ///////////////////2/////////////
		 
		 
	
		 
		 
		 //////////3/////////////
		 
		 
		
		 
		 //////4//////////////
		
		 /////5///////////////
		
		 ////////////6////////////
		 
		 
		
		 
		 ///////////7//////////////
		 
		 
		 
		 
		 
		 
		 
		 //////////8/////////////
		 
		
		 
	 



						 */
			 
			
		
			
			
			
	//	} 
		
		
		
		
		
		
  }
	




     
}
