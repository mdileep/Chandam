//---------------------------------------------------------------------------------------------
// <copyright file="Designer.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:14EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using Chandam.Core;
using Chandam.Rules;
using Chandam.Util;
using MiriyamApp.External;
using MiriyamApp.Social.Facebook;
using System;
using System.Html;


namespace MiriyamApp
{
	public static class Designer
	{
		public static void OnGanaChange()
		{
			string v = Util.SelectedValue("GanaType");
			CreateNewRules(v);
		}

		public static void OnShareWithMe()
		{
			bool v = Util.IsChecked("shareWithMe");
			Document.GetElementById("EmailId").Style.Display = v ? "inline" : "none";
		}

		public static void Init()
		{
			Load();
		}

		private static void Load()
		{
			Clear2();
			LoadPadyamTypes();
			OnPadyamTypeChange();
			LoadLines();
			OnSameRulesChanged();
			OnShareWithMe();
		}


		public static void CreateNewRules(string v)
		{

			Element Table = Document.GetElementById("Rules");
			Table.InnerHTML = "";
			Element Row = AddEmpyRow(v, 1);
			Table.AppendChild(Row);

			Element Table2 = Document.GetElementById("Rows");
			if (Table2 != null)
			{
				Element Ling = AddNewRowLink();
				if (Ling != null)
				{
					Table2.AppendChild(Ling);
				}
			}
		}

		private static Element AddNewRowLink()
		{
			if (Document.GetElementById("new_a") != null)
			{
				return null;
			}
			Element AddR = Document.CreateElement("h5");
			AddR.SetAttribute("href", "#");
			AddR.SetAttribute("id", "new_a");
			AddR.ClassName = "link";
			AddR.InnerHTML = "పాదమును కలుపు";
			try
			{
				AddR.AddEventListener("click", delegate (ElementEvent e)
				{
					Element Anchor = e.Target;
					AddRowHandler(Anchor);
				}, false);
			}
			catch
			{
				AddR.AttachEvent("onclick", new ElementEventHandler(delegate ()
							{
								Element E3 = Window.Event.SrcElement;
								AddRowHandler(E3);
							}));
			}
			return AddR;
		}

		private static void AddRowHandler(Element Anchor)
		{
			string id = Anchor.GetAttribute("id").ToString();
			Element Table = Document.GetElementById("Rules");
			Table.AppendChild(AddEmpyRow(Util.SelectedValue("GanaType"), Table.Children.Length + 1));
		}

		private static Element AddEmpyRow(string v, int row)
		{

			Element Cell = GetCellWithList(v, row, 1);
			Element CellG = GetCellWithGHandler(row);
			Element CellY = GetCellWithYatiHandler(row);
			Element CellGR = GetCellWithRemoveHandler(row);


			Element Row = Document.CreateElement("tr");
			Row.SetAttribute("id", "r" + row);

			Element FirstCell = Document.CreateElement("td");
			FirstCell.SetAttribute("id", "rh" + row);

			Row.AppendChild(FirstCell);
			Row.AppendChild(CellG);
			Row.AppendChild(CellGR);
			Row.AppendChild(CellY);
			Row.AppendChild(Cell);
			return Row;
		}

		private static Element GetCellWithRemoveHandler(int row)
		{
			Element AddG = Document.CreateElement("h5");
			AddG.SetAttribute("href", "#");
			AddG.SetAttribute("id", "r" + row + "_anchor_remove");
			AddG.ClassName = "link";
			AddG.InnerHTML = "గణమును తొలగించు";
			try
			{
				AddG.AddEventListener("click", delegate (ElementEvent e)
				{
					Element Anchor = e.Target;
					RemoveGana(Anchor);
				}, false);
			}
			catch
			{
				AddG.AttachEvent("onclick", new ElementEventHandler(delegate ()
				{
					Element Anchor = Window.Event.SrcElement;
					RemoveGana(Anchor);
				}));
			}

			Element CellG = Document.CreateElement("td");
			CellG.AppendChild(AddG);
			CellG.SetAttribute("id", "r" + row + "_c_remove_Gana");

			return CellG;
		}
		private static Element GetCellWithYatiHandler(int row)
		{
			Element E = Document.CreateElement("input");
			E.SetAttribute("type", "text");
			E.SetAttribute("class", "yIn");
			E.SetAttribute("id", "r" + row + "y" + row);

			Element Cell = Document.CreateElement("td");
			Cell.SetAttribute("id", "td_ry" + row);
			Cell.AppendChild(E);

			return Cell;
		}
		private static Element GetCellWithGHandler(int row)
		{
			Element AddG = Document.CreateElement("h5");
			AddG.SetAttribute("href", "#");
			AddG.SetAttribute("id", "r" + row + "_g");
			AddG.ClassName = "link";

			AddG.InnerHTML = "గణమును కలుపు";
			try
			{
				AddG.AddEventListener("click", delegate (ElementEvent e)
				{
					Element Anchor = e.Target;
					AddNewGana(Anchor);
				}, false);
			}
			catch
			{
				AddG.AttachEvent("onclick", new ElementEventHandler(delegate ()
				{
					Element Anchor = Window.Event.SrcElement;
					AddNewGana(Anchor);
				}));
			}

			Element CellG = Document.CreateElement("td");
			CellG.AppendChild(AddG);
			CellG.SetAttribute("id", "r" + row + "_c_g");

			return CellG;
		}
		private static void RemoveGana(Element Anchor)
		{
			Element Cell = Anchor.ParentNode;
			Element Row = Cell.ParentNode;


			string v = Util.SelectedValue("GanaType");
			string id = Anchor.GetAttribute("id").ToString();
			string rowId = id.Split('_')[0];

			if (rowId.Replace("r", "") == "1" && Row.Children.Length == 5)
			{
				return;
			}

			int l = Row.Children.Length - 5;
			if (l == 0)
			{
				Row.ParentNode.RemoveChild(Row);
				return;
			}

			Element Holder = Document.GetElementById("rh" + rowId.Replace("r", ""));
			Holder.InnerHTML = l.ToString() + " గణములు";

			string cellId = rowId + "c" + (l + 1).ToString();
			Row.RemoveChild(Document.GetElementById(cellId));

		}
		private static void AddNewGana(Element Anchor)
		{
			Element Cell = Anchor.ParentNode;
			Element Row = Cell.ParentNode;
			int Cells = Row.Children.Length;


			string v = Util.SelectedValue("GanaType");
			string id = Anchor.GetAttribute("id").ToString();
			string rowId = id.Split('_')[0].Replace("r", "");


			Element Expand = Document.GetElementById("Expand");
			int ActualColSpan = int.Parse(Expand.GetAttribute("colspan").ToString());


			if (ActualColSpan <= Cells - 5 + 1)
			{
				Expand.SetAttribute("colspan", (ActualColSpan + 1));
			}


			Element Holder = Document.GetElementById("rh" + rowId);
			Holder.InnerHTML = (Cells - 3).ToString() + " గణములు";

			Element NewCell = GetCellWithList(v, int.Parse(rowId), Cells - 3);
			Row.AppendChild(NewCell);
		}
		private static Element GetCellWithList(string v, int rowid, int cellid)
		{
			string id = "r" + rowid + "c" + cellid;
			Element E = GetList(v, id + "_select");
			Element Cell = Document.CreateElement("td");
			Cell.AppendChild(E);
			Cell.SetAttribute("id", id);
			Cell.AppendChild(E);
			return Cell;
		}
		private static Element GetList(string v, string id)
		{
			switch (v)
			{
				case "Name":
					return GetNamedList(id);
				case "Type":
					return GetTypeList(id);
				case "Weight":
					return GetWeightList(id);
			}
			return null;
		}
		private static void LoadLines()
		{
			Element E = Document.GetElementById("Lines");
			for (int i = 1; i <= 8; i++)
			{
				string x = i == 1 ? "ఒక పాదం" : i.ToString() + " పాదాలు";
				Element Local = Util.AddOptionItem(x, i.ToString(), false);
				if (i == 4)
				{
					Local.SetAttribute("selected", "selected");
				}
				E.AppendChild(Local);
			}
		}
		private static Element GetWeightList(string id)
		{
			Element E = Document.CreateElement("select");
			E.SetAttribute("id", id);
			for (int i = 1; i <= 50; i++)
			{
				Element Local = Util.AddOptionItem(i.ToString() + (i == 1 ? " మాత్ర" : " మాత్రలు"), i.ToString(), false);
				E.AppendChild(Local);
			}
			return E;
		}
		private static Element GetTypeList(string id)
		{
			Element E = Document.CreateElement("select");
			E.SetAttribute("id", id);
			string[] Names = new string[] { "ఇంద్ర", "సూర్య", "చంద్ర", "గురువు", "లఘువు" };
			string[] Values = new string[] { "Indra", "Surya", "Chandra", "Guruvu", "Laghuvu" };
			for (int i = 0; i < Names.Length; i++)
			{
				string name = Names[i];
				Element Local = Util.AddOptionItem(name, Values[i], false);
				E.AppendChild(Local);
			}

			return E;
		}
		private static Element GetNamedList(string id)
		{
			Element E = Document.CreateElement("select");
			E.SetAttribute("id", id);
			string[] Names = new string[] { "య(ల-గ-గ)", "మ(గ-గ-గ)", "త(గ-గ-ల)", "ర(గ-ల-గ)", "జ(ల-గ-ల)", "భ(గ-ల-ల)", "న(ల-ల-ల)", "స(ల-ల-గ)", "గ", "గా(గ-గ)", "వ(ల-గ)", "హ(గ-ల)", "లల", "ల" };
			string[] Values = new string[] { "ya", "ma", "ta", "ra", "ja", "bha", "na", "sa", "ga", "gaa", "va", "ha", "lala", "la" };
			for (int i = 0; i < Names.Length; i++)
			{
				string name = Names[i];
				Element Local = Util.AddOptionItem(name, Values[i], false);
				E.AppendChild(Local);
			}

			return E;

		}
		public static void CustomRuleText()
		{
			Rule R = BuildRule();
			Worker.OnShowRules2(R);
		}
		public static void CreateRule()
		{
			Rule R = BuildRule();
			Worker.OnTryMatch2(R);
		}



		private static object GetRuleObject(RuleType ruleType, string val)
		{
			switch (ruleType)
			{
				case RuleType.Name:
					switch (val)
					{
						case "ya":
							return "య";
						case "ma":
							return "మ";
						case "ta":
							return "త";

						case "ra":
							return "ర";

						case "ja":
							return "జ";

						case "bha":
							return "భ";


						case "na":
							return "న";


						case "sa":
							return "స";

						case "ga":
							return "గ";

						case "gaa":
							return "గా";

						case "ha":
							return "హ";

						case "va":
							return "వ";

						case "la":
							return "ల";

						case "lala":
							return "లల";
					}
					break;
				case RuleType.Type:
					{
						switch (val)
						{
							case "Indra":
								return Category.Indra;
							case "Surya":
								return Category.Surya;
							case "Chandra":
								return Category.Chandra;
							case "Guruvu":
								return Category.Guruvu;
							case "Laghuvu":
								return Category.Laghuvu;
						}
					}
					break;
				case RuleType.Weight:
					{
						return int.Parse(val);
					}

			}
			return null;
		}

		private static RuleType GetRuleType(string v)
		{
			switch (v)
			{
				case "Name":
					return RuleType.Name;
				case "Type":
					return RuleType.Type;
				case "Weight":
					return RuleType.Weight;
			}
			return RuleType.Custom;

		}

