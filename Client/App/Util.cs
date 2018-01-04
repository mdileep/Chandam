//---------------------------------------------------------------------------------------------
// <copyright file="Util.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:13EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

//---------------------------------------------------------------------------------------------
// <copyright file="Util.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:10EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Html;


namespace MiriyamApp
{
	public static class Events
	{
		public const string Click = "click";
		public const string Change = "change";
	}
	public static class Util
	{

		public static bool IsChecked(string Id)
		{
			if (Document.GetElementById(Id) == null)
			{
				return false;
			}
			return (bool)Script.Literal("document.getElementById({0}).checked", Id);
		}
		public static string GetValue(string Id)
		{
			if (Document.GetElementById(Id) == null)
			{
				return "";
			}

			return Script.Literal("document.getElementById({0}).value", Id).ToString();
		}
		public static void SetChecked(string Id)
		{
			if (Document.GetElementById(Id) == null)
			{
				return;
			}

			Script.Literal("document.getElementById ( {0}).checked=true", Id);
		}
		public static void SetValue(string Id, string D)
		{
			if (Document.GetElementById(Id) == null)
			{
				return;
			}

			Script.Literal("document.getElementById ( {1}).value={0}", D, Id);
		}
		public static Element AddOptionItem(string Name, string Value, bool isGroup)
		{
			Element O = Window.Document.CreateElement(isGroup ? "optgroup" : "option");
			if (!isGroup)
			{
				O.InnerHTML = Name;
			}
			O.SetAttribute(isGroup ? "label" : "value", Value);

			return O;
		}
		public static void SetOption(string id, string value)
		{
			//int index=0;
			Element E = Document.GetElementById(id);
			for (int i = 0; i < E.Children.Length; i++)
			{
				Element OG = E.Children[i];
				if (OG.TagName.ToLowerCase() == "optgroup")
				{
					for (int j = 0; j < OG.Children.Length; j++)
					{
						Element O = OG.Children[j];
						if ((string)Script.Literal("O.value") == value)
						{
							O.SetAttribute("selected", "selected");
							Script.Literal("O.selected=true");
							//return;
						}
						else if (O.Attributes.GetNamedItem("selected") != null && O.Attributes.GetNamedItem("selected").Value == "selected")
						{
							O.RemoveAttribute("selected");
							Script.Literal("O.selected=false;");
						}
					}
				}
				else
				{
					if ((string)Script.Literal("OG.value") == value)
					{
						OG.SetAttribute("selected", "selected");
						Script.Literal("OG.selected=true;");
						//return;
					}
					else if (OG.Attributes.GetNamedItem("selected") != null && OG.Attributes.GetNamedItem("selected").Value == "selected")
					{
						OG.RemoveAttribute("selected");
						Script.Literal("OG.selected=false;");
					}
				}
			}
		}
		public static string SelectedValue(string id)
		{
			Element E = Window.Document.GetElementById(id);
			if ((bool)Script.Literal("E.selectedIndex==-1"))
			{
				return null;
			}
			string v = (string)Script.Literal("E.options[E.selectedIndex].value", null);
			return v;
		}

		public static void SetUnChecked(string Id)
		{
			if (Document.GetElementById(Id) == null)
			{
				return;
			}

			Script.Literal("document.getElementById ( {0}).checked=false", Id);
		}
		public static void RegisterEvent(string E, string eventName, ElementEventListener elementEventListener)
		{
			RegisterEvent2(Document.GetElementById(E), eventName, elementEventListener);
		}
		public static void RegisterClick(string E, ElementEventListener elementEventListener)
		{
			RegisterEvent2(Document.GetElementById(E), Events.Click, elementEventListener);
		}

		public static void RegisterClick2(string[] Elemes, ElementEventListener elementEventListener)
		{
			foreach (string E in Elemes)
			{
				RegisterEvent2(Document.GetElementById(E), Events.Click, elementEventListener);
			}
		}
		public static Element FindByClass(Element elem, string className)
		{
			ElementCollection coll = elem.Children;
			for (int i = 0; i < coll.Length; i++)
			{
				Element e2 = coll[i];

				if (e2.ClassName == className)
				{
					return e2;
				}
				Element e3 = FindByClass(e2, className);
				if (e3 != null)
				{
					return e3;
				}
			}
			return null;
		}
		public static void RegisterClick3(Element Elem, ElementEventListener elementEventListener)
		{

			RegisterEvent2(Elem, Events.Click, elementEventListener);

		}

