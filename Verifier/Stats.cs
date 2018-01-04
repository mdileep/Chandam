//---------------------------------------------------------------------------------------------
// <copyright file="Stats.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
//using Excel = Microsoft.Office.Interop.Excel;

namespace Verifier
{
	public partial class Poem
	{
		private static void Serialize(XmlTextWriter w, Poem F)
		{
			w.WriteStartElement("Padyam");
			w.WriteAttributeString("skanda", F.Skanda);
			w.WriteAttributeString("ghatta", F.Ghatta);
			w.WriteAttributeString("Number", F.Number);
			w.WriteAttributeString("type", F.Type);
			w.WriteAttributeString("audio", F.Audio);
			w.WriteAttributeString("title", F.Title);


			w.WriteStartElement("Poem ");
			w.WriteCData(F.Lines);
			w.WriteEndElement();
			w.WriteStartElement("Prose ");
			w.WriteCData(F.Prose);
			w.WriteEndElement();
			w.WriteEndElement();
		}
		public static void Serialise(string file, List<Poem> Poems)
		{
			FileInfo FI = new FileInfo(file);
			if (!FI.Directory.Exists)
			{
				FI.Directory.Create();
			}

			XmlTextWriter w = new XmlTextWriter(file, Encoding.UTF8);
			w.Formatting = Formatting.Indented;
			w.WriteStartElement("Data");
			foreach (Poem F in Poems)
			{
				Serialize(w, F);
			}

			w.WriteEndElement();
			w.Close();
		}
		public static List<Poem> DeSerialise(string file)
		{
			List<Poem> L = new List<Poem>();

			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(file);

			foreach (XmlNode item in xmlDoc.GetElementsByTagName("Padyam"))
			{
				Poem Link = new Poem();
				Link.Audio = item.Attributes["audio"].Value;
				Link.Title = item.Attributes["title"].Value;
				Link.Number = item.Attributes["Number"].Value;


				Link.Skanda = item.Attributes["skanda"].Value;
				Link.Ghatta = item.Attributes["ghatta"].Value;
				Link.Type = item.Attributes["type"].Value;

				foreach (XmlNode n in item.ChildNodes)
				{
					if (n.Name == "Poem")
					{
						Link.Lines = n.InnerText;
					}
					if (n.Name == "Prose")
					{
						Link.Prose = n.InnerText;
					}
				}



				L.Add(Link);
			}
			return L;
		}
		public string Number
		{
			get;
			set;
		}
		public string Lines
		{
			get;
			set;
		}
		public string Prose
		{
			get;
			set;
		}
		public string Audio
		{
			get;
			set;
		}
		public override string ToString()
		{
			return Title;
		}

		public string Title
		{
			get;
			set;
		}
		public string Type
		{
			get;
			set;
		}
		public string Skanda
		{
			get;
			set;
		}
		public string Ghatta
		{
			get;
			set;
		}


		public string Calculated
		{
			get;
			set;
		}
		public bool HasMatach
		{
			get;
			set;
		}
		public string Percentage
		{
			get;
			set;
		}
		public string Remarks
		{
			get;
			set;
		}

		//public List<Library.Chandam.Range> UMarkings
		//{
		//    get;
		//    set;
		//}

		//public List<Library.Chandam.Range> BMarkings
		//{
		//    get;
		//    set;
		//}

		public string MarkingText
		{
			get;
			set;
		}

		public List<YatiGroups> Yatis
		{
			get;
			set;
		}
	}

}
