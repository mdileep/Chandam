//---------------------------------------------------------------------------------------------
// <copyright file="OverlayDialog.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:10EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using System.Html;

namespace MiriyamApp
{
	public delegate bool OKCallBack();
	public delegate void LoadCallBack();
	public class OverlayDialog
	{
		public string OKText;
		public string CancelText;
		public LoadCallBack PostLoadCallback;
		public OKCallBack PreOKCallBack;
		public OKCallBack PostOKCallBack;

		string _content;
		string _title;
		Element _inner;
		bool _showClose;
		string footerText;
		string id;

		public bool ShowClose
		{
			get { return _showClose; }
			set { _showClose = value; }
		}

		public string FooterText
		{
			get { return footerText; }
			set { footerText = value; }
		}

		public string Id
		{
			get { return id; }
			set { id = value; }
		}

		public Element InnerElement
		{
			set
			{
				_inner = value;
			}
			get
			{
				return _inner;
			}
		}

		public OverlayDialog(string title, string content)
		{
			_title = title;
			_content = content;
			OKText = "సరే";
			CancelText = "వద్దు";
			id = "OLay";
			_showClose = true;
		}

		public void Show()
		{

			Element oFContent = Document.CreateElement("div");
			oFContent.ClassName = "oFContent";
			if (Content != "")
			{
				oFContent.InnerHTML = _content;
			}


			if (_inner != null)
			{
				oFContent.AppendChild(Document.CreateElement("br"));
				oFContent.AppendChild(_inner);
			}

			Element oFTitle = null;
			if (Title != "")
			{
				oFTitle = Document.CreateElement("h1");
				oFTitle.ClassName = "oFTitle";
				oFTitle.InnerHTML = Title;
			}

			Element btnClose2 = null;
			if (ShowClose)
			{
				btnClose2 = Document.CreateElement("input");
				btnClose2.ClassName = "actions";
				btnClose2.SetAttribute("type", "button");
				btnClose2.SetAttribute("value", CancelText);
				Util.RegisterEvent2(btnClose2, "click", delegate (ElementEvent e)
				{
					Close();
				});
			}

			Element btnOK = Document.CreateElement("input");
			btnOK.ClassName = "actions";
			btnOK.SetAttribute("type", "button");
			btnOK.SetAttribute("value", OKText);
			Util.RegisterEvent2(btnOK, "click", OnOK);

			Element oFButtonHolder = Document.CreateElement("div");
			oFButtonHolder.ClassName = "oFButtonHolder";

			if (this.FooterText != null)
			{
				Element p = Document.CreateElement("span");

				p.InnerHTML = this.FooterText;
				oFButtonHolder.AppendChild(p);
			}
			oFButtonHolder.AppendChild(btnOK);

			if (btnClose2 != null)
			{
				oFButtonHolder.AppendChild(btnClose2);
			}

			Element oFCloseButtonHolder = null;
			if (ShowClose)
			{
				Element btnClose = Document.CreateElement("h1");
				btnClose.InnerHTML = "X";
				btnClose.Title = CancelText;
				btnClose.ID = id + "Close";

				Util.RegisterEvent2(btnClose, "click", delegate (ElementEvent e)
				{
					Close();
				});

				oFCloseButtonHolder = Document.CreateElement("div");
				oFCloseButtonHolder.ClassName = "oFCloseButtonHolder";
				oFCloseButtonHolder.AppendChild(btnClose);
			}




			Element oBackGround = Document.GetElementById(oBackGroundId);
			if (oBackGround == null)
			{
				oBackGround = Document.CreateElement("div");
				oBackGround.ClassName = "oBackGround";
				oBackGround.ID = oBackGroundId;
				Document.Body.AppendChild(oBackGround);
			}
			oBackGround.Style.Visibility = (oBackGround.Style.Visibility == "visible") ? "hidden" : "visible";

			Element oForeGround = Document.GetElementById(oForeGroundId);
			if (oForeGround == null)
			{
				oForeGround = Document.CreateElement("div");
				oForeGround.ClassName = "oForeGround";
				oForeGround.ID = oForeGroundId;
				Document.Body.AppendChild(oForeGround);
			}
			oForeGround.Style.Visibility = (oForeGround.Style.Visibility == "visible") ? "hidden" : "visible";
			if (oFTitle != null)
			{
				oForeGround.AppendChild(oFTitle);
			}
			if (oFCloseButtonHolder != null)
			{
				oForeGround.AppendChild(oFCloseButtonHolder);
			}
			oForeGround.AppendChild(oFContent);
			oForeGround.AppendChild(oFButtonHolder);

			if (PostLoadCallback != null)
			{
				PostLoadCallback();
			}
		}


		string oBackGroundId
		{
			get
			{
				return id + "_oBackGround";
			}
		}
		string oForeGroundId
		{
			get
			{
				return id + "_oForeGround";
			}
		}
		public string Title
		{
			set
			{
				_title = value;
			}
			get
			{
				return _title == null ? "" : _title;
			}
		}
		public string Content
		{
			set
			{
				_content = value;
			}
			get
			{
				return _content == null ? "" : _content;
			}
		}

		public extern OverlayDialog();


		public void OnOK(ElementEvent e)
		{
			bool res = PreOKCallBack == null ? true : PreOKCallBack();
			if (res)
			{
				Close();
				if (PostOKCallBack != null)
				{
					PostOKCallBack();
				}
			}


		}
		public void Close()
		{
			Element oForeGround = Document.GetElementById(oForeGroundId);
			oForeGround.Style.Visibility = (oForeGround.Style.Visibility == "visible") ? "hidden" : "visible";
			oForeGround.InnerHTML = "";

			Element oBackGround = Document.GetElementById(oBackGroundId);
			oBackGround.Style.Visibility = (oBackGround.Style.Visibility == "visible") ? "hidden" : "visible";
			oBackGround.InnerHTML = "";
		}




	}
}
