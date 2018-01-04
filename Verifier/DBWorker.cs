using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Library.Framework.Utilities;
using System.Data.SqlClient;
using Library.Chandam;
using System.Diagnostics;
using System.IO;

namespace Verifier
{
	public class DBWorker : SqlActionLayer
	{

        public  void DumpMeanings()
        {
            string select = "select teeka,pskanda,ghattano,pno from tebha2014  order by pskanda,ghattano,pno";
            DataTable dt = DBUtil.ExecuteQuery(select, new SqlParameter[] {}, Databases.Core);
            StreamWriter SW = new StreamWriter(@"D:\Working\Bhaghavatam\tebhadict_sql.txt");
            StreamWriter SW2 = new StreamWriter(@"D:\Working\Bhaghavatam\tebhadict_mysql.txt");
            int cnt = 1;
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine("Processing ..."+(cnt++));

                string teeka = DBNull(dr["teeka"]);
                string pskanda = DBNull(dr["pskanda"]);
                string ghattano =  DBNull(dr["ghattano"]);
                string pno =  DBNull(dr["pno"]);

                string[] Meanings = teeka.Split(';');
                this.Open();
                foreach (string meaning in Meanings)
                { 
                    string[] B=meaning.Split('=');
                    string lhs="";
                    string rhs="";
                    if(B.Length<2)
                    {
                        lhs = meaning.Trim();
                    }else
                    {
                        lhs= B[0].Trim();
                        rhs = B[1].Trim();
                    }

                    string insert= PrepareInsert(lhs,rhs,pskanda,ghattano,pno);
                    SW.WriteLine(insert);
                    

                    bool x= DBUtil.ExecuteNonQuery(insert,null, Databases.Core, this.Connection, this.Transaction);
                    if (!x)
                    {
                        this.Rollback();
                    }
                    
                    SW2.WriteLine(insert.Replace("N'","'"));
                }
                this.Commit();

                this.Close();
                
            }
            SW.Close();
            SW2.Close();
        }

        private string PrepareInsert(string lhs, string rhs, string pskanda, string ghattano, string pno)
        {
            return String.Format("insert into tebhadict(lhs,rhs,skanda,ghatta,pno) values(N'{0}',N'{1}',{2},{3},{4});",lhs,rhs,pskanda,ghattano,pno);
        }

		public void GenerateXmls ()
		{
			foreach ( double Skanda in new double[] { 1 , 2 , 3 , 4 , 5.1 , 5.2 , 6 , 7 , 8 , 9 , 10.1 , 10.2 , 11 , 12 } )
			{
				string select="select * from Tebhadata where pskanda=@skanda  order by GhattaNo,PNo";
				DataTable dt=DBUtil.ExecuteQuery ( select , new SqlParameter[] {
																		new MySqlParam("skanda",SqlDbType.Float,Skanda).SqlParameter,
												 						} , Databases.Core );

				StreamWriter SW= new StreamWriter ( "Xml\\" + Skanda + ".xml" , false , Encoding.UTF8 );
				SW.WriteLine ( String.Format ( "<Skanda No=\"{0}\">" , Skanda ) );

				string gNo=null;
				string gName=null;
				foreach ( DataRow dr in dt.Rows )
				{

					string currgNo=( string ) ( dr["GhattaNo"].ToString ( ) );
					string currgName=( string ) dr["Ghatta"];

					if ( gNo != currgNo & gNo != null )
					{
						SW.WriteLine ( "</Ghtatta>" );
						SW.WriteLine ( String.Format ( "<Ghtatta No=\"{0}\"><Name>{1}</Name>" , currgNo , currgName ) );
					}
					if(gNo==null)
					{
						SW.WriteLine ( String.Format ( "<Ghtatta No=\"{0}\"><Name>{1}</Name>" , currgNo , currgName ) );
					}

					SW.WriteLine ( String.Format ( "<Padyam no=\"{0}\" en=\"{1}\" te=\"{2}\" short=\"{3}\"  media=\"{4}\" img=\"{5}\">" ,
DBNull ( dr["PNo"] ) ,
DBNull ( dr["PTypeEn"] ) ,
DBNull ( dr["PTypeTe"] ) ,
DBNull ( dr["PType"] ) ,
DBNull ( dr["media"] ) ,
DBNull ( dr["img"] )
) );

					SW.WriteLine ( "<poem><![CDATA[" + DBNull ( dr["padyam"] ) + "]]></poem>" );
					SW.WriteLine ( "<teeka><![CDATA[" + DBNull ( dr["teeka"] ) + "]]></teeka>" );
					SW.WriteLine ( "<meaning><![CDATA[" + DBNull ( dr["meaning"] ) + "]]></meaning>" );
					SW.WriteLine ( "<poem2><![CDATA[" + DBNull ( dr["padyam2"] ) + "]]></poem2>" );
					SW.WriteLine ( "</Padyam>" );


					gNo = currgNo;
					gName = currgName;
				}

				SW.WriteLine ( "</Ghtatta>" );
				SW.WriteLine ( "</Skanda>" );
				SW.Close ( );

			}
		}

