using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Chandam.Samples;
using Chandam.Rules;
using Library.Chandam.Samples;
using Chandam;
using Chandam.Core;

public partial class Satakam : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		//Go ( );
		//EvaluateSampels ( );
		//EvaluateSampels2 ( );
		EvalTextFile(Server.MapPath("txt\\vs.txt"), Server.MapPath("html\\vs.html"));
	}

	private void EvaluateSampels()
	{
		List<string> Poems = new List<string>();
		foreach (Rule R in RuleHelper.GetAllRules(true))
		{
			foreach (Example s in R.Examples2)
			{
				Poems.Add(s.Text);
			}
		}

		Go(Poems.ToArray(), "ఛందం", "ఎందరో", "Chandassu");

	}
	private void EvaluateSampels2()
	{
		string file = "Chandam_Noyati";
		string htmlFile = Server.MapPath("html\\" + file + ".html");
		string s = Library.Chandam.Samples.Satakam.EvaluateAllRules(htmlFile);
		f.InnerHtml = s;
		head.Title = "ఛందం";
	}

	private void Go()
	{
		Go(new Vemana(), "వేమన శతకము", "వేమన కొండవీటి", "Vemana");
		Go(new Kumara(), "కుమార శతకము", "పక్కి వేంకట నరశింహ కవీంద్ర", "Kumara");
		Go(new Bhaskara(), "భాస్కర శతకము", "మారవి వెంకయ్య కవి", "Bhaskara");
		Go(new MyFavPoems(), "కొన్ని ఆణిముత్యాలు", "ఎందరో", "MyFav");
		Go(new SriKalaHadteeswara(), "శ్రీ కాళహస్తీశ్వర శతకము", "ధూర్జటి", "SriKalaHadteeswara");
		Go(new SriRama(), "శ్రీరామ శతకము(1948)", "శ్రీమతి కల్లూరి విశాలాక్షమ్మ", "SriRam");
		Go(new Sumati(), "సుమతీ శతకము", "బద్దెన", "Sumati");

	}

	private void Go(SamplePoems V, string title, string author, string file)
	{
		Go(V.Poems, title, author, file);
	}

	private void Go(string[] Poems, string title, string author, string file)
	{
		string txtFile = Server.MapPath("txt\\" + file + ".txt");
		string htmlFile = Server.MapPath("html\\" + file + ".html");
		BuildTextFile(Poems, title, author, txtFile);
		EvalTextFile(txtFile, htmlFile);

	}

	private void BuildTextFile(string[] Poems, string title, string author, string file)
	{
		SatakamData S = new SatakamData();

		S.Poems = new List<Poem>();
		foreach (string s in Poems)
		{
			Poem P = new Poem();
			P.Text = s;
			S.Poems.Add(P);

		}
		S.Header = new List<string> { author };
		S.Footer = new List<string>
		{
		};
		S.Format = Format.Format1;
		S.Title = title;
		Library.Chandam.Samples.Satakam.Write2File(file, S);
	}

	private void EvalTextFile(string fromFile, string toFile)
	{
		{
			SatakamData S = Library.Chandam.Samples.Satakam.ExtractSatakamFromFile(fromFile);
			string s = Library.Chandam.Samples.Satakam.Build(S, MatchOptions.QucikMatchSettings);
			f.InnerHtml = s;
			head.Title = S.Title;
			File.WriteAllText(toFile, s, Encoding.UTF8);
		}
	}

}