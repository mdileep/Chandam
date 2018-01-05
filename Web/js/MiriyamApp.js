/*! MiriyamApp.js 1.0.0.0
 * 
 */

"use strict";

require(['ss', 'MiriyamUtil', 'MiriyamLib2'], function(ss, MiriyamUtil, MiriyamLib2) {
  var $global = this;

  // MiriyamApp.Metric

  var MiriyamApp$Metric = {
    random: 0, 
    scores: 1, 
    determine: 2, 
    tryMatch: 3, 
    tryMatch2: 4, 
    rules: 5, 
    rules2: 6, 
    showDesigner: 7, 
    samples: 8, 
    cheatSheet: 9, 
    book: 10, 
    load: 11
  };


  // Chandam.Strings

  function Chandam$Strings() {
  }
  var Chandam$Strings$ = {

  };


  // Chandam.Core.Business

  function Chandam$Core$Business() {
  }
  Chandam$Core$Business.buildBook = function() {
    return MiriyamLib2.CheatSheet.buildBook();
  };
  Chandam$Core$Business.buildCheatSheet = function() {
    return MiriyamLib2.CheatSheet.buildCheatSheet(false, false);
  };
  Chandam$Core$Business.rules = function(identifier) {
    var R = MiriyamUtil.Manager.fetchRule(identifier);
    return Chandam$Core$Business.rules2(R, false);
  };
  Chandam$Core$Business.rules3 = function(R) {
    return Chandam$Core$Business.rules2(R, true);
  };
  Chandam$Core$Business.rules2 = function(R, useExample) {
    var s = (R.get_ruleText() == null) ? MiriyamLib2.CheatSheet.buildRules2(R, useExample) : R.get_ruleText();
    return "<div class='err'>" + R.get_name() + '</div>' + s;
  };
  Chandam$Core$Business.samples = function(identifier) {
    var R = MiriyamUtil.Manager.fetchRule(identifier);
    R.set_language(Chandam$Core$Context.get_language());
    var s = '';
    var $enum1 = ss.enumerate(R.get_examples2());
    while ($enum1.moveNext()) {
      var item = $enum1.current;
      if (item != null) {
        var poem = item.get_text();
        var author = item.get_author();
        s = s + "<li  title='Click on this poem to use' class='sample'>" + Chandam$Core$Business._tryMatch3(poem, R);
        if (!!author) {
          s = s + ' <i>~' + author + '</i>';
        }
        s = s + '</li>';
      }
    }
    if (!!s) {
      s = "<ol class='poems'>" + s + '</ol>';
    }
    else {
      s = "\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c32\u0c41 \u0c05\u0c02\u0c26\u0c41\u0c2c\u0c3e\u0c1f\u0c41\u0c32\u0c4b \u0c32\u0c47\u0c35\u0c41<br />\u0c2e\u0c40 \u0c35\u0c26\u0c4d\u0c26 \u0c08 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c3f\u0c15\u0c3f \u0c1a\u0c46\u0c02\u0c26\u0c3f\u0c28 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c09\u0c02\u0c1f\u0c47 \u0c28\u0c3e\u0c15\u0c41  ( <a href='mailto:m.dileep@gmail.com'>m.dileep@gmail.com</a> )\u0c2a\u0c02\u0c2a\u0c17\u0c32\u0c30\u0c41.";
    }
    return "<div class='err'>" + R.get_name() + '</div>' + s;
  };
  Chandam$Core$Business.scores = function(s, Options) {
    var G = new MiriyamLib2.GanaVibhajana(s, Options.get_language());
    var includeRare = Options.get_includeRare();
    var min = G.get_min();
    var max = G.get_max();
    includeRare = true;
    var Rules = (Options.get_quickMatch()) ? MiriyamUtil.RuleHelper.getAllRules2(min, max, G.get_preLines()) : MiriyamUtil.RuleHelper.getAllRules(includeRare);
    var L = [];
    var $enum1 = ss.enumerate(Rules);
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      var P = new MiriyamLib2.Padyam();
      P.set_matchYati(Options.get_matchYati());
      P.set_matchPrasa(Options.get_matchPrasa());
      P.set_allowSantiPrasa(Options.get_allowSantiPrasa());
      P.set_sandiMatch(Options.get_experimenatalSandhi());
      var MR = P.match(s, R);
      L.push(MR);
      P = null;
    }
    var s2 = Chandam$Core$Business.buildAllScores(L);
    L = null;
    return s2;
  };
  Chandam$Core$Business._tryMatch3 = function(s, R) {
    if (s == null || !s.trim().length) {
      return '';
    }
    var P = new MiriyamLib2.Padyam();
    var Options = MiriyamLib2.MatchOptions.get_tradtionalMatchSettings();
    P.set_matchYati(Options.get_matchYati());
    P.set_matchPrasa(Options.get_matchPrasa());
    P.set_allowSantiPrasa(Options.get_allowSantiPrasa());
    P.set_sandiMatch(Options.get_experimenatalSandhi());
    var MR = P.match(s, R);
    if (!MR.get_total()) {
      return '';
    }
    return P.build2(MR);
  };
  Chandam$Core$Business.determine = function(s, Options) {
    if (s == null || !s.trim().length) {
      return null;
    }
    var Pr = MiriyamLib2.Padyam.mostProbable(s, Options);
    return Pr;
  };
  Chandam$Core$Business.buildResult2 = function(Pr) {
    if (Pr == null) {
      return '';
    }
    var P = Pr.get_padyam();
    var MR = Pr.get_matchResult();
    var R = Pr.get_rule();
    if (!MR.get_total()) {
      return '';
    }
    var s2 = Chandam$Core$Business.buildResult(R, P, MR, Pr.get_candiates());
    P = null;
    MR = null;
    R = null;
    return s2;
  };
  Chandam$Core$Business.tryMatch = function(s, identifier, Options) {
    var R = MiriyamUtil.Manager.fetchRule(identifier);
    return Chandam$Core$Business.tryMatch2(s, R, Options);
  };
  Chandam$Core$Business.tryMatch2 = function(s, R, Options) {
    if (s == null || !s.trim().length) {
      return '';
    }
    var P = new MiriyamLib2.Padyam();
    P.set_matchYati(Options.get_matchYati());
    P.set_matchPrasa(Options.get_matchPrasa());
    P.set_allowSantiPrasa(Options.get_allowSantiPrasa());
    P.set_sandiMatch(Options.get_experimenatalSandhi());
    var MR = P.match(s, R);
    if (!MR.get_total()) {
      return '';
    }
    return Chandam$Core$Business.buildResult(R, P, MR, null);
  };
  Chandam$Core$Business.buildResult = function(R, P, MR, Candidates) {
    var handleProse = (Candidates != null);
    var sb = new ss.StringBuilder();
    if (MR.get_percentage() !== 100) {
      if (MR.get_percentage() < 50 && handleProse) {
      }
      else {
        sb.appendLine("<div class='err w100 center'>" + R.get_name());
        sb.appendLine(": <b class='red'>" + parseFloat(MR.get_percentage().toString()).toFixed() + '%</b>(' + MR.get_score() + '/' + MR.get_total() + ')');
        sb.appendLine('</div>');
      }
    }
    else {
      sb.appendLine("<div class='err Green  w100 center'>" + R.get_name());
      sb.appendLine('</div>');
    }
    if (MR.get_percentage() !== 100) {
      if (MR.get_percentage() < 50 && handleProse) {
        sb.appendLine("<div class='vachanam'>" + "<div class='err'>\u0c15\u0c35\u0c3f\u0c24 \u0c32\u0c47\u0c26\u0c3e \u0c2a\u0c3e\u0c1f \u0c32\u0c47\u0c26\u0c3e \u0c35\u0c1a\u0c28\u0c2e\u0c41 \u0c32\u0c47\u0c26\u0c3e \u0c17\u0c26\u0c4d\u0c2f\u0c2e\u0c41 \u0c32\u0c47\u0c26\u0c3e \u0c2e\u0c30\u0c47\u0c26\u0c48\u0c28\u0c3e \u0c1b\u0c02\u0c26\u0c4b\u0c2a\u0c4d\u0c30\u0c15\u0c4d\u0c30\u0c3f\u0c2f</div>" + "<div class='Err22'>");
        sb.appendLine(P.build3());
        sb.appendLine('</div></div>');
      }
      else {
        if (!R.get_infiniteLength()) {
          sb.appendLine("<div class='build'><div class='err'>\u0c17\u0c23 \u0c35\u0c3f\u0c2d\u0c1c\u0c28</div>");
          sb.appendLine(P.build(MR));
          sb.appendLine('</div>');
          sb.appendLine("<div class='buildErrors'><div class='err'>\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c41</div>");
          sb.appendLine(MR.showErrors(MiriyamUtil.OutputFormat.HTML));
          sb.appendLine('</div>');
        }
        else {
          sb.appendLine("<div class='build2'><div class='err'>\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c41</div>");
          sb.appendLine(MR.showErrors(MiriyamUtil.OutputFormat.HTML));
          sb.appendLine('</div>');
          sb.appendLine("<div  class='buildErrors'><div class='err'>\u0c17\u0c23 \u0c35\u0c3f\u0c2d\u0c1c\u0c28</div>");
          sb.appendLine(P.build(MR));
          sb.appendLine('</div>');
        }
      }
    }
    else {
      try {
        sb.appendLine("<div class='build'><div class='err'>" + R.get_shortName() + "</div><div class='Err22'>");
        sb.appendLine(P.build2(MR));
        sb.appendLine('</div></div>');
      }
      catch ($e1) {
      }
      sb.appendLine("<div class='build3'><div class='err right'>\u0c17\u0c23 \u0c35\u0c3f\u0c2d\u0c1c\u0c28</div>");
      sb.appendLine(P.build(MR));
      sb.appendLine('</div>');
    }
    if (Candidates != null && MR.get_percentage() !== 100 && Candidates.length >= 1) {
      sb.appendLine("<div class='candidates'>");
      sb.appendLine("<div class='err'>\u0c38\u0c2e\u0c40\u0c2a \u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c41</div>");
      sb.appendLine("<ol style='cursor:pointer;' class='num'>");
      for (var i = 0; i < Candidates.length; i++) {
        if (i > 5 || (!i && MR.get_percentage() >= 50 && !handleProse)) {
          continue;
        }
        var _MR = Candidates[i];
        sb.appendLine("<li  id='candiate_" + i + "' data='" + _MR.get_rule().get_identifier() + "'>" + _MR.get_rule().get_name());
        sb.appendLine(": <b style='color:red'>" + parseFloat(_MR.get_percentage().toString()).toFixed() + '%</b>');
        sb.appendLine('</li>');
      }
      sb.appendLine('</ol>');
      sb.append("<div class='help'>\u0c2e\u0c40\u0c30\u0c41 \u0c05\u0c28\u0c41\u0c15\u0c41\u0c02\u0c1f\u0c41\u0c28\u0c4d\u0c28 \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c02 \u0c08 \u0c38\u0c2e\u0c40\u0c2a \u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c32\u0c4b \u0c15\u0c28\u0c41\u0c15 \u0c09\u0c02\u0c1f\u0c47 \u0c26\u0c3e\u0c28\u0c3f\u0c2a\u0c48 \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c3f <span class='gName'>...\u0c24\u0c4b \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</span>  \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c2e\u0c41 \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f. \u0c32\u0c47\u0c26\u0c3e \u0c2f\u0c24\u0c3f, \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c17\u0c23\u0c28\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c24\u0c40\u0c38\u0c3f\u0c35\u0c47\u0c38\u0c3f \u0c2e\u0c30\u0c4b\u0c38\u0c3e\u0c30\u0c3f <span class='gName'>\u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</span> \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f.\u0c2e\u0c30\u0c3f\u0c28\u0c4d\u0c28\u0c3f \u0c35\u0c3f\u0c35\u0c30\u0c3e\u0c32\u0c15\u0c41 <a  target=\"_blank\" class=\"pink\" href=\"default.aspx?faq\" title=\"\u0c24\u0c30\u0c1a\u0c41\u0c17\u0c3e \u0c05\u0c21\u0c3f\u0c17\u0c47 \u0c2a\u0c4d\u0c30\u0c36\u0c4d\u0c30\u0c4d\u0c28\u0c32\u0c41(FAQ)\">\u0c24\u0c30\u0c1a\u0c41\u0c17\u0c3e \u0c05\u0c21\u0c3f\u0c17\u0c47 \u0c2a\u0c4d\u0c30\u0c36\u0c4d\u0c30\u0c4d\u0c28\u0c32\u0c41(FAQ)</a> \u0c1a\u0c42\u0c21\u0c02\u0c21\u0c3f.</div>");
      sb.appendLine('</div>');
    }
    return sb.toString2();
  };
  Chandam$Core$Business.buildAllScores = function(L) {
    var sb = new ss.StringBuilder();
    sb.append("<div class='err'>\u0c2e\u0c42\u0c32\u0c4d\u0c2f\u0c3e\u0c02\u0c15\u0c28\u0c02</div>" + "<table  class='sort-table' id='scores' cellspacing='0'  border='1'  class='errTab'><thead><tr><td>#</td><td>\u0c2a\u0c26\u0c4d\u0c2f \u0c30\u0c40\u0c24\u0c3f</td><td>\u0c2a\u0c47\u0c30\u0c41</td><td class='number'>\u0c36\u0c3e\u0c24\u0c02</td><td class='number'>\u0c2e\u0c3e\u0c30\u0c4d\u0c15\u0c41\u0c32\u0c41</td><td class='number'>\u0c2e\u0c4a\u0c24\u0c4d\u0c24\u0c02</td></tr></thead><tbody>");
    var cnt = 1;
    var $enum1 = ss.enumerate(L);
    while ($enum1.moveNext()) {
      var MR = $enum1.current;
      sb.append((MR.get_percentage() === 100) ? "<tr  style='font-weight:bold;color:green;'>" : '<tr>');
      sb.append('<td>' + (cnt++) + '</td><td>' + MiriyamUtil.Helper.getPadyamTypeString(MR.get_rule().get_padyamType(), MR.get_rule().get_padyamSubType()) + ((!MR.get_rule().get_chandamName()) ? '' : ' (' + MR.get_rule().get_chandamName() + ')') + '</td><td>' + MR.get_rule().get_name() + "</td><td class='number'>" + parseFloat(MR.get_percentage().toString()).toFixed() + "</td><td class='number'>" + MR.get_score() + "</td><td class='number'>" + MR.get_total() + '</td>');
      sb.append('</tr>');
    }
    sb.append('</tbody></table>');
    return sb.toString2();
  };
  Chandam$Core$Business.getRandomPoem = function() {
    var current = Math.floor(Math.random() * Chandam$Samples$SamplePoems.get_poems().length);
    var s = Chandam$Samples$SamplePoems.getItem(current);
    return s;
  };
  Chandam$Core$Business.initRandomPoems = function() {
    var $enum1 = ss.enumerate(MiriyamUtil.RuleHelper.getAllRules(true));
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      Chandam$Samples$SamplePoems.append(R.get_examples());
    }
  };
  Chandam$Core$Business.get_randomPoemsCount = function() {
    return Chandam$Samples$SamplePoems.get_poems().length;
  };
  Chandam$Core$Business.checkPrasa = function(s1, s2, allowSantiPrasa) {
    return new MiriyamLib2.YatiPrasaTester().checkPrasa(s1, s2, allowSantiPrasa);
  };
  Chandam$Core$Business.checkYati = function(s1, s2, Sandhi) {
    return new MiriyamLib2.YatiPrasaTester().checkYati(s1, s2, Sandhi);
  };


  // Chandam.Core.Context

  function Chandam$Core$Context() {
  }
  Chandam$Core$Context.get_language = function() {
    return Chandam$Core$Context._GetTarget();
  };
  Chandam$Core$Context._GetTarget = function() {
    var lang = MiriyamUtil.RuleLanguage.telugu;
    try {
      lang = Config.Language;
    }
    catch ($e1) {
    }
    switch (lang) {
      case MiriyamUtil.RuleLanguage.telugu:
      default:
        return MiriyamUtil.RuleLanguage.telugu;
      case MiriyamUtil.RuleLanguage.kannada:
        return MiriyamUtil.RuleLanguage.kannada;
    }
  };
  var Chandam$Core$Context$ = {

  };


  // MiriyamApp.CookieUtil

  function MiriyamApp$CookieUtil() {
  }
  MiriyamApp$CookieUtil.getCookie = function(key) {
    try {
      var s = document.cookie;
      var Items = s.split(';');
      var $enum1 = ss.enumerate(Items);
      while ($enum1.moveNext()) {
        var Item = $enum1.current;
        var KV = Item.split('=');
        if (KV.length === 2 && KV[0].trim() === key.trim()) {
          return KV[1];
        }
      }
    }
    catch ($e2) {
      return null;
    }
    return null;
  };
  MiriyamApp$CookieUtil.deleteCookie = function(key) {
    MiriyamApp$CookieUtil.setCookie(key, '', -1);
  };
  MiriyamApp$CookieUtil.setCookie = function(key, value, days) {
    try {
      var dt = MiriyamApp$CookieUtil._getOffSetDate(days);
      var a = [ key + '=' + value, ' expires=' + ((days !== -1) ? dt.toUTCString() : '-1') ];
      var s = a.join(';');
      document.cookie = s;
    }
    catch ($e1) {
    }
  };
  MiriyamApp$CookieUtil._getOffSetDate = function(days) {
    var now = new Date();
    try {
      if (days >= 365) {
        var extra = (now.getFullYear() % 365);
        now.setYear(now.getFullYear() + extra);
      }
      if (days >= 30 && days < 365) {
        var extra = (now.getMonth() % 30);
        if (extra + now.getMonth() > 12) {
          now.setMonth(extra + now.getMonth() - 12);
          now.setYear(now.getFullYear() + 1);
        }
      }
      if (days >= 0 && days < 30) {
        if (now.getDate() + days > 30) {
          now.setDate(days + now.getDate() - 30);
          now.setMonth((now.getMonth() + 1) % 12);
        }
        else {
          now.setDate(days + now.getDate());
        }
      }
    }
    catch ($e1) {
    }
    return now;
  };


  // MiriyamApp.LoadRules2

  function MiriyamApp$LoadRules2() {
  }
  MiriyamApp$LoadRules2.setGroupedList = function(includeRare) {
    var cnt = 0;
    var Jati = MiriyamApp$Util.addOptionItem('\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', '\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', true);
    var UpaJati = MiriyamApp$Util.addOptionItem('\u0c09\u0c2a-\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', '\u0c09\u0c2a-\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', true);
    var Vruttam = MiriyamApp$Util.addOptionItem('\u0c24\u0c30\u0c41\u0c1a\u0c41\u0c17\u0c3e  \u0c35\u0c3e\u0c21\u0c47 \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', '\u0c24\u0c30\u0c41\u0c1a\u0c41\u0c17\u0c3e  \u0c35\u0c3e\u0c21\u0c47 \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', true);
    var Ragadalu = MiriyamApp$Util.addOptionItem('\u0c30\u0c17\u0c21\u0c32\u0c41', '\u0c30\u0c17\u0c21\u0c32\u0c41', true);
    var Shatpadalu = MiriyamApp$Util.addOptionItem('\u0c37\u0c1f\u0c4d\u0c2a\u0c26\u0c32\u0c41', '\u0c37\u0c1f\u0c4d\u0c2a\u0c26\u0c32\u0c41', true);
    var Akkara = MiriyamApp$Util.addOptionItem('\u0c05\u0c15\u0c4d\u0c15\u0c30\u0c32\u0c41(\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', '\u0c05\u0c15\u0c4d\u0c15\u0c30\u0c32\u0c41(\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', true);
    var Dvipadalu = MiriyamApp$Util.addOptionItem('\u0c26\u0c4d\u0c35\u0c3f\u0c2a\u0c26\u0c32\u0c41(\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', '\u0c26\u0c4d\u0c35\u0c3f\u0c2a\u0c26\u0c32\u0c41(\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', true);
    var Sisamulu = MiriyamApp$Util.addOptionItem('\u0c38\u0c40\u0c38\u0c2e\u0c41\u0c32\u0c41(\u0c09\u0c2a-\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', '\u0c38\u0c40\u0c38\u0c2e\u0c41\u0c32\u0c41(\u0c09\u0c2a-\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41)', true);
    var ASamaVruttam = MiriyamApp$Util.addOptionItem('\u0c05\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', '\u0c05\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', true);
    var daMDakaVruttam = MiriyamApp$Util.addOptionItem('\u0c26\u0c02\u0c21\u0c15\u0c2e\u0c41\u0c32\u0c41', '\u0c26\u0c02\u0c21\u0c15\u0c2e\u0c41\u0c32\u0c41', true);
    var GenericVruttam = MiriyamApp$Util.addOptionItem('\u0c0f\u0c26\u0c47\u0c28\u0c3f \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02 ##', '\u0c0f\u0c26\u0c47\u0c28\u0c3f \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02 ##', true);
    var $enum1 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.daMDakamu)));
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      daMDakaVruttam.appendChild(O);
      cnt++;
    }
    var $enum2 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules5(MiriyamUtil.PadyamType.vruttam, MiriyamUtil.Frequency.frequent)));
    while ($enum2.moveNext()) {
      var R = $enum2.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Vruttam.appendChild(O);
    }
    var $enum3 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.akkara)));
    while ($enum3.moveNext()) {
      var R = $enum3.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Akkara.appendChild(O);
      cnt++;
    }
    var $enum4 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.ragada)));
    while ($enum4.moveNext()) {
      var R = $enum4.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Ragadalu.appendChild(O);
      cnt++;
    }
    var $enum5 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.ragada2)));
    while ($enum5.moveNext()) {
      var R = $enum5.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Ragadalu.appendChild(O);
      cnt++;
    }
    var $enum6 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.shatpada)));
    while ($enum6.moveNext()) {
      var R = $enum6.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Shatpadalu.appendChild(O);
      cnt++;
    }
    var $enum7 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.divpada)));
    while ($enum7.moveNext()) {
      var R = $enum7.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Dvipadalu.appendChild(O);
      cnt++;
    }
    var $enum8 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.sisamu)));
    while ($enum8.moveNext()) {
      var R = $enum8.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Sisamulu.appendChild(O);
      cnt++;
    }
    var $enum9 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.jati)));
    while ($enum9.moveNext()) {
      var R = $enum9.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      Jati.appendChild(O);
      cnt++;
    }
    var $enum10 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.upaJati)));
    while ($enum10.moveNext()) {
      var R = $enum10.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      UpaJati.appendChild(O);
      cnt++;
    }
    var R = new Chandam$Rules$Vruttam$GenricVruttam();
    var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
    GenericVruttam.appendChild(O);
    var OrderedVruttams = [];
    if (includeRare) {
      for (var i = 1; i <= 27; i++) {
        var cName = MiriyamUtil.Helper.chandamName(i) + ((i <= 26) ? ' (' + i + ')' : ' (>26)');
        var Local = MiriyamApp$Util.addOptionItem(cName, cName, true);
        var VRules = (i <= 26) ? MiriyamUtil.RuleHelper.getRules3(i) : MiriyamUtil.RuleHelper.getRules4(i);
        var $enum11 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(VRules));
        while ($enum11.moveNext()) {
          var R = $enum11.current;
          var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
          Local.appendChild(O);
          OrderedVruttams.push(Local);
          cnt++;
        }
      }
    }
    var asamaRules = MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.vishamaVruttam);
    var $enum12 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(asamaRules));
    while ($enum12.moveNext()) {
      var R = $enum12.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      ASamaVruttam.appendChild(O);
      cnt++;
    }
    var E = window.document.getElementById('list');
    E.innerHTML = '';
    if (Jati.children.length > 0) {
      E.appendChild(Jati);
    }
    if (Akkara.children.length > 0) {
      E.appendChild(Akkara);
    }
    if (Dvipadalu.children.length > 0) {
      E.appendChild(Dvipadalu);
    }
    if (UpaJati.children.length > 0) {
      E.appendChild(UpaJati);
    }
    if (Sisamulu.children.length > 0) {
      E.appendChild(Sisamulu);
    }
    if (Vruttam.children.length > 0) {
      E.appendChild(Vruttam);
    }
    if (includeRare) {
      var $enum13 = ss.enumerate(OrderedVruttams);
      while ($enum13.moveNext()) {
        var _E = $enum13.current;
        E.appendChild(_E);
      }
    }
    if (daMDakaVruttam.children.length > 0) {
      E.appendChild(daMDakaVruttam);
    }
    if (ASamaVruttam.children.length > 0) {
      E.appendChild(ASamaVruttam);
    }
    if (Shatpadalu.children.length > 0) {
      E.appendChild(Shatpadalu);
    }
    if (Ragadalu.children.length > 0) {
      E.appendChild(Ragadalu);
    }
    if (GenericVruttam.children.length > 0) {
      E.appendChild(GenericVruttam);
    }
    document.getElementById('totItems').innerHTML = cnt.toString() + '+';
  };
  MiriyamApp$LoadRules2.setSortedList = function(includeRare) {
    var cnt = 0;
    var E = window.document.getElementById('list');
    E.innerHTML = '';
    var $enum1 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getAllRules(includeRare)));
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      E.appendChild(O);
      cnt++;
    }
    document.getElementById('totItems').innerHTML = cnt.toString() + '+';
  };
  var MiriyamApp$LoadRules2$ = {

  };


  // MiriyamApp.MapRules

  function MiriyamApp$MapRules() {
  }
  MiriyamApp$MapRules.loadExternalRules = function() {
    if (!ss.isValue(Config.ExternalRules)) {
      MiriyamUtil.Manager.register([]);
      return;
    }
    var Rules2 = Config.ExternalRules;
    var Rules = MiriyamApp$MapRules.go(Rules2);
    var Examples = Config.ExternalExamples;
    debugger;;
    MiriyamApp$MapRules._mergeExamples(Rules, Examples);
    MiriyamUtil.Manager.register(Rules);
  };
  MiriyamApp$MapRules._mergeExamples = function(rules, examaples) {
    var $enum1 = ss.enumerate(rules);
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      if (examaples[R.get_identifier()] == null) {
        continue;
      }
      R.set_examples(examaples[R.get_identifier()]);
    }
  };
  MiriyamApp$MapRules.go = function(Rules2) {
    var Rules = new Array(Rules2.length);
    var cnt = 0;
    var $enum1 = ss.enumerate(Rules2);
    while ($enum1.moveNext()) {
      var R2 = $enum1.current;
      var R = new MiriyamUtil.Rule();
      R.set_anthyaPrasa(R2.anthyaPrasa);
      R.set_deferThresold(R2.deferThresold);
      R.set_examples(R2.examples);
      R.set_frequency(R2.frequency);
      R.set_identifier(R2.identifier);
      R.set_infiniteLength(R2.infiniteLength);
      R.set_language((R2.language == null) ? MiriyamUtil.RuleLanguage.telugu : R2.language);
      R.set_lines(R2.lines);
      R.set_name(R2.name);
      R.set_onlyPrasaYati(R2.onlyPrasaYati);
      R.set_padyamSubType(R2.padyamSubType);
      R.set_padyamType(R2.padyamType);
      R.set_prasa(R2.prasa);
      R.set_prasaYati(R2.prasaYati);
      R.set_references(R2.references);
      R.set_ruleText(R2.ruleText);
      R.set_rules(R2.rules);
      R.set_reverseYati(R2.reverseYati);
      R.set_ruleType(R2.ruleType);
      R.set_threshold(R2.threshold);
      R.set_yati((R2.yati == null) ? [] : R2.yati);
      R.set_yatiMode(R2.yatiMode);
      R.set_yatiRecycle(R2.yatiRecycle);
      Rules[cnt++] = R;
    }
    return Rules;
  };
  MiriyamApp$MapRules.defaultOptions = function() {
    var Options = {};
    Options['AllowSantiPrasa'] = true;
    Options['ExperimenatalSandhi'] = true;
    Options['IncludeRare'] = true;
    Options['Language'] = MiriyamUtil.RuleLanguage.telugu;
    Options['MatchPrasa'] = true;
    Options['MatchYati'] = true;
    Options['QuickMatch'] = true;
    Options['ShowGV'] = false;
    return Options;
  };
  MiriyamApp$MapRules.mapOptions = function(Options2) {
    if (Options2 == null) {
      return null;
    }
    var Options = new MiriyamLib2.MatchOptions();
    Options.set_allowSantiPrasa(MiriyamApp$MapRules._ifNotNull(Options2.allowSantiPrasa));
    Options.set_experimenatalSandhi(MiriyamApp$MapRules._ifNotNull(Options2.experimenatalSandhi));
    Options.set_includeRare(MiriyamApp$MapRules._ifNotNull(Options2.includeRare));
    Options.set_language((Options2.language == null) ? MiriyamUtil.RuleLanguage.telugu : Options2.language);
    Options.set_matchPrasa(MiriyamApp$MapRules._ifNotNull(Options2.matchPrasa));
    Options.set_matchYati(MiriyamApp$MapRules._ifNotNull(Options2.matchYati));
    Options.set_quickMatch(MiriyamApp$MapRules._ifNotNull(Options2.quickMatch));
    return Options;
  };
  MiriyamApp$MapRules._ifNotNull = function(val) {
    if (val == null) {
      return true;
    }
    return val;
  };
  var MiriyamApp$MapRules$ = {

  };


  // MiriyamApp.Search

  function MiriyamApp$Search() {
  }
  MiriyamApp$Search.init = function() {
    MiriyamApp$Search._load();
  };
  MiriyamApp$Search._load = function() {
    MiriyamApp$Search._loadPadyamTypes();
    MiriyamApp$Search._loadSreni();
    MiriyamApp$Worker.loadRules();
  };
  MiriyamApp$Search._loadSreni = function() {
    var E = window.document.getElementById('SearchSreni');
    if (E == null) {
      return;
    }
    E.innerHTML = '';
    var E0 = MiriyamApp$Util.addOptionItem('\u0c0f\u0c26\u0c47\u0c28\u0c3f', '-1', false);
    E0.setAttribute('selected', 'selected');
    E.appendChild(E0);
    var $enum1 = ss.enumerate([ '3', '4', '5', '6', '3-4', '4-3', '4-5', '5-4', '3-5', '5-3' ]);
    while ($enum1.moveNext()) {
      var k = $enum1.current;
      var E1 = MiriyamApp$Util.addOptionItem(k, k, false);
      E.appendChild(E1);
    }
  };
  MiriyamApp$Search._loadPadyamTypes = function() {
    var E = window.document.getElementById('SearchPadyamType');
    if (E == null) {
      return;
    }
    E.innerHTML = '';
    var E1 = MiriyamApp$Util.addOptionItem('\u0c1c\u0c3e\u0c24\u0c3f', 'Jati', false);
    var E2 = MiriyamApp$Util.addOptionItem('\u0c09\u0c2a\u0c1c\u0c3e\u0c24\u0c3f', 'UpaJati', false);
    var E3 = MiriyamApp$Util.addOptionItem('\u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02', 'Vruttam', false);
    var E4 = MiriyamApp$Util.addOptionItem('\u0c0f\u0c26\u0c47\u0c28\u0c3f', 'Any', false);
    E4.setAttribute('selected', 'selected');
    E.appendChild(E4);
    E.appendChild(E1);
    E.appendChild(E2);
    E.appendChild(E3);
  };
  MiriyamApp$Search.go = function() {
    document.getElementById('result').innerHTML = "<b style='color:red;'>Searching ..</b>";
    setTimeout(MiriyamApp$Search._searchRules, 0);
  };
  MiriyamApp$Search._searchRules = function() {
    var SC = MiriyamApp$Search._getSearchCriteria();
    var Rules = MiriyamUtil.RuleHelper.getRules7(SC);
    document.getElementById('result').innerHTML = MiriyamApp$Search._buildList(Rules);
    MiriyamApp$Util.scrollTo('main');
  };
  MiriyamApp$Search._buildList = function(Rules) {
    var sb = new ss.StringBuilder();
    sb.append('<h2>');
    if (Rules.length > 0) {
      sb.append(Rules.length + ' ');
    }
    sb.append('\u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c41');
    sb.append('</h2>');
    if (Rules.length > 0) {
      sb.append('<ol>');
      var $enum1 = ss.enumerate(Rules);
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        sb.append('<li>');
        sb.append("<a href='?chandassu=" + R.get_identifier() + "' target='_blank'>" + R.get_name() + '</a>');
        sb.append('&nbsp;');
        sb.append("<a  title='" + R.get_name() + " \u0c2a\u0c26\u0c4d\u0c2f \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c4b \u0c35\u0c4d\u0c30\u0c3e\u0c38\u0c3f\u0c28 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c02\u0c21\u0c3f.' href='?chandam=" + R.get_identifier() + "' target='_blank'><sup>^</sup></a>");
        sb.append('</li>');
      }
      sb.append('</ol>');
    }
    else {
      sb.append('<b>\u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c41 \u0c0f\u0c2e\u0c40 \u0c32\u0c47\u0c35\u0c41.<br/> \u0c36\u0c4b\u0c27\u0c28\u0c28\u0c41 \u0c2e\u0c3e\u0c30\u0c4d\u0c1a\u0c3f \u0c2a\u0c4d\u0c30\u0c2f\u0c24\u0c4d\u0c28\u0c3f\u0c02\u0c1a\u0c02\u0c21\u0c3f.</b>');
    }
    return sb.toString2();
  };
  MiriyamApp$Search._getSearchCriteria = function() {
    var SearchName = MiriyamApp$Util.getValue('SearchName');
    var SearchSansToo = MiriyamApp$Util.isChecked('SearchSansToo');
    var SearchPadyamType = MiriyamApp$Util.selectedValue('SearchPadyamType');
    var SearchSreni = MiriyamApp$Util.selectedValue('SearchSreni');
    var SearchMatra = MiriyamApp$Util.getValue('SearchMatra');
    var SearchCharLen = MiriyamApp$Util.getValue('SearchCharLen');
    var SC = new MiriyamUtil.SearchCriteria();
    SC.matraSreni = (SearchSreni === '-1') ? '' : SearchSreni;
    SC.includeSans = SearchSansToo;
    SC.nameLike = SearchName;
    SC.padyamType = MiriyamApp$Search._getPadtyamType(SearchPadyamType);
    SC.charLength = 0;
    try {
      SC.charLength = parseInt(SearchCharLen);
    }
    catch ($e1) {
      MiriyamApp$Util.setValue('SearchCharLen', '0');
    }
    SC.matraLength = 0;
    try {
      SC.matraLength = parseInt(SearchMatra);
    }
    catch ($e2) {
      MiriyamApp$Util.setValue('SearchMatra', '0');
    }
    return SC;
  };
  MiriyamApp$Search._getPadtyamType = function(nm) {
    switch (nm) {
      case 'Jati':
        return MiriyamUtil.PadyamType.jati;
      case 'UpaJati':
        return MiriyamUtil.PadyamType.upaJati;
      case 'Vruttam':
        return MiriyamUtil.PadyamType.vruttam;
      case 'Any':
      default:
        return MiriyamUtil.PadyamType.unspecified;
    }
  };


  // MiriyamApp.WorkerEvents

  function MiriyamApp$WorkerEvents() {
  }
  MiriyamApp$WorkerEvents.registerEvents = function() {
    MiriyamApp$WorkerEvents._registerSocialEvents();
    MiriyamApp$WorkerEvents._registerTools();
    MiriyamApp$WorkerEvents._registerSettings();
    MiriyamApp$WorkerEvents._registerCore();
    MiriyamApp$WorkerEvents._registerDesigner();
    MiriyamApp$WorkerEvents._registerSearch();
    MiriyamApp$WorkerEvents._registerMenuEvents();
    MiriyamApp$WorkerEvents._registerLab();
    MiriyamApp$WorkerEvents._registerFooter();
  };
  MiriyamApp$WorkerEvents._registerFooter = function() {
    MiriyamApp$Util.registerClick('subscribe', function(e) {
      MiriyamApp$Worker.onSubscribe();
    });
    MiriyamApp$Util.registerClick('unSubscribe', function(e) {
      MiriyamApp$Worker.onUnSubscribe();
    });
    MiriyamApp$Util.registerClick('notification', function(e) {
      MiriyamApp$Worker.hideNotification();
    });
    MiriyamApp$Util.registerClick('bulk', function(e) {
      MiriyamApp$Worker.showBulkCompute();
    });
    MiriyamApp$Util.registerClick('feedback', function(e) {
      MiriyamApp$Worker.onFeedback();
    });
    MiriyamApp$Util.registerClick('req', function(e) {
      MiriyamApp$Worker.onAppeal();
    });
  };
  MiriyamApp$WorkerEvents._registerSocialEvents = function() {
    MiriyamApp$Util.registerClick('fbPost', function(e) {
      MiriyamApp$Worker.onFBShare();
    });
    MiriyamApp$Util.registerClick('permLink', function(e) {
      MiriyamApp$Worker.onPermLink();
    });
    MiriyamApp$Util.registerClick('twitterPost', function(e) {
      MiriyamApp$Worker.onTwitterPost();
    });
    MiriyamApp$Util.registerClick('print', function(e) {
      MiriyamApp$Worker.onPrint();
    });
  };
  MiriyamApp$WorkerEvents._registerSearch = function() {
    MiriyamApp$Util.registerClick('Search', function(e) {
      MiriyamApp$Search.go();
    });
  };
  MiriyamApp$WorkerEvents._registerLab = function() {
    MiriyamApp$Util.registerClick2([ 'btnClear3', 'btnClear4', 'btnClear5' ], function(e) {
      MiriyamApp$Worker.onClear();
    });
    MiriyamApp$Util.registerClick('btnGenPadyam', function(e) {
      MiriyamaApp$Labs$ChandamLab.writeAPadyam();
    });
    MiriyamApp$Util.registerClick('WhichG', function(e) {
      MiriyamApp$Worker.buildGana();
    });
    MiriyamApp$Util.registerClick('btnWVruttam', function(e) {
      MiriyamApp$Worker.buildMatraVruttam();
    });
    MiriyamApp$Util.registerClick('ReportPending', function(e) {
      MiriyamApp$Worker.pendingReport();
    });
    MiriyamApp$Util.registerClick('HowMany', function(e) {
      MiriyamApp$Worker.howMany();
    });
    MiriyamApp$Util.registerClick('YCheck', function(e) {
      MiriyamApp$Worker.onYatiCheck();
    });
    MiriyamApp$Util.registerClick('PCheck', function(e) {
      MiriyamApp$Worker.onPrasaCheck();
    });
  };
  MiriyamApp$WorkerEvents._registerDesigner = function() {
    MiriyamApp$Util.registerClick('create', function(e) {
      MiriyamApp$Designer.showDesigner();
    });
    MiriyamApp$Util.registerClick('hideDesigner', function(e) {
      MiriyamApp$Designer.hideDesigner2();
    });
    MiriyamApp$Util.registerChange('PadyamType', function(e) {
      MiriyamApp$Designer.onPadyamTypeChange();
    });
    MiriyamApp$Util.registerChange('GanaType', function(e) {
      MiriyamApp$Designer.onGanaChange();
    });
    MiriyamApp$Util.registerChange('hasSameRules', function(e) {
      MiriyamApp$Designer.onSameRulesChanged();
    });
    MiriyamApp$Util.registerChange('shareWithMe', function(e) {
      MiriyamApp$Designer.onShareWithMe();
    });
    MiriyamApp$Util.registerClick('Reset', function(e) {
      MiriyamApp$Worker.onClear2();
    });
    MiriyamApp$Util.registerClick('Share', function(e) {
      MiriyamApp$Designer.onShare();
    });
    MiriyamApp$Util.registerClick('btnCustomRules', function(e) {
      MiriyamApp$Designer.customRuleText();
    });
    MiriyamApp$Util.registerClick('btnCreate', function(e) {
      MiriyamApp$Designer.createRule();
    });
  };
  MiriyamApp$WorkerEvents._registerCore = function() {
    MiriyamApp$Util.registerClick('btnDetermine', function(e) {
      MiriyamApp$Worker.onDetermine();
    });
    MiriyamApp$Util.registerClick('btnScores', function(e) {
      MiriyamApp$Worker.onScores();
    });
    MiriyamApp$Util.registerClick('btnTry', function(e) {
      MiriyamApp$Worker.onTryMatch();
    });
    MiriyamApp$Util.registerClick('btnShowRules', function(e) {
      MiriyamApp$Worker.onShowRules();
    });
    MiriyamApp$Util.registerClick('btnSamples', function(e) {
      MiriyamApp$Worker.onShowSamples();
    });
    MiriyamApp$Util.registerClick('sort_a2z', function(e) {
      MiriyamApp$Worker.onA2ZSort();
    });
    MiriyamApp$Util.registerClick('sort_g', function(e) {
      MiriyamApp$Worker.onGroupSort();
    });
  };
  MiriyamApp$WorkerEvents._registerSettings = function() {
    MiriyamApp$Util.registerChange('btnYatiCheck', function(e) {
      MiriyamApp$Worker.onYatiCheckChange();
    });
  };
  MiriyamApp$WorkerEvents._registerMenuEvents = function() {
  };
  MiriyamApp$WorkerEvents._registerTools = function() {
    MiriyamApp$Util.registerClick('btnRandom', function(e) {
      MiriyamApp$Worker.onRandom();
    });
    MiriyamApp$Util.registerClick('btnClear', function(e) {
      MiriyamApp$Worker.onClear();
    });
  };
  var MiriyamApp$WorkerEvents$ = {

  };


  // MiriyamApp.CSWriter

  function MiriyamApp$CSWriter() {
  }
  MiriyamApp$CSWriter.codeIt = function(R) {
    var template = 'public class {0} :Rule \r\n{ \r\n\tpublic {0}()\r\n\t{ \r\n\t\tLines = {1};\r\n\t\tThreshold = {2};\r\n\r\n\t\tRuleType = {3};\r\n\t\tPadyamType = {4};\r\n\t\tPadyamSubType = PadyamSubType.RareVruttam;{5}\r\n\t\tYatiMode = {6};\r\n\r\n\t\tPrasa = {7};\r\n\t\tPrasaYati = {8};\r\n\t\tAnthyaPrasa={9};\r\n\t\tInfiniteLength = {16};\r\n\r\n\t\tRules = {10};\r\n\t\tYati = {11};\r\n\t\t\r\n\t\tIdentifier = {12};\r\n\t\tName = {13};\r\n\t\tShortName = {14};\r\n\t\t\r\n\t\tExamples = {15};\r\n\t}\r\n}';
    var C = new MiriyamApp$CSWriter();
    var identifier = C.RTS(R.get_name());
    var nm = ss.replaceString(R.get_name(), identifier, '').trim();
    var s = ss.replaceString(template, '{0}', identifier);
    s = ss.replaceString(s, '{1}', R.get_lines().toString());
    s = ss.replaceString(s, '{2}', MiriyamUtil.Helper.calcThreshold(R).toString());
    s = ss.replaceString(s, '{3}', C.csRuleType(R.get_ruleType()));
    s = ss.replaceString(s, '{4}', C._csPadyamType(R.get_padyamType()));
    s = ss.replaceString(s, '{5}', C._csPadyamSubType(R.get_padyamSubType()));
    s = ss.replaceString(s, '{6}', C._csYatiMode(R.get_yatiMode()));
    s = ss.replaceString(s, '{7}', C._csBool(R.get_prasa()));
    s = ss.replaceString(s, '{8}', C._csBool(R.get_prasaYati()));
    s = ss.replaceString(s, '{9}', C._csBool(R.get_anthyaPrasa()));
    s = ss.replaceString(s, '{10}', C._csRules(R.get_rules(), R.get_ruleType()));
    s = ss.replaceString(s, '{11}', C._cSyati(R.get_yati()));
    s = ss.replaceString(s, '{12}', C._csString(identifier));
    s = ss.replaceString(s, '{13}', C._csString(nm));
    s = ss.replaceString(s, '{14}', C._csString(nm));
    s = ss.replaceString(s, '{15}', C._cStringArray(R.get_examples()));
    s = ss.replaceString(s, '{16}', C._csBool(R.get_infiniteLength()));
    return s;
  };
  var MiriyamApp$CSWriter$ = {
    _csString: function(s) {
      return '"' + s + '"';
    },
    csRuleType: function(ruleType) {
      switch (ruleType) {
        case MiriyamUtil.RuleType.name:
          return 'RuleType.Name';
        case MiriyamUtil.RuleType.type:
          return 'RuleType.Type';
        case MiriyamUtil.RuleType.weight:
          return 'RuleType.Weight';
      }
      return '';
    },
    RTS: function(s) {
      if (s.indexOf(' ') >= 0) {
        return s.split(' ')[1];
      }
      return s;
    },
    _csPadyamType: function(padyamType) {
      switch (padyamType) {
        case MiriyamUtil.PadyamType.jati:
          return 'PadyamType.Jati';
        case MiriyamUtil.PadyamType.upaJati:
          return 'PadyamType.UpaJati';
        case MiriyamUtil.PadyamType.vruttam:
          return 'PadyamType.Vruttam';
      }
      return '';
    },
    _csPadyamSubType: function(padyamSubType) {
      return '';
    },
    _csYatiMode: function(yatiMode) {
      switch (yatiMode) {
        case MiriyamUtil.YatiMode.charPosition:
          return 'YatiMode.CharPosition';
        case MiriyamUtil.YatiMode.gPosition:
          return 'YatiMode.GPosition';
      }
      return '';
    },
    _csBool: function(p) {
      return (p) ? 'true' : 'false';
    },
    _csRules: function(p, rt) {
      switch (rt) {
        case MiriyamUtil.RuleType.name:
          return this._cStringArrayArray(p);
        case MiriyamUtil.RuleType.type:
          return this._csTypeArrayArray(p);
        case MiriyamUtil.RuleType.type2:
          return this._csType2ArrayArray(p);
        case MiriyamUtil.RuleType.weight:
          return this._csWeightArrayArray(p);
      }
      return '';
    },
    _csWeightArrayArray: function(p) {
      var s = 'new object[][]{\n';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var row = $enum1.current;
        s = s + 'new object[]{';
        var $enum2 = ss.enumerate(row);
        while ($enum2.moveNext()) {
          var c = $enum2.current;
          s = s + c.toString() + ',';
        }
        s = s + '},\n';
      }
      return s + '}';
    },
    _csTypeArrayArray: function(p) {
      var s = 'new object[][]{\n';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var row = $enum1.current;
        s = s + 'new object[]{';
        var $enum2 = ss.enumerate(row);
        while ($enum2.moveNext()) {
          var c = $enum2.current;
          s = s + this._getCategory(c) + ',';
        }
        s = s + '},\n';
      }
      return s + '}';
    },
    _csType2ArrayArray: function(p) {
      var s = 'new object[][]{\n';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var row = $enum1.current;
        s = s + 'new object[]{';
        var $enum2 = ss.enumerate(row);
        while ($enum2.moveNext()) {
          var c = $enum2.current;
          s = s + this._getCategory2(c) + ',';
        }
        s = s + '},\n';
      }
      return s + '}';
    },
    _getCategory: function(category) {
      switch (category) {
        case MiriyamUtil.Category.indra:
          return 'Category.Indra';
        case MiriyamUtil.Category.surya:
          return 'Category.Surya';
        case MiriyamUtil.Category.chandra:
          return 'Category.Chandra';
        case MiriyamUtil.Category.guruvu:
          return 'Category.Guruvu';
        case MiriyamUtil.Category.laghuvu:
          return 'Category.Laghuvu';
      }
      return '';
    },
    _getCategory2: function(category) {
      switch (category) {
        case MiriyamUtil.Category2.brahma:
          return 'Category.Brahma';
        case MiriyamUtil.Category2.vishnu:
          return 'Category.Vishnu';
        case MiriyamUtil.Category2.rudra:
          return 'Category2.Rudra';
        case MiriyamUtil.Category2.guruvu:
          return 'Category2.Guruvu';
        case MiriyamUtil.Category2.laghuvu:
          return 'Category2.Laghuvu';
      }
      return '';
    },
    _cStringArrayArray: function(p) {
      var s = 'new string[][]{';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var row = $enum1.current;
        s = s + 'new string[]{';
        var $enum2 = ss.enumerate(row);
        while ($enum2.moveNext()) {
          var c = $enum2.current;
          s = s + '"' + c + '",';
        }
        s = s + '},';
      }
      return s + '}';
    },
    _cSyati: function(p) {
      var s = 'new int[][]{';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var row = $enum1.current;
        s = s + 'new int[]{';
        var $enum2 = ss.enumerate(row);
        while ($enum2.moveNext()) {
          var c = $enum2.current;
          s = s + c.toString() + ',';
        }
        s = s + '},';
      }
      return s + '}';
    },
    _cStringArray: function(p) {
      var s = 'new string[]{';
      var $enum1 = ss.enumerate(p);
      while ($enum1.moveNext()) {
        var _p = $enum1.current;
        s = s + '"' + ss.replaceString(_p, '\n', '\\n') + '",';
      }
      return s + '}';
    }
  };


  // MiriyamApp.Designer

  function MiriyamApp$Designer() {
  }
  MiriyamApp$Designer.onGanaChange = function() {
    var v = MiriyamApp$Util.selectedValue('GanaType');
    MiriyamApp$Designer.createNewRules(v);
  };
  MiriyamApp$Designer.onShareWithMe = function() {
    var v = MiriyamApp$Util.isChecked('shareWithMe');
    document.getElementById('EmailId').style.display = (v) ? 'inline' : 'none';
  };
  MiriyamApp$Designer.init = function() {
    MiriyamApp$Designer._load();
  };
  MiriyamApp$Designer._load = function() {
    MiriyamApp$Designer._clear2();
    MiriyamApp$Designer._loadPadyamTypes();
    MiriyamApp$Designer.onPadyamTypeChange();
    MiriyamApp$Designer._loadLines();
    MiriyamApp$Designer.onSameRulesChanged();
    MiriyamApp$Designer.onShareWithMe();
  };
  MiriyamApp$Designer.createNewRules = function(v) {
    var Table = document.getElementById('Rules');
    Table.innerHTML = '';
    var Row = MiriyamApp$Designer._addEmpyRow(v, 1);
    Table.appendChild(Row);
    var Table2 = document.getElementById('Rows');
    if (Table2 != null) {
      var Ling = MiriyamApp$Designer._addNewRowLink();
      if (Ling != null) {
        Table2.appendChild(Ling);
      }
    }
  };
  MiriyamApp$Designer._addNewRowLink = function() {
    if (document.getElementById('new_a') != null) {
      return null;
    }
    var AddR = document.createElement('h5');
    AddR.setAttribute('href', '#');
    AddR.setAttribute('id', 'new_a');
    AddR.className = 'link';
    AddR.innerHTML = '\u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c28\u0c41 \u0c15\u0c32\u0c41\u0c2a\u0c41';
    try {
      AddR.addEventListener('click', function(e) {
        var Anchor = e.target;
        MiriyamApp$Designer._addRowHandler(Anchor);
      }, false);
    }
    catch ($e1) {
      AddR.attachEvent('onclick', (function() {
        var E3 = window.event.srcElement;
        MiriyamApp$Designer._addRowHandler(E3);
      }));
    }
    return AddR;
  };
  MiriyamApp$Designer._addRowHandler = function(Anchor) {
    var id = Anchor.getAttribute('id').toString();
    var Table = document.getElementById('Rules');
    Table.appendChild(MiriyamApp$Designer._addEmpyRow(MiriyamApp$Util.selectedValue('GanaType'), Table.children.length + 1));
  };
  MiriyamApp$Designer._addEmpyRow = function(v, row) {
    var Cell = MiriyamApp$Designer._getCellWithList(v, row, 1);
    var CellG = MiriyamApp$Designer._getCellWithGHandler(row);
    var CellY = MiriyamApp$Designer._getCellWithYatiHandler(row);
    var CellGR = MiriyamApp$Designer._getCellWithRemoveHandler(row);
    var Row = document.createElement('tr');
    Row.setAttribute('id', 'r' + row);
    var FirstCell = document.createElement('td');
    FirstCell.setAttribute('id', 'rh' + row);
    Row.appendChild(FirstCell);
    Row.appendChild(CellG);
    Row.appendChild(CellGR);
    Row.appendChild(CellY);
    Row.appendChild(Cell);
    return Row;
  };
  MiriyamApp$Designer._getCellWithRemoveHandler = function(row) {
    var AddG = document.createElement('h5');
    AddG.setAttribute('href', '#');
    AddG.setAttribute('id', 'r' + row + '_anchor_remove');
    AddG.className = 'link';
    AddG.innerHTML = '\u0c17\u0c23\u0c2e\u0c41\u0c28\u0c41 \u0c24\u0c4a\u0c32\u0c17\u0c3f\u0c02\u0c1a\u0c41';
    try {
      AddG.addEventListener('click', function(e) {
        var Anchor = e.target;
        MiriyamApp$Designer._removeGana(Anchor);
      }, false);
    }
    catch ($e1) {
      AddG.attachEvent('onclick', (function() {
        var Anchor = window.event.srcElement;
        MiriyamApp$Designer._removeGana(Anchor);
      }));
    }
    var CellG = document.createElement('td');
    CellG.appendChild(AddG);
    CellG.setAttribute('id', 'r' + row + '_c_remove_Gana');
    return CellG;
  };
  MiriyamApp$Designer._getCellWithYatiHandler = function(row) {
    var E = document.createElement('input');
    E.setAttribute('type', 'text');
    E.setAttribute('class', 'yIn');
    E.setAttribute('id', 'r' + row + 'y' + row);
    var Cell = document.createElement('td');
    Cell.setAttribute('id', 'td_ry' + row);
    Cell.appendChild(E);
    return Cell;
  };
  MiriyamApp$Designer._getCellWithGHandler = function(row) {
    var AddG = document.createElement('h5');
    AddG.setAttribute('href', '#');
    AddG.setAttribute('id', 'r' + row + '_g');
    AddG.className = 'link';
    AddG.innerHTML = '\u0c17\u0c23\u0c2e\u0c41\u0c28\u0c41 \u0c15\u0c32\u0c41\u0c2a\u0c41';
    try {
      AddG.addEventListener('click', function(e) {
        var Anchor = e.target;
        MiriyamApp$Designer._addNewGana(Anchor);
      }, false);
    }
    catch ($e1) {
      AddG.attachEvent('onclick', (function() {
        var Anchor = window.event.srcElement;
        MiriyamApp$Designer._addNewGana(Anchor);
      }));
    }
    var CellG = document.createElement('td');
    CellG.appendChild(AddG);
    CellG.setAttribute('id', 'r' + row + '_c_g');
    return CellG;
  };
  MiriyamApp$Designer._removeGana = function(Anchor) {
    var Cell = Anchor.parentNode;
    var Row = Cell.parentNode;
    var v = MiriyamApp$Util.selectedValue('GanaType');
    var id = Anchor.getAttribute('id').toString();
    var rowId = id.split('_')[0];
    if (ss.replaceString(rowId, 'r', '') === '1' && Row.children.length === 5) {
      return;
    }
    var l = Row.children.length - 5;
    if (!l) {
      Row.parentNode.removeChild(Row);
      return;
    }
    var Holder = document.getElementById('rh' + ss.replaceString(rowId, 'r', ''));
    Holder.innerHTML = l.toString() + ' \u0c17\u0c23\u0c2e\u0c41\u0c32\u0c41';
    var cellId = rowId + 'c' + (l + 1).toString();
    Row.removeChild(document.getElementById(cellId));
  };
  MiriyamApp$Designer._addNewGana = function(Anchor) {
    var Cell = Anchor.parentNode;
    var Row = Cell.parentNode;
    var Cells = Row.children.length;
    var v = MiriyamApp$Util.selectedValue('GanaType');
    var id = Anchor.getAttribute('id').toString();
    var rowId = ss.replaceString(id.split('_')[0], 'r', '');
    var Expand = document.getElementById('Expand');
    var ActualColSpan = parseInt(Expand.getAttribute('colspan').toString());
    if (ActualColSpan <= Cells - 5 + 1) {
      Expand.setAttribute('colspan', (ActualColSpan + 1));
    }
    var Holder = document.getElementById('rh' + rowId);
    Holder.innerHTML = (Cells - 3).toString() + ' \u0c17\u0c23\u0c2e\u0c41\u0c32\u0c41';
    var NewCell = MiriyamApp$Designer._getCellWithList(v, parseInt(rowId), Cells - 3);
    Row.appendChild(NewCell);
  };
  MiriyamApp$Designer._getCellWithList = function(v, rowid, cellid) {
    var id = 'r' + rowid + 'c' + cellid;
    var E = MiriyamApp$Designer._getList(v, id + '_select');
    var Cell = document.createElement('td');
    Cell.appendChild(E);
    Cell.setAttribute('id', id);
    Cell.appendChild(E);
    return Cell;
  };
  MiriyamApp$Designer._getList = function(v, id) {
    switch (v) {
      case 'Name':
        return MiriyamApp$Designer._getNamedList(id);
      case 'Type':
        return MiriyamApp$Designer._getTypeList(id);
      case 'Weight':
        return MiriyamApp$Designer._getWeightList(id);
    }
    return null;
  };
  MiriyamApp$Designer._loadLines = function() {
    var E = document.getElementById('Lines');
    for (var i = 1; i <= 8; i++) {
      var x = (i === 1) ? '\u0c12\u0c15 \u0c2a\u0c3e\u0c26\u0c02' : i.toString() + ' \u0c2a\u0c3e\u0c26\u0c3e\u0c32\u0c41';
      var Local = MiriyamApp$Util.addOptionItem(x, i.toString(), false);
      if (i === 4) {
        Local.setAttribute('selected', 'selected');
      }
      E.appendChild(Local);
    }
  };
  MiriyamApp$Designer._getWeightList = function(id) {
    var E = document.createElement('select');
    E.setAttribute('id', id);
    for (var i = 1; i <= 50; i++) {
      var Local = MiriyamApp$Util.addOptionItem(i.toString() + ((i === 1) ? ' \u0c2e\u0c3e\u0c24\u0c4d\u0c30' : ' \u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c32\u0c41'), i.toString(), false);
      E.appendChild(Local);
    }
    return E;
  };
  MiriyamApp$Designer._getTypeList = function(id) {
    var E = document.createElement('select');
    E.setAttribute('id', id);
    var Names = [ '\u0c07\u0c02\u0c26\u0c4d\u0c30', '\u0c38\u0c42\u0c30\u0c4d\u0c2f', '\u0c1a\u0c02\u0c26\u0c4d\u0c30', '\u0c17\u0c41\u0c30\u0c41\u0c35\u0c41', '\u0c32\u0c18\u0c41\u0c35\u0c41' ];
    var Values = [ 'Indra', 'Surya', 'Chandra', 'Guruvu', 'Laghuvu' ];
    for (var i = 0; i < Names.length; i++) {
      var name = Names[i];
      var Local = MiriyamApp$Util.addOptionItem(name, Values[i], false);
      E.appendChild(Local);
    }
    return E;
  };
  MiriyamApp$Designer._getNamedList = function(id) {
    var E = document.createElement('select');
    E.setAttribute('id', id);
    var Names = [ '\u0c2f(\u0c32-\u0c17-\u0c17)', '\u0c2e(\u0c17-\u0c17-\u0c17)', '\u0c24(\u0c17-\u0c17-\u0c32)', '\u0c30(\u0c17-\u0c32-\u0c17)', '\u0c1c(\u0c32-\u0c17-\u0c32)', '\u0c2d(\u0c17-\u0c32-\u0c32)', '\u0c28(\u0c32-\u0c32-\u0c32)', '\u0c38(\u0c32-\u0c32-\u0c17)', '\u0c17', '\u0c17\u0c3e(\u0c17-\u0c17)', '\u0c35(\u0c32-\u0c17)', '\u0c39(\u0c17-\u0c32)', '\u0c32\u0c32', '\u0c32' ];
    var Values = [ 'ya', 'ma', 'ta', 'ra', 'ja', 'bha', 'na', 'sa', 'ga', 'gaa', 'va', 'ha', 'lala', 'la' ];
    for (var i = 0; i < Names.length; i++) {
      var name = Names[i];
      var Local = MiriyamApp$Util.addOptionItem(name, Values[i], false);
      E.appendChild(Local);
    }
    return E;
  };
  MiriyamApp$Designer.customRuleText = function() {
    var R = MiriyamApp$Designer._buildRule();
    MiriyamApp$Worker.onShowRules2(R);
  };
  MiriyamApp$Designer.createRule = function() {
    var R = MiriyamApp$Designer._buildRule();
    MiriyamApp$Worker.onTryMatch2(R);
  };
  MiriyamApp$Designer._getRuleObject = function(ruleType, val) {
    switch (ruleType) {
      case MiriyamUtil.RuleType.name:
        switch (val) {
          case 'ya':
            return '\u0c2f';
          case 'ma':
            return '\u0c2e';
          case 'ta':
            return '\u0c24';
          case 'ra':
            return '\u0c30';
          case 'ja':
            return '\u0c1c';
          case 'bha':
            return '\u0c2d';
          case 'na':
            return '\u0c28';
          case 'sa':
            return '\u0c38';
          case 'ga':
            return '\u0c17';
          case 'gaa':
            return '\u0c17\u0c3e';
          case 'ha':
            return '\u0c39';
          case 'va':
            return '\u0c35';
          case 'la':
            return '\u0c32';
          case 'lala':
            return '\u0c32\u0c32';
        }
        break;
      case MiriyamUtil.RuleType.type:
        switch (val) {
          case 'Indra':
            return MiriyamUtil.Category.indra;
          case 'Surya':
            return MiriyamUtil.Category.surya;
          case 'Chandra':
            return MiriyamUtil.Category.chandra;
          case 'Guruvu':
            return MiriyamUtil.Category.guruvu;
          case 'Laghuvu':
            return MiriyamUtil.Category.laghuvu;
        }
        break;
      case MiriyamUtil.RuleType.weight:
        return parseInt(val);
    }
    return null;
  };
  MiriyamApp$Designer._getRuleType = function(v) {
    switch (v) {
      case 'Name':
        return MiriyamUtil.RuleType.name;
      case 'Type':
        return MiriyamUtil.RuleType.type;
      case 'Weight':
        return MiriyamUtil.RuleType.weight;
    }
    return MiriyamUtil.RuleType.custom;
  };
  MiriyamApp$Designer._getPadyamType = function(v) {
    switch (v) {
      case 'Jati':
        return MiriyamUtil.PadyamType.jati;
      case 'UpaJati':
        return MiriyamUtil.PadyamType.upaJati;
      case 'Vruttam':
        return MiriyamUtil.PadyamType.vruttam;
    }
    return MiriyamUtil.PadyamType.vruttam;
  };
  MiriyamApp$Designer.showDesigner = function() {
    MiriyamApp$Designer._clear2();
    document.getElementById('buttons').style.display = 'none';
    document.getElementById('sortTools').style.display = 'none';
    document.getElementById('DesignerContainer').style.display = 'inline';
    document.getElementById('hideDesigner').style.display = 'inline';
    document.getElementById('create').style.display = 'none';
    MiriyamApp$Metrics.export2(7, MiriyamApp$StopWatch.get_lastTicks());
  };
  MiriyamApp$Designer.hideDesigner = function() {
    if (!MiriyamApp$Util._isAvailable('DesignerContainer')) {
      return;
    }
    MiriyamApp$Designer._clear2();
    MiriyamApp$Util._setDisplay('buttons');
    MiriyamApp$Util._setDisplay('sortTools');
    MiriyamApp$Util._noDisplay('DesignerContainer');
    MiriyamApp$Util._noDisplay('hideDesigner');
    MiriyamApp$Util._setDisplay('create');
  };
  MiriyamApp$Designer._clear2 = function() {
    MiriyamApp$Util.setValue('Name', '');
    MiriyamApp$Util.setValue('txt', '');
    MiriyamApp$Util.setValue('EmailId', '');
    MiriyamApp$Util.setChecked('hasPrasa');
    MiriyamApp$Util.setUnChecked('hasPrasaYati');
    MiriyamApp$Util.setUnChecked('hasAnthyaPrasa');
    MiriyamApp$Util.setUnChecked('shareWithMe');
  };
  MiriyamApp$Designer._loadPadyamTypes = function() {
    var E = window.document.getElementById('PadyamType');
    if (E == null) {
      return;
    }
    E.innerHTML = '';
    var E1 = MiriyamApp$Util.addOptionItem('\u0c1c\u0c3e\u0c24\u0c3f', 'Jati', false);
    var E2 = MiriyamApp$Util.addOptionItem('\u0c09\u0c2a\u0c1c\u0c3e\u0c24\u0c3f', 'UpaJati', false);
    var E3 = MiriyamApp$Util.addOptionItem('\u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02', 'Vruttam', false);
    E3.setAttribute('selected', 'selected');
    E.appendChild(E1);
    E.appendChild(E2);
    E.appendChild(E3);
  };
  MiriyamApp$Designer.onSameRulesChanged = function() {
    var SameRules = MiriyamApp$Util.isChecked('hasSameRules');
    var Parent = document.getElementById('Lines').parentNode;
    Parent.style.visibility = (SameRules) ? 'visible' : 'hidden';
    document.getElementById('new_a').style.display = (SameRules) ? 'none' : 'inline';
  };
  MiriyamApp$Designer.onPadyamTypeChange = function() {
    var E = window.document.getElementById('GanaType');
    if (E == null) {
      return;
    }
    E.innerHTML = '';
    var v = MiriyamApp$Util.selectedValue('PadyamType');
    switch (v) {
      case 'Jati':
        var E1 = MiriyamApp$Util.addOptionItem('\u0c30\u0c40\u0c24\u0c3f', 'Type', false);
        var E2 = MiriyamApp$Util.addOptionItem('\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e', 'Weight', false);
        E.appendChild(E1);
        E.appendChild(E2);
        break;
      case 'UpaJati':
        var E1 = MiriyamApp$Util.addOptionItem('\u0c30\u0c40\u0c24\u0c3f', 'Type', false);
        E.appendChild(E1);
        break;
      case 'Vruttam':
        var E1 = MiriyamApp$Util.addOptionItem('\u0c2a\u0c47\u0c30\u0c41', 'Name', false);
        E.appendChild(E1);
        break;
    }
    MiriyamApp$Designer.onGanaChange();
  };
  MiriyamApp$Designer.onShare = function() {
    var email = MiriyamApp$Util.getValue('EmailId');
    var isValid = true;
    if (email.trim().length > 0) {
      isValid = new RegExp('\\S+@\\S+\\.\\S+').test(email);
    }
    if (!isValid) {
      alert("\u0c2e\u0c40\u0c30\u0c41 \u0c07\u0c1a\u0c4d\u0c1a\u0c3f\u0c28 \u0c08-\u0c2e\u0c46\u0c2f\u0c41\u0c32\u0c41 \u0c1a\u0c3f\u0c30\u0c41\u0c28\u0c3e\u0c2e\u0c3e  \u0c38\u0c30\u0c3f \u0c05\u0c2f\u0c3f\u0c28\u0c26\u0c3f \u0c15\u0c3e\u0c26\u0c41 . \u0c08 \u0c2a\u0c26\u0c4d\u0c2f\u0c32\u0c15\u0c4d\u0c37\u0c23\u0c3e\u0c32\u0c41 \u0c15\u0c47\u0c35\u0c32\u0c02 '\u0c1b\u0c02\u0c26\u0c02\u00a9' \u0c1f\u0c40\u0c02 \u0c24\u0c4b \u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c2e\u0c47 \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c2c\u0c21\u0c24\u0c3e\u0c2f\u0c3f.\nThe Eamil Address you have mentioned is not a valid, Hence these details will only be shared with Chandam\u00a9 Team only. ");
    }
    var R = MiriyamApp$Designer._buildRule();
    MiriyamApp$Designer._share(R, email);
  };
  MiriyamApp$Designer._buildRule = function() {
    var nm = MiriyamApp$Util.getValue('Name').trim();
    nm = (!nm) ? '[\u0c2a\u0c47\u0c30\u0c41 \u0c32\u0c47\u0c28\u0c3f]' : nm;
    var R = new MiriyamUtil.Rule();
    R.set_name(nm);
    R.set_prasa(MiriyamApp$Util.isChecked('hasPrasa'));
    R.set_prasaYati(MiriyamApp$Util.isChecked('hasPrasaYati'));
    R.set_anthyaPrasa(MiriyamApp$Util.isChecked('hasAnthyaPrasa'));
    R.set_padyamType(MiriyamApp$Designer._getPadyamType(MiriyamApp$Util.selectedValue('PadyamType')));
    R.set_ruleType(MiriyamApp$Designer._getRuleType(MiriyamApp$Util.selectedValue('GanaType')));
    R.set_infiniteLength(MiriyamApp$Util.isChecked('isDaMdakamu'));
    var Table = document.getElementById('Rules');
    var Rules = [];
    for (var i = 0; i < Table.children.length; i++) {
      var A = [];
      var E = Table.children[i];
      var cnt = 0;
      for (var j = 0; j < E.children.length; j++) {
        var E2 = document.getElementById('r' + (i + 1) + 'c' + (j + 1) + '_select');
        if (E2 != null) {
          A[cnt++] = MiriyamApp$Designer._getRuleObject(R.get_ruleType(), MiriyamApp$Util.selectedValue(E2.id));
        }
      }
      Rules[i] = A;
    }
    R.set_rules(Rules);
    R.set_yatiMode((R.get_padyamType() === MiriyamUtil.PadyamType.vruttam) ? MiriyamUtil.YatiMode.charPosition : MiriyamUtil.YatiMode.gPosition);
    var hasSameRules = MiriyamApp$Util.isChecked('hasSameRules');
    R.set_lines((hasSameRules) ? parseInt(MiriyamApp$Util.selectedValue('Lines')) : Rules.length);
    R.set_yati([]);
    var Yati = [];
    for (var i = 0; i < Table.children.length; i++) {
      var A = [];
      var cnt = 0;
      var E = Table.children[i];
      var id = 'r' + (i + 1) + 'y' + (i + 1);
      var E2 = document.getElementById(id);
      if (E2 != null) {
        var y = MiriyamApp$Util.getValue(id);
        var $enum1 = ss.enumerate(y.split(','));
        while ($enum1.moveNext()) {
          var _y = $enum1.current;
          if (!_y) {
            continue;
          }
          try {
            var h = parseInt(_y);
            A[cnt++] = h;
          }
          catch ($e2) {
          }
        }
        Yati[i] = A;
      }
    }
    if (!!Yati.length) {
      R.set_yati(Yati);
    }
    R.set_examples([]);
    var ex = MiriyamApp$Util.getValue('txt');
    if (!!ex.length) {
      R.set_examples([ ex ]);
    }
    return R;
  };
  MiriyamApp$Designer._share = function(R, cc) {
    var r = Chandam$Core$Business.rules3(R);
    var c = MiriyamApp$CSWriter.codeIt(R);
    r = MiriyamApp$Designer._fixRequest(r);
    c = MiriyamApp$Designer._fixRequest(c);
    var content = 't=rc&e=' + cc + '&n=' + R.get_name() + '&r=' + r + '&c=' + c;
    Ajax.makeCall('/Log.ashx', (function(err, data, xhr) {
      MiriyamUtil.Debug2.write('Status: ' + xhr.status.toString() + '<br />' + 'Error: ' + err + '<br/>' + 'Response: ' + data);
      if (xhr.status.toString() === '200') {
        alert("\u0c2e\u0c40\u0c30\u0c41 \u0c2a\u0c26\u0c4d\u0c2f \u0c32\u0c15\u0c4d\u0c37\u0c23\u0c3e\u0c32\u0c41 '\u0c1b\u0c02\u0c26\u0c02 \u00a9' \u0c24\u0c4b \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c41\u0c28\u0c4d\u0c28\u0c02\u0c26\u0c41\u0c15\u0c41 \u0c1a\u0c3e\u0c32\u0c3e \u0c38\u0c02\u0c24\u0c4b\u0c37\u0c02.\nThanks for your contribution.! Details are Shared with  'Chandam\u00a9' team.");
      }
    }), 'POST', content);
  };
  MiriyamApp$Designer._fixRequest = function(r) {
    return ss.replaceString(ss.replaceString(r, '<', '_l_'), '>', '_r_');
  };
  MiriyamApp$Designer.hideDesigner2 = function() {
    document.getElementById('result').innerHTML = '';
    MiriyamApp$Designer.hideDesigner();
  };


  // MiriyamApp.MenuItems

  function MiriyamApp$MenuItems() {
  }
  MiriyamApp$MenuItems._makeStaticCall = function(url) {
    if (MiriyamApp$MenuItems._reqInProgress) {
      return;
    }
    MiriyamApp$MenuItems._reqInProgress = true;
    Ajax.makeCall(url + '?r=' + new Date().toUTCString(), (function(err, data, xhr) {
      window.document.getElementById('result').innerHTML = data;
    }), 'GET');
    MiriyamApp$MenuItems._reqInProgress = false;
  };
  MiriyamApp$MenuItems.onDedicatedTo = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/dedicated.html');
  };
  MiriyamApp$MenuItems.onFAQ = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/faq.html');
  };
  MiriyamApp$MenuItems.onLimitations = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/Limitations.html');
  };
  MiriyamApp$MenuItems.onCaseStudy = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/CaseStudy.html');
  };
  MiriyamApp$MenuItems.onReleaseNotes = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/Release.html');
  };
  MiriyamApp$MenuItems.onAbout = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/About.html');
  };
  MiriyamApp$MenuItems.onShowCredits = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/Credits.html');
  };
  MiriyamApp$MenuItems.onContact = function() {
    MiriyamApp$Worker.hideToolbar();
    MiriyamApp$MenuItems._makeStaticCall('Menu/Contact.html');
  };
  MiriyamApp$MenuItems._onShowLab = function() {
    window.document.getElementById('result').innerHTML = '';
    MiriyamApp$Worker.hideToolbar();
    MiriyamaApp$Labs$ChandamLab.init();
  };
  MiriyamApp$MenuItems.onCheatSheet = function() {
    MiriyamApp$Worker.hideToolbar();
    window.document.getElementById('result').innerHTML = "<b style='color:blue;'>\u0c1b\u0c02\u0c26\u0c4b\u0c30\u0c3e\u0c1c\u0c02</b> <b style='color:red;'>\u0c2e\u0c41\u0c26\u0c4d\u0c30\u0c23 \u0c1c\u0c30\u0c41\u0c17\u0c41\u0c24\u0c4b\u0c02\u0c26\u0c3f \u0c15\u0c4a\u0c28\u0c4d\u0c28\u0c3f \u0c38\u0c46\u0c15\u0c28\u0c4d\u0c32\u0c41 \u0c13\u0c2a\u0c3f\u0c15 \u0c2a\u0c1f\u0c4d\u0c1f\u0c02\u0c21\u0c3f.</b>";
    setTimeout(MiriyamApp$MenuItems._printCheatSheet, 200);
  };
  MiriyamApp$MenuItems.onBook = function() {
    MiriyamApp$Worker.hideToolbar();
    window.document.getElementById('result').innerHTML = "<b style='color:blue;'> \u0c1b\u0c02\u0c26\u0c4b\u0c30\u0c24\u0c4d\u0c28\u0c3e\u0c35\u0c33\u0c3f</b> <b style='color:red;'>\u0c2a\u0c41\u0c38\u0c4d\u0c24\u0c15\u0c02 \u0c2e\u0c41\u0c26\u0c4d\u0c30\u0c23 \u0c1c\u0c30\u0c41\u0c17\u0c41\u0c24\u0c4b\u0c02\u0c26\u0c3f \u0c15\u0c4a\u0c28\u0c4d\u0c28\u0c3f \u0c38\u0c46\u0c15\u0c28\u0c4d\u0c32\u0c41 \u0c13\u0c2a\u0c3f\u0c15 \u0c2a\u0c1f\u0c4d\u0c1f\u0c02\u0c21\u0c3f.</b>";
    setTimeout(MiriyamApp$MenuItems._printBook, 200);
  };
  MiriyamApp$MenuItems._printBook = function() {
    MiriyamApp$StopWatch.start();
    var s = Chandam$Core$Business.buildBook();
    window.document.getElementById('result').innerHTML = "<span class='err'>\u0c1b\u0c02\u0c26\u0c4b\u0c30\u0c24\u0c4d\u0c28\u0c3e\u0c35\u0c33\u0c3f</span> <div>" + s + '</div>';
    MiriyamApp$StopWatch.showTicks(true);
    MiriyamApp$Metrics.export2(10, MiriyamApp$StopWatch.get_lastTicks());
  };
  MiriyamApp$MenuItems._printCheatSheet = function() {
    MiriyamApp$StopWatch.start();
    var s = Chandam$Core$Business.buildCheatSheet();
    window.document.getElementById('result').innerHTML = "<span class='err'>\u0c1b\u0c02\u0c26\u0c4b\u0c30\u0c3e\u0c1c\u0c02</span>" + s;
    var s1=new SortableTable(document.getElementById('CheatSheet'),['Number','String', 'Number', 'String','Number','Number', 'String','String','String', 'String','String']);s1.sort(0,false);
    MiriyamApp$Metrics.export2(9, MiriyamApp$StopWatch.get_lastTicks());
    MiriyamApp$StopWatch.showTicks(true);
  };


  // MiriyamApp.Metrics

  function MiriyamApp$Metrics() {
  }
  MiriyamApp$Metrics.export2 = function(metric, time, identifier, percentage) {
    var content = 'm=' + MiriyamApp$Metrics._toString2(metric) + ((time == null) ? '' : '&t=' + time) + ((identifier == null) ? '' : '&i=' + identifier) + ((percentage == null) ? '' : '&s=' + percentage);
    Ajax.makeCall('/Metrics.ashx', (function(err, data, xhr) {
      MiriyamApp$Metrics.showStats();
    }), 'POST', content);
  };
  MiriyamApp$Metrics.showStats = function() {
    Ajax.makeCall('/Stats.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
      window.document.getElementById('totCalcs').innerHTML = data;
    }), 'GET');
  };
  MiriyamApp$Metrics._toString2 = function(metric) {
    switch (metric) {
      case 0:
        return 'Random';
      case 1:
        return 'Scores';
      case 2:
        return 'Determine';
      case 3:
        return 'TryMatch';
      case 4:
        return 'TryMatch2';
      case 5:
        return 'Rules';
      case 6:
        return 'Rules2';
      case 7:
        return 'ShowDesigner';
      case 8:
        return 'Samples';
      case 10:
        return 'Book';
      case 9:
        return 'CheatSheet';
      case 11:
        return 'Load';
      default:
        return 'Unknown';
    }
  };


  // MiriyamApp.OverlayDialog

  function MiriyamApp$OverlayDialog(title, content) {
    this._showClose = false;
    this._title = title;
    this._content = content;
    this.okText = '\u0c38\u0c30\u0c47';
    this.cancelText = '\u0c35\u0c26\u0c4d\u0c26\u0c41';
    this._id = 'OLay';
    this._showClose = true;
  }
  var MiriyamApp$OverlayDialog$ = {
    get_showClose: function() {
      return this._showClose;
    },
    set_showClose: function(value) {
      this._showClose = value;
      return value;
    },
    get_footerText: function() {
      return this._footerText;
    },
    set_footerText: function(value) {
      this._footerText = value;
      return value;
    },
    get_id: function() {
      return this._id;
    },
    set_id: function(value) {
      this._id = value;
      return value;
    },
    get_innerElement: function() {
      return this._inner;
    },
    set_innerElement: function(value) {
      this._inner = value;
      return value;
    },
    show: function() {
      var $this = this;

      var oFContent = document.createElement('div');
      oFContent.className = 'oFContent';
      if (!!this.get_content()) {
        oFContent.innerHTML = this._content;
      }
      if (this._inner != null) {
        oFContent.appendChild(document.createElement('br'));
        oFContent.appendChild(this._inner);
      }
      var oFTitle = null;
      if (!!this.get_title()) {
        oFTitle = document.createElement('h1');
        oFTitle.className = 'oFTitle';
        oFTitle.innerHTML = this.get_title();
      }
      var btnClose2 = null;
      if (this.get_showClose()) {
        btnClose2 = document.createElement('input');
        btnClose2.className = 'actions';
        btnClose2.setAttribute('type', 'button');
        btnClose2.setAttribute('value', this.cancelText);
        MiriyamApp$Util.registerEvent2(btnClose2, 'click', function(e) {
          $this.close();
        });
      }
      var btnOK = document.createElement('input');
      btnOK.className = 'actions';
      btnOK.setAttribute('type', 'button');
      btnOK.setAttribute('value', this.okText);
      MiriyamApp$Util.registerEvent2(btnOK, 'click', ss.bind('onOK', this));
      var oFButtonHolder = document.createElement('div');
      oFButtonHolder.className = 'oFButtonHolder';
      if (this.get_footerText() != null) {
        var p = document.createElement('span');
        p.innerHTML = this.get_footerText();
        oFButtonHolder.appendChild(p);
      }
      oFButtonHolder.appendChild(btnOK);
      if (btnClose2 != null) {
        oFButtonHolder.appendChild(btnClose2);
      }
      var oFCloseButtonHolder = null;
      if (this.get_showClose()) {
        var btnClose = document.createElement('h1');
        btnClose.innerHTML = 'X';
        btnClose.title = this.cancelText;
        btnClose.id = this._id + 'Close';
        MiriyamApp$Util.registerEvent2(btnClose, 'click', function(e) {
          $this.close();
        });
        oFCloseButtonHolder = document.createElement('div');
        oFCloseButtonHolder.className = 'oFCloseButtonHolder';
        oFCloseButtonHolder.appendChild(btnClose);
      }
      var oBackGround = document.getElementById(this.get__oBackGroundId());
      if (oBackGround == null) {
        oBackGround = document.createElement('div');
        oBackGround.className = 'oBackGround';
        oBackGround.id = this.get__oBackGroundId();
        document.body.appendChild(oBackGround);
      }
      oBackGround.style.visibility = (oBackGround.style.visibility === 'visible') ? 'hidden' : 'visible';
      var oForeGround = document.getElementById(this.get__oForeGroundId());
      if (oForeGround == null) {
        oForeGround = document.createElement('div');
        oForeGround.className = 'oForeGround';
        oForeGround.id = this.get__oForeGroundId();
        document.body.appendChild(oForeGround);
      }
      oForeGround.style.visibility = (oForeGround.style.visibility === 'visible') ? 'hidden' : 'visible';
      if (oFTitle != null) {
        oForeGround.appendChild(oFTitle);
      }
      if (oFCloseButtonHolder != null) {
        oForeGround.appendChild(oFCloseButtonHolder);
      }
      oForeGround.appendChild(oFContent);
      oForeGround.appendChild(oFButtonHolder);
      if (this.postLoadCallback != null) {
        this.postLoadCallback();
      }
    },
    get__oBackGroundId: function() {
      return this._id + '_oBackGround';
    },
    get__oForeGroundId: function() {
      return this._id + '_oForeGround';
    },
    get_title: function() {
      return (this._title == null) ? '' : this._title;
    },
    set_title: function(value) {
      this._title = value;
      return value;
    },
    get_content: function() {
      return (this._content == null) ? '' : this._content;
    },
    set_content: function(value) {
      this._content = value;
      return value;
    },
    onOK: function(e) {
      var res = (this.preOKCallBack == null) ? true : this.preOKCallBack();
      if (res) {
        this.close();
        if (this.postOKCallBack != null) {
          this.postOKCallBack();
        }
      }
    },
    close: function() {
      var oForeGround = document.getElementById(this.get__oForeGroundId());
      oForeGround.style.visibility = (oForeGround.style.visibility === 'visible') ? 'hidden' : 'visible';
      oForeGround.innerHTML = '';
      var oBackGround = document.getElementById(this.get__oBackGroundId());
      oBackGround.style.visibility = (oBackGround.style.visibility === 'visible') ? 'hidden' : 'visible';
      oBackGround.innerHTML = '';
    }
  };


  // MiriyamApp.StandardExport

  function MiriyamApp$StandardExport() {
  }
  MiriyamApp$StandardExport.printElemet = function(ElementId) {
    var Elem = document.getElementById(ElementId);
    if (Elem == null) {
      return;
    }
    var Content = Elem.innerHTML;
    if (!Content.trim()) {
      alert('Nothing to print');
      return;
    }
    var styleSheets = [ 'CSS/Print.css' ];
    var title = 'Chandam-\u0c1b\u0c02\u0c26\u0c02 \u00a9';
    var Header = '';
    var Footer = "<div class='power'>\u0c1b\u0c02\u0c26\u0c02<sup class='copyright'>\u00a9</sup> \u0c24\u0c4b \u0c2a\u0c26\u0c4d\u0c2f \u0c38\u0c3e\u0c39\u0c3f\u0c24\u0c4d\u0c2f\u0c02 \u0c2e\u0c30\u0c3f\u0c02\u0c24 \u0c30\u0c38\u0c2e\u0c2f\u0c02..!!</div>";
    MiriyamApp$Export.print(styleSheets, title, Header, Content, Footer);
  };
  var MiriyamApp$StandardExport$ = {

  };


  // MiriyamApp.Export

  function MiriyamApp$Export() {
  }
  MiriyamApp$Export.print = function(styleSheets, title, Header, content, Footer) {
    var styleSheet = MiriyamApp$Export._buildStyleSheet(styleSheets);
    var html = '<html><head><title>{0}</title>{1}</head><body>{2}{3}{4}</body></html>';
    html = ss.replaceString(ss.replaceString(ss.replaceString(ss.replaceString(ss.replaceString(html, '{0}', title), '{1}', styleSheet), '{2}', Header), '{3}', content), '{4}', Footer);
    MiriyamApp$Export._printHTML(html);
  };
  MiriyamApp$Export._printHTML = function(html) {
    var wp = window.open('', 'PrintPage');
    wp.document.open();
    wp.document.write(html);
    wp.document.close();
    wp.document.body.focus();
    wp.print();
  };
  MiriyamApp$Export._buildStyleSheet = function(styleSheets) {
    var s = '';
    var template = '<link href="{0}" type="text/css" rel="Stylesheet" />';
    var $enum1 = ss.enumerate(styleSheets);
    while ($enum1.moveNext()) {
      var stylesheet = $enum1.current;
      s = s + ss.replaceString(template, '{0}', stylesheet);
    }
    return s;
  };
  var MiriyamApp$Export$ = {

  };


  // MiriyamApp.StopWatch

  function MiriyamApp$StopWatch() {
  }
  MiriyamApp$StopWatch.start = function() {
    MiriyamApp$StopWatch._Start = new Date();
  };
  MiriyamApp$StopWatch.showTicks = function(reset) {
    if (MiriyamApp$StopWatch._Start == null) {
      return;
    }
    var sec = (new Date() - MiriyamApp$StopWatch._Start);
    MiriyamApp$StopWatch._lastTicks = sec;
    if (reset) {
      MiriyamApp$StopWatch._Start = null;
    }
    var res = (sec < 1000) ? sec + ' \u0c2e\u0c3f\u0c32\u0c4d\u0c32\u0c40 \u0c38\u0c46\u0c15\u0c28\u0c4d\u0c32\u0c41' : (sec / (1000) + ' \u0c38\u0c46\u0c15\u0c28\u0c4d\u0c32\u0c41');
    window.document.getElementById('timeTaken').innerHTML = res;
  };
  MiriyamApp$StopWatch.get_lastTicks = function() {
    return MiriyamApp$StopWatch._lastTicks;
  };
  var MiriyamApp$StopWatch$ = {

  };


  // MiriyamApp.Events

  function MiriyamApp$Events() {
  }


  // MiriyamApp.Util

  function MiriyamApp$Util() {
  }
  MiriyamApp$Util.isChecked = function(Id) {
    if (document.getElementById(Id) == null) {
      return false;
    }
    return document.getElementById(Id).checked;
  };
  MiriyamApp$Util.getValue = function(Id) {
    if (document.getElementById(Id) == null) {
      return '';
    }
    return document.getElementById(Id).value.toString();
  };
  MiriyamApp$Util.setChecked = function(Id) {
    if (document.getElementById(Id) == null) {
      return;
    }
    document.getElementById ( Id).checked=true;
  };
  MiriyamApp$Util.setValue = function(Id, D) {
    if (document.getElementById(Id) == null) {
      return;
    }
    document.getElementById ( Id).value=D;
  };
  MiriyamApp$Util.addOptionItem = function(Name, Value, isGroup) {
    var O = window.document.createElement((isGroup) ? 'optgroup' : 'option');
    if (!isGroup) {
      O.innerHTML = Name;
    }
    O.setAttribute((isGroup) ? 'label' : 'value', Value);
    return O;
  };
  MiriyamApp$Util.setOption = function(id, value) {
    var E = document.getElementById(id);
    for (var i = 0; i < E.children.length; i++) {
      var OG = E.children[i];
      if (OG.tagName.toLowerCase() === 'optgroup') {
        for (var j = 0; j < OG.children.length; j++) {
          var O = OG.children[j];
          if (O.value === value) {
            O.setAttribute('selected', 'selected');
            O.selected=true;
          }
          else if (O.attributes.getNamedItem('selected') != null && O.attributes.getNamedItem('selected').value === 'selected') {
            O.removeAttribute('selected');
            O.selected=false;;
          }
        }
      }
      else {
        if (OG.value === value) {
          OG.setAttribute('selected', 'selected');
          OG.selected=true;;
        }
        else if (OG.attributes.getNamedItem('selected') != null && OG.attributes.getNamedItem('selected').value === 'selected') {
          OG.removeAttribute('selected');
          OG.selected=false;;
        }
      }
    }
  };
  MiriyamApp$Util.selectedValue = function(id) {
    var E = window.document.getElementById(id);
    if (E.selectedIndex==-1) {
      return null;
    }
    var v = E.options[E.selectedIndex].value;
    return v;
  };
  MiriyamApp$Util.setUnChecked = function(Id) {
    if (document.getElementById(Id) == null) {
      return;
    }
    document.getElementById ( Id).checked=false;
  };
  MiriyamApp$Util.registerEvent = function(E, eventName, elementEventListener) {
    MiriyamApp$Util.registerEvent2(document.getElementById(E), eventName, elementEventListener);
  };
  MiriyamApp$Util.registerClick = function(E, elementEventListener) {
    MiriyamApp$Util.registerEvent2(document.getElementById(E), 'click', elementEventListener);
  };
  MiriyamApp$Util.registerClick2 = function(Elemes, elementEventListener) {
    var $enum1 = ss.enumerate(Elemes);
    while ($enum1.moveNext()) {
      var E = $enum1.current;
      MiriyamApp$Util.registerEvent2(document.getElementById(E), 'click', elementEventListener);
    }
  };
  MiriyamApp$Util.findByClass = function(elem, className) {
    var coll = elem.children;
    for (var i = 0; i < coll.length; i++) {
      var e2 = coll[i];
      if (e2.className === className) {
        return e2;
      }
      var e3 = MiriyamApp$Util.findByClass(e2, className);
      if (e3 != null) {
        return e3;
      }
    }
    return null;
  };
  MiriyamApp$Util.registerClick3 = function(Elem, elementEventListener) {
    MiriyamApp$Util.registerEvent2(Elem, 'click', elementEventListener);
  };
  MiriyamApp$Util.registerChange = function(E, elementEventListener) {
    MiriyamApp$Util.registerEvent2(document.getElementById(E), 'change', elementEventListener);
  };
  MiriyamApp$Util.registerEvent2 = function(E, eventName, elementEventListener) {
    if (E == null) {
      return;
    }
    try {
      if (E.addEventListener!=null) {
        E.addEventListener(eventName, elementEventListener, false);
      }
      else {
        E.attachEvent('oneventName', elementEventListener);
      }
    }
    catch ($e1) {
      E.attachEvent('oneventName', elementEventListener);
    }
  };
  MiriyamApp$Util._prevent = function(e) {
    e.preventDefault();
    e.stopPropagation();
    e.stopImmediatePropagation();
  };
  MiriyamApp$Util.findQuery = function(key) {
    try {
      var Q = MiriyamApp$Util.buildQuery();
      return Q[key];
    }
    catch ($e1) {
      return '';
    }
  };
  MiriyamApp$Util.buildQuery = function() {
    var queryString = window.location.search.substring(1);
    var D = queryString.split('&');
    var Dict = {};
    var $enum1 = ss.enumerate(D);
    while ($enum1.moveNext()) {
      var d = $enum1.current;
      var lr = d.split('=');
      if (!!lr[0]) {
        Dict[lr[0]] = lr[1];
      }
    }
    return Dict;
  };
  MiriyamApp$Util._isEmailValid = function(input) {
    return new RegExp(MiriyamApp$Patterns.email).test(input);
  };
  MiriyamApp$Util._setVisible = function(Id) {
    var Elem = window.document.getElementById(Id);
    if (Elem == null) {
      return;
    }
    Elem.style.visibility = 'visible';
  };
  MiriyamApp$Util._setDisplay = function(Id) {
    var Elem = window.document.getElementById(Id);
    if (Elem == null) {
      return;
    }
    Elem.style.display = 'block';
  };
  MiriyamApp$Util._noDisplay = function(Id) {
    var Elem = window.document.getElementById(Id);
    if (Elem == null) {
      return;
    }
    Elem.style.display = 'none';
  };
  MiriyamApp$Util._isAvailable = function(Id) {
    return window.document.getElementById(Id) != null;
  };
  MiriyamApp$Util._setClass = function(Id, className) {
    if (MiriyamApp$Util._isAvailable(Id)) {
      document.getElementById(Id).className = className;
    }
  };
  MiriyamApp$Util._hide = function(Id) {
    if (MiriyamApp$Util._isAvailable(Id)) {
      window.document.getElementById('tc').style.visibility = 'hidden';
    }
  };
  MiriyamApp$Util.scrollTo = function(Id) {
    if (MiriyamApp$Util._isAvailable(Id)) {
      try {
        window.document.getElementById(Id).scrollIntoView();
      }
      catch ($e1) {
      }
    }
  };
  MiriyamApp$Util.noTags = function(s) {
    return ss.replaceString(ss.replaceString(ss.replaceString(ss.replaceString(ss.replaceString(ss.replaceString(s.toLowerCase(), '<u>', ''), '</u>', ''), '<b>', ''), '<i>', ''), '</b>', ''), '</i>', '');
  };
  MiriyamApp$Util.setFocus = function(Id) {
    if (document.getElementById(Id) == null) {
      return;
    }
    else {
      document.getElementById(Id).focus();
    }
  };
  MiriyamApp$Util.setCheckedValue = function(Id, value) {
    if (value) {
      MiriyamApp$Util.setChecked(Id);
    }
    else {
      MiriyamApp$Util.setUnChecked(Id);
    }
  };


  // MiriyamApp.Patterns

  function MiriyamApp$Patterns() {
  }
  var MiriyamApp$Patterns$ = {

  };


  // MiriyamApp.Worker

  function MiriyamApp$Worker() {
  }
  MiriyamApp$Worker.onPrint = function() {
    MiriyamApp$StandardExport.printElemet('result');
  };
  MiriyamApp$Worker.onUnSubscribe = function() {
    MiriyamApp$Worker._onSubscribe2(false);
  };
  MiriyamApp$Worker.onFeedback = function() {
    var OD = new MiriyamApp$OverlayDialog();
    OD.preOKCallBack = function() {
      if (!MiriyamApp$Util._isEmailValid(MiriyamApp$Util.getValue('fEmail'))) {
        alert('Please provide a valid Email Address.');
        document.getElementById('fEmail').focus();
        return false;
      }
      var content = 'n=' + MiriyamApp$Util.getValue('fName') + '&e=' + MiriyamApp$Util.getValue('fEmail') + '&m=' + MiriyamApp$Util.getValue('fMessage');
      Ajax.makeCall('/Feedback.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
        MiriyamApp$Worker.showNotification("<span class='gName' style='color:green !important;'>\u2714</span> Feedback Sent Successfully..!!");
      }), 'POST', content);
      return true;
    };
    OD.set_title('Feedback');
    OD.set_content('');
    var Table = document.createElement('table');
    var Tbody = document.createElement('tbody');
    var TR0 = MiriyamApp$Worker._addTextRow('Name', 'fName');
    var TR1 = MiriyamApp$Worker._addEmailRow('Email', 'fEmail');
    var TR2 = MiriyamApp$Worker._addLabelRow('Message');
    var TR3 = MiriyamApp$Worker._addTextAreaRow('fMessage', 3);
    Tbody.appendChild(TR0);
    Tbody.appendChild(TR1);
    Tbody.appendChild(TR2);
    Tbody.appendChild(TR3);
    Table.appendChild(Tbody);
    Table.style.width = '100%';
    OD.set_innerElement(Table);
    OD.show();
  };
  MiriyamApp$Worker._addLabelRow = function(LabelText) {
    var Row = document.createElement('tr');
    var Label = document.createElement('td');
    Label.setAttribute('colspan', 2);
    Label.innerHTML = LabelText;
    Row.appendChild(Label);
    return Row;
  };
  MiriyamApp$Worker._addTextAreaRow = function(Id, rows) {
    var E = document.createElement('textarea');
    E.id = Id;
    E.style.width = '80%';
    E.setAttribute('rows', rows);
    var Control = document.createElement('td');
    Control.setAttribute('colspan', 2);
    Control.appendChild(E);
    var Row = document.createElement('tr');
    Row.appendChild(Control);
    return Row;
  };
  MiriyamApp$Worker._addTextRow = function(LabelText, Id) {
    return MiriyamApp$Worker._addControlRow(LabelText, Id, 'text');
  };
  MiriyamApp$Worker._addControlRow = function(LabelText, Id, type) {
    var Row = document.createElement('tr');
    var Label = document.createElement('td');
    Label.innerHTML = LabelText;
    var E = document.createElement('input');
    E.setAttribute('type', type);
    E.id = Id;
    E.className = 'text';
    E.setAttribute('placeholder', LabelText);
    var Control = document.createElement('td');
    Control.appendChild(E);
    Row.appendChild(Label);
    Row.appendChild(Control);
    return Row;
  };
  MiriyamApp$Worker._addEmailRow = function(LabelText, Id) {
    return MiriyamApp$Worker._addControlRow(LabelText, Id, 'email');
  };
  MiriyamApp$Worker.showBulkCompute = function() {
    var OD = new MiriyamApp$OverlayDialog();
    OD.set_title('Bulk Compute');
    OD.set_content('\u0c2a\u0c4d\u0c30\u0c38\u0c4d\u0c24\u0c41\u0c24\u0c3e\u0c28\u0c3f\u0c15\u0c3f public \u0c21\u0c4a\u0c2e\u0c48\u0c28\u0c4d \u0c32\u0c4b \u0c05\u0c02\u0c26\u0c41\u0c2c\u0c3e\u0c1f\u0c41\u0c32\u0c4b \u0c32\u0c47\u0c26\u0c41.\u0c05\u0c2d\u0c4d\u0c2f\u0c30\u0c4d\u0c27\u0c28 \u0c2e\u0c47\u0c30\u0c15\u0c41 \u0c28\u0c3e\u0c15\u0c41 \u0c2a\u0c02\u0c2a\u0c3f\u0c24\u0c47 \u0c26\u0c4b\u0c37\u0c3e\u0c32 \u0c32\u0c3f\u0c38\u0c4d\u0c1f\u0c41 \u0c2a\u0c02\u0c2a\u0c17\u0c32\u0c28\u0c41. \u0c26\u0c40\u0c28\u0c3f\u0c28\u0c3f \u0c2e\u0c40\u0c30\u0c47 run \u0c1a\u0c47\u0c38\u0c41\u0c15\u0c4a\u0c28\u0c47\u0c32\u0c3e \u0c12\u0c15 application \u0c24\u0c2f\u0c3e\u0c30\u0c41 \u0c1a\u0c47\u0c2f\u0c2c\u0c21\u0c41\u0c24\u0c4b\u0c02\u0c26\u0c3f. \u0c35\u0c47\u0c1a\u0c3f\u0c1a\u0c42\u0c21\u0c17\u0c32\u0c30\u0c41.\u0c15\u0c3e\u0c35\u0c32\u0c38\u0c3f\u0c28\u0c35\u0c3e\u0c30\u0c41 \u0c28\u0c3e\u0c15\u0c41 \u0c08-\u0c2e\u0c46\u0c2f\u0c3f\u0c32\u0c41 \u0c1a\u0c47\u0c2f\u0c17\u0c32\u0c30\u0c41.\u0c24\u0c2f\u0c3e\u0c30\u0c41 \u0c05\u0c2f\u0c3f\u0c28 \u0c24\u0c30\u0c41\u0c35\u0c3e\u0c24 \u0c2e\u0c40\u0c15\u0c41 \u0c24\u0c46\u0c32\u0c3f\u0c2f\u0c2c\u0c30\u0c4d\u0c1a\u0c17\u0c32\u0c28\u0c41.');
    OD.show();
  };
  MiriyamApp$Worker._onSubscribe2 = function(allow) {
    var OD = new MiriyamApp$OverlayDialog();
    OD.set_title((allow) ? 'Subscribe' : 'Unsubscribe');
    OD.set_content('');
    OD.postLoadCallback = function() {
      document.getElementById('txtEmail').focus();
    };
    OD.preOKCallBack = function() {
      if (!MiriyamApp$Util._isEmailValid(MiriyamApp$Util.getValue('txtEmail'))) {
        alert('Please provide a valid Email Address.');
        document.getElementById('txtEmail').focus();
        return false;
      }
      var content = 'g=' + ((allow) ? '1' : '0') + '&e=' + MiriyamApp$Util.getValue('txtEmail');
      Ajax.makeCall('/Subscribe.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
        MiriyamApp$Worker.showNotification((allow) ? "<span class='gName' style='color:green !important;'>\u2714</span> Subscribed Successfully..!!" : "<span class='gName'  style='color:green !important;'>\u2718</span> Unsubscribed Successfully..!!</span>");
      }), 'POST', content);
      return true;
    };
    var Div = document.createElement('div');
    var Span = document.createElement('div');
    Span.innerHTML = 'Email:&nbsp;&nbsp;';
    var E = document.createElement('input');
    E.setAttribute('type', 'email');
    E.id = 'txtEmail';
    E.className = 'text';
    E.setAttribute('placeholder', 'Ex:m.dileep@gmail.com');
    Div.appendChild(Span);
    Div.appendChild(E);
    OD.set_innerElement(Div);
    OD.show();
  };
  MiriyamApp$Worker.hideNotification = function() {
    var Notification = document.getElementById('notification');
    Notification.style.visibility = 'hidden';
  };
  MiriyamApp$Worker.showNotification = function(message) {
    var Notification = document.getElementById('notification');
    Notification.innerHTML = message;
    Notification.style.visibility = 'visible';
    setTimeout(function() {
      MiriyamApp$Worker.hideNotification();
    }, 30000);
  };
  MiriyamApp$Worker.onSubscribe = function() {
    MiriyamApp$Worker._onSubscribe2(true);
  };
  MiriyamApp$Worker.onPermLink = function() {
    if (!MiriyamApp$Util.getValue('txt').length) {
      return;
    }
    var content = 'd=' + MiriyamApp$Util.getValue('txt');
    Ajax.makeCall('/Link.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
      var OD = new MiriyamApp$OverlayDialog();
      OD.postLoadCallback = function() {
        MiriyamApp$Util.setValue('txtPermLink', 'http://chandam.apphb.com/?p=' + data);
        MiriyamApp$Util.registerClick('txtPermLink', function(e) {
          document.getElementById('txtPermLink').focus();
          document.getElementById('txtPermLink').select();
        });
        document.getElementById('txtPermLink').click();
      };
      OD.set_title('\u0c36\u0c3e\u0c36\u0c4d\u0c35\u0c24\u0c2e\u0c48\u0c28 \u0c32\u0c3f\u0c02\u0c15\u0c41..');
      OD.set_content(ss.replaceString(MiriyamApp$Util.getValue('txt'), '\n', '<br/>'));
      var E = document.createElement('textarea');
      E.setAttribute('readonly', '1');
      E.setAttribute('rows', '1');
      E.style.overflow = 'hidden';
      E.style.width = '80%';
      E.id = 'txtPermLink';
      E.className = 'text';
      var Span = document.createElement('span');
      Span.innerHTML = '\u0c2a\u0c48 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c0e\u0c2a\u0c4d\u0c2a\u0c41\u0c21\u0c48\u0c28\u0c3e \u0c08 \u0c32\u0c3f\u0c02\u0c15\u0c41\u0c28\u0c41 \u0c09\u0c2a\u0c2f\u0c4b\u0c17\u0c3f\u0c02\u0c1a\u0c3f \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c35\u0c1a\u0c4d\u0c1a\u0c41.';
      var Div = document.createElement('div');
      Div.appendChild(document.createElement('hr'));
      Div.appendChild(E);
      Div.appendChild(document.createElement('br'));
      Div.appendChild(Span);
      OD.set_innerElement(Div);
      OD.show();
    }), 'POST', content, false);
  };
  MiriyamApp$Worker.onFBShare = function() {
    var OD = new MiriyamApp$OverlayDialog();
    OD.preOKCallBack = function() {
      var content = 'd=' + MiriyamApp$Util.getValue('txt');
      Ajax.makeCall('/Link.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
        var FP = new MiriyamApp$Social$Facebook$FeedParams();
        FP.name = '\u0c1b\u0c02\u0c26\u0c02 \u00a9-\u0c24\u0c46\u0c32\u0c41\u0c17\u0c41 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c15\u0c41 \u0c2a\u0c42\u0c30\u0c4d\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c2f\u0c3f \u0c38\u0c3e\u0c2b\u0c4d\u0c1f\u0c4d\u200c\u0c35\u0c47\u0c30\u0c4d';
        FP.caption = '\u0c1b\u0c02\u0c26\u0c02 \u00a9 \u0c24\u0c4b \u0c2a\u0c26\u0c4d\u0c2f \u0c38\u0c3e\u0c39\u0c3f\u0c24\u0c4d\u0c2f\u0c02 \u0c2e\u0c30\u0c3f\u0c02\u0c24 \u0c30\u0c38\u0c2e\u0c2f\u0c02..!!';
        FP.description = '\u0c17\u0c23\u0c35\u0c3f\u0c2d\u0c1c\u0c28, \u0c2f\u0c24\u0c3f \u0c2e\u0c30\u0c3f\u0c2f\u0c42 \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c32\u0c28\u0c41 \u0c15\u0c42\u0c21\u0c3e \u0c38\u0c30\u0c3f\u0c1a\u0c42\u0c21\u0c17\u0c32\u0c26\u0c41,\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c28\u0c41 \u0c35\u0c3f\u0c21\u0c2e\u0c30\u0c4d\u0c1a\u0c3f \u0c1a\u0c46\u0c2a\u0c4d\u0c2a\u0c17\u0c32\u0c26\u0c41. 343+ \u0c24\u0c46\u0c32\u0c41\u0c17\u0c41 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c28\u0c41 \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c17\u0c32\u0c26\u0c41 . 550 \u0c15\u0c3f \u0c2a\u0c48\u0c17\u0c3e \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41.\u0c38\u0c30\u0c3f\u0c15\u0c4a\u0c24\u0c4d\u0c24 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c28\u0c41 \u0c38\u0c43\u0c37\u0c4d\u0c1f\u0c3f\u0c02\u0c1a\u0c3f \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c17\u0c32\u0c3f\u0c17\u0c47 \u0c38\u0c4c\u0c15\u0c30\u0c4d\u0c2f\u0c02 \u0c07\u0c35\u0c28\u0c4d\u0c28\u0c40 \u0c1b\u0c02\u0c26\u0c02 \u00a9 \u0c32\u0c4b..';
        FP.picture = 'http://chandam.apphb.com/img/fbPreView.png?r' + new Date().toUTCString();
        FP.link = 'http://chandam.apphb.com/?p=' + data;
        FP.message = MiriyamApp$Util.getValue('txt');
        MiriyamApp$Social$Facebook$FBUtil.post(FP);
      }), 'POST', content, false);
      return true;
    };
    OD.set_title("\u0c2e\u0c40 <span class='gName'>FaceBook</span>  \u0c38\u0c4d\u0c28\u0c47\u0c39\u0c3f\u0c24\u0c41\u0c32\u0c24\u0c4b  \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c02\u0c21\u0c3f...");
    OD.set_content(ss.replaceString(MiriyamApp$Util.getValue('txt'), '\n', '<br/>'));
    OD.show();
  };
  MiriyamApp$Worker.onTwitterPost = function() {
    var OD = new MiriyamApp$OverlayDialog();
    OD.preOKCallBack = function() {
      var content = 'd=' + MiriyamApp$Util.getValue('txt');
      Ajax.makeCall('/Link.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
        var Link = 'http://chandam.apphb.com/?p=' + data;
        var txt = MiriyamApp$Util.getValue('txt');
        var brand = '\n\u0c1b\u0c02\u0c26\u0c02 \u00a9- ';
        var more = ' ...';
        var b = txt.substring(0, 140 - (more.length + brand.length)) + more + brand + Link;
        window.open('https://twitter.com/intent/tweet?text=' + encodeURI(b));
      }), 'POST', content, false);
      return true;
    };
    OD.set_title("\u0c2e\u0c40 <span class='gName'>Twitter</span>  \u0c38\u0c4d\u0c28\u0c47\u0c39\u0c3f\u0c24\u0c41\u0c32\u0c24\u0c4b  \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c02\u0c21\u0c3f...");
    OD.set_content(ss.replaceString(MiriyamApp$Util.getValue('txt'), '\n', '<br/>'));
    OD.show();
  };
  MiriyamApp$Worker.onRandom = function() {
    setTimeout(function() {
      MiriyamApp$Util.setValue('txt', Chandam$Core$Business.getRandomPoem());
      MiriyamApp$Metrics.export2(0, 0);
    }, 0);
  };
  MiriyamApp$Worker.onClear = function() {
    setTimeout(function() {
      MiriyamApp$Util.setValue('txt', '');
      window.document.getElementById('result').innerHTML = '';
      MiriyamApp$Worker._clearLabs();
    }, 0);
  };
  MiriyamApp$Worker._clearLabs = function() {
    MiriyamApp$Util.setValue('Group1', '');
    MiriyamApp$Util.setValue('Group2', '');
  };
  MiriyamApp$Worker.onYatiCheckChange = function() {
    var f = MiriyamApp$Util.isChecked('btnYatiCheck');
    window.document.getElementById('lblAllowSantiPrasa').style.display = (f) ? 'inline' : 'none';
    window.document.getElementById('allowSantiPrasa').style.display = (f) ? 'inline' : 'none';
  };
  MiriyamApp$Worker.onLoadRare = function() {
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      MiriyamApp$Worker.setList(true, true);
      MiriyamApp$StopWatch.showTicks(true);
    }, 0);
  };
  MiriyamApp$Worker.onScores = function() {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>Determining Scores..</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var Options = MiriyamApp$Worker._settings();
      var s = Chandam$Core$Business.scores(MiriyamApp$Util.getValue('txt'), Options);
      window.document.getElementById('result').innerHTML = s;
      var s1=new SortableTable(document.getElementById('scores'),['Number','String','String', 'Number', 'Number', 'Number']);s1.sort(3,true);;
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(1, MiriyamApp$StopWatch.get_lastTicks());
    }, 0);
  };
  MiriyamApp$Worker.onDetermine = function() {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>Detecting Best Match..</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var Options = MiriyamApp$Worker._settings();
      var Pr = Chandam$Core$Business.determine(MiriyamApp$Util.getValue('txt'), Options);
      var s = Chandam$Core$Business.buildResult2(Pr);
      window.document.getElementById('result').innerHTML = s;
      for (var i = 1; i <= 5; i++) {
        var E = document.getElementById('candiate_' + i);
        if (E == null) {
          continue;
        }
        try {
          E.addEventListener('click', function(e) {
            var E3 = e.target;
            MiriyamApp$Worker._setClosedResult(E3);
          }, false);
        }
        catch ($e1) {
          E.attachEvent('onclick', (function() {
            var E3 = window.event.srcElement;
            MiriyamApp$Worker._setClosedResult(E3);
          }));
        }
      }
      if (Pr != null && Pr.get_matchResult() != null && Pr.get_rule() != null) {
        MiriyamApp$Util.setOption('list', Pr.get_rule().get_identifier());
      }
      var identifier = '';
      var score = '';
      if (Pr != null) {
        identifier = Pr.get_rule().get_identifier();
        score = Pr.get_matchResult().get_percentage().toString();
      }
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(2, MiriyamApp$StopWatch.get_lastTicks(), identifier, score);
    }, 0);
  };
  MiriyamApp$Worker._setClosedResult = function(E3) {
    var att = null;
    if (E3.tagName.toLowerCase() === 'b') {
      E3 = E3.parentNode;
    }
    att = E3.attributes.getNamedItem('data');
    if (att == null) {
      return;
    }
    MiriyamApp$Util.setOption('list', att.value);
  };
  MiriyamApp$Worker.onTryMatch = function() {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>Matching..</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var v = MiriyamApp$Util.selectedValue('list');
      var Options = MiriyamApp$Worker._settings();
      var s = Chandam$Core$Business.tryMatch(MiriyamApp$Util.getValue('txt'), v, Options);
      window.document.getElementById('result').innerHTML = s;
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(3, MiriyamApp$StopWatch.get_lastTicks(), v);
    }, 0);
  };
  MiriyamApp$Worker._settings = function() {
    var Options = new MiriyamLib2.MatchOptions();
    Options.set_matchYati(MiriyamApp$Util.isChecked('btnYatiCheck'));
    Options.set_matchPrasa(MiriyamApp$Util.isChecked('btnYatiCheck'));
    Options.set_allowSantiPrasa(MiriyamApp$Util.isChecked('allowSantiPrasa'));
    Options.set_quickMatch(MiriyamApp$Util.isChecked('quickMatch'));
    Options.set_experimenatalSandhi(MiriyamApp$Util.isChecked('experimentalYati'));
    Options.set_language(Chandam$Core$Context.get_language());
    MiriyamApp$Worker._saveOptions(Options);
    return Options;
  };
  MiriyamApp$Worker._setOptions = function(Options) {
    try {
      MiriyamApp$Util.setCheckedValue('btnYatiCheck', Options.get_matchYati());
      MiriyamApp$Util.setCheckedValue('btnYatiCheck', Options.get_matchPrasa());
      MiriyamApp$Util.setCheckedValue('allowSantiPrasa', Options.get_allowSantiPrasa());
      MiriyamApp$Util.setCheckedValue('quickMatch', Options.get_quickMatch());
      MiriyamApp$Util.setCheckedValue('experimentalYati', Options.get_experimenatalSandhi());
    }
    catch ($e1) {
    }
  };
  MiriyamApp$Worker._saveOptions = function(Options) {
    try {
      var days = 30;
      MiriyamApp$CookieUtil.setCookie('y', (Options.get_matchYati()) ? '1' : '0', days);
      MiriyamApp$CookieUtil.setCookie('p', (Options.get_matchPrasa()) ? '1' : '0', days);
      MiriyamApp$CookieUtil.setCookie('sp', (Options.get_allowSantiPrasa()) ? '1' : '0', days);
      MiriyamApp$CookieUtil.setCookie('qm', (Options.get_quickMatch()) ? '1' : '0', days);
      MiriyamApp$CookieUtil.setCookie('es', (Options.get_experimenatalSandhi()) ? '1' : '0', days);
    }
    catch ($e1) {
    }
  };
  MiriyamApp$Worker._redOptions = function() {
    try {
      var Options = new MiriyamLib2.MatchOptions();
      Options.set_allowSantiPrasa((MiriyamApp$CookieUtil.getCookie('sp') === '1') ? true : false);
      Options.set_experimenatalSandhi((MiriyamApp$CookieUtil.getCookie('es') === '1') ? true : false);
      Options.set_matchYati(true);
      Options.set_matchPrasa(true);
      Options.set_quickMatch(true);
      return Options;
    }
    catch ($e1) {
    }
    return null;
  };
  MiriyamApp$Worker.onTryMatch2 = function(R) {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>Matching..</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var Options = MiriyamApp$Worker._settings();
      var s = Chandam$Core$Business.tryMatch2(MiriyamApp$Util.getValue('txt'), R, Options);
      window.document.getElementById('result').innerHTML = s;
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(4, MiriyamApp$StopWatch.get_lastTicks(), s);
    }, 0);
  };
  MiriyamApp$Worker.onShowRules = function() {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>About to Show Rules...</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var E = window.document.getElementById('list');
      var v = E.options[E.selectedIndex].value;
      var s = Chandam$Core$Business.rules(v);
      window.document.getElementById('result').innerHTML = s;
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(5, MiriyamApp$StopWatch.get_lastTicks(), v);
    }, 0);
  };
  MiriyamApp$Worker.onShowRules2 = function(R) {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>About to Show Rules...</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var s = Chandam$Core$Business.rules2(R, false);
      window.document.getElementById('result').innerHTML = s;
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(6, MiriyamApp$StopWatch.get_lastTicks(), s);
    }, 0);
  };
  MiriyamApp$Worker.onShowSamples = function() {
    window.document.getElementById('result').innerHTML = "<b style='color:red;'>About to Show Examples...</b>";
    setTimeout(function() {
      MiriyamApp$StopWatch.start();
      var E = window.document.getElementById('list');
      var v = E.options[E.selectedIndex].value;
      var s = Chandam$Core$Business.samples(v);
      window.document.getElementById('result').innerHTML = s;
      var ListItems = window.document.getElementsByTagName('li');
      for (var i = 0; i < ListItems.length; i++) {
        var E2 = ListItems[i];
        if (E2.parentNode.className === 'poems') {
          try {
            E2.addEventListener('click', function(e) {
              MiriyamApp$Worker._setSample(e.target);
            }, false);
          }
          catch ($e1) {
            E2.attachEvent('onclick', (function() {
              MiriyamApp$Worker._setSample(window.event.srcElement);
            }));
          }
        }
      }
      MiriyamApp$Util.scrollTo('main');
      MiriyamApp$StopWatch.showTicks(true);
      MiriyamApp$Metrics.export2(8, MiriyamApp$StopWatch.get_lastTicks(), v);
    }, 0);
  };
  MiriyamApp$Worker._setSample = function(E3) {
    if (E3.tagName.toUpperCase() === 'I') {
      E3 = E3.parentNode;
    }
    var txt = E3.innerHTML;
    txt = MiriyamApp$Util.noTags(txt);
    if (txt.indexOf('~') > 0) {
      txt = txt.substr(0, txt.indexOf('~'));
    }
    MiriyamApp$Worker._setText('txt', txt);
  };
  MiriyamApp$Worker.hideToolbar = function() {
    MiriyamApp$Util._hide('tc');
  };
  MiriyamApp$Worker.showToolBar = function() {
    MiriyamApp$Util._setVisible('tc');
  };
  MiriyamApp$Worker.ready = function() {
  };
  MiriyamApp$Worker.init = function() {
    MiriyamApp$StopWatch.start();
    if (MiriyamApp$Util._isAvailable('bannerWrapper')) {
      MiriyamApp$Worker._prepareDebugger();
      if (MiriyamApp$Util._isAvailable('ChandamContainer')) {
        MiriyamApp$Worker._setupChandam();
      }
      if (MiriyamApp$Util._isAvailable('LabsPage')) {
        MiriyamApp$MenuItems._onShowLab();
      }
      if (MiriyamApp$Util._isAvailable('SearchPage')) {
        MiriyamApp$Search.init();
      }
    }
    MiriyamApp$Worker._incoming();
    MiriyamApp$Worker._showUI();
    MiriyamApp$StopWatch.showTicks(true);
    MiriyamApp$Metrics.export2(11, MiriyamApp$StopWatch.get_lastTicks());
    MiriyamApp$Metrics.showStats();
  };
  MiriyamApp$Worker._setupChandam = function() {
    MiriyamApp$Social$Facebook$FBUtil.init();
    MiriyamApp$Worker.loadRules();
    MiriyamApp$Worker._loadSamples();
    MiriyamApp$Worker._loadRandom();
    MiriyamApp$Worker._initDesigner();
    MiriyamApp$Worker._initList();
    MiriyamApp$Worker.showToolBar();
    MiriyamApp$Worker._initNotification();
    MiriyamApp$Worker._initRandom();
    MiriyamApp$Worker._restoreOptions();
    MiriyamApp$Worker._manageNotification();
  };
  MiriyamApp$Worker._initDesigner = function() {
    MiriyamApp$Designer.init();
    MiriyamApp$Designer.hideDesigner();
  };
  MiriyamApp$Worker._loadRandom = function() {
    Chandam$Core$Business.initRandomPoems();
  };
  MiriyamApp$Worker.onAppeal = function() {
    MiriyamApp$Worker._makeNotice('/menu/notice_req.htm', 'nw2', '\u0c28\u0c3f\u0c35\u0c47\u0c26\u0c28', 0, 1, true);
  };
  MiriyamApp$Worker._manageNotification = function() {
    try {
    }
    catch ($e1) {
    }
  };
  MiriyamApp$Worker._makeNotice = function(url, key, title, delay, days, always) {
    if (!always) {
      var flg = (MiriyamApp$CookieUtil.getCookie(key) === '1') ? true : false;
      if (flg) {
        return;
      }
    }
    setTimeout(function() {
      Ajax.makeCall(url, (function(err, data, xhr) {
        if (ss.emptyString(data)) {
          return;
        }
        MiriyamApp$CookieUtil.setCookie(key, '1', days);
        var OD = new MiriyamApp$OverlayDialog(title, data);
        OD.set_id(key);
        OD.show();
      }), 'GET');
    }, delay * 1000);
  };
  MiriyamApp$Worker._restoreOptions = function() {
    var Options = MiriyamApp$Worker._redOptions();
    if (Options != null) {
      MiriyamApp$Worker._setOptions(Options);
    }
  };
  MiriyamApp$Worker._initList = function() {
    var a2z = MiriyamApp$CookieUtil.getCookie('a2z') === '1';
    if (a2z) {
      MiriyamApp$Worker.onA2ZSort();
    }
    else {
      MiriyamApp$Worker.onGroupSort();
    }
    MiriyamApp$Util.setOption('list', 'kandam');
  };
  MiriyamApp$Worker._prepareDebugger = function() {
    if (window.location.href.indexOf('localhost') > 0) {
      window.document.getElementById('debug').style.display = 'inline';
    }
  };
  MiriyamApp$Worker._initNotification = function() {
    MiriyamApp$Worker.showNotification("\u0c0f\u0c26\u0c48\u0c28\u0c3e \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c15\u0c4d\u0c30\u0c3f\u0c02\u0c26\u0c3f <label class='gName'>\u21e9</label> \u0c2c\u0c3e\u0c15\u0c4d\u0c38\u0c41\u0c32\u0c4b \u0c35\u0c4d\u0c30\u0c3e\u0c38\u0c3f <label class='gName'>\u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</label> \u0c05\u0c28\u0c4d\u0c28 \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f. \u0c32\u0c47\u0c26\u0c3e  <img src='css/Dice64.png'  alt='Dice' title='\u0c2f\u0c3e\u0c26\u0c43\u0c1a\u0c4d\u0c1a\u0c3f\u0c15 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f' /> \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c3f \u0c12\u0c15 \u0c2f\u0c3e\u0c26\u0c43\u0c1a\u0c4d\u0c1a\u0c3f\u0c15 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c2a\u0c4a\u0c02\u0c26\u0c02\u0c21\u0c3f.");
    MiriyamApp$Util._setDisplay('notification2');
  };
  MiriyamApp$Worker._showUI = function() {
  };
  MiriyamApp$Worker._incoming = function() {
    var Q = MiriyamApp$Util.buildQuery();
    if (Q == null || !ss.keyCount(Q)) {
      MiriyamApp$Worker._setCurrent('btnAbout');
      return;
    }
    switch (ss.keys(Q)[0]) {
      case 'p':
        var p = MiriyamApp$Util.findQuery('p');
        MiriyamApp$Worker._handlePermLinks(p);
        MiriyamApp$Worker._setChandam();
        break;
      case 'about':
        MiriyamApp$Worker._setCurrent('btnAbout');
        break;
      case 'credits':
        MiriyamApp$Worker._setCurrent('btnCredits');
        break;
      case 'dedicated':
        MiriyamApp$Worker._setCurrent('btnDedicatedTo');
        break;
      case 'cheatSheet':
        MiriyamApp$Worker._setCurrent('learn');
        break;
      case 'book':
        MiriyamApp$Worker._setCurrent('book');
        break;
      case 'chandassu':
        MiriyamApp$Worker._setCurrent('chandassu');
        break;
      case 'chandam':
        MiriyamApp$Worker._setChandam();
        break;
      default:
        break;
    }
  };
  MiriyamApp$Worker._setChandam = function() {
    var identifier = MiriyamApp$Util.findQuery('chandam');
    if (identifier != null) {
      MiriyamApp$Util.setOption('list', identifier);
    }
    MiriyamApp$Worker._setCurrent('logoH1');
  };
  MiriyamApp$Worker.onA2ZSort = function() {
    MiriyamApp$Worker._setList2(false);
  };
  MiriyamApp$Worker.onGroupSort = function() {
    MiriyamApp$Worker._setList2(true);
  };
  MiriyamApp$Worker._setList2 = function(grouped) {
    MiriyamApp$Util._setClass('sort_a2z', (grouped) ? 'sub' : 'sub2');
    MiriyamApp$Util._setClass('sort_g', (grouped) ? 'sub2' : 'sub');
    var curr = MiriyamApp$Util.selectedValue('list');
    MiriyamApp$Worker.setList(true, grouped);
    if (curr != null) {
      MiriyamApp$Util.setOption('list', curr);
    }
    MiriyamApp$CookieUtil.setCookie('a2z', (grouped) ? '0' : '1', 30);
  };
  MiriyamApp$Worker._setCurrent = function(Id) {
    MiriyamApp$Util._setClass(Id, 'current-page-item');
  };
  MiriyamApp$Worker._handlePermLinks = function(p) {
    if (ss.emptyString(p)) {
      return;
    }
    var content = 'p=' + p;
    Ajax.makeCall('/GLink.ashx?r=' + new Date().toUTCString(), (function(err, data, xhr) {
      if (ss.emptyString(data)) {
        return;
      }
      MiriyamApp$Util.setValue('txt', data);
    }), 'POST', content);
  };
  MiriyamApp$Worker._initRandom = function() {
    var count = Chandam$Core$Business.get_randomPoemsCount().toString();
    document.getElementById('RandomItems').innerHTML = count;
    document.getElementById('btnRandom').title = count + ' \u0c15\u0c41 \u0c2a\u0c48\u0c17\u0c3e \u0c09\u0c28\u0c4d\u0c28 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c32 \u0c28\u0c41\u0c02\u0c21\u0c3f \u0c12\u0c15 \u0c2f\u0c3e\u0c26\u0c43\u0c1a\u0c4d\u0c1a\u0c3f\u0c15 \u0c2a\u0c26\u0c4d\u0c2f\u0c02';
  };
  MiriyamApp$Worker.setList = function(includeRare, grouped) {
    if (grouped) {
      MiriyamApp$LoadRules2.setGroupedList(includeRare);
    }
    else {
      MiriyamApp$LoadRules2.setSortedList(includeRare);
    }
  };
  MiriyamApp$Worker.showLogo = function() {
    window.document.getElementById('result').innerHTML = '';
    MiriyamApp$Worker.showToolBar();
    MiriyamApp$Worker._hideLabs();
  };
  MiriyamApp$Worker._hideLabs = function() {
    var LabsPage = window.document.getElementById('LabsPage');
    LabsPage.style.display = 'none';
  };
  MiriyamApp$Worker.onClear2 = function() {
    MiriyamApp$Worker.onClear();
    MiriyamApp$Designer.init();
  };
  MiriyamApp$Worker.onYatiCheck = function() {
    var s1 = MiriyamApp$Util.getValue('Group1');
    var s2 = MiriyamApp$Util.getValue('Group2');
    var allowSandhi = false;
    window.document.getElementById('result').innerHTML = Chandam$Core$Business.checkYati(s1, s2, allowSandhi);
  };
  MiriyamApp$Worker.onPrasaCheck = function() {
    var s1 = MiriyamApp$Util.getValue('Group1');
    var s2 = MiriyamApp$Util.getValue('Group2');
    var allowSantiPrasa = MiriyamApp$Util.isChecked('allowSantiPrasa2');
    window.document.getElementById('result').innerHTML = Chandam$Core$Business.checkPrasa(s1, s2, allowSantiPrasa);
  };
  MiriyamApp$Worker.howMany = function() {
    var v = MiriyamApp$Util.selectedValue('ChandamNames');
    var i = parseInt(v);
    window.document.getElementById('result').innerHTML = "<span class='gName'>" + MiriyamUtil.Helper.chandamName(i) + "</span> \u0c1b\u0c02\u0c26\u0c2e\u0c41\u0c28\u0c15\u0c41  <span class='gName'>" + Math.pow(2, i) + '</span> \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c41 \u0c2a\u0c41\u0c1f\u0c4d\u0c1f\u0c41\u0c28\u0c41.';
  };
  MiriyamApp$Worker.buildMatraVruttam = function() {
    var sn = MiriyamApp$Util.getValue('txtVruttam');
    var n = 0;
    try {
      n = parseInt(sn);
      if (isNaN(n)) {
        window.document.getElementById('result').innerHTML = '';
        return;
      }
    }
    catch ($e1) {
      window.document.getElementById('result').innerHTML = '';
      return;
    }
    MiriyamaApp$Labs$ChandamLab.findMatraVruttams(n);
  };
  MiriyamApp$Worker.buildGana = function() {
    var sc = MiriyamApp$Util.selectedValue('ChandamNames');
    var sn = MiriyamApp$Util.getValue('txtNumber');
    if (!sc) {
    }
    var n = 0;
    var c = 0;
    try {
      n = parseInt(sn);
      c = parseInt(sc);
      if (isNaN(n) || isNaN(c)) {
        window.document.getElementById('result').innerHTML = '';
        return;
      }
    }
    catch ($e1) {
      window.document.getElementById('result').innerHTML = '';
      return;
    }
    window.document.getElementById('result').innerHTML = MiriyamaApp$Labs$ChandamLab.buildGana(c, n);
  };
  MiriyamApp$Worker.pendingReport = function() {
    var s = new MiriyamLib2.ChandamReports().pendingWork();
    window.document.getElementById('result').innerHTML = s;
  };
  MiriyamApp$Worker._loadSamples = function() {
    if (!ss.isValue(Config.ExternalRules)) {
      return;
    }
    var Rules2 = Config.Samples;
    Chandam$Samples$SamplePoems.append(Rules2);
  };
  MiriyamApp$Worker.loadRules = function() {
    var Mode2 = Config.Mode;
    switch (Mode2) {
      case MiriyamUtil.LoadMode.external:
      default:
        MiriyamApp$MapRules.loadExternalRules();
        break;
    }
    MiriyamUtil.Manager.addRule(new Chandam$Rules$Vruttam$GenricVruttam());
  };
  MiriyamApp$Worker._setText = function(id, v) {
    MiriyamApp$Util.setValue(id, ss.replaceString(ss.replaceString(v.toUpperCase(), '<BR>', '\n'), '<BR />', '\n'));
    MiriyamApp$Util.setFocus(id);
  };


  // MiriyamApp.External.Social.Facebook.FBAPI

  window.fbAsyncInit = function() {
    var IP = new MiriyamApp$Social$Facebook$InitParams();
    IP.appId = '590773791009851';
    IP.status = true;
    IP.xfbml = true;
    IP.cookie = true;
    FB.init(IP);
  };


  // Chandam.Samples.SamplePoems

  function Chandam$Samples$SamplePoems() {
  }
  Chandam$Samples$SamplePoems.get_poems = function() {
    return Chandam$Samples$SamplePoems._Poems;
  };
  Chandam$Samples$SamplePoems.getItem = function(i) {
    return (i > 0 && i < Chandam$Samples$SamplePoems.get_poems().length) ? Chandam$Samples$SamplePoems.get_poems()[i] : Chandam$Samples$SamplePoems.get_poems()[0];
  };
  Chandam$Samples$SamplePoems.append = function(Items) {
    if (Items == null || !Items.length) {
      return;
    }
    if (Chandam$Samples$SamplePoems._Poems == null) {
      Chandam$Samples$SamplePoems._Poems = [];
    }
    var S = new Array(Chandam$Samples$SamplePoems._Poems.length + Items.length);
    for (var i = 0; i < Chandam$Samples$SamplePoems._Poems.length; i++) {
      S[i] = Chandam$Samples$SamplePoems._Poems[i];
    }
    for (var i = 0; i < Items.length; i++) {
      S[i + Chandam$Samples$SamplePoems._Poems.length] = Items[i];
    }
    Chandam$Samples$SamplePoems._Poems = S;
  };


  // MiriyamaApp.Labs.ChandamLab

  function MiriyamaApp$Labs$ChandamLab() {
  }
  MiriyamaApp$Labs$ChandamLab.init = function() {
    MiriyamApp$Worker.loadRules();
    MiriyamaApp$Labs$ChandamLab.setList();
    MiriyamaApp$Labs$ChandamLab._loadChandamNames();
    document.getElementById('LabsPage').style.display = 'block';
    try {
      document.getElementById('banner').style.display = 'block';
      for (var i = 0; i < document.getElementById('banner').childNodes.length; i++) {
        var E = document.getElementById('banner').childNodes[i];
        E.style.display = 'none';
      }
    }
    catch ($e1) {
    }
  };
  MiriyamaApp$Labs$ChandamLab._loadChandamNames = function() {
    var E = window.document.getElementById('ChandamNames');
    E.innerHTML = '';
    for (var i = 1; i <= 26; i++) {
      var s = MiriyamUtil.Helper.chandamName(i) + ' (' + i + ')';
      var O = MiriyamApp$Util.addOptionItem(s, i.toString(), false);
      E.appendChild(O);
    }
  };
  MiriyamaApp$Labs$ChandamLab.setList = function() {
    var E = window.document.getElementById('MachineEnabled');
    E.innerHTML = '';
    var Jati = MiriyamApp$Util.addOptionItem('\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', '\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', true);
    var SamaVruttam = MiriyamApp$Util.addOptionItem('\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', '\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', true);
    var ASamaVruttam = MiriyamApp$Util.addOptionItem('\u0c05\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', '\u0c05\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', true);
    var $enum1 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.jati)));
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      if (R.get_identifier() === 'kandam') {
        var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
        Jati.appendChild(O);
      }
    }
    var OrderedVruttams = [];
    for (var i = 1; i <= 27; i++) {
      var cName = MiriyamUtil.Helper.chandamName(i) + ((i <= 26) ? ' (' + i + ')' : ' (>26)');
      var Local = MiriyamApp$Util.addOptionItem(cName, cName, true);
      var VRules = (i <= 26) ? MiriyamUtil.RuleHelper.getRules3(i) : MiriyamUtil.RuleHelper.getRules4(i);
      var $enum2 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(VRules));
      while ($enum2.moveNext()) {
        var R = $enum2.current;
        if (!R.get_infiniteLength()) {
          var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
          Local.appendChild(O);
          OrderedVruttams.push(Local);
        }
      }
    }
    var asamaRules = MiriyamUtil.RuleHelper.getRules2(MiriyamUtil.PadyamSubType.vishamaVruttam);
    var $enum3 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(asamaRules));
    while ($enum3.moveNext()) {
      var R = $enum3.current;
      var O = MiriyamApp$Util.addOptionItem(R.get_name(), R.get_identifier(), false);
      ASamaVruttam.appendChild(O);
    }
    E.appendChild(Jati);
    E.appendChild(SamaVruttam);
    var $enum4 = ss.enumerate(OrderedVruttams);
    while ($enum4.moveNext()) {
      var _E = $enum4.current;
      E.appendChild(_E);
    }
    E.appendChild(ASamaVruttam);
  };
  MiriyamaApp$Labs$ChandamLab.writeAPadyam = function() {
    var identifier = MiriyamApp$Util.selectedValue('MachineEnabled');
    var s = new MiriyamLib2.MachinePoem().build(identifier);
    s = Chandam$Core$Business.tryMatch(s, identifier, MiriyamLib2.MatchOptions.get_qucikMatchSettings());
    document.getElementById('result').innerHTML = s;
    MiriyamApp$Util.scrollTo('main');
  };
  MiriyamaApp$Labs$ChandamLab.findMatraVruttams = function(n) {
    var Rules = MiriyamUtil.RuleHelper.getMatraVruttams(n);
    if (!Rules.length) {
      document.getElementById('result').innerHTML = "<span class='gName'>\u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c41 \u0c0f\u0c2e\u0c40 \u0c32\u0c47\u0c35\u0c41</span>";
      return;
    }
    Rules = MiriyamUtil.SortHelper.sortByCharLength(Rules);
    var sb = new ss.StringBuilder();
    sb.append("<span class='gName'>");
    sb.append(n);
    sb.append('</span>');
    sb.append(' \u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c32\u0c41 \u0c17\u0c32 \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41 \u0c15\u0c4d\u0c30\u0c3f\u0c02\u0c26\u0c28 \u0c07\u0c35\u0c4d\u0c35\u0c2c\u0c21\u0c4d\u0c21\u0c3e\u0c2f\u0c3f.');
    sb.append(' \u0c2e\u0c4a\u0c24\u0c4d\u0c24\u0c02 ');
    sb.append("<span class='gName'> ");
    sb.append(Rules.length);
    sb.append('</span>');
    sb.append(' \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41 \u0c26\u0c4a\u0c30\u0c3f\u0c15\u0c3e\u0c2f\u0c3f. ');
    sb.append('<ol>');
    var last = 0;
    var $enum1 = ss.enumerate(Rules);
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      if (R.get_charLength() !== last) {
        if (0 !== last) {
          sb.append('</ol>');
          sb.append('</li>');
        }
        sb.append('<li>');
        sb.append('<b>');
        sb.append(R.get_chandamName() + ' (' + R.get_charLength() + ') ');
        sb.append('</b>');
        sb.append('</li>');
        sb.append('<ol>');
      }
      sb.append('<li>');
      sb.append(R.get_name());
      sb.append('</li>');
      last = R.get_charLength();
    }
    sb.append('</li>');
    sb.append('</ol>');
    document.getElementById('result').innerHTML = sb.toString2();
  };
  MiriyamaApp$Labs$ChandamLab.buildGana = function(c, n) {
    return MiriyamUtil.Helper.buildGana(c, n);
  };
  var MiriyamaApp$Labs$ChandamLab$ = {

  };


  // MiriyamApp.Social.Facebook.FBUtil

  function MiriyamApp$Social$Facebook$FBUtil() {
  }
  MiriyamApp$Social$Facebook$FBUtil.post = function(FP) {
    var Scope = new MiriyamApp$Social$Facebook$FBScope();
    Scope.scope = 'publish_actions';
    FB.login(function(resp) {
      if (resp.status === 'connected') {
        FB.api('/me/feed', 'POST', FP, function(response) {
        });
      }
    }, Scope);
  };
  MiriyamApp$Social$Facebook$FBUtil.init = function() {
  };


  // MiriyamApp.Social.Facebook.HTTPMethod

  function MiriyamApp$Social$Facebook$HTTPMethod() {
  }


  // MiriyamApp.Social.Facebook.APINames

  function MiriyamApp$Social$Facebook$APINames() {
  }


  // MiriyamApp.Social.Facebook.FBStatus

  function MiriyamApp$Social$Facebook$FBStatus() {
  }


  // MiriyamApp.Social.Facebook.ScopeNames

  function MiriyamApp$Social$Facebook$ScopeNames() {
  }


  // MiriyamApp.Social.Facebook.InitParams

  function MiriyamApp$Social$Facebook$InitParams() {
    this.status = false;
    this.cookie = false;
    this.xfbml = false;
  }
  var MiriyamApp$Social$Facebook$InitParams$ = {

  };


  // MiriyamApp.Social.Facebook.FBScope

  function MiriyamApp$Social$Facebook$FBScope() {
  }
  var MiriyamApp$Social$Facebook$FBScope$ = {

  };


  // MiriyamApp.Social.Facebook.FeedParams

  function MiriyamApp$Social$Facebook$FeedParams() {
  }
  var MiriyamApp$Social$Facebook$FeedParams$ = {

  };


  // Chandam.Rules.Vruttam.GenricVruttam

  function Chandam$Rules$Vruttam$GenricVruttam() {
    MiriyamUtil.Rule.call(this);
    this.set_lines(4);
    this.set_threshold(3);
    this.set_identifier('GenricVruttam');
    this.set_name('\u0c0f\u0c26\u0c47\u0c28\u0c3f \u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02');
    this.set_examples([]);
    this.set_ruleType(MiriyamUtil.RuleType.name);
    this.set_padyamType(MiriyamUtil.PadyamType.vruttam);
    this.set_padyamSubType(MiriyamUtil.PadyamSubType.genricVruttam);
    this.set_yatiMode(MiriyamUtil.YatiMode.charPosition);
    this.set_rules([ [] ]);
    this.set_yati([]);
    this.set_prasa(false);
    this.set_prasaYati(false);
  }
  var Chandam$Rules$Vruttam$GenricVruttam$ = {

  };


  var $exports = ss.module('MiriyamApp', null,
    {
      Metric: MiriyamApp$Metric,
      Strings: [ Chandam$Strings, Chandam$Strings$, null ],
      Business: [ Chandam$Core$Business, null, null ],
      Context: [ Chandam$Core$Context, Chandam$Core$Context$, null ],
      CookieUtil: [ MiriyamApp$CookieUtil, null, null ],
      LoadRules2: [ MiriyamApp$LoadRules2, MiriyamApp$LoadRules2$, null ],
      MapRules: [ MiriyamApp$MapRules, MiriyamApp$MapRules$, null ],
      Search: [ MiriyamApp$Search, null, null ],
      WorkerEvents: [ MiriyamApp$WorkerEvents, MiriyamApp$WorkerEvents$, null ],
      CSWriter: [ MiriyamApp$CSWriter, MiriyamApp$CSWriter$, null ],
      Designer: [ MiriyamApp$Designer, null, null ],
      MenuItems: [ MiriyamApp$MenuItems, null, null ],
      Metrics: [ MiriyamApp$Metrics, null, null ],
      OverlayDialog: [ MiriyamApp$OverlayDialog, MiriyamApp$OverlayDialog$, null ],
      StandardExport: [ MiriyamApp$StandardExport, MiriyamApp$StandardExport$, null ],
      Export: [ MiriyamApp$Export, MiriyamApp$Export$, null ],
      StopWatch: [ MiriyamApp$StopWatch, MiriyamApp$StopWatch$, null ],
      Events: [ MiriyamApp$Events, null, null ],
      Util: [ MiriyamApp$Util, null, null ],
      Patterns: [ MiriyamApp$Patterns, MiriyamApp$Patterns$, null ],
      Worker: [ MiriyamApp$Worker, null, null ],
      SamplePoems: [ Chandam$Samples$SamplePoems, null, null ],
      ChandamLab: [ MiriyamaApp$Labs$ChandamLab, MiriyamaApp$Labs$ChandamLab$, null ],
      FBUtil: [ MiriyamApp$Social$Facebook$FBUtil, null, null ],
      HTTPMethod: [ MiriyamApp$Social$Facebook$HTTPMethod, null, null ],
      APINames: [ MiriyamApp$Social$Facebook$APINames, null, null ],
      FBStatus: [ MiriyamApp$Social$Facebook$FBStatus, null, null ],
      ScopeNames: [ MiriyamApp$Social$Facebook$ScopeNames, null, null ],
      InitParams: [ MiriyamApp$Social$Facebook$InitParams, MiriyamApp$Social$Facebook$InitParams$, null ],
      FBScope: [ MiriyamApp$Social$Facebook$FBScope, MiriyamApp$Social$Facebook$FBScope$, null ],
      FeedParams: [ MiriyamApp$Social$Facebook$FeedParams, MiriyamApp$Social$Facebook$FeedParams$, null ],
      GenricVruttam: [ Chandam$Rules$Vruttam$GenricVruttam, Chandam$Rules$Vruttam$GenricVruttam$, MiriyamUtil.Rule ]
    });

  Chandam$Strings.noExamples = "\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c32\u0c41 \u0c05\u0c02\u0c26\u0c41\u0c2c\u0c3e\u0c1f\u0c41\u0c32\u0c4b \u0c32\u0c47\u0c35\u0c41<br />\u0c2e\u0c40 \u0c35\u0c26\u0c4d\u0c26 \u0c08 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c3f\u0c15\u0c3f \u0c1a\u0c46\u0c02\u0c26\u0c3f\u0c28 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c09\u0c02\u0c1f\u0c47 \u0c28\u0c3e\u0c15\u0c41  ( <a href='mailto:m.dileep@gmail.com'>m.dileep@gmail.com</a> )\u0c2a\u0c02\u0c2a\u0c17\u0c32\u0c30\u0c41.";
  Chandam$Strings.brand = '\n\u0c1b\u0c02\u0c26\u0c02 \u00a9- ';
  Chandam$Strings.initNotification = "\u0c0f\u0c26\u0c48\u0c28\u0c3e \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c15\u0c4d\u0c30\u0c3f\u0c02\u0c26\u0c3f <label class='gName'>\u21e9</label> \u0c2c\u0c3e\u0c15\u0c4d\u0c38\u0c41\u0c32\u0c4b \u0c35\u0c4d\u0c30\u0c3e\u0c38\u0c3f <label class='gName'>\u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</label> \u0c05\u0c28\u0c4d\u0c28 \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f. \u0c32\u0c47\u0c26\u0c3e  <img src='css/Dice64.png'  alt='Dice' title='\u0c2f\u0c3e\u0c26\u0c43\u0c1a\u0c4d\u0c1a\u0c3f\u0c15 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f' /> \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c3f \u0c12\u0c15 \u0c2f\u0c3e\u0c26\u0c43\u0c1a\u0c4d\u0c1a\u0c3f\u0c15 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c2a\u0c4a\u0c02\u0c26\u0c02\u0c21\u0c3f.";
  Chandam$Strings.twitterTitle = "\u0c2e\u0c40 <span class='gName'>Twitter</span>  \u0c38\u0c4d\u0c28\u0c47\u0c39\u0c3f\u0c24\u0c41\u0c32\u0c24\u0c4b  \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c02\u0c21\u0c3f...";
  Chandam$Strings.fbTitle = "\u0c2e\u0c40 <span class='gName'>FaceBook</span>  \u0c38\u0c4d\u0c28\u0c47\u0c39\u0c3f\u0c24\u0c41\u0c32\u0c24\u0c4b  \u0c2a\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c02\u0c21\u0c3f...";
  Chandam$Strings.title = '\u0c1b\u0c02\u0c26\u0c02 \u00a9-\u0c24\u0c46\u0c32\u0c41\u0c17\u0c41 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c15\u0c41 \u0c2a\u0c42\u0c30\u0c4d\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c2f\u0c3f \u0c38\u0c3e\u0c2b\u0c4d\u0c1f\u0c4d\u200c\u0c35\u0c47\u0c30\u0c4d';
  Chandam$Strings.tagLine = '\u0c1b\u0c02\u0c26\u0c02 \u00a9 \u0c24\u0c4b \u0c2a\u0c26\u0c4d\u0c2f \u0c38\u0c3e\u0c39\u0c3f\u0c24\u0c4d\u0c2f\u0c02 \u0c2e\u0c30\u0c3f\u0c02\u0c24 \u0c30\u0c38\u0c2e\u0c2f\u0c02..!!';
  Chandam$Strings.standardDesc = '\u0c17\u0c23\u0c35\u0c3f\u0c2d\u0c1c\u0c28, \u0c2f\u0c24\u0c3f \u0c2e\u0c30\u0c3f\u0c2f\u0c42 \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c32\u0c28\u0c41 \u0c15\u0c42\u0c21\u0c3e \u0c38\u0c30\u0c3f\u0c1a\u0c42\u0c21\u0c17\u0c32\u0c26\u0c41,\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c28\u0c41 \u0c35\u0c3f\u0c21\u0c2e\u0c30\u0c4d\u0c1a\u0c3f \u0c1a\u0c46\u0c2a\u0c4d\u0c2a\u0c17\u0c32\u0c26\u0c41. 343+ \u0c24\u0c46\u0c32\u0c41\u0c17\u0c41 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c28\u0c41 \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c17\u0c32\u0c26\u0c41 . 550 \u0c15\u0c3f \u0c2a\u0c48\u0c17\u0c3e \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41.\u0c38\u0c30\u0c3f\u0c15\u0c4a\u0c24\u0c4d\u0c24 \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c32\u0c28\u0c41 \u0c38\u0c43\u0c37\u0c4d\u0c1f\u0c3f\u0c02\u0c1a\u0c3f \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c17\u0c32\u0c3f\u0c17\u0c47 \u0c38\u0c4c\u0c15\u0c30\u0c4d\u0c2f\u0c02 \u0c07\u0c35\u0c28\u0c4d\u0c28\u0c40 \u0c1b\u0c02\u0c26\u0c02 \u00a9 \u0c32\u0c4b..';
  Chandam$Strings.permLinkDesc = '\u0c2a\u0c48 \u0c2a\u0c26\u0c4d\u0c2f\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c0e\u0c2a\u0c4d\u0c2a\u0c41\u0c21\u0c48\u0c28\u0c3e \u0c08 \u0c32\u0c3f\u0c02\u0c15\u0c41\u0c28\u0c41 \u0c09\u0c2a\u0c2f\u0c4b\u0c17\u0c3f\u0c02\u0c1a\u0c3f \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41\u0c15\u0c4b\u0c35\u0c1a\u0c4d\u0c1a\u0c41.';
  Chandam$Strings.permLinkTitle = '\u0c36\u0c3e\u0c36\u0c4d\u0c35\u0c24\u0c2e\u0c48\u0c28 \u0c32\u0c3f\u0c02\u0c15\u0c41..';
  Chandam$Strings.subscribtionSucc = "<span class='gName' style='color:green !important;'>\u2714</span> Subscribed Successfully..!!";
  Chandam$Strings.unSubscribtionSucc = "<span class='gName'  style='color:green !important;'>\u2718</span> Unsubscribed Successfully..!!</span>";
  Chandam$Strings.invalidEmail = 'Please provide a valid Email Address.';
  Chandam$Strings.subscribe = 'Subscribe';
  Chandam$Strings.unSubscribe = 'Unsubscribe';
  Chandam$Strings.bcOnRequest = '\u0c2a\u0c4d\u0c30\u0c38\u0c4d\u0c24\u0c41\u0c24\u0c3e\u0c28\u0c3f\u0c15\u0c3f public \u0c21\u0c4a\u0c2e\u0c48\u0c28\u0c4d \u0c32\u0c4b \u0c05\u0c02\u0c26\u0c41\u0c2c\u0c3e\u0c1f\u0c41\u0c32\u0c4b \u0c32\u0c47\u0c26\u0c41.\u0c05\u0c2d\u0c4d\u0c2f\u0c30\u0c4d\u0c27\u0c28 \u0c2e\u0c47\u0c30\u0c15\u0c41 \u0c28\u0c3e\u0c15\u0c41 \u0c2a\u0c02\u0c2a\u0c3f\u0c24\u0c47 \u0c26\u0c4b\u0c37\u0c3e\u0c32 \u0c32\u0c3f\u0c38\u0c4d\u0c1f\u0c41 \u0c2a\u0c02\u0c2a\u0c17\u0c32\u0c28\u0c41. \u0c26\u0c40\u0c28\u0c3f\u0c28\u0c3f \u0c2e\u0c40\u0c30\u0c47 run \u0c1a\u0c47\u0c38\u0c41\u0c15\u0c4a\u0c28\u0c47\u0c32\u0c3e \u0c12\u0c15 application \u0c24\u0c2f\u0c3e\u0c30\u0c41 \u0c1a\u0c47\u0c2f\u0c2c\u0c21\u0c41\u0c24\u0c4b\u0c02\u0c26\u0c3f. \u0c35\u0c47\u0c1a\u0c3f\u0c1a\u0c42\u0c21\u0c17\u0c32\u0c30\u0c41.\u0c15\u0c3e\u0c35\u0c32\u0c38\u0c3f\u0c28\u0c35\u0c3e\u0c30\u0c41 \u0c28\u0c3e\u0c15\u0c41 \u0c08-\u0c2e\u0c46\u0c2f\u0c3f\u0c32\u0c41 \u0c1a\u0c47\u0c2f\u0c17\u0c32\u0c30\u0c41.\u0c24\u0c2f\u0c3e\u0c30\u0c41 \u0c05\u0c2f\u0c3f\u0c28 \u0c24\u0c30\u0c41\u0c35\u0c3e\u0c24 \u0c2e\u0c40\u0c15\u0c41 \u0c24\u0c46\u0c32\u0c3f\u0c2f\u0c2c\u0c30\u0c4d\u0c1a\u0c17\u0c32\u0c28\u0c41.';
  Chandam$Strings.bulkCompute = 'Bulk Compute';
  Chandam$Strings.feedbackSucc = "<span class='gName' style='color:green !important;'>\u2714</span> Feedback Sent Successfully..!!";
  Chandam$Strings.help = "<div class='help'>\u0c2e\u0c40\u0c30\u0c41 \u0c05\u0c28\u0c41\u0c15\u0c41\u0c02\u0c1f\u0c41\u0c28\u0c4d\u0c28 \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c02 \u0c08 \u0c38\u0c2e\u0c40\u0c2a \u0c2b\u0c32\u0c3f\u0c24\u0c3e\u0c32\u0c32\u0c4b \u0c15\u0c28\u0c41\u0c15 \u0c09\u0c02\u0c1f\u0c47 \u0c26\u0c3e\u0c28\u0c3f\u0c2a\u0c48 \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c3f <span class='gName'>...\u0c24\u0c4b \u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</span>  \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c2e\u0c41 \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f. \u0c32\u0c47\u0c26\u0c3e \u0c2f\u0c24\u0c3f, \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c17\u0c23\u0c28\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c24\u0c40\u0c38\u0c3f\u0c35\u0c47\u0c38\u0c3f \u0c2e\u0c30\u0c4b\u0c38\u0c3e\u0c30\u0c3f <span class='gName'>\u0c17\u0c23\u0c3f\u0c02\u0c1a\u0c41</span> \u0c2c\u0c4a\u0c24\u0c4d\u0c24\u0c3e\u0c28\u0c4d\u0c28\u0c3f \u0c28\u0c4a\u0c15\u0c4d\u0c15\u0c02\u0c21\u0c3f.\u0c2e\u0c30\u0c3f\u0c28\u0c4d\u0c28\u0c3f \u0c35\u0c3f\u0c35\u0c30\u0c3e\u0c32\u0c15\u0c41 <a  target=\"_blank\" class=\"pink\" href=\"default.aspx?faq\" title=\"\u0c24\u0c30\u0c1a\u0c41\u0c17\u0c3e \u0c05\u0c21\u0c3f\u0c17\u0c47 \u0c2a\u0c4d\u0c30\u0c36\u0c4d\u0c30\u0c4d\u0c28\u0c32\u0c41(FAQ)\">\u0c24\u0c30\u0c1a\u0c41\u0c17\u0c3e \u0c05\u0c21\u0c3f\u0c17\u0c47 \u0c2a\u0c4d\u0c30\u0c36\u0c4d\u0c30\u0c4d\u0c28\u0c32\u0c41(FAQ)</a> \u0c1a\u0c42\u0c21\u0c02\u0c21\u0c3f.</div>";
  MiriyamApp$MenuItems._reqInProgress = false;
  MiriyamApp$StopWatch._lastTicks = 0;
  MiriyamApp$Events.click = 'click';
  MiriyamApp$Events.change = 'change';
  MiriyamApp$Patterns.email = /^[a-zA-Z_\.]+?@[a-zA-Z_\.]+?\.[a-zA-Z]{2,3}$/;
  (function() {
    var url = window.location.href.toLowerCase();
    if (url.indexOf('http://') === -1 && url.indexOf('https://') === -1) {
      document.getElementById('body').innerHTML = '<h2>Protocol is not supported.</h2>';
      return;
    }
    MiriyamApp$WorkerEvents.registerEvents();
    MiriyamApp$Worker.init();
  })();
  MiriyamApp$Social$Facebook$HTTPMethod.POST = 'POST';
  MiriyamApp$Social$Facebook$HTTPMethod.GET = 'GET';
  MiriyamApp$Social$Facebook$APINames.feed = '/me/feed';
  MiriyamApp$Social$Facebook$FBStatus.connected = 'connected';
  MiriyamApp$Social$Facebook$FBStatus.notAuthorized = 'not_authorized';
  MiriyamApp$Social$Facebook$ScopeNames.publishActions = 'publish_actions';

});