		private static PadyamType GetPadyamType(string v)
		{
			switch (v)
			{
				case "Jati":
					return PadyamType.Jati;
				case "UpaJati":
					return PadyamType.UpaJati;
				case "Vruttam":
					return PadyamType.Vruttam;
			}
			return PadyamType.Vruttam;
		}

		public static void ShowDesigner()
		{
			Clear2();

			Document.GetElementById("buttons").Style.Display = "none";
			Document.GetElementById("sortTools").Style.Display = "none";
			Document.GetElementById("DesignerContainer").Style.Display = "inline";

			Document.GetElementById("hideDesigner").Style.Display = "inline";
			Document.GetElementById("create").Style.Display = "none";

			Metrics.Export2(Metric.ShowDesigner, StopWatch.LastTicks);
		}
		public static void HideDesigner()
		{
			if (!Util.IsAvailable("DesignerContainer"))
			{
				return;
			}

			Clear2();

			Util.SetDisplay("buttons");
			Util.SetDisplay("sortTools");
			Util.NoDisplay("DesignerContainer");
			Util.NoDisplay("hideDesigner");
			Util.SetDisplay("create");

		}

		private static void Clear2()
		{
			Util.SetValue("Name", "");
			Util.SetValue("txt", "");
			Util.SetValue("EmailId", "");
			Util.SetChecked("hasPrasa");
			Util.SetUnChecked("hasPrasaYati");
			Util.SetUnChecked("hasAnthyaPrasa");
			Util.SetUnChecked("shareWithMe");
		}

		private static void LoadPadyamTypes()
		{
			Element E = Window.Document.GetElementById("PadyamType");
			if (E == null)
			{
				return;
			}
			E.InnerHTML = "";

			Element E1 = Util.AddOptionItem("జాతి", "Jati", false);
			Element E2 = Util.AddOptionItem("ఉపజాతి", "UpaJati", false);
			Element E3 = Util.AddOptionItem("వృత్తం", "Vruttam", false);
			E3.SetAttribute("selected", "selected");
			E.AppendChild(E1);
			E.AppendChild(E2);
			E.AppendChild(E3);
		}