		public static void RegisterChange(string E, ElementEventListener elementEventListener)
		{
			RegisterEvent2(Document.GetElementById(E), Events.Change, elementEventListener);
		}

		public static void RegisterEvent2(Element E, string eventName, ElementEventListener elementEventListener)
		{

			if (E == null)
			{
				return;
			}

			//Don't depened on Try-Catch for Business Logic
			try
			{
				if ((bool)Script.Literal("E.addEventListener!=null"))
				{
					E.AddEventListener(eventName, elementEventListener, false);
				}
				else
				{
					Script.Literal("{0}.attachEvent('on{1}', {2})", E, eventName, elementEventListener);
				}

			}
			catch
			{
				Script.Literal("{0}.attachEvent('on{1}', {2})", E, eventName, elementEventListener);
			}

		}
		internal static void Prevent(ElementEvent e)
		{
			e.PreventDefault();
			e.StopPropagation();
			e.StopImmediatePropagation();
		}
		public static string FindQuery(string key)
		{
			try
			{
				Dictionary Q = BuildQuery();
				return (string)Q[key];
			}
			catch
			{
				return "";
			}
		}

		public static Dictionary BuildQuery()
		{
			string queryString = Window.Location.Search.Substring(1);
			string[] D = queryString.Split('&');
			Dictionary Dict = new Dictionary();
			foreach (string d in D)
			{
				string[] lr = d.Split("=");
				if (lr[0] != "")
				{
					Dict[lr[0]] = lr[1];
				}
			}
			return Dict;
		}

		internal static bool IsEmailValid(string input)
		{

			return new RegExp(Patterns.Email).Test(input);

		}

		internal static void SetVisible(string Id)
		{
			Element Elem = Window.Document.GetElementById(Id);
			if (Elem == null)
			{
				return;
			}
			Elem.Style.Visibility = "visible";
		}

		internal static void SetDisplay(string Id)
		{
			Element Elem = Window.Document.GetElementById(Id);
			if (Elem == null)
			{
				return;
			}
			Elem.Style.Display = "block";
		}

		internal static void NoDisplay(string Id)
		{
			Element Elem = Window.Document.GetElementById(Id);
			if (Elem == null)
			{
				return;
			}
			Elem.Style.Display = "none";
		}

		internal static bool IsAvailable(string Id)
		{
			return Window.Document.GetElementById(Id) != null;
		}

		internal static void SetClass(string Id, string className)
		{
			if (Util.IsAvailable(Id))
			{
				Document.GetElementById(Id).ClassName = className;
			}
		}

		internal static void Hide(string Id)
		{
			if (Util.IsAvailable(Id))
			{
				Window.Document.GetElementById("tc").Style.Visibility = "hidden";

			}
		}

		public static void ScrollTo(string Id)
		{
			if (Util.IsAvailable(Id))
			{
				try
				{
					Window.Document.GetElementById(Id).ScrollIntoView();
				}
				catch
				{
				}

			}
		}

		public static string NoTags(string s)
		{
			//Regex to be used..
			return s.ToLowerCase().Replace("<u>", "").Replace("</u>", "").Replace("<b>", "").Replace("<i>", "").Replace("</b>", "").Replace("</i>", "");
		}

		public static void SetFocus(string Id)
		{
			if (Document.GetElementById(Id) == null)
			{
				return;
			}
			else
			{
				Document.GetElementById(Id).Focus();
			}
		}

		public static void SetCheckedValue(string Id, bool value)
		{
			if (value)
			{
				Util.SetChecked(Id);
			}
			else
			{
				Util.SetUnChecked(Id);
			}
		}
	}

	public class Patterns
	{
		public static string Email = (string)Script.Literal("/^[a-zA-Z_\\.]+?@[a-zA-Z_\\.]+?\\.[a-zA-Z]{2,3}$/");
	}
}