		private string DBNull (object p)
		{
			if ( p == System.DBNull.Value )
				return "";
			return p.ToString ( );
		}

		public void Go ()
		{
			DataTable dt=DBUtil.ExecuteQuery ( "select  * from ns where Padyam2 is  null" , Databases.Core );


			foreach ( DataRow dr in dt.Rows )
			{
				this.Open ( );

				int Id=( int ) dr["id"];
				string sPadyam=( string ) dr["Padyam"];
				string PadyamType=( string ) dr["PTypeEn"];

				int percentage=0;
				string name="";
				string PadyamFormatted=Eval.Build ( sPadyam , PadyamType , out name , out percentage );
				bool done=false;

				if ( percentage < 100 && percentage > 0 )
				{
					//Probable Pr=Padyam.MostProbable ( sPadyam , MatchOptions.QucikMatchSettings );
					//if ( Pr.MatchResult == null )
					//{
					//    Debugger.Break ( );
					//}
					//MatchResult MR= Pr.MatchResult;
					//Library.Chandam.Rule R=Pr.Rule;
					//Padyam P =Pr.Padyam;
					//percentage = MR.Percentage;

					//PadyamFormatted = P.Build2 ( MR );


					//done = DBUtil.ExecuteNonQuery ( "update ns set PTypeTe=@PTypeTe,ptypeCalc=@ptypeCalc,padyam2=@padyam,MatchPercentage=@percentage where id=@id" ,
					//                                new SqlParameter[] {
					//                                                    new MySqlParam("padyam",SqlDbType.NVarChar,PadyamFormatted).SqlParameter,
					//                                                    new MySqlParam("id",SqlDbType.Int,Id).SqlParameter,
					//                                                    new MySqlParam("percentage",SqlDbType.Int,percentage).SqlParameter,
					//                                                    new MySqlParam("ptypeCalc",SqlDbType.VarChar,R.Identifier).SqlParameter,
					//                                                    new MySqlParam("PTypeTe",SqlDbType.NVarChar,R.ShortName).SqlParameter,
					//                                                    } ,
					//                                Databases.Core , this.Connection , this.Transaction );


				}
				//else
				{
					done = DBUtil.ExecuteNonQuery ( "update ns set PTypeTe=@PTypeTe,padyam2=@padyam,MatchPercentage=@percentage where id=@id" ,
														new SqlParameter[] {
																		new MySqlParam("padyam",SqlDbType.NVarChar,PadyamFormatted).SqlParameter,
																		new MySqlParam("id",SqlDbType.Int,Id).SqlParameter,
																		new MySqlParam("percentage",SqlDbType.Int,percentage).SqlParameter,
																		new MySqlParam("PTypeTe",SqlDbType.NVarChar,name).SqlParameter,
 																		} ,
														Databases.Core , this.Connection , this.Transaction );

				}


				if ( done )
				{
					this.Commit ( );

					Console.Write ( "\r Done with: " + Id );
				}

				this.Close ( );

			}
			Console.WriteLine ( "\r  Done with DB Updates" );
		}


	}
}