		public static void OnSameRulesChanged()
		{
			bool SameRules = Util.IsChecked("hasSameRules");
			Element Parent = Document.GetElementById("Lines").ParentNode;
			Parent.Style.Visibility = SameRules ? "visible" : "hidden";
			Document.GetElementById("new_a").Style.Display = SameRules ? "none" : "inline";

		}
		public static void OnPadyamTypeChange()
		{
			Element E = Window.Document.GetElementById("GanaType");
			if (E == null)
			{
				return;
			}
			E.InnerHTML = "";

			string v = Util.SelectedValue("PadyamType");
			switch (v)
			{
				case "Jati":
					{
						Element E1 = Util.AddOptionItem("రీతి", "Type", false);
						Element E2 = Util.AddOptionItem("మాత్రా", "Weight", false);
						E.AppendChild(E1);
						E.AppendChild(E2);
						break;
					}
				case "UpaJati":
					{
						Element E1 = Util.AddOptionItem("రీతి", "Type", false);
						E.AppendChild(E1);
						break;
					}
				case "Vruttam":
					{
						Element E1 = Util.AddOptionItem("పేరు", "Name", false);
						E.AppendChild(E1);
						break;
					}
			}
			OnGanaChange();

		}
		public static void OnShare()
		{
			string email = Util.GetValue("EmailId");

			bool isValid = true;
			if (email.Trim().Length > 0)
			{
				isValid = new RegExp("\\S+@\\S+\\.\\S+").Test(email);
			}

			if (!isValid)
			{
				Window.Alert("మీరు ఇచ్చిన ఈ-మెయులు చిరునామా  సరి అయినది కాదు . ఈ పద్యలక్షణాలు కేవలం 'ఛందం©' టీం తో మాత్రమే పంచుకోబడతాయి.\nThe Eamil Address you have mentioned is not a valid, Hence these details will only be shared with Chandam© Team only. ");
			}

			Rule R = BuildRule();
			Share(R, email);
		}
		private static Rule BuildRule()
		{
			string nm = Util.GetValue("Name").Trim();
			nm = nm == "" ? "[పేరు లేని]" : nm;

			Rule R = new Rule();
			R.Name = nm;
			R.Prasa = Util.IsChecked("hasPrasa");
			R.PrasaYati = Util.IsChecked("hasPrasaYati");
			R.AnthyaPrasa = Util.IsChecked("hasAnthyaPrasa");
			R.PadyamType = GetPadyamType(Util.SelectedValue("PadyamType"));
			R.RuleType = GetRuleType(Util.SelectedValue("GanaType"));
			R.InfiniteLength = Util.IsChecked("isDaMdakamu");

			Element Table = Document.GetElementById("Rules");

			Array Rules = new Array();

			for (int i = 0; i < Table.Children.Length; i++)
			{
				Array A = new Array();
				Element E = Table.Children[i];
				int cnt = 0;
				for (int j = 0; j < E.Children.Length; j++)
				{
					Element E2 = Document.GetElementById("r" + (i + 1) + "c" + (j + 1) + "_select");
					if (E2 != null)
					{
						A[cnt++] = GetRuleObject(R.RuleType, Util.SelectedValue(E2.ID));
					}
				}
				Rules[i] = A;
			}
			R.Rules = (object[][])Rules;
			R.YatiMode = R.PadyamType == PadyamType.Vruttam ? YatiMode.CharPosition : YatiMode.GPosition;

			bool hasSameRules = Util.IsChecked("hasSameRules");
			R.Lines = hasSameRules ? int.Parse(Util.SelectedValue("Lines")) : Rules.Length;
			R.Yati = new int[][] { };


			Array Yati = new Array();
			for (int i = 0; i < Table.Children.Length; i++)
			{
				Array A = new Array();
				int cnt = 0;
				Element E = Table.Children[i];
				string id = "r" + (i + 1) + "y" + (i + 1);
				Element E2 = Document.GetElementById(id);
				if (E2 != null)
				{
					string y = Util.GetValue(id);
					foreach (string _y in y.Split(","))
					{
						if (_y == "")
						{
							continue;
						}
						try
						{
							int h = int.Parse(_y);
							A[cnt++] = h;
						}
						catch
						{
							//Some invalid so ignore it..
						}
					}
					Yati[i] = A;
				}
			}
			if (Yati.Length != 0)
			{
				R.Yati = (int[][])Yati;
			}

			R.Examples = new string[] { };
			string ex = Util.GetValue("txt");
			if (ex.Length != 0)
			{
				R.Examples = new string[] { ex };
			}
			return R;
		}

		private static void Share(Rule R, string cc)
		{
			string r = Business.Rules3(R);
			string c = CSWriter.CodeIt(R);

			r = FixRequest(r);
			c = FixRequest(c);

			string content = "t=rc&e=" + cc + "&n=" + R.Name + "&r=" + r + "&c=" + c;

			Ajax.MakeCall("/Log.ashx", new AjaxCallback(delegate (string err, string data, XHR xhr)
			{
				Debug2.Write("Status: " + xhr.Status.ToString() + "<br />" +
							"Error: " + err + "<br/>" +
							"Response: " + data);
				if (xhr.Status.ToString() == "200")
				{
					Window.Alert("మీరు పద్య లక్షణాలు 'ఛందం ©' తో పంచుకున్నందుకు చాలా సంతోషం.\nThanks for your contribution.! Details are Shared with  'Chandam©' team.");
				}

			}), HTTPMethod.POST, content);
		}

		private static string FixRequest(string r)
		{
			return r.Replace("<", "_l_").Replace(">", "_r_");
		}
		public static void HideDesigner2()
		{
			Document.GetElementById("result").InnerHTML = "";
			HideDesigner();
		}
	}
}
