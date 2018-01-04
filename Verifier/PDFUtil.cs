//---------------------------------------------------------------------------------------------
// <copyright file="PDFUtil.cs" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:33EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------

using iTextSharp.text;
using iTextSharp.text.html;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Verifier
{
	public class PDFUtil
	{
		PDFOptions Options;
		StyleSheet ST;

		public PDFUtil()
		{
			Init(PDFOptions.Default);
		}

		public PDFUtil(PDFOptions Options)
		{
			Init(Options);
		}

		private void Init(PDFOptions Options)
		{
			this.Options = Options;

			FontFactory.Register(@"RaviPrakash.ttf");
			FontFactory.Register(@"Ponnala.ttf");
			FontFactory.Register(@"RamaneeyaWin.ttf");
			FontFactory.Register("seguisym.ttf");

			//BaseFont bf = BaseFont.CreateFont ( BaseFont.SYMBOL , BaseFont.CP1252 , BaseFont.EMBEDDED);

			ST = new StyleSheet();

			ST.LoadTagStyle(HtmlTags.BODY, HtmlTags.FACE, "RamaneeyaWin");
			ST.LoadTagStyle(HtmlTags.BODY, HtmlTags.ENCODING, BaseFont.IDENTITY_H);

			ST.LoadTagStyle(HtmlTags.H1, HtmlTags.FACE, "RaviPrakash");
			ST.LoadTagStyle(HtmlTags.H2, HtmlTags.FACE, "Ponnala");
			ST.LoadTagStyle(HtmlTags.TH, HtmlTags.FACE, "RaviPrakash");

			ST.LoadStyle("symbol", HtmlTags.FACE, "Segoe UI Symbol");

			ST.LoadTagStyle(HtmlTags.TH, HtmlTags.BGCOLOR, "#EEEEEE");
			ST.LoadStyle("th", HtmlTags.BGCOLOR, "#EEEEEE");


		}

		public void HTML2PDF(string input, string output)
		{

			Console.WriteLine("Started Processing..." + input);

			Document document = new Document(Options.PageSize);

			PdfWriter PdfWriter = PdfWriter.GetInstance(document, new FileStream(output, FileMode.Create));
			HeaderFooter PageEventHandler = new HeaderFooter();
			PdfWriter.PageEvent = PageEventHandler;
			PageEventHandler.Title = Options.Title;
			PageEventHandler.Caption = Options.Caption;


			document.Open();
			HTMLWorker hw = new HTMLWorker(document);

			string text = File.ReadAllText(input, Encoding.UTF8);

			List<IElement> list = HTMLWorker.ParseToList(new StringReader(text), ST);
			Console.WriteLine("\t");
			int cnt = 1;
			foreach (var el in list)
			{
				Console.WriteLine("\rProcessing: " + (cnt++) + " of " + list.Count);

				if (el is PdfPTable)
				{
					if (Options.RepeaterHeader)
					{
						((PdfPTable)el).HeaderRows = 1;
					}
					((PdfPTable)el).SplitLate = false;
				}

				if (Options.Indentation)
				{
					if (el is List)
					{
						SetIndendation((List)el, 10f);
					}
				}
				document.Add(el);
			}
			document.Close();

			Console.WriteLine("Dumped to: " + output);
		}

		private void SetIndendation(List OL, float p)
		{
			OL.IndentationLeft = p == 0 ? 10f : p;

			foreach (var el in OL.Items)
			{
				if (el is List)
				{
					SetIndendation((List)el, p + 10f);
				}
			}
		}
	}
}

namespace Verifier
{
	using iTextSharp.text;
	using iTextSharp.text.pdf;

	public class HeaderFooter : PdfPageEventHelper
	{

		PdfContentByte cb;
		PdfTemplate template;


		public HeaderFooter()
		{
			string normal = "RamaneeyaWin" + ".ttf";
			BaseFont = BaseFont.CreateFont(normal, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);

		}

		#region Properties
		public BaseFont BaseFont
		{
			get;
			set;
		}

		public string Title
		{
			get;
			set;
		}
		public string Caption
		{
			get;
			set;
		}
		#endregion

		public override void OnOpenDocument(PdfWriter writer, Document document)
		{
			try
			{

				cb = writer.DirectContent;
				template = cb.CreateTemplate(50, 50);
			}
			catch (DocumentException de)
			{
			}
			catch (System.IO.IOException ioe)
			{
			}
		}

		public override void OnStartPage(PdfWriter writer, Document document)
		{
			base.OnStartPage(writer, document);


			string text = "Page " + writer.PageNumber + " of ";
			float len = BaseFont.GetWidthPoint(text, 8);
			SetText(text, document.PageSize.GetRight(60), document.PageSize.GetTop(20), 8);
			cb.AddTemplate(template, document.PageSize.GetRight(60) + len, document.PageSize.GetTop(20));
		}



		public override void OnEndPage(PdfWriter writer, Document document)
		{
			base.OnEndPage(writer, document);
			SetText(Title, document.PageSize.GetRight(60), document.PageSize.GetBottom(20), 8);
			SetText(Caption, document.PageSize.GetLeft(20), document.PageSize.GetBottom(20), 8);
		}

		public override void OnCloseDocument(PdfWriter writer, Document document)
		{
			base.OnCloseDocument(writer, document);

			template.BeginText();
			template.SetFontAndSize(BaseFont, 8);
			template.SetTextMatrix(0, 0);
			template.ShowText((writer.PageNumber - 1).ToString());
			template.EndText();
		}

		private void SetText(string Text, float x, float y, float f)
		{
			if (Text != string.Empty)
			{
				cb.BeginText();
				cb.SetFontAndSize(BaseFont, f);
				cb.SetRGBColorFill(50, 50, 50);
				cb.SetTextMatrix(x, y);
				cb.ShowText(Text);
				cb.EndText();
			}
		}

	}
}

namespace Verifier
{
	using iTextSharp.text;

	public class PDFOptions
	{

		public PDFOptions()
		{
			PageSize = iTextSharp.text.PageSize.A4;
		}
		public Rectangle PageSize;
		public string Title;
		public string Caption;
		public bool Indentation;
		public bool RepeaterHeader;
		public static PDFOptions Default
		{
			get
			{
				return new PDFOptions
				{
					Indentation = false,
					RepeaterHeader = false
				};
			}

		}
		public static PDFOptions Book
		{
			get
			{
				return new PDFOptions
				{
					Indentation = true,
					RepeaterHeader = false
				};
			}

		}
		public static PDFOptions Report
		{
			get
			{
				return new PDFOptions
				{
					Indentation = false,
					RepeaterHeader = true
				};
			}

		}

		public bool CheckContent
		{
			get;
			set;
		}
	}

}