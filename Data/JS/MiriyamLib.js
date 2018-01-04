"use strict";

define('MiriyamLib2', ['ss', 'MiriyamUtil'], function(ss, MiriyamUtil) {
  var $global = this;

  // Chandam.Rules.CheatSheet

  function Chandam$Rules$CheatSheet() {
  }
  Chandam$Rules$CheatSheet.buildBook = function() {
    var s2 = '<h1>\u0c05\u0c28\u0c41\u0c15\u0c4d\u0c30\u0c2e\u0c23\u0c3f\u0c15</h1><ol>';
    var s = '';
    var F = [];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.jati);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c05\u0c15\u0c4d\u0c15\u0c30\u0c32\u0c41', MiriyamUtil.PadyamSubType.akkara);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c30\u0c17\u0c21\u0c32\u0c41', MiriyamUtil.PadyamSubType.ragada);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c2e\u0c41\u0c24\u0c4d\u0c2f\u0c3e\u0c32\u0c38\u0c30\u0c2e\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.ragada2);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c37\u0c1f\u0c4d\u0c2a\u0c26\u0c32\u0c41', MiriyamUtil.PadyamSubType.shatpada);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c09\u0c2a-\u0c1c\u0c3e\u0c24\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.upaJati);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c26\u0c4d\u0c35\u0c3f\u0c2a\u0c26\u0c32\u0c41', MiriyamUtil.PadyamSubType.divpada);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c38\u0c40\u0c38\u0c2e\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.divpada);
    s = s + F[0];
    s2 = s2 + F[1];
    s = s + '<h1>\u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41</h1>';
    s2 = s2 + '<li>\u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41</li><ol>';
    for (var i = 1; i <= 27; i++) {
      var cName = MiriyamUtil.Helper.chandamName(i) + ((i <= 26) ? ' (' + i + ')' : ' (>26)');
      var VRules = (i <= 26) ? MiriyamUtil.RuleHelper.getRules3(i) : MiriyamUtil.RuleHelper.getRules4(i);
      s = s + '<h1>' + cName + '</h1>';
      s = s + '<ol>';
      s2 = s2 + '<li>' + cName + '</li>';
      s2 = s2 + '<ol>';
      var $enum1 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(VRules));
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        s = s + "<li  id='" + R.get_identifier() + "'>";
        s = s + Chandam$Rules$CheatSheet.buildHTMLRules(R, true);
        s = s + "&nbsp; <a class='link' href='#TOP_" + R.get_identifier() + "'>[TOP]</a>";
        s = s + '</li>';
        s2 = s2 + "<li id='TOP_" + R.get_identifier() + "'><a class='identifier' href='#" + R.get_identifier() + "'>" + R.get_name() + '</a></li>';
      }
      s = s + '</ol>';
      s2 = s2 + '</ol>';
    }
    s2 = s2 + '</ol>';
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c26\u0c02\u0c21\u0c15\u0c2e\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.daMDakamu);
    s = s + F[0];
    s2 = s2 + F[1];
    F = Chandam$Rules$CheatSheet._sortByName2('\u0c05\u0c38\u0c2e \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41\u0c32\u0c41', MiriyamUtil.PadyamSubType.vishamaVruttam);
    s = s + F[0];
    s2 = s2 + F[1];
    s2 = s2 + '</ol>';
    return s2 + s;
  };
  Chandam$Rules$CheatSheet._sortByName2 = function(head, padyamSubType) {
    return Chandam$Rules$CheatSheet._sortByName3(head, padyamSubType, MiriyamUtil.RuleHelper.getRules2(padyamSubType));
  };
  Chandam$Rules$CheatSheet._sortByName3 = function(head, padyamSubType, rules) {
    var s = '';
    var s2 = '';
    s = s + '<h1>' + head + '</h1>';
    s = s + '<ol>';
    s2 = s2 + '<li>' + head + '</li>';
    s2 = s2 + '<ol>';
    var $enum1 = ss.enumerate(MiriyamUtil.SortHelper.sortByName(rules));
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      s = s + "<li  id='" + R.get_identifier() + "'>";
      s = s + Chandam$Rules$CheatSheet.buildHTMLRules(R, true);
      s = s + "&nbsp; <a class='link' href='#TOP_" + R.get_identifier() + "'>[TOP]</a>";
      s = s + '</li>';
      s2 = s2 + "<li id='TOP_" + R.get_identifier() + "'><a class='identifier' href='#" + R.get_identifier() + "'>" + R.get_name() + '</a></li>';
    }
    s = s + '</ol>';
    s2 = s2 + '</ol>';
    return [ s, s2 ];
  };
  Chandam$Rules$CheatSheet.buildRules = function(R) {
    return Chandam$Rules$CheatSheet.buildHTMLRules(R, false);
  };
  Chandam$Rules$CheatSheet.buildRules2 = function(R, useExample) {
    return Chandam$Rules$CheatSheet.buildHTMLRules(R, useExample);
  };
  Chandam$Rules$CheatSheet.buildRulesWithExamples = function(R) {
    return Chandam$Rules$CheatSheet.buildHTMLRules(R, true);
  };
  Chandam$Rules$CheatSheet.buildCheatSheet = function(extended, fixedWidth) {
    return Chandam$Rules$CheatSheet.buildCheatSheet2(extended, fixedWidth, MiriyamUtil.SortHelper.orderedRules());
  };
  Chandam$Rules$CheatSheet.buildCheatSheet2 = function(extended, fixedWidth, Rules) {
    var s = "<table id='CheatSheet' class='sort-table errTab2' cellspacing='0'  border='1'>";
    if (!extended) {
      s = s + '<colgroup><col /><col /><col /><col /><col /><col /><col /><col /><col /><col  /><col /></colgroup>';
    }
    var row = '<thead><tr>';
    row = row + '<th' + ((fixedWidth) ? ' width="3%" style="text-align:center"' : '') + '>\u0c15\u0c4d\u0c30\u0c2e \u0c38\u0c02\u0c16\u0c4d\u0c2f</th>';
    row = row + '<th' + ((fixedWidth) ? ' style="text-align:center"' : '') + '>\u0c2a\u0c47\u0c30\u0c41</th>';
    row = row + '<th' + ((fixedWidth) ? ' width="5%" style="text-align:center"' : '') + '><nobr>\u0c2a\u0c3e\u0c26\u0c3e\u0c15\u0c4d\u0c37\u0c30\u0c3e\u0c32 \u0c38\u0c02\u0c16\u0c4d\u0c2f</nobr></th>';
    row = row + '<th' + ((fixedWidth) ? ' width="3%" style="text-align:center"' : '') + '><nobr>\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c32\u0c41</nobr></th>';
    row = row + '<th' + ((fixedWidth) ? ' width="5%" style="text-align:center"' : '') + '><nobr>\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c41\u0c32\u0c41</nobr></th>';
    row = row + '<th' + ((fixedWidth) ? ' width="5%" style="text-align:center"' : '') + '>\u0c1b\u0c02\u0c26\u0c02</th>';
    row = row + '<th' + ((fixedWidth) ? ' width="3%" style="text-align:center"' : '') + '>\u0c0e\u0c28\u0c4d\u0c28\u0c4b\u0c35 \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c02</th>';
    row = row + '<th' + ((fixedWidth) ? ' width="6%" style="text-align:center"' : '') + '>\u0c38\u0c4d\u0c35\u0c2d\u0c3e\u0c35\u0c02</th>';
    row = row + '<th' + ((fixedWidth) ? ' width="4%" style="text-align:center"' : '') + '>\u0c2a\u0c3e\u0c26\u0c3e\u0c32\u0c41</th>';
    row = row + '<th' + ((fixedWidth) ? ' width="3%" style="text-align:center"' : '') + '>\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c28\u0c3f\u0c2f\u0c2e\u0c02</th>';
    row = row + ((extended) ? '<th><nobr>\u0c05\u0c02\u0c24\u0c4d\u0c2f\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c28\u0c3f\u0c2f\u0c2e\u0c02</nobr></th>' : '');
    row = row + '<th' + ((fixedWidth) ? ' width="3%" style="text-align:center"' : '') + '><nobr>\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c2f\u0c24\u0c3f</nobr></th>';
    row = row + '<th' + ((fixedWidth) ? ' width="7%" style="text-align:center"' : '') + '>\u0c2f\u0c24\u0c3f \u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f</th>';
    row = row + '<th style="text-align:center">\u0c32\u0c15\u0c4d\u0c37\u0c23\u0c3e\u0c32\u0c41(\u0c17\u0c23 )</th>';
    row = row + '<th style="text-align:center">\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23</th>';
    if (extended) {
      row = row + '<th>#</th>';
      row = row + '<th>\u0c32\u0c15\u0c4d\u0c37\u0c23\u0c3e\u0c32\u0c41</th>';
    }
    row = row + '</tr></thead>';
    s = s + row;
    s = s + '<tbody>';
    var cnt = 1;
    var $enum1 = ss.enumerate(Rules);
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      var ml = (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_infiniteLength() && !R.get_rowWiseRules()) ? R.get_matraLength().toString() : '';
      var mlSeries = R.get_matraSeries();
      var l = (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_infiniteLength() && !R.get_rowWiseRules()) ? R.get_charLength().toString() : '';
      var cName = (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_infiniteLength() && !R.get_rowWiseRules()) ? R.get_chandamName() : '';
      var cNumber = (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_infiniteLength() && !R.get_rowWiseRules() && R.get_chandamNumber() !== -1) ? R.get_chandamNumber().toString() : '';
      var PadyamName = MiriyamUtil.Helper.getPadyamTypeString(R.get_padyamType(), R.get_padyamSubType());
      var ruleName = ss.replaceString(ss.replaceString(ss.replaceString(R.get_name(), '(', '<br/>&nbsp;'), ',', '<br/>&nbsp;'), ')', '');
      if (R.get_charLength() === -1 && !R.get_infiniteLength()) {
        l = (R.get_min() === R.get_max()) ? R.get_max().toString() : '<nobr>' + R.get_min() + ' \u0c28\u0c41\u0c02\u0c21\u0c3f ' + R.get_max() + '</nobr>';
      }
      if (!!PadyamName) {
        PadyamName = '<nobr>' + PadyamName + '</nobr>';
      }
      var row = '<tr>';
      row = row + '<td>' + (cnt++) + '</td>';
      row = row + '<td>' + ruleName + '</td>';
      row = row + '<td>' + l + '</td>';
      row = row + '<td>' + ml + '</td>';
      row = row + '<td>' + mlSeries + '</td>';
      row = row + '<td>' + cName + '</td>';
      row = row + '<td>' + cNumber + '</td>';
      row = row + '<td>' + PadyamName + '</td>';
      row = row + '<td>' + R.get_lines() + '</td>';
      row = row + '<td>' + ((R.get_prasa()) ? '\u0c15\u0c32\u0c26\u0c41' : '\u0c32\u0c47\u0c26\u0c41') + ((R.get_anthyaPrasa() && !extended) ? '<br/><nobr>\u0c05\u0c02\u0c24\u0c4d\u0c2f\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c15\u0c32\u0c26\u0c41</nobr>' : '') + '</td>';
      if (extended) {
        row = row + '<td>' + ((R.get_anthyaPrasa()) ? '\u0c15\u0c32\u0c26\u0c41' : '\u0c32\u0c47\u0c26\u0c41') + '</td>';
      }
      row = row + '<td>' + ((R.get_prasaYati()) ? '\u0c15\u0c32\u0c26\u0c41' : '') + '</td>';
      row = row + '<td>' + Chandam$Rules$CheatSheet._getYatiRules(R.get_rules(), R.get_yati(), R.get_yatiMode(), R.get_reverseYati()) + '</td>';
      row = row + '<td>' + Chandam$Rules$CheatSheet._getRules(R.get_rules(), R.get_ruleType(), R.get_infiniteLength(), R.get_rowWiseRules()) + '</td>';
      row = row + '<td>' + ((R.get_examples2().length > 0) ? Chandam$Rules$CheatSheet._tryMatch(R.get_examples2()[0].get_text(), R) : '') + '</td>';
      if (extended) {
        row = row + '<td>' + ((R.get_examples2() == null) ? '' : R.get_examples2().length.toString()) + '</td>';
        row = row + '<td>' + ((R.get_ruleText() == null) ? '' : R.get_ruleText()) + '</td>';
      }
      row = row + '</tr>\n';
      s = s + row;
    }
    s = s + '</tbody>';
    s = s + '</table>';
    return s;
  };
  Chandam$Rules$CheatSheet._getYatiRules = function(Rules, Yati, Mode, ReverseYati) {
    var s = '';
    if (Yati.length === Rules.length && Yati.length > 1) {
      for (var i = 0; i < Yati.length; i++) {
        var LineRule = Yati[i];
        if (Yati.length > 1) {
          if (!i) {
            s = s + "<ol class='rules'>";
          }
          s = s + '<li><nobr>';
        }
        if (LineRule.length > 0) {
          s = s + Chandam$Rules$CheatSheet._getPadamYatiText2(LineRule);
        }
        else {
          s = s + '--';
        }
        if (LineRule.length > 0) {
          s = s + Chandam$Rules$CheatSheet._YEnd(Mode, ReverseYati, LineRule.length);
        }
        if (Yati.length > 1) {
          s = s + '</nobr></li>';
          if (i === Yati.length - 1) {
            s = s + '</ol>';
          }
        }
      }
    }
    else {
      if (Yati.length > 0 && Yati[0].length > 0) {
        var LineRule = Yati[0];
        s = s + Chandam$Rules$CheatSheet._getPadamYatiText2(LineRule);
        s = s + Chandam$Rules$CheatSheet._YEnd(Mode, ReverseYati, LineRule.length);
      }
    }
    return s;
  };
  Chandam$Rules$CheatSheet._YEnd = function(Mode, ReverseYati, Length) {
    var s = '';
    if (Mode === MiriyamUtil.YatiMode.gPosition) {
      if (ReverseYati) {
        s = s + ((Length > 1) ? ' \u0c17\u0c23\u0c2e\u0c41\u0c32 \u0c1a\u0c3f\u0c35\u0c30\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : ' \u0c35 \u0c17\u0c23\u0c2e\u0c41 \u0c2f\u0c4a\u0c15\u0c4d\u0c15 \u0c1a\u0c3f\u0c35\u0c30\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
      }
      else {
        s = s + ((Length > 1) ? ' \u0c17\u0c23\u0c2e\u0c41\u0c32 \u0c2e\u0c4a\u0c26\u0c1f\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : ' \u0c35 \u0c17\u0c23\u0c2e\u0c41 \u0c2f\u0c4a\u0c15\u0c4d\u0c15 \u0c2e\u0c4a\u0c26\u0c1f\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
      }
    }
    if (Mode === MiriyamUtil.YatiMode.charPosition) {
      s = s + ((Length > 1) ? ' \u0c35 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : ' \u0c35 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
    }
    return s;
  };
  Chandam$Rules$CheatSheet._getPadamYatiText2 = function(LineRule) {
    var s = '';
    for (var r = 0; r < LineRule.length; r++) {
      s = s + LineRule[r].toString();
      if (r !== LineRule.length - 1) {
        s = s + ',';
      }
    }
    return s;
  };
  Chandam$Rules$CheatSheet._getRules = function(Rules, RuleType, infiniteLength, RowWiseRules) {
    var s = '';
    if (RowWiseRules && Rules.length !== 1) {
      s = s + "<ol  class='rules'>";
      for (var i = 0; i < Rules.length; i++) {
        var LineRule = Rules[i];
        s = s + '<li><nobr>' + Chandam$Rules$CheatSheet._getPadamRuleText(RuleType, infiniteLength, LineRule) + '</nobr></li>';
      }
      s = s + '</ol>';
    }
    else {
      var LineRule = Rules[0];
      s = s + "<nobr style='margin:5px;'>" + Chandam$Rules$CheatSheet._getPadamRuleText(RuleType, infiniteLength, LineRule) + '</nobr>';
    }
    return s;
  };
  Chandam$Rules$CheatSheet._getPadamYatiText = function(LineRule, _YatiMode, ReverseYati) {
    if (!LineRule.length) {
      return '';
    }
    var s = "<span class='gName'>";
    for (var i = 0; i < LineRule.length; i++) {
      var o = LineRule[i];
      s = s + o.toString();
      if (i !== LineRule.length - 1) {
        s = s + ',';
      }
    }
    if (_YatiMode === MiriyamUtil.YatiMode.gPosition) {
      if (ReverseYati) {
        s = s + ((LineRule.length > 1) ? '</span> \u0c17\u0c23\u0c2e\u0c41\u0c32 \u0c1a\u0c3f\u0c35\u0c30\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : '</span> \u0c35 \u0c17\u0c23\u0c2e\u0c41 \u0c2f\u0c4a\u0c15\u0c4d\u0c15 \u0c1a\u0c3f\u0c35\u0c30\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
      }
      else {
        s = s + ((LineRule.length > 1) ? '</span> \u0c17\u0c23\u0c2e\u0c41\u0c32 \u0c2e\u0c4a\u0c26\u0c1f\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : '</span> \u0c35 \u0c17\u0c23\u0c2e\u0c41 \u0c2f\u0c4a\u0c15\u0c4d\u0c15 \u0c2e\u0c4a\u0c26\u0c1f\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
      }
    }
    if (_YatiMode === MiriyamUtil.YatiMode.charPosition) {
      s = s + ((LineRule.length > 1) ? '</span> \u0c35 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41' : '</span> \u0c35 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41');
    }
    return s;
  };
  Chandam$Rules$CheatSheet._getPadamRuleText = function(ruleType, infiniteLength, LineRule) {
    var s = '';
    var prev = '';
    var repeat = 0;
    for (var i = 0; i < LineRule.length; i++) {
      var o = LineRule[i];
      var curr = Chandam$Rules$CheatSheet._ruleText(ruleType, o);
      if (ruleType === MiriyamUtil.RuleType.name) {
        s = s + curr;
        if (i !== LineRule.length - 1) {
          s = s + ' , ';
        }
        if (infiniteLength && LineRule.length - 2 >= 0 && i === LineRule.length - 2) {
          s = ss.removeString(s, s.length - 2, 2);
          s = s + ' ..... ';
        }
      }
      else {
        if (!!prev && prev !== curr) {
          s = s + Chandam$Rules$CheatSheet._getNumberText(repeat) + ' ' + prev;
          if (i !== LineRule.length - 1) {
            s = s + ' , ';
          }
          repeat = 1;
          prev = curr;
          continue;
        }
        repeat++;
        prev = curr;
      }
    }
    if (repeat > 0) {
      if (!ss.endsWith(s, ' , ') && s.length + 1 !== 1) {
        s = s + ' , ';
      }
      s = s + Chandam$Rules$CheatSheet._getNumberText(repeat) + ' ' + prev;
    }
    return s;
  };
  Chandam$Rules$CheatSheet._getNumberText = function(num) {
    switch (num) {
      case 1:
        return '\u0c12\u0c15';
      case 2:
        return '\u0c30\u0c46\u0c02\u0c21\u0c41';
      case 3:
        return '\u0c2e\u0c42\u0c21\u0c41';
      case 4:
        return '\u0c28\u0c3e\u0c32\u0c41\u0c17\u0c41';
      case 5:
        return '\u0c10\u0c26\u0c41';
      case 6:
        return '\u0c06\u0c30\u0c41';
      case 7:
        return '\u0c0f\u0c21\u0c41';
      case 8:
        return '\u0c0e\u0c28\u0c3f\u0c2e\u0c3f\u0c26\u0c3f';
      default:
        return num.toString();
    }
  };
  Chandam$Rules$CheatSheet._getPadamName = function(p) {
    switch (p) {
      case 1:
        return '\u0c12\u0c15\u0c1f\u0c35';
      case 2:
        return '\u0c30\u0c46\u0c02\u0c21\u0c35';
      case 3:
        return '\u0c2e\u0c42\u0c21\u0c35';
      case 4:
        return '\u0c28\u0c3e\u0c32\u0c41\u0c17\u0c35';
      case 5:
        return '\u0c07\u0c26\u0c35';
      case 6:
        return '\u0c06\u0c30\u0c35';
      case 7:
        return '\u0c0f\u0c21\u0c35';
      case 8:
        return '\u0c0e\u0c28\u0c3f\u0c2e\u0c3f\u0c26\u0c35';
      default:
        return '{\u0c24\u0c46\u0c32\u0c3f\u0c2f\u0c26\u0c41}';
    }
  };
  Chandam$Rules$CheatSheet._ruleText = function(ruleType, o) {
    switch (ruleType) {
      case MiriyamUtil.RuleType.name:
        return MiriyamUtil.GDefinition.gAlias(o);
      case MiriyamUtil.RuleType.type:
        var Cat = o;
        return MiriyamUtil.GDefinition.categoryString(Cat);
      case MiriyamUtil.RuleType.subType:
        var Cat = o;
        return MiriyamUtil.GDefinition.subCategoryString(Cat);
      case MiriyamUtil.RuleType.weight:
        var Cat = o;
        return Cat.toString() + ' \u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c32\u0c41';
      default:
        return '\u0c24\u0c46\u0c32\u0c3f\u0c2f\u0c26\u0c41';
    }
  };
  Chandam$Rules$CheatSheet.buildHTMLRules = function(R, includeExamples) {
    var s = '<h2>' + R.get_shortName() + ' \u0c2a\u0c26\u0c4d\u0c2f \u0c32\u0c15\u0c4d\u0c37\u0c23\u0c2e\u0c41\u0c32\u0c41 </h2>';
    s = s + '<ol>';
    if (!!R.get_alias()) {
      s = s + "<li>\u0c08 \u0c2a\u0c26\u0c4d\u0c2f \u0c1b\u0c02\u0c26\u0c38\u0c4d\u0c38\u0c41\u0c15\u0c47 <span class='gName'>" + R.get_alias() + '</span> \u0c05\u0c28\u0c47 \u0c07\u0c24\u0c30 \u0c28\u0c3e\u0c2e\u0c2e\u0c41' + ((R.get_alias().indexOf(',') > 0) ? '\u0c32\u0c41' : '') + ' \u0c15\u0c42\u0c21\u0c3e \u0c15\u0c32' + ((R.get_alias().indexOf(',') > 0) ? '\u0c35\u0c41' : '\u0c26\u0c41') + '.</li>';
    }
    s = s + "<li><span class='gName'>" + MiriyamUtil.Helper.getPadyamTypeString(R.get_padyamType(), R.get_padyamSubType()) + '</span> \u0c30\u0c15\u0c3e\u0c28\u0c3f\u0c15\u0c3f \u0c1a\u0c46\u0c02\u0c26\u0c3f\u0c28\u0c26\u0c3f </li>';
    if (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_rowWiseRules() && R.get_chandamNumber() !== -1) {
      s = s + "<li><span class='gName'>" + R.get_chandamName() + "</span> \u0c1b\u0c02\u0c26\u0c2e\u0c41\u0c28\u0c15\u0c41  \u0c1a\u0c46\u0c02\u0c26\u0c3f\u0c28 <span class='gName'>" + R.get_chandamNumber() + '</span> \u0c35 \u0c35\u0c43\u0c24\u0c4d\u0c24\u0c2e\u0c41.</li>';
      s = s + "<li><span class='gName'>" + R.get_charLength() + '</span> \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41 \u0c09\u0c02\u0c21\u0c41\u0c28\u0c41.</li>';
    }
    if (R.get_charLength() === -1 && !R.get_infiniteLength()) {
      s = s + "<li><span class='gName'>" + R.get_min() + "</span> \u0c28\u0c41\u0c02\u0c21\u0c3f <span class='gName'>" + R.get_max() + '</span> \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c2e\u0c41\u0c32\u0c41 \u0c09\u0c02\u0c21\u0c41\u0c28\u0c41.</li>';
    }
    if (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && !R.get_rowWiseRules() && R.get_matraLength() !== -1) {
      s = s + "<li><span class='gName'>" + R.get_matraLength() + '</span> \u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c32\u0c41 \u0c09\u0c02\u0c21\u0c41\u0c28\u0c41.</li>';
      s = s + '<li>';
      s = s + "<span class='gName'>\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f</span>: " + Chandam$Rules$CheatSheet._colorFul(R.get_sequence());
      s = s + Chandam$Rules$CheatSheet._availableSerieses(R.get_sequence());
      s = s + '</li>';
    }
    s = s + "<li><span class='gName'>" + R.get_lines() + '</span>' + ((R.get_lines() !== 1) ? ' \u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c32\u0c41' : ' \u0c2a\u0c3e\u0c26\u0c2e\u0c41') + ' \u0c09\u0c02\u0c21\u0c41\u0c28\u0c41.' + '</li>';
    if (R.get_prasa()) {
      s = s + "<li>\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c28\u0c3f\u0c2f\u0c2e\u0c02 <span class='gName'>\u0c15\u0c32\u0c26\u0c41</span>" + '</li>';
    }
    else {
      s = s + "<li>\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c28\u0c3f\u0c2f\u0c2e\u0c02 <span class='gName'>\u0c32\u0c47\u0c26\u0c41</span>" + '</li>';
    }
    if (R.get_anthyaPrasa()) {
      s = s + "<li>\u0c05\u0c02\u0c24\u0c4d\u0c2f \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c28\u0c3f\u0c2f\u0c2e\u0c02 <span class='gName'>\u0c15\u0c32\u0c26\u0c41</span>" + '</li>';
    }
    if (R.get_prasaYati()) {
      s = s + "<li>\u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c2f\u0c24\u0c3f \u0c28\u0c3f\u0c2f\u0c2e\u0c02 <span class='gName'>\u0c15\u0c32\u0c26\u0c41</span>" + '</li>';
    }
    if (R.get_yati().length === R.get_rules().length && R.get_yati().length > 1) {
      for (var i = 0; i < R.get_yati().length; i++) {
        var LineRule = R.get_yati()[i];
        var PadamName = Chandam$Rules$CheatSheet._getPadamName(i + 1);
        if (LineRule.length > 0) {
          s = s + '<li>' + PadamName + ' \u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c28\u0c02\u0c26\u0c41 ';
          s = s + Chandam$Rules$CheatSheet._getPadamYatiText(LineRule, R.get_yatiMode(), R.get_reverseYati());
          s = s + ((LineRule.length === 1) ? ' \u0c2f\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41</li>' : ' \u0c2f\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41\u0c32\u0c41</li>');
        }
      }
    }
    else {
      if (R.get_yati().length > 0 && R.get_yati()[0].length > 0) {
        s = s + '<li>\u0c2a\u0c4d\u0c30\u0c24\u0c3f \u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c28\u0c02\u0c26\u0c41 ';
        s = s + Chandam$Rules$CheatSheet._getPadamYatiText(R.get_yati()[0], R.get_yatiMode(), R.get_reverseYati());
        s = s + ((R.get_yati()[0].length === 1) ? ' \u0c2f\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41</li>' : ' \u0c2f\u0c24\u0c3f \u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41\u0c32\u0c41</li>');
      }
    }
    if (R.get_rowWiseRules()) {
      s = s + "<li><span class='gName'>\u0c17\u0c23 \u0c32\u0c15\u0c4d\u0c37\u0c23\u0c3e\u0c32\u0c41 :</span><ol>";
      for (var i = 0; i < R.get_rules().length; i++) {
        var LineRule = R.get_rules()[i];
        var PadamName = Chandam$Rules$CheatSheet._getPadamName(i + 1);
        s = s + '<li>' + PadamName + " \u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c28\u0c02\u0c26\u0c41 <span class='gName'>";
        s = s + Chandam$Rules$CheatSheet._getPadamRuleText(R.get_ruleType(), R.get_infiniteLength(), LineRule);
        s = s + '</span> \u0c17\u0c23\u0c2e\u0c41\u0c32\u0c41\u0c02\u0c21\u0c41\u0c28\u0c41.</li>';
      }
      s = s + '</ol></li>';
    }
    else {
      s = s + "<li>\u0c2a\u0c4d\u0c30\u0c24\u0c3f \u0c2a\u0c3e\u0c26\u0c2e\u0c41\u0c28\u0c02\u0c26\u0c41 <span class='gName'>";
      s = s + Chandam$Rules$CheatSheet._getPadamRuleText(R.get_ruleType(), R.get_infiniteLength(), R.get_rules()[0]);
      s = s + '</span> \u0c17\u0c23\u0c2e\u0c41\u0c32\u0c41\u0c02\u0c21\u0c41\u0c28\u0c41.</li>';
    }
    if (includeExamples) {
      s = s + "<li><span class='gName'>\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41:</span>";
      if (!R.get_examples2().length) {
        s = s + ' \u0c05\u0c02\u0c26\u0c41\u0c2c\u0c3e\u0c1f\u0c41\u0c32\u0c4b \u0c32\u0c47\u0c35\u0c41. ';
      }
      s = s + '<ol>';
      var $enum1 = ss.enumerate(R.get_examples2());
      while ($enum1.moveNext()) {
        var ex = $enum1.current;
        s = s + '<li>' + Chandam$Rules$CheatSheet._tryMatch(ex.get_text(), R) + '</li>';
      }
      s = s + '</ol></li>';
    }
    s = s + '</ol>';
    return s;
  };
  Chandam$Rules$CheatSheet._tryMatch = function(s, R) {
    if (s == null || !s.trim().length) {
      return '';
    }
    return ss.replaceString(s, '\n', '<br/>');
  };
  Chandam$Rules$CheatSheet._colorFul = function(series) {
    return ss.replaceString(ss.replaceString(series, '|', " <span class='laghu'>I</span> "), 'U', " <span class='guru'>U</span> ");
  };
  Chandam$Rules$CheatSheet._matraSreni2 = function(Sequence, x, y) {
    var s = '';
    var tot = 0;
    var target = x;
    if (Sequence.length < target) {
      return '';
    }
    var done = 0;
    for (var i = 0; i < Sequence.length; i++) {
      if (tot > target) {
        return '';
      }
      if (tot === target) {
        tot = 0;
        s = s + '-';
        target = (target === x) ? y : x;
        done++;
      }
      tot = tot + ((MiriyamUtil.StringPlus.charAt(Sequence, i) === '|') ? 1 : 2);
      s = s + MiriyamUtil.StringPlus.charAt(Sequence, i);
    }
    if (tot > target || done < 2) {
      return '';
    }
    return s;
  };
  Chandam$Rules$CheatSheet.matraSreni = function(Sequence, target) {
    var s = '';
    var tot = 0;
    if (Sequence.length < target) {
      return '';
    }
    for (var i = 0; i < Sequence.length; i++) {
      if (tot > target) {
        return null;
      }
      if (tot === target) {
        tot = 0;
        s = s + '-';
      }
      tot = tot + ((MiriyamUtil.StringPlus.charAt(Sequence, i) === '|') ? 1 : 2);
      s = s + MiriyamUtil.StringPlus.charAt(Sequence, i);
    }
    if (tot > target) {
      return '';
    }
    return s;
  };
  Chandam$Rules$CheatSheet._availableSerieses = function(Sequence) {
    var temp = '';
    var seq = ss.replaceString(Sequence, '-', '');
    for (var i = 3; i <= 6; i++) {
      var _m = Chandam$Rules$CheatSheet.matraSreni(seq, i);
      if (!_m || _m == null) {
        continue;
      }
      temp = temp + '<li> ' + Chandam$Rules$CheatSheet._matraSreniName(i) + ': ' + Chandam$Rules$CheatSheet._colorFul(_m) + '</li>';
    }
    var $enum1 = ss.enumerate([ [ 3, 4 ], [ 3, 5 ], [ 4, 5 ] ]);
    while ($enum1.moveNext()) {
      var D = $enum1.current;
      var x = D[0];
      var y = D[1];
      var _m = Chandam$Rules$CheatSheet._matraSreni2(seq, x, y);
      if (!!_m) {
        temp = temp + '<li> ' + Chandam$Rules$CheatSheet._matraSreniName2(x, y) + ': ' + Chandam$Rules$CheatSheet._colorFul(_m) + '</li>';
      }
      x = D[1];
      y = D[0];
      _m = Chandam$Rules$CheatSheet._matraSreni2(seq, x, y);
      if (!!_m) {
        temp = temp + '<li> ' + Chandam$Rules$CheatSheet._matraSreniName2(x, y) + ': ' + Chandam$Rules$CheatSheet._colorFul(_m) + '</li>';
      }
    }
    if (!!temp) {
      temp = '<ul>' + temp + '</ul>';
    }
    return temp;
  };
  Chandam$Rules$CheatSheet._matraSreniName2 = function(x, y) {
    return '\u0c2e\u0c3f\u0c36\u0c4d\u0c30\u0c17\u0c24\u0c3f \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f (' + x + '-' + y + ') ';
  };
  Chandam$Rules$CheatSheet._matraSreniName = function(n) {
    switch (n) {
      case 3:
        return '\u0c24\u0c4d\u0c30\u0c3f\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f';
      case 4:
        return '\u0c1a\u0c24\u0c41\u0c30\u0c4d\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f';
      case 5:
        return '\u0c2a\u0c02\u0c1a\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f';
      case 6:
        return '\u0c37\u0c23\u0c4d\u0c2e\u0c3e\u0c24\u0c4d\u0c30\u0c3e \u0c36\u0c4d\u0c30\u0c47\u0c23\u0c3f';
      default:
        return '';
    }
  };
  var Chandam$Rules$CheatSheet$ = {

  };


  // Chandam.Rules.SortHelper2

  function Chandam$Rules$SortHelper2() {
  }
  Chandam$Rules$SortHelper2.top = function(L) {
    var r = L.slice(0);
    r.sort(function(r1, r2) {
      var R1 = (r1);
      var R2 = (r2);
      var l1 = R1.get_percentage();
      var l2 = R2.get_percentage();
      return (l1 > l2) ? -1 : (l1 < l2) ? 1 : 0;
    });
    return r;
  };
  var Chandam$Rules$SortHelper2$ = {

  };


  // Library.Chandam.Labs.MachinePoem

  function Library$Chandam$Labs$MachinePoem() {
    this._lang = 0;
    this._w = [ [ '\u0c38', '\u0c30\u0c3f', '\u0c17', '\u0c2e', '\u0c2a', '\u0c26', '\u0c28\u0c3f' ], [ '\u0c38\u0c3e', '\u0c30\u0c40', '\u0c17\u0c3e', '\u0c2e\u0c3e', '\u0c2a\u0c3e', '\u0c26\u0c3e', '\u0c28\u0c40' ] ];
    this._temp = -1;
    this._lang = MiriyamUtil.RuleLanguage.telugu;
  }
  var Library$Chandam$Labs$MachinePoem$ = {
    build: function(identifier) {
      var R = MiriyamUtil.Manager.fetchRule(identifier);
      var s = this._write(R);
      return s;
    },
    _write: function(Rule) {
      this._r = new Chandam$Random();
      this._y = new Chandam$Core$YatiPrasaChecker2();
      var s = (Rule.get_identifier() === 'kandam') ? this._generateKandam() : this._generateVruttam(Rule);
      return s;
    },
    _generateVruttam: function(Rules) {
      var s = '';
      var g = 1;
      var localG = 1;
      var line = 1;
      var prasa = '';
      var yati = '';
      var l = (Rules.get_rowWiseRules()) ? 1 : Rules.get_lines();
      for (var i = 0; i < l; i++) {
        var $enum1 = ss.enumerate(Rules.get_rules());
        while ($enum1.moveNext()) {
          var LineRule = $enum1.current;
          localG = 1;
          var $enum2 = ss.enumerate(LineRule);
          while ($enum2.moveNext()) {
            var Rule = $enum2.current;
            var nm = Rule;
            var p = 0;
            this._temp = 0;
            var NextYati = this._findNextYati(Rules.get_yati(), Rules.get_yatiMode(), Rules.get_yatiRecycle(), localG);
            p = this._temp;
            var curr = '';
            var PrasaG = (g > 1 && localG === 1);
            var YatiG = (NextYati === localG);
            if (PrasaG) {
              curr = this._prasaString2(nm, prasa);
            }
            if (YatiG) {
              curr = this._yatiString(nm, yati, p);
            }
            if (!PrasaG && !YatiG) {
              curr = this._stringWith1(nm);
            }
            s = s + curr;
            if (g === 1 && curr.indexOf(',') >= 0) {
              prasa = curr.split(',')[1];
            }
            if (localG === 1 && curr.indexOf(',') >= 0) {
              yati = curr.split(',')[0];
            }
            g++;
            localG++;
          }
          s = s + '\n';
          line++;
        }
      }
      return ss.replaceString(s, ',', '');
    },
    _findNextYati: function(YYY, yatiMode, recycle, localG) {
      var next = 0;
      if (YYY.length > 1 || !YYY.length) {
        return 0;
      }
      var YY = YYY[0];
      var $enum1 = ss.enumerate(YY);
      while ($enum1.moveNext()) {
        var y = $enum1.current;
        if (yatiMode === MiriyamUtil.YatiMode.charPosition) {
          var afterGan = Math.floor(y / 3);
          var pos = y % 3;
          if (afterGan + 1 < localG) {
            continue;
          }
          if (afterGan + 1 > next) {
            if (!pos) {
              this._temp = 2;
              return afterGan;
            }
            else {
              this._temp = pos - 1;
              return afterGan + 1;
            }
          }
        }
      }
      return next;
    },
    _generateKandam: function() {
      var s = '';
      var Rules = MiriyamUtil.Manager.fetchRule('kandam');
      if (Rules == null) {
        return 'Not available';
      }
      var g = 1;
      var localG = 1;
      var line = 1;
      var prasa = '';
      var yati = '';
      var $enum1 = ss.enumerate(Rules.get_rules());
      while ($enum1.moveNext()) {
        var LineRule = $enum1.current;
        localG = 1;
        var $enum2 = ss.enumerate(LineRule);
        while ($enum2.moveNext()) {
          var Rule = $enum2.current;
          var w = Rule;
          var curr = '';
          var PrasaG = (g > 1 && localG === 1);
          var YatiG = ((line === 2 || line === 4) && (localG === 4));
          if (g % 2 === 1) {
            if (PrasaG) {
              curr = this._prasaString3(w, prasa, '\u0c1c');
            }
            if (YatiG) {
              curr = this._yatiString3(w, yati, '\u0c1c');
            }
            if (!PrasaG && !YatiG) {
              curr = this._stringWith2(w, '\u0c1c');
            }
          }
          else {
            if (g === 6) {
              var _LL = [];
              _LL.push('\u0c28\u0c32');
              _LL.push('\u0c1c');
              curr = this._stringWith(w, yati, _LL);
            }
            else {
              if (PrasaG) {
                curr = this._prasaString(w, prasa);
              }
              if (YatiG) {
                curr = this._yatiString2(w, yati);
              }
              if (!PrasaG && !YatiG) {
                if (((line === 2 || line === 4) & localG === 5) === 1) {
                  curr = ss.replaceString(this._stringWith_i(2), ' ', '') + this._singleAkshar(2);
                }
                else {
                  curr = this._stringWith_i(w);
                }
              }
            }
          }
          s = s + curr;
          if (g === 1) {
            prasa = curr.split(',')[1];
          }
          if (localG === 1) {
            yati = curr.split(',')[0];
          }
          g++;
          localG++;
        }
        s = s + '\n';
        line++;
      }
      return ss.replaceString(s, ',', '');
    },
    _stringWith: function(w, yati, whiteList) {
      var s = '';
      var nm = '';
      while (!(whiteList.indexOf(nm) >= 0)) {
        s = this._yatiString2(w, yati);
        var G = new Chandam$Core$GanaVibhajana(s, this._lang);
        nm = MiriyamUtil.GDefinition.gName(ss.replaceString(G.get_symbolsStream(), ' ', '')).trim();
      }
      return s;
    },
    _yatiString3: function(w, yati, blackList) {
      var s = '';
      var nm = blackList;
      while (nm === blackList) {
        s = this._yatiString2(w, yati);
        var G = new Chandam$Core$GanaVibhajana(s, this._lang);
        nm = MiriyamUtil.GDefinition.gName(ss.replaceString(G.get_symbolsStream(), ' ', '')).trim();
      }
      return s;
    },
    _prasaString3: function(w, prasa, blackList) {
      var s = '';
      var nm = blackList;
      while (nm === blackList) {
        s = this._prasaString(w, prasa);
        var G = new Chandam$Core$GanaVibhajana(s, this._lang);
        nm = MiriyamUtil.GDefinition.gName(ss.replaceString(G.get_symbolsStream(), ' ', '')).trim();
      }
      return s;
    },
    _prasaString2: function(nm, prasa) {
      if (!prasa) {
        return this._stringWith1(nm);
      }
      var s = '';
      var matched = false;
      while (!matched) {
        s = this._stringWith1(nm);
        var lp = s.split(',')[1];
        matched = this._y.isPrasaMatched(lp, prasa);
      }
      return s;
    },
    _yatiString: function(nm, yati, p) {
      var s = '';
      var matched = false;
      while (!matched) {
        s = this._stringWith1(nm);
        var lp = s.split(',')[p];
        matched = this._y.isYatiMatched(lp, yati);
      }
      return s;
    },
    _stringWith1: function(nm) {
      var thresold = MiriyamUtil.GDefinition.threshold2(nm);
      var curr = nm;
      var s = '';
      var sym = MiriyamUtil.GDefinition.getSymbols(nm);
      s = '';
      for (var i = 0; i < thresold; i++) {
        var index = (sym[i] === '|') ? 0 : 1;
        var Selected = this._w[index];
        var t = Selected[this._r._next(Selected.length)];
        s = s + ((!i) ? '' : ',') + t;
      }
      return s + ' ';
    },
    _singleAkshar: function(w) {
      var Selected = this._w[w - 1];
      var t = Selected[this._r._next(Selected.length)];
      return t;
    },
    _yatiString2: function(w, yati) {
      var s = '';
      var matched = false;
      while (!matched) {
        s = this._stringWith_i(w);
        var lp = s.split(',')[0];
        matched = this._y.isYatiMatched(lp, yati);
      }
      return s;
    },
    _prasaString: function(w, prasa) {
      var s = '';
      var matched = false;
      while (!matched) {
        s = this._stringWith_i(w);
        var lp = s.split(',')[1];
        matched = this._y.isPrasaMatched(lp, prasa);
      }
      return s;
    },
    _stringWith_i: function(w) {
      var s = '';
      var tot = 0;
      while (tot !== w) {
        var index = this._r._next(this._w.length);
        var Selected = this._w[index];
        var t = Selected[this._r._next(Selected.length)];
        var weight = this._getWeight(t);
        if (weight + tot <= w) {
          s = s + ((!tot) ? '' : ',') + t;
          tot = weight + tot;
        }
      }
      s = s + ' ';
      return s;
    },
    _stringWith2: function(w, blackList) {
      var s = '';
      var nm = blackList;
      while (nm === blackList) {
        s = this._stringWith_i(w);
        var G = new Chandam$Core$GanaVibhajana(s, this._lang);
        nm = MiriyamUtil.GDefinition.gName(ss.replaceString(G.get_symbolsStream(), ' ', '')).trim();
      }
      return s;
    },
    _stringWithList: function(w, whiteList) {
      var s = '';
      var nm = '';
      while (!(whiteList.indexOf(nm) >= 0)) {
        s = this._stringWith_i(w);
        var G = new Chandam$Core$GanaVibhajana(s, this._lang);
        nm = MiriyamUtil.GDefinition.gName(ss.replaceString(G.get_symbolsStream(), ' ', '')).trim();
      }
      return s;
    },
    _getWeight: function(s) {
      switch (s) {
        case '\u0c38':
        case '\u0c30\u0c3f':
        case '\u0c17':
        case '\u0c2e':
        case '\u0c2a':
        case '\u0c26':
        case '\u0c28\u0c3f':
          return 1;
        case '\u0c38\u0c3e':
        case '\u0c30\u0c40':
        case '\u0c17\u0c3e':
        case '\u0c2e\u0c3e':
        case '\u0c2a\u0c3e':
        case '\u0c26\u0c3e':
        case '\u0c28\u0c40':
          return 2;
      }
      return 0;
    }
  };


  // Chandam.Reports.BarGraph

  function Chandam$Reports$BarGraph() {
  }
  Chandam$Reports$BarGraph.buildGraph = function(L) {
    var s = '<h2>' + L.title + '</h2>';
    var $enum1 = ss.enumerate(L.values);
    while ($enum1.moveNext()) {
      var B = $enum1.current;
      s = s + ss.format("<li style='background-color:#222;border:solid 1px black; color:white;'>\r\n\t\t\t\t\t\t\t\t\t\t<div style='width:{0}%; background-color:{1}; padding-left:5px;'>\r\n\t\t\t\t\t\t\t\t\t\t<nobr>\r\n\t\t\t\t\t\t\t\t\t\t\t{2}\r\n\t\t\t\t\t\t\t\t\t\t</nobr>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</li><br/>", B.value, B.color, B.title);
    }
    s = '<ul>' + s + '</ul>';
    return s;
  };
  var Chandam$Reports$BarGraph$ = {
    add: function(B) {
      if (this.values == null) {
        this.values = [];
      }
      this.values.push(B);
    }
  };


  // Chandam.Reports.BarGraphValue

  function Chandam$Reports$BarGraphValue() {
    this.value = 0;
  }
  var Chandam$Reports$BarGraphValue$ = {

  };


  // Library.Reports.ChandamReports

  function Library$Reports$ChandamReports() {
    this._tot = 0;
  }
  var Library$Reports$ChandamReports$ = {
    pendingWork: function() {
      var s = '';
      s = s + this._getExamplesYatiReport();
      s = s + this._getExamplesReport2();
      s = s + this._getExamplesReport();
      s = s + this._getYatiReport();
      s = s + this._listMissingData();
      return s;
    },
    _listMissingData: function() {
      var s1 = '';
      var s2 = '';
      var s3 = '';
      var $enum1 = ss.enumerate(MiriyamUtil.RuleHelper.getAllRules(true));
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        var f2 = R.get_yati().length > 0 || (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && R.get_charLength() <= 10);
        var f1 = !R.get_examples().length;
        f2 = !f2;
        var h = '<li>' + R.get_name() + ((!R.get_chandamName()) ? '' : '(' + R.get_chandamName() + ')') + '</li>';
        if (f1) {
          s1 = s1 + h;
        }
        if (f2) {
          s2 = s2 + h;
        }
        if (f1 && f2) {
          s3 = s3 + h;
        }
      }
      return '<h2>\u0c2f\u0c24\u0c3f+\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c32\u0c47\u0c28\u0c3f\u0c35\u0c3f</h2><ol>' + s3 + '</ol>' + '<h2>\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c32\u0c47\u0c28\u0c3f\u0c35\u0c3f</h2><ol>' + s1 + '</ol>' + '<h2>\u0c2f\u0c24\u0c3f \u0c32\u0c47\u0c28\u0c3f\u0c35\u0c3f</h2><ol>' + s2 + '</ol>';
    },
    _getExamplesYatiReport: function() {
      this._tot = 0;
      var YatiData = this._getExamplesYatiData();
      var L = new Chandam$Reports$BarGraph();
      L.title = '\u0c2f\u0c24\u0c3f+\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41';
      for (var i = 0; i < YatiData.length; i++) {
        var B = new Chandam$Reports$BarGraphValue();
        B.value = (YatiData[i] * 100) / this._tot;
        B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41  \u0c2f\u0c24\u0c41\u0c32\u0c41+\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 <b>{1}</b>', YatiData[i], (!i) ? '\u0c15\u0c32\u0c35\u0c41' : '\u0c32\u0c47\u0c35\u0c41');
        B.color = ((!i) ? 'Green' : 'Red');
        L.add(B);
      }
      return Chandam$Reports$BarGraph.buildGraph(L);
    },
    _getExamplesReport: function() {
      this._tot = 0;
      var Examples = this._getExamplesData();
      var L = new Chandam$Reports$BarGraph();
      L.title = '\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41';
      for (var i = 0; i < Examples.length; i++) {
        var B = new Chandam$Reports$BarGraphValue();
        B.value = (Examples[i] * 100) / this._tot;
        switch (i) {
          case 0:
            B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c32\u0c47\u0c35\u0c41.', Examples[i]);
            break;
          default:
            if (i > 5) {
              B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 <b>5</b> \u0c15\u0c02\u0c1f\u0c47 \u0c0e\u0c15\u0c4d\u0c15\u0c41\u0c35 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c15\u0c32\u0c35\u0c41.', Examples[i]);
            }
            else {
              B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 <b>{1}</b> \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c15\u0c32\u0c35\u0c41.', Examples[i], i);
            }
            break;
        }
        B.color = this._colorCode(i);
        L.add(B);
      }
      return Chandam$Reports$BarGraph.buildGraph(L);
    },
    _getExamplesReport2: function() {
      this._tot = 0;
      var Examples = this._getExamplesData2();
      var L = new Chandam$Reports$BarGraph();
      L.title = '\u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41';
      for (var i = 0; i < Examples.length; i++) {
        var B = new Chandam$Reports$BarGraphValue();
        B.value = (Examples[i] * 100) / this._tot;
        switch (i) {
          case 0:
            B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 \u0c15\u0c28\u0c40\u0c38\u0c02 \u0c12\u0c15\u0c4d\u0c15 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23 \u0c15\u0c42\u0c21\u0c3e \u0c32\u0c47\u0c26\u0c41.', Examples[i], i);
            break;
          case 5:
            B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 <b>{1}</b> \u0c32\u0c47\u0c26\u0c3e \u0c05\u0c02\u0c24\u0c15\u0c02\u0c1f\u0c47 \u0c0e\u0c15\u0c4d\u0c15\u0c41\u0c35 \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c15\u0c32\u0c35\u0c41.', Examples[i], i);
            break;
          default:
            B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41 \u0c15\u0c28\u0c40\u0c38\u0c02 <b>{1}</b> \u0c09\u0c26\u0c3e\u0c39\u0c30\u0c23\u0c32\u0c41 \u0c15\u0c32\u0c35\u0c41.', Examples[i], i);
            break;
        }
        B.color = this._colorCode(i);
        L.add(B);
      }
      return Chandam$Reports$BarGraph.buildGraph(L);
    },
    _getExamplesData: function() {
      var Examples = [ 0, 0, 0, 0, 0, 0, 0 ];
      var $enum1 = ss.enumerate(MiriyamUtil.RuleHelper.getAllRules(true));
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        this._tot++;
        if (R.get_examples().length > 5) {
          Examples[6]++;
          continue;
        }
        if (!R.get_examples().length) {
        }
        Examples[R.get_examples().length]++;
      }
      return Examples;
    },
    _getExamplesData2: function() {
      var Examples = this._getExamplesData();
      var N = [ Examples[0], 0, 0, 0, 0, 0 ];
      for (var i = 1; i < Examples.length - 1; i++) {
        for (var j = i; j < Examples.length; j++) {
          if (i >= 5) {
            N[5] = N[5] + Examples[j];
            continue;
          }
          N[i] = N[i] + Examples[j];
        }
      }
      return N;
    },
    _getYatiReport: function() {
      this._tot = 0;
      var YatiData = this._getYatiData();
      var L = new Chandam$Reports$BarGraph();
      L.title = '\u0c2f\u0c24\u0c3f';
      for (var i = 0; i < YatiData.length; i++) {
        var B = new Chandam$Reports$BarGraphValue();
        B.value = (YatiData[i] * 100) / this._tot;
        B.title = ss.format('<b>{0}</b> \u0c2a\u0c26\u0c4d\u0c2f\u0c30\u0c15\u0c3e\u0c32\u0c15\u0c41  \u0c2f\u0c24\u0c41\u0c32\u0c41 <b>{1}</b>', YatiData[i], (!!i) ? '\u0c15\u0c32\u0c35\u0c41' : '\u0c32\u0c47\u0c35\u0c41');
        B.color = ((!i) ? 'Red' : 'Green');
        L.add(B);
      }
      return Chandam$Reports$BarGraph.buildGraph(L);
    },
    _getYatiData: function() {
      var Examples = [ 0, 0 ];
      var $enum1 = ss.enumerate(MiriyamUtil.RuleHelper.getAllRules(true));
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        this._tot++;
        var f = R.get_yati().length > 0 || (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && R.get_charLength() <= 10);
        if (f) {
          Examples[1]++;
          continue;
        }
        Examples[0]++;
      }
      return Examples;
    },
    _getExamplesYatiData: function() {
      var Examples = [ 0, 0 ];
      var $enum1 = ss.enumerate(MiriyamUtil.RuleHelper.getAllRules(true));
      while ($enum1.moveNext()) {
        var R = $enum1.current;
        this._tot++;
        var f1 = R.get_yati().length > 0 || (R.get_padyamType() === MiriyamUtil.PadyamType.vruttam && R.get_charLength() <= 10);
        var f2 = !R.get_examples().length;
        f1 = !f1;
        if (f1 && f2) {
          Examples[1]++;
          continue;
        }
        Examples[0]++;
      }
      return Examples;
    },
    _colorCode: function(i) {
      switch (i) {
        case 0:
          return 'Red';
        case 1:
          return '#AC193D';
        case 2:
          return '#D24726';
        case 3:
          return '#8C0095';
        default:
          return '#008299';
        case 5:
        case 6:
        case 7:
          return 'Green';
      }
    }
  };


  // Chandam.Extensions.YatiPrasaTester

  function Chandam$Extensions$YatiPrasaTester() {
    this._lang = 0;
    this._lang = MiriyamUtil.RuleLanguage.telugu;
  }
  var Chandam$Extensions$YatiPrasaTester$ = {
    checkPrasa: function(s1, s2, allowSantiPrasa) {
      var Y = new Chandam$Core$YatiPrasaChecker2();
      s1 = ss.replaceString(s1, ' ', '');
      s2 = ss.replaceString(s2, ' ', '');
      Y.set_allowSantiPrasa(allowSantiPrasa);
      Y.set_soundexSandhi(false);
      var G1 = new Chandam$Core$GanaVibhajana(s1, this._lang);
      var G2 = new Chandam$Core$GanaVibhajana(s2, this._lang);
      if (!G1.get_gWiseString().length) {
        return "<span class='gName'>Group-1 is not valid</span>";
      }
      if (!G2.get_gWiseString().length) {
        return "<span class='gName'>Group-2 is not valid</span>";
      }
      var f = false;
      if (G1.get_gWiseString().length > 1 && G2.get_gWiseString().length > 1) {
        this.p1 = G1.get_gWiseString()[0] + '<u>' + G1.get_gWiseString()[1] + '</u>';
        this.p2 = G2.get_gWiseString()[0] + '<u>' + G2.get_gWiseString()[1] + '</u>';
        var P1 = new Chandam$Core$Prasa(MiriyamUtil.StringPlus.charAt(G1.get_symbolsStream(), 0).toString(), false, G1.get_gWiseString()[1], G1.get_gWiseString()[0]);
        var P2 = new Chandam$Core$Prasa(MiriyamUtil.StringPlus.charAt(G2.get_symbolsStream(), 0).toString(), false, G2.get_gWiseString()[1], G2.get_gWiseString()[0]);
        f = Y.isPrasaMatched3(P1, P2);
        if (f && Y.get_noMoreChecks()) {
          return this._success(this.p1, this.p2, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'", Y.get_lastName());
        }
        if (f) {
          if (P1.get_symbol() === MiriyamUtil.Symbols.LAGHUVU) {
          }
          else {
            f = (P1.get_symbol() === P2.get_symbol());
          }
        }
        if (f) {
          var E = this._checkPrasaPoorva2(Y, P1, P2);
          if (E == null) {
            return this._success(this.p1, this.p2, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'", Y.get_lastName());
          }
          return this._failWith(this.p1, this.p2, E, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'");
        }
        else {
          return this._failWith(this.p1, this.p2, null, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'");
        }
      }
      else {
        this.p1 = G1.get_gWiseString()[0];
        this.p2 = G2.get_gWiseString()[0];
        f = Y.isPrasaMatched(this.p1, this.p2);
        if (f) {
          return this._success(this.p1, this.p2, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'", Y.get_lastName());
        }
      }
      return this._failWith(this.p1, this.p2, null, "'\u0c2a\u0c4d\u0c30\u0c3e\u0c38'");
    },
    checkYati: function(s1, s2, Sandhi) {
      var G1 = new Chandam$Core$GanaVibhajana(s1, this._lang);
      var G2 = new Chandam$Core$GanaVibhajana(s2, this._lang);
      if (!G1.get_gWiseString().length) {
        return "<span class='gName'>Group-1 is not valid</span>";
      }
      if (!G2.get_gWiseString().length) {
        return "<span class='gName'>Group-2 is not valid</span>";
      }
      var c1 = null;
      var y1 = null;
      var py1 = null;
      var c2 = null;
      var y2 = null;
      var py2 = null;
      var YPC = new Chandam$Core$YatiPrasaChecker2();
      YPC.set_soundexSandhi(Sandhi);
      if (G1.get_gWiseString().length === 3) {
        c1 = (MiriyamUtil.StringPlus.endsWith(G1.get_gWiseString()[0], '\u0c02')) ? '\u0c02' : null;
        y1 = G1.get_gWiseString()[1];
        py1 = G1.get_gWiseString()[2];
        this.p1 = (c1 != null) ? G1.get_gWiseString()[0] + G1.get_gWiseString()[1] : G1.get_gWiseString()[1];
        this.p1 = this.p1 + G1.get_gWiseString()[2];
      }
      if (G1.get_gWiseString().length === 2) {
        c1 = (MiriyamUtil.StringPlus.endsWith(G1.get_gWiseString()[0], '\u0c02')) ? '\u0c02' : null;
        y1 = G1.get_gWiseString()[1];
        this.p1 = (c1 != null) ? G1.get_gWiseString()[0] + G1.get_gWiseString()[1] : G1.get_gWiseString()[1];
      }
      if (G2.get_gWiseString().length === 3) {
        c2 = (MiriyamUtil.StringPlus.endsWith(G2.get_gWiseString()[0], '\u0c02')) ? '\u0c02' : null;
        y2 = G2.get_gWiseString()[1];
        py2 = G2.get_gWiseString()[2];
        this.p2 = (c2 != null) ? G2.get_gWiseString()[0] + G2.get_gWiseString()[1] : G2.get_gWiseString()[1];
        this.p2 = this.p2 + G2.get_gWiseString()[2];
      }
      if (G1.get_gWiseString().length === 1) {
        y1 = G1.get_gWiseString()[0];
        this.p1 = G1.get_gWiseString()[0];
      }
      if (G2.get_gWiseString().length === 2) {
        c2 = (MiriyamUtil.StringPlus.endsWith(G2.get_gWiseString()[0], '\u0c02')) ? '\u0c02' : null;
        y2 = G2.get_gWiseString()[1];
        this.p2 = (c2 != null) ? G2.get_gWiseString()[0] + G2.get_gWiseString()[1] : G2.get_gWiseString()[1];
      }
      if (G2.get_gWiseString().length === 1) {
        y2 = G2.get_gWiseString()[0];
        this.p2 = G2.get_gWiseString()[0];
      }
      var res = YPC.isYatiMatched(this.p1, this.p2);
      if (res) {
        return this._success(this.p1, this.p2, "'\u0c2f\u0c24\u0c3f'", YPC.get_lastName());
      }
      else {
        if (G1.get_gWiseString().length === 2) {
          y1 = G1.get_gWiseString()[0];
          py1 = G1.get_gWiseString()[1];
        }
        if (G2.get_gWiseString().length === 2) {
          y2 = G2.get_gWiseString()[0];
          py2 = G2.get_gWiseString()[1];
        }
        res = YPC.isYatiMatched(y1, y2);
        if (res) {
          return this._success(y1, y2, "'\u0c2f\u0c24\u0c3f'", YPC.get_lastName());
        }
        else {
          var s = this._failWith(this.p1, this.p2, null, "'\u0c2f\u0c24\u0c3f'");
          if (G1.get_gWiseString().length > 1 && G2.get_gWiseString().length > 1) {
            s = s + '<br/>\u0c05\u0c02\u0c26\u0c41\u0c35\u0c32\u0c4d\u0c32 \u0c2a\u0c4d\u0c30\u0c3e\u0c38 \u0c2f\u0c24\u0c3f \u0c38\u0c30\u0c3f \u0c2a\u0c4b\u0c24\u0c41\u0c02\u0c26\u0c47\u0c2e\u0c4b \u0c1a\u0c42\u0c38\u0c4d\u0c24\u0c41\u0c28\u0c4d\u0c28\u0c3e<br/>';
            s = s + this.checkPrasa(py1, py2, false);
          }
          return s;
        }
      }
    },
    _checkPrasaPoorva2: function(Y, p1, p2) {
      var SUNNA = '\u0c02';
      var VISARGA = '\u0c03';
      if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === SUNNA) {
        if (MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === SUNNA) {
          Y.set_lastName((Y.get_lastName() == null) ? '\u0c2c\u0c3f\u0c02\u0c26\u0c41\u0c2a\u0c42\u0c30\u0c4d\u0c35\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41' : Y.get_lastName() + '(\u0c35\u0c3f\u0c38\u0c30\u0c4d\u0c17\u0c2a\u0c42\u0c30\u0c4d\u0c35\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41)');
          return null;
        }
        else {
          var E = new Chandam$Core$Errors();
          E.set_actual(p1.get_value());
          E.set_expected("'" + SUNNA + "'  \u0c24\u0c4b \u0c15\u0c42\u0c21\u0c3f\u0c28 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02");
          E.set_mismatch((p1.get_isAnthyaPrasa()) ? MiriyamUtil.Mismatch.anthyaPrasaPoorvaBindu : MiriyamUtil.Mismatch.prasaPoorvaBindu);
          return E;
        }
      }
      else {
        if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === VISARGA) {
          if (MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === VISARGA) {
            Y.set_lastName((Y.get_lastName() == null) ? '\u0c35\u0c3f\u0c38\u0c30\u0c4d\u0c17\u0c2a\u0c42\u0c30\u0c4d\u0c35\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41' : Y.get_lastName() + '(\u0c35\u0c3f\u0c38\u0c30\u0c4d\u0c17\u0c2a\u0c42\u0c30\u0c4d\u0c35\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41)');
            return null;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(p1.get_value());
            E.set_expected("'" + VISARGA + "'  \u0c24\u0c4b \u0c15\u0c42\u0c21\u0c3f\u0c28 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02");
            E.set_mismatch((p1.get_isAnthyaPrasa()) ? MiriyamUtil.Mismatch.anthyaPrasaPoorvaVisarga : MiriyamUtil.Mismatch.prasaPoorvaVisarga);
            return E;
          }
        }
      }
      return null;
    },
    _yatiMatcher: function(p1, p2) {
      return new Chandam$Core$YatiPrasaChecker2().isYatiMatched(p1, p2);
    },
    _success: function(s1, s2, objective, which) {
      return "<span class='gName'>" + s1 + "</span> , <span class='gName'>" + s2 + '</span> \u0c32\u0c15\u0c41  ' + objective + ' \u0c38\u0c30\u0c3f\u0c2a\u0c4b\u0c2f\u0c3f\u0c02\u0c26\u0c3f.<br/> \u0c0f ' + objective + ": <span class='gName'>" + ((which == null) ? '--' : which) + '</span> ';
    },
    _failWith: function(s1, s2, E, objective) {
      var s = "<span class='gName'>" + s1 + "</span> , <span class='gName'>" + s2 + '</span> \u0c32\u0c15\u0c41  ' + objective + ' \u0c38\u0c30\u0c3f\u0c2a\u0c4b\u0c32\u0c47\u0c26\u0c41.';
      if (E != null) {
        s = s + '<br/> \u0c15\u0c3e\u0c30\u0c23\u0c02: ' + "<span class='gName'>" + E.get_expected() + '</span>';
      }
      return s;
    }
  };


  // Chandam.Core.Errors

  function Chandam$Core$Errors() {
    this._line = 0;
    this._r = 0;
    this._Position = 0;
  }
  var Chandam$Core$Errors$ = {
    get_position: function() {
      return this._Position;
    },
    set_position: function(value) {
      this._Position = value;
      return value;
    },
    get_mismatch: function() {
      return this._r;
    },
    set_mismatch: function(value) {
      this._r = value;
      return value;
    },
    get_line: function() {
      return this._line;
    },
    set_line: function(value) {
      this._line = value;
      return value;
    },
    get_expected: function() {
      return this._Expected;
    },
    set_expected: function(value) {
      this._Expected = value;
      return value;
    },
    get_actual: function() {
      return this._Actual;
    },
    set_actual: function(value) {
      this._Actual = value;
      return value;
    },
    get_remarks: function() {
      return this._remarks;
    },
    set_remarks: function(value) {
      this._remarks = value;
      return value;
    }
  };


  // Chandam.Core.MatchOptions

  function Chandam$Core$MatchOptions() {
    this._MatchYati = false;
    this._MatchPrasa = false;
    this._AllowSantiPrasa = false;
    this._QuickMatch = false;
    this._IncludeRare = false;
    this._ExperimenatalSandhi = false;
    this._lang = 0;
  }
  Chandam$Core$MatchOptions.get_qucikMatchSettings = function() {
    var Options = new Chandam$Core$MatchOptions();
    Options.set_allowSantiPrasa(false);
    Options.set_includeRare(true);
    Options.set_matchPrasa(true);
    Options.set_matchYati(true);
    Options.set_quickMatch(true);
    Options.set_experimenatalSandhi(true);
    Options.set_language(MiriyamUtil.RuleLanguage.telugu);
    return Options;
  };
  Chandam$Core$MatchOptions.get_tradtionalMatchSettings = function() {
    var Options = new Chandam$Core$MatchOptions();
    Options.set_allowSantiPrasa(false);
    Options.set_includeRare(true);
    Options.set_matchPrasa(true);
    Options.set_matchYati(true);
    Options.set_quickMatch(false);
    Options.set_experimenatalSandhi(true);
    Options.set_language(MiriyamUtil.RuleLanguage.telugu);
    return Options;
  };
  var Chandam$Core$MatchOptions$ = {
    get_experimenatalSandhi: function() {
      return this._ExperimenatalSandhi;
    },
    set_experimenatalSandhi: function(value) {
      this._ExperimenatalSandhi = value;
      return value;
    },
    get_includeRare: function() {
      return this._IncludeRare;
    },
    set_includeRare: function(value) {
      this._IncludeRare = value;
      return value;
    },
    get_quickMatch: function() {
      return this._QuickMatch;
    },
    set_quickMatch: function(value) {
      this._QuickMatch = value;
      return value;
    },
    get_matchYati: function() {
      return this._MatchYati;
    },
    set_matchYati: function(value) {
      this._MatchYati = value;
      return value;
    },
    get_matchPrasa: function() {
      return this._MatchPrasa;
    },
    set_matchPrasa: function(value) {
      this._MatchPrasa = value;
      return value;
    },
    get_allowSantiPrasa: function() {
      return this._AllowSantiPrasa;
    },
    set_allowSantiPrasa: function(value) {
      this._AllowSantiPrasa = value;
      return value;
    },
    get_language: function() {
      return this._lang;
    },
    set_language: function(value) {
      this._lang = value;
      return value;
    }
  };


  // Chandam.Core.MatchResult

  function Chandam$Core$MatchResult() {
    this._Score = 0;
    this._Total = 0;
    this.set_errors([]);
  }
  var Chandam$Core$MatchResult$ = {
    showErrors: function(F) {
      switch (F) {
        case MiriyamUtil.OutputFormat.text:
          return this._buildText();
        case MiriyamUtil.OutputFormat.HTML:
        default:
          return this._buildHTML();
      }
    },
    _buildText: function() {
      if (this.get_score() === this.get_total() || !this.get_total()) {
        return '';
      }
      var s = '';
      var $enum1 = ss.enumerate(this._l);
      while ($enum1.moveNext()) {
        var E = $enum1.current;
        s = s + ((E.get_mismatch() === MiriyamUtil.Mismatch.lines) ? '' : (E.get_line() === -1) ? '' : E.get_line().toString() + ' \u0c35 \u0c2a\u0c3e\u0c26\u0c2e\u0c41-') + ((E.get_mismatch() === MiriyamUtil.Mismatch.lines) ? '' : (E.get_position() === -1) ? '' : E.get_position().toString() + ' \u0c35 \u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41-') + '\u0c24\u0c2a\u0c4d\u0c2a\u0c41: ' + MiriyamUtil.Helper.mismatchString(E.get_mismatch()) + ' - ' + '\u0c15\u0c3e\u0c35\u0c32\u0c38\u0c3f\u0c28\u0c26\u0c3f: ' + E.get_expected() + ' - ' + '\u0c09\u0c28\u0c4d\u0c28\u0c26\u0c3f: ' + E.get_actual() + '(' + E.get_remarks() + ')';
        s = s + '\n';
      }
      return s;
    },
    _buildHTML: function() {
      if (this.get_score() === this.get_total() || !this.get_total()) {
        return '';
      }
      var s = "<table cellspacing='0'  border='1'  class='errTab'><thead><tr><th>\u0c2a\u0c3e\u0c26\u0c2e\u0c41</th><th>\u0c38\u0c4d\u0c25\u0c3e\u0c28\u0c2e\u0c41</th><th>\u0c24\u0c2a\u0c4d\u0c2a\u0c41 \u0c2a\u0c47\u0c30\u0c41</th><th>\u0c15\u0c3e\u0c35\u0c32\u0c38\u0c3f\u0c28\u0c26\u0c3f(\u0c35\u0c3f)</th><th>\u0c09\u0c28\u0c4d\u0c28\u0c26\u0c3f(\u0c35\u0c3f)</th></tr></thead><tbody>";
      var $enum1 = ss.enumerate(this._l);
      while ($enum1.moveNext()) {
        var E = $enum1.current;
        s = s + '<tr>' + '<td>' + ((E.get_mismatch() === MiriyamUtil.Mismatch.lines) ? '' : (E.get_line() === -1) ? '' : E.get_line().toString()) + '</td>' + '<td>' + ((E.get_mismatch() === MiriyamUtil.Mismatch.lines) ? '' : (E.get_position() === -1) ? '' : E.get_position().toString()) + '</td>' + '<td>' + MiriyamUtil.Helper.mismatchString(E.get_mismatch()) + '</td>' + '<td>' + E.get_expected() + '</td>' + '<td>' + E.get_actual() + '</td>' + '</tr>';
      }
      s = s + '</tbody></table>';
      return s;
    },
    get_score: function() {
      return this._Score;
    },
    set_score: function(value) {
      this._Score = value;
      return value;
    },
    get_total: function() {
      return this._Total;
    },
    set_total: function(value) {
      this._Total = value;
      return value;
    },
    get_errors: function() {
      return this._l;
    },
    set_errors: function(value) {
      this._l = value;
      return value;
    },
    get_isMatched: function() {
      return (this.get_score() === this.get_total());
    },
    get_percentage: function() {
      if (!this.get_total()) {
        return 0;
      }
      return (this.get_score() * 100) / this.get_total();
    },
    get_rule: function() {
      return this._matchedFor;
    },
    set_rule: function(value) {
      this._matchedFor = value;
      return value;
    }
  };


  // Chandam.Core.Padyam

  function Chandam$Core$Padyam() {
    this._tot = 0;
    this._score = 0;
    this._MR = null;
    this._MatchPrasa = false;
    this._MatchYati = false;
    this._AllowSantiPrasa = false;
    this._SandiMatch = false;
    this._YPC = new Chandam$Core$YatiPrasaChecker2();
  }
  Chandam$Core$Padyam.mostProbable = function(s, Options) {
    return Chandam$Core$Padyam.mostProbable2(s, Options, null);
  };
  Chandam$Core$Padyam.mostProbable2 = function(s, Options, Rules) {
    if (!s.trim().length) {
      return null;
    }
    var P = null;
    var score = 0;
    var G = new Chandam$Core$GanaVibhajana(s, Options.get_language());
    var min = G.get_min();
    var max = G.get_max();
    var includeRare = Options.get_includeRare();
    includeRare = true;
    var Results = [];
    if (Rules == null || !Rules.length) {
      Rules = (Options.get_quickMatch()) ? MiriyamUtil.RuleHelper.getAllRules2(min, max, G.get_preLines()) : MiriyamUtil.RuleHelper.getAllRules(includeRare);
    }
    if (!Rules.length) {
      Rules = MiriyamUtil.RuleHelper.getAllRules(includeRare);
    }
    var Rules2 = MiriyamUtil.Helper2.clone(Rules);
    var $enum1 = ss.enumerate(Rules2);
    while ($enum1.moveNext()) {
      var R = $enum1.current;
      var Padyam = new Chandam$Core$Padyam();
      Padyam.set_matchYati(Options.get_matchYati());
      Padyam.set_matchPrasa(Options.get_matchPrasa());
      Padyam.set_allowSantiPrasa(Options.get_allowSantiPrasa());
      Padyam.set_sandiMatch(Options.get_experimenatalSandhi());
      var MR = Padyam.match2(G.clone(), R);
      Results.push(MR);
      if (MR.get_percentage() >= score) {
        P = new Chandam$Core$Probable();
        P.set_padyam(Padyam);
        P.set_matchResult(MR);
        P.set_rule(R);
        if (MR.get_isMatched()) {
          return P;
        }
        score = MR.get_percentage();
      }
    }
    if (P != null) {
      P.set_candiates(Chandam$Rules$SortHelper2.top(Results));
    }
    else {
    }
    return P;
  };
  var Chandam$Core$Padyam$ = {
    get_matchYati: function() {
      return this._MatchYati;
    },
    set_matchYati: function(value) {
      this._MatchYati = value;
      return value;
    },
    get_matchPrasa: function() {
      return this._MatchPrasa;
    },
    set_matchPrasa: function(value) {
      this._MatchPrasa = value;
      return value;
    },
    get_allowSantiPrasa: function() {
      return this._AllowSantiPrasa;
    },
    set_allowSantiPrasa: function(value) {
      this._AllowSantiPrasa = value;
      this._YPC.set_allowSantiPrasa(value);
      return value;
    },
    get_sandiMatch: function() {
      return this._SandiMatch;
    },
    set_sandiMatch: function(value) {
      this._SandiMatch = value;
      this._YPC.set_soundexSandhi(value);
      return value;
    },
    match2: function(_G, Rule) {
      this._s = _G.get_rawString();
      this._g = _G;
      this._r = Rule;
      this._analyse();
      return this._matchInternal();
    },
    match: function(str, Rule) {
      this._s = str;
      this._g = new Chandam$Core$GanaVibhajana(this._s, Rule.get_language());
      this._r = Rule;
      this._analyse();
      return this._matchInternal();
    },
    _matchInternal: function() {
      if (this._r.get_identifier() === 'GenricVruttam') {
        this._r.set_lines(this._g.get_lines());
        var Names = this._g.get_gNamesStream().split('\n');
        if (Names.length >= 0) {
          this._l = [];
          this._r.set_rules([ Names[0].split(' ') ]);
          var lp = 0;
          var $enum1 = ss.enumerate(Names);
          while ($enum1.moveNext()) {
            var name = $enum1.current;
            this._tot++;
            lp++;
            if (name === Names[0]) {
              this._score++;
            }
            else {
              var E = new Chandam$Core$Errors();
              E.set_actual(name);
              E.set_expected(Names[0]);
              E.set_mismatch(MiriyamUtil.Mismatch.name);
              E.set_line(lp);
              E.set_position(-1);
              this._l.push(E);
            }
          }
        }
        var M = new Chandam$Core$MatchResult();
        M.set_total(this._tot);
        M.set_score(this._score);
        M.set_errors(this._l);
        M.set_rule(this._r);
        return M;
      }
      if (!this._r.get_rowWiseRules() && this._g.get_lines() > this._r.get_lines()) {
        if (this._r.get_padyamSubType() !== MiriyamUtil.PadyamSubType.ragada) {
          switch (this._g.get_lines()) {
            case 5:
              this._r.set_name(this._r.get_name() + '(\u0c2a\u0c02\u0c1a\u0c2a\u0c3e\u0c26\u0c3f)');
              break;
            case 6:
              this._r.set_name(this._r.get_name() + '(\u0c37\u0c1f\u0c4d\u0c2a\u0c26\u0c3f)');
              break;
            default:
              this._r.set_name(this._r.get_name() + '(\u0c2e\u0c3e\u0c32\u0c3f\u0c15)');
              break;
          }
        }
        this._r.set_lines(this._g.get_lines());
      }
      this._tot = 0;
      this._score = 0;
      this._l = [];
      if (this._r.get_infiniteLength() && !this._g.get_gNames().length) {
        var M = new Chandam$Core$MatchResult();
        M.set_total(this._tot);
        M.set_score(this._score);
        M.set_errors(this._l);
        M.set_rule(this._r);
        return M;
      }
      this._tot++;
      if (this._g.get_lines() === this._r.get_lines()) {
        this._score++;
      }
      else {
        var offset = Math.abs(this._r.get_lines() - this._g.get_lines());
        this._tot = this._tot + offset;
        var E = new Chandam$Core$Errors();
        E.set_actual(this._g.get_lines().toString());
        E.set_expected(this._r.get_lines().toString());
        E.set_mismatch(MiriyamUtil.Mismatch.lines);
        this._l.push(E);
      }
      for (var i = 0; i < this._r.get_lines(); i++) {
        this._lineScore(i);
      }
      if (this._r.get_ruleType() === MiriyamUtil.RuleType.weight && this._r.get_identifier() === 'kandam') {
        this._checkSpecial();
      }
      if (this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.ragada) {
        this._tot++;
        if (!!(this._g.get_lines() % 2)) {
          this._tot++;
          var E = new Chandam$Core$Errors();
          E.set_actual(this._g.get_lines().toString());
          E.set_expected((this._g.get_lines() + 1).toString());
          E.set_line(-1);
          E.set_position(-1);
          E.set_mismatch(MiriyamUtil.Mismatch.lines);
          this._l.push(E);
        }
        else {
          this._score++;
        }
      }
      var M = new Chandam$Core$MatchResult();
      M.set_total(this._tot);
      M.set_score(this._score);
      M.set_errors(this._l);
      M.set_rule(this._r);
      return M;
    },
    _analyse: function() {
      this._vibhajana(this._r);
    },
    _vibhajana: function(R) {
      var lines = 0;
      var gstr = '';
      var gn = '';
      var last = '';
      var lastSymbol = '';
      var lastLast = '';
      var lastLastSymbol = '';
      var offset = 0;
      var charCnt = 0;
      var GCount = 0;
      var y = 0;
      var W = 0;
      var GPassed = 0;
      var NextWeight = 0;
      var NextCat = MiriyamUtil.Category.unknown;
      var NextCat2 = MiriyamUtil.Category2.unknown;
      var NextSubCat = MiriyamUtil.SubCategory.unknown;
      var NextGName = '';
      var NextYati = 0;
      var Y = new Chandam$Core$Yati();
      for (var i = 0; i < this._g.get_symbolsStream().length; i++) {
        var curr = MiriyamUtil.StringPlus.charAt(this._g.get_symbolsStream(), i).toString();
        if (curr === ' ') {
          continue;
        }
        if (curr === MiriyamUtil.Constants.newLine) {
          if (!!gn) {
            this._update(gn, MiriyamUtil.GDefinition.gName(gn), gstr);
            gstr = '';
            gn = '';
            charCnt = 0;
            GCount = 0;
            GPassed = 0;
            W = 0;
            y = 0;
          }
          this._update(MiriyamUtil.Constants.newLine, MiriyamUtil.Constants.newLine, MiriyamUtil.Constants.newLine);
          this._g.get_yati().push(Y);
          if (R.get_anthyaPrasa()) {
            this._g.get_anthyaPrasa().push(new Chandam$Core$Prasa(lastLastSymbol, true, last, lastLast));
          }
          charCnt = 0;
          GCount = 0;
          GPassed = 0;
          W = 0;
          y = 0;
          lines++;
          Y = new Chandam$Core$Yati();
          continue;
        }
        if (!charCnt) {
          Y.p1 = this._g.get_gWiseString()[i];
          Y.pY1 = this._nextNonSpaceAkshar(i + 1, this._g.get_gWiseString());
          Y.YC = this._prevHasSunna(i, this._g.get_gWiseString());
        }
        if (R.get_prasa()) {
          if (charCnt === 1) {
            this._g.get_prasa().push(new Chandam$Core$Prasa(lastSymbol, false, this._g.get_gWiseString()[i], last));
          }
        }
        gn = gn + ((curr === ' ') ? '' : curr);
        gstr = gstr + ((!!gstr) ? ' ' : '') + this._g.get_gWiseString()[i];
        W = W + MiriyamUtil.GDefinition.getSymbolWeight(curr);
        charCnt++;
        lastLastSymbol = lastSymbol;
        lastSymbol = curr;
        if (R.get_yati().length === R.get_lines() && lines < R.get_yati().length) {
          if (!R.get_yati()[lines].length) {
            NextYati = 0;
          }
          else {
            NextYati = (y < R.get_yati()[lines].length && y >= 0) ? R.get_yati()[lines][y] : 0;
          }
        }
        else {
          if (R.get_yati().length > 0 && y >= 0) {
            if (y < R.get_yati()[0].length && y >= 0) {
              NextYati = R.get_yati()[0][y];
            }
            else {
              NextYati = 0;
            }
          }
          else {
            NextYati = 0;
          }
        }
        switch (R.get_yatiMode()) {
          case MiriyamUtil.YatiMode.charPosition:
            if (charCnt === NextYati) {
              Y.p2.push(this._g.get_gWiseString()[i]);
              Y.prasaYati.push(this._nextNonSpaceAkshar(i + 1, this._g.get_gWiseString()));
              Y.prevContext.push(this._prevHasSunna(i, this._g.get_gWiseString()));
              Y.positions.push(GPassed + 1);
              y++;
            }
            break;
          case MiriyamUtil.YatiMode.gPosition:
            if (GPassed + 1 === NextYati) {
              if (R.get_yatiRecycle() && NextYati === 5) {
                this._g.get_yati().push(Y);
                Y = new Chandam$Core$Yati();
                Y.p1 = this._g.get_gWiseString()[i];
                Y.pY1 = this._nextNonSpaceAkshar(i + 1, this._g.get_gWiseString());
                Y.YC = this._prevHasSunna(i, this._g.get_gWiseString());
                y++;
              }
              else {
                if (!R.get_reverseYati()) {
                  Y.p2.push(this._g.get_gWiseString()[i]);
                  Y.prasaYati.push(this._nextNonSpaceAkshar(i + 1, this._g.get_gWiseString()));
                  Y.prevContext.push(this._prevHasSunna(i, this._g.get_gWiseString()));
                  Y.positions.push(GPassed + 1);
                  y++;
                }
              }
            }
            break;
        }
        if (R.get_ruleType() === MiriyamUtil.RuleType.type) {
          var _R = (R.get_rowWiseRules() && lines < R.get_rules().length) ? R.get_rules()[lines] : R.get_rules()[0];
          if (GCount >= _R.length) {
            NextCat = MiriyamUtil.Category.unknown;
          }
          else {
            NextCat = _R[GCount];
          }
        }
        if (R.get_ruleType() === MiriyamUtil.RuleType.type2) {
          var _R = (R.get_rowWiseRules() && lines < R.get_rules().length) ? R.get_rules()[lines] : R.get_rules()[0];
          if (GCount >= _R.length) {
            NextCat2 = MiriyamUtil.Category2.unknown;
          }
          else {
            NextCat2 = _R[GCount];
          }
        }
        if (R.get_ruleType() === MiriyamUtil.RuleType.subType) {
          var _R = (R.get_rowWiseRules() && lines < R.get_rules().length) ? R.get_rules()[lines] : R.get_rules()[0];
          if (GCount >= _R.length) {
            NextSubCat = MiriyamUtil.SubCategory.unknown;
          }
          else {
            NextSubCat = _R[GCount];
          }
        }
        if (R.get_ruleType() === MiriyamUtil.RuleType.weight) {
          var _R = (R.get_rowWiseRules() && lines < R.get_rules().length) ? R.get_rules()[lines] : R.get_rules()[0];
          if (GCount >= _R.length) {
            NextWeight = 0;
          }
          else {
            NextWeight = _R[GCount];
          }
        }
        if (R.get_ruleType() === MiriyamUtil.RuleType.name) {
          var _R = (R.get_rowWiseRules() && lines < R.get_rules().length) ? R.get_rules()[lines] : R.get_rules()[0];
          if (GCount >= _R.length) {
            NextGName = '';
          }
          else {
            NextGName = _R[GCount];
          }
        }
        var _break = false;
        switch (R.get_ruleType()) {
          case MiriyamUtil.RuleType.name:
            var thresold = 3;
            if (R.get_deferThresold()) {
              if (R.get_infiniteLength()) {
                if (NextGName === '\u0c39' || NextGName === '\u0c35') {
                  thresold = 2;
                  _break = (!(charCnt % thresold) && !!charCnt);
                  offset = 1;
                }
                else {
                  _break = (!((charCnt + offset) % thresold) && !!charCnt);
                }
              }
              else {
                if (GCount === 2 && charCnt === 8) {
                  _break = true;
                }
                if (charCnt > 8) {
                  _break = (!((charCnt + 1) % thresold) && !!charCnt);
                }
              }
            }
            else {
              _break = (!(charCnt % thresold) && !!charCnt);
            }
            break;
          case MiriyamUtil.RuleType.type:
            var Current = MiriyamUtil.GDefinition.getType(gn);
            _break = (Current === NextCat);
            break;
          case MiriyamUtil.RuleType.type2:
            var Current = MiriyamUtil.GDefinition.getType2(gn);
            _break = (Current === NextCat2);
            break;
          case MiriyamUtil.RuleType.subType:
            var Current = MiriyamUtil.GDefinition.getSubType(gn);
            _break = (Current === NextSubCat);
            break;
          case MiriyamUtil.RuleType.weight:
            _break = (W === NextWeight);
            break;
        }
        if (!_break && (R.get_threshold() === gn.length)) {
          _break = true;
        }
        if (_break && !!gn) {
          if (R.get_reverseYati() && (GPassed + 1 === NextYati)) {
            Y.p2.push(this._g.get_gWiseString()[i]);
            Y.prasaYati.push(this._nextNonSpaceAkshar(i + 1, this._g.get_gWiseString()));
            Y.prevContext.push(this._prevHasSunna(i, this._g.get_gWiseString()));
            Y.positions.push(GPassed + 1);
            y++;
          }
          this._update(gn, MiriyamUtil.GDefinition.gName(gn), gstr);
          gstr = '';
          gn = '';
          W = 0;
          GCount++;
          GPassed++;
        }
        lastLast = last;
        last = (this._g.get_gWiseString()[i] === ' ') ? last : this._g.get_gWiseString()[i];
      }
      if (!!gn) {
        this._update(gn, MiriyamUtil.GDefinition.gName(gn), gstr);
        this._g.get_yati().push(Y);
        gstr = '';
        gn = '';
        Y = new Chandam$Core$Yati();
      }
      this._g.get_yati().push(Y);
      lines++;
      if (R.get_anthyaPrasa()) {
        this._g.get_anthyaPrasa().push(new Chandam$Core$Prasa(lastLastSymbol, true, last, lastLast));
      }
      this._g.set_lines(lines);
    },
    _prevHasSunna: function(start, list) {
      var got = false;
      start = start - 1;
      while (!got) {
        if (start >= 0 && start < list.length) {
          if (list[start] === '\n' || list[start] === ' ') {
            start = start - 1;
          }
          else {
            return (MiriyamUtil.StringPlus.endsWith(list[start], '\u0c02')) ? '\u0c02' : null;
          }
        }
        else {
          return null;
        }
      }
      return null;
    },
    _nextNonSpaceAkshar: function(start, list) {
      var got = false;
      var x = null;
      while (!got) {
        x = (start < list.length) ? list[start] : null;
        if (x == null || x === '\n') {
          return null;
        }
        if (x === ' ') {
          start = start + 1;
        }
        else {
          return x;
        }
      }
      return x;
    },
    _linePosition: function(i) {
      if (!i) {
        return 0;
      }
      var cnt = 0;
      var l = 0;
      var $enum1 = ss.enumerate(this._g.get_gNames());
      while ($enum1.moveNext()) {
        var nm = $enum1.current;
        if (nm === MiriyamUtil.Constants.newLine) {
          l++;
        }
        cnt++;
        if (l === i) {
          return cnt;
        }
      }
      return -1;
    },
    _linePosition2: function(line) {
      var cnt = 0;
      var l = 0;
      for (var i = 0; i < this._g.get_gNames().length; i++) {
        var nm = this._g.get_gNames()[i];
        if (nm === MiriyamUtil.Constants.newLine) {
          l++;
          if (l === line + 1) {
            return cnt;
          }
        }
        cnt++;
      }
      return this._g.get_gNames().length;
    },
    _lineScore: function(line) {
      var mark = this._linePosition(line);
      var next = this._linePosition2(line);
      var pos = 1;
      var Rules = (this._r.get_rowWiseRules()) ? this._r.get_rules()[line] : this._r.get_rules()[0];
      this._tot++;
      var gCount = (mark === -1) ? 0 : next - mark;
      if (gCount !== Rules.length && !this._r.get_infiniteLength()) {
        var offset = Math.abs(Rules.length - gCount);
        this._tot = this._tot + offset;
        var E = new Chandam$Core$Errors();
        E.set_actual((!gCount) ? '' : gCount.toString());
        E.set_expected(Rules.length.toString());
        E.set_line(line + 1);
        E.set_position(-1);
        E.set_mismatch(MiriyamUtil.Mismatch.gCount);
        this._l.push(E);
      }
      else {
        this._score++;
      }
      var to = mark + Rules.length;
      if (this._r.get_infiniteLength()) {
        to = this._g.get_gNames().length;
      }
      for (var j = mark; j < to; j++) {
        var err = true;
        var nm = '';
        var rule = '';
        var gString = '';
        var w = 0;
        if ((j < this._g.get_gNames().length & j >= 0) === 1) {
          this._tot++;
          nm = this._g.get_gNames()[j];
          nm = nm.trim();
          gString = this._g.get_gString()[j];
          gString = gString.trim();
          switch (this._r.get_ruleType()) {
            case MiriyamUtil.RuleType.name:
              if (!this._r.get_infiniteLength()) {
                rule = Rules[j - mark];
              }
              else {
                if (j < to - 1 && Rules.length - 2 >= 0 && j > Rules.length - 2) {
                  rule = Rules[(Rules.length - 2)];
                }
                else if (j === to - 1) {
                  rule = Rules[Rules.length - 1];
                }
                else {
                  rule = Rules[j - mark];
                }
              }
              if (nm === rule) {
                this._score++;
                err = false;
              }
              break;
            case MiriyamUtil.RuleType.type:
              var r1 = Rules[j - mark];
              var c1 = MiriyamUtil.GDefinition.getType(nm);
              rule = MiriyamUtil.GDefinition.categoryString(r1);
              if (r1 === c1) {
                this._score++;
                err = false;
              }
              break;
            case MiriyamUtil.RuleType.type2:
              var r1 = Rules[j - mark];
              var c1 = MiriyamUtil.GDefinition.getType2(nm);
              rule = MiriyamUtil.GDefinition.category2String(r1);
              if (r1 === c1) {
                this._score++;
                err = false;
              }
              break;
            case MiriyamUtil.RuleType.subType:
              var r1 = Rules[j - mark];
              var c1 = MiriyamUtil.GDefinition.getSubType(nm);
              rule = MiriyamUtil.GDefinition.subCategoryString(r1);
              if (r1 === c1) {
                this._score++;
                err = false;
              }
              break;
            case MiriyamUtil.RuleType.weight:
              var r1 = Rules[j - mark];
              w = MiriyamUtil.GDefinition.getGWeight2(this._g.get_gSymbols()[j]);
              var c1 = w;
              rule = r1.toString();
              if (r1 === c1) {
                this._score++;
                err = false;
              }
              break;
          }
        }
        else {
          if (j === -1) {
            for (var k = 0; k < Rules.length; k++) {
              this._tot++;
              switch (this._r.get_ruleType()) {
                case MiriyamUtil.RuleType.weight:
                  rule = (Rules[k]).toString();
                  break;
                case MiriyamUtil.RuleType.name:
                  rule = Rules[k];
                  break;
                case MiriyamUtil.RuleType.type:
                  var r1 = Rules[k];
                  rule = MiriyamUtil.GDefinition.categoryString(r1);
                  break;
                case MiriyamUtil.RuleType.type2:
                  var r1 = Rules[k];
                  rule = MiriyamUtil.GDefinition.category2String(r1);
                  break;
                case MiriyamUtil.RuleType.subType:
                  var r1 = Rules[k];
                  rule = MiriyamUtil.GDefinition.subCategoryString(r1);
                  break;
              }
              var E = new Chandam$Core$Errors();
              E.set_actual((this._r.get_ruleType() === MiriyamUtil.RuleType.name) ? nm : ((this._r.get_ruleType() === MiriyamUtil.RuleType.weight) ? w.toString() : MiriyamUtil.GDefinition.categoryString(MiriyamUtil.GDefinition.getType(nm))));
              E.set_expected(rule);
              E.set_line(line + 1);
              E.set_position(pos);
              E.set_mismatch((this._r.get_ruleType() === MiriyamUtil.RuleType.name) ? MiriyamUtil.Mismatch.name : ((this._r.get_ruleType() === MiriyamUtil.RuleType.weight) ? MiriyamUtil.Mismatch.weight : MiriyamUtil.Mismatch.category));
              E.set_remarks(gString);
              this._l.push(E);
              pos++;
            }
            j = Rules.length + 1;
            continue;
          }
          else {
            err = true;
            switch (this._r.get_ruleType()) {
              case MiriyamUtil.RuleType.name:
                rule = Rules[j - mark];
                break;
              case MiriyamUtil.RuleType.type:
                var r1 = Rules[j - mark];
                rule = MiriyamUtil.GDefinition.categoryString(r1);
                break;
              case MiriyamUtil.RuleType.type2:
                var r1 = Rules[j - mark];
                rule = MiriyamUtil.GDefinition.category2String(r1);
                break;
              case MiriyamUtil.RuleType.subType:
                var r1 = Rules[j - mark];
                rule = MiriyamUtil.GDefinition.subCategoryString(r1);
                break;
              case MiriyamUtil.RuleType.weight:
                rule = (Rules[j - mark]).toString();
                break;
            }
          }
        }
        if (err) {
          var E = new Chandam$Core$Errors();
          E.set_actual((this._r.get_ruleType() === MiriyamUtil.RuleType.name) ? nm : ((this._r.get_ruleType() === MiriyamUtil.RuleType.weight) ? w.toString() : MiriyamUtil.GDefinition.categoryString(MiriyamUtil.GDefinition.getType(nm))));
          E.set_expected(rule);
          E.set_line(line + 1);
          E.set_position(pos);
          E.set_mismatch((this._r.get_ruleType() === MiriyamUtil.RuleType.name) ? MiriyamUtil.Mismatch.name : ((this._r.get_ruleType() === MiriyamUtil.RuleType.weight) ? MiriyamUtil.Mismatch.weight : MiriyamUtil.Mismatch.category));
          E.set_remarks(gString);
          this._l.push(E);
        }
        pos++;
      }
      if (this.get_matchYati()) {
        this._checkYati(line);
      }
      if (this.get_matchPrasa()) {
        this._checkPrasa(line);
        this._checkAnthyaPrasa(line);
      }
    },
    _checkYati: function(line) {
      if (this._r.get_onlyPrasaYati()) {
        this._checkPrasaYati(line);
        return;
      }
      if (this._g.get_yati().length > line) {
        if (!this._r.get_yatiRecycle()) {
          var y = this._g.get_yati()[line];
          var _PY = this._checkYatiMatch(y, line);
          this._g.get_prasaYati().push(_PY);
        }
        else {
          try {
            if (line * 2 < this._g.get_yati().length && (line + 1) * 2 - 1 < this._g.get_yati().length) {
              var y = this._g.get_yati()[line * 2];
              var _PY1 = this._checkYatiMatch(y, line);
              y = this._g.get_yati()[(line + 1) * 2 - 1];
              var _PY2 = this._checkYatiMatch(y, line);
              var _PY = new Array(_PY1.length + _PY2.length);
              for (var _k = 0; _k < _PY1.length; _k++) {
                _PY[_k] = _PY1[_k];
              }
              for (var _k = _PY1.length; _k < _PY1.length + _PY2.length; _k++) {
                _PY[_k] = _PY2[_k - _PY1.length];
              }
              this._g.get_prasaYati().push(_PY);
            }
          }
          catch ($e1) {
          }
        }
      }
      else {
      }
    },
    _checkPrasaYati: function(line) {
      if (this._g.get_yati().length > line) {
        if (!this._r.get_yatiRecycle()) {
          var y = this._g.get_yati()[line];
          var _PY = this._checkPrasaYati2(y, line);
          this._g.get_prasaYati().push(_PY);
        }
      }
    },
    _checkPrasaYati2: function(y, line) {
      var _PY2 = [ true, true ];
      if (y.p2.length >= 1) {
        var cnt = 0;
        var _PY = new Array(y.p2.length + 1);
        var $enum1 = ss.enumerate(y.p2);
        while ($enum1.moveNext()) {
          var p2 = $enum1.current;
          var res = false;
          if (!res && this._r.get_prasaYati()) {
            if (y.prasaYati[cnt] != null) {
              res = this._YPC.isPrasaMatched(y.pY1, y.prasaYati[cnt]);
              if (res) {
                _PY[cnt + 1] = true;
                _PY[0] = true;
              }
              else {
                _PY[cnt + 1] = true;
                _PY[0] = true;
              }
            }
          }
          if (res) {
            this._score++;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(p2 + y.prasaYati[cnt]);
            E.set_expected(y.p1 + y.pY1);
            E.set_line(line + 1);
            E.set_position(y.positions[cnt]);
            E.set_mismatch(MiriyamUtil.Mismatch.prasaYati);
            this._l.push(E);
          }
          this._tot++;
          cnt++;
        }
        return _PY;
      }
      return _PY2;
    },
    _checkYatiMatch: function(y, line) {
      var _PY2 = new Array(2);
      if (y.p2.length >= 1) {
        var cnt = 0;
        var _PY = new Array(y.p2.length + 1);
        var $enum1 = ss.enumerate(y.p2);
        while ($enum1.moveNext()) {
          var p2 = $enum1.current;
          var res = this._yatiMatcher(y.p1, p2);
          if (res) {
            _PY[cnt + 1] = false;
            _PY[0] = false;
          }
          if (!res) {
            res = this._yatiMatcher((y.YC == null) ? y.p1 : (y.YC + y.p1), p2);
          }
          if (!res && cnt < y.prevContext.length && y.prevContext[cnt] != null) {
            res = this._yatiMatcher((y.YC == null) ? y.p1 : (y.YC + y.p1), y.prevContext[cnt] + p2);
          }
          if (!res && this._r.get_prasaYati()) {
            if (y.prasaYati[cnt] != null) {
              res = this._YPC.isPrasaMatched(y.pY1, y.prasaYati[cnt]);
              if (res) {
                _PY[cnt + 1] = true;
                _PY[0] = true;
              }
            }
          }
          if (res) {
            this._score++;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(p2);
            E.set_expected(y.p1);
            E.set_line(line + 1);
            E.set_position(y.positions[cnt]);
            E.set_mismatch(MiriyamUtil.Mismatch.yati);
            this._l.push(E);
          }
          this._tot++;
          cnt++;
        }
        return _PY;
      }
      return _PY2;
    },
    _checkSpecial: function() {
      var cnt = 0;
      var l_p = 0;
      var l_cnt = 0;
      var _tot = 0;
      var $enum1 = ss.enumerate(this._g.get_gNames());
      while ($enum1.moveNext()) {
        var s = $enum1.current;
        _tot++;
        if (cnt > 16) {
          this._tot++;
          return;
        }
        if (s === '\n') {
          l_p++;
          l_cnt = 0;
          continue;
        }
        cnt++;
        l_cnt++;
        if (cnt % 2 === 1) {
          this._tot++;
          if (s.trim() !== '\u0c1c') {
            this._score++;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(s);
            E.set_expected("'\u0c1c' \u0c15\u0c3e\u0c28\u0c3f\u0c26\u0c3f");
            E.set_mismatch(MiriyamUtil.Mismatch.oddNonJa);
            E.set_position(l_cnt);
            E.set_line(l_p + 1);
            this._l.push(E);
          }
        }
        if ((l_p === 1 || l_p === 3) && (l_cnt === 3)) {
          this._tot++;
          if (s.trim() === '\u0c1c' || s.trim() === '\u0c28\u0c32') {
            this._score++;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(s);
            E.set_expected('\u0c1c or \u0c28\u0c32');
            E.set_mismatch(MiriyamUtil.Mismatch.sixth);
            E.set_position(l_cnt);
            E.set_line(l_p + 1);
            this._l.push(E);
          }
        }
      }
      if (l_cnt === 5 && (l_p === 3 || l_p === 1)) {
        this._tot++;
        var _s = this._g.get_gSymbols()[_tot - 1];
        var c = MiriyamUtil.StringPlus.charAt(_s, _s.length - 1);
        if (c === 'U') {
          this._score++;
        }
        else {
          var E = new Chandam$Core$Errors();
          E.set_actual(c);
          E.set_expected('U(\u0c17\u0c41\u0c30\u0c41\u0c35\u0c41)');
          E.set_mismatch(MiriyamUtil.Mismatch.nonGuruvu);
          E.set_position(l_cnt);
          E.set_line(l_p + 1);
          this._l.push(E);
        }
      }
    },
    _checkPrasa: function(line) {
      if (!this._r.get_prasa()) {
        return;
      }
      if (!line) {
        return;
      }
      this._tot++;
      if (!this._g.get_prasa().length) {
        return;
      }
      if (line > this._g.get_prasa().length) {
        return;
      }
      var P1 = this._g.get_prasa()[0];
      if (this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.ragada || this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.divpada) {
        if (!(line % 2)) {
          this._score++;
          return;
        }
        if (line % 2 === 1 && line - 1 > 0) {
          P1 = this._g.get_prasa()[line - 1];
        }
      }
      if (line >= this._g.get_prasa().length) {
        return;
      }
      var P2 = this._g.get_prasa()[line];
      var res = this._YPC.isPrasaMatched3(P1, P2);
      if (res) {
        this._score++;
      }
      else {
        var E = new Chandam$Core$Errors();
        E.set_actual(P2.get_value());
        E.set_expected(P1.get_value());
        E.set_line(line + 1);
        E.set_position(-1);
        E.set_mismatch(MiriyamUtil.Mismatch.prasa);
        this._l.push(E);
      }
      this._checkPrasaPoorva(this._g.get_prasa(), line);
    },
    _checkPrasaPoorva: function(PP, line) {
      this._tot++;
      var p1 = PP[0];
      var p2 = PP[line];
      if (this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.ragada || this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.divpada) {
        if (!(line % 2)) {
          this._score++;
          this._checkPrasaPoorva2(p1, p2, line);
          return;
        }
        if (line % 2 === 1 && line - 1 > 0) {
          p1 = PP[line - 1];
        }
      }
      var res = (p1.get_symbol() === p2.get_symbol());
      if (res) {
        this._score++;
      }
      else {
        var E = new Chandam$Core$Errors();
        E.set_actual(MiriyamUtil.GDefinition.getSymbolName(p2.get_symbol()));
        E.set_expected(MiriyamUtil.GDefinition.getSymbolName(p1.get_symbol()));
        E.set_line(line + 1);
        E.set_position(-1);
        E.set_mismatch((p1.get_isAnthyaPrasa()) ? MiriyamUtil.Mismatch.anthyaPrasaPoorva : MiriyamUtil.Mismatch.prasaPoorva);
        this._l.push(E);
      }
      this._checkPrasaPoorva2(p1, p2, line);
    },
    _checkPrasaPoorva2: function(p1, p2, line) {
      this._tot++;
      var SUNNA = '\u0c02';
      var VISARGA = '\u0c03';
      if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === SUNNA || MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === SUNNA) {
        if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === SUNNA && MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === SUNNA) {
          this._score++;
          return;
        }
        else {
          var E = new Chandam$Core$Errors();
          E.set_actual(p2.get_poorva());
          E.set_expected((MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === SUNNA) ? ("'" + SUNNA + "'  \u0c24\u0c4b \u0c15\u0c42\u0c21\u0c3f\u0c28 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02") : ("'" + SUNNA + "'  \u0c24\u0c4b \u0c32\u0c47\u0c28\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02"));
          E.set_line(line + 1);
          E.set_position(-1);
          E.set_mismatch((p1.get_isAnthyaPrasa()) ? MiriyamUtil.Mismatch.anthyaPrasaPoorvaBindu : MiriyamUtil.Mismatch.prasaPoorvaBindu);
          this._l.push(E);
          return;
        }
      }
      else {
        if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === VISARGA || (MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === VISARGA)) {
          if (MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === VISARGA && (MiriyamUtil.StringPlus.charAt(p2.get_poorva(), p2.get_poorva().length - 1) === VISARGA)) {
            this._score++;
            return;
          }
          else {
            var E = new Chandam$Core$Errors();
            E.set_actual(p2.get_poorva());
            E.set_expected((MiriyamUtil.StringPlus.charAt(p1.get_poorva(), p1.get_poorva().length - 1) === VISARGA) ? ("'" + VISARGA + "'  \u0c24\u0c4b \u0c15\u0c42\u0c21\u0c3f\u0c28 \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02") : ("'" + VISARGA + "'  \u0c24\u0c4b \u0c32\u0c47\u0c28\u0c3f \u0c05\u0c15\u0c4d\u0c37\u0c30\u0c02"));
            E.set_line(line + 1);
            E.set_position(-1);
            E.set_mismatch((p1.get_isAnthyaPrasa()) ? MiriyamUtil.Mismatch.anthyaPrasaPoorvaVisarga : MiriyamUtil.Mismatch.prasaPoorvaVisarga);
            this._l.push(E);
            return;
          }
        }
      }
      this._score++;
    },
    _checkAnthyaPrasa: function(line) {
      if (!this._r.get_anthyaPrasa()) {
        return;
      }
      if (!line) {
        return;
      }
      this._tot++;
      if (!this._g.get_anthyaPrasa().length) {
        return;
      }
      if (line > this._g.get_anthyaPrasa().length) {
        return;
      }
      var p1 = this._g.get_anthyaPrasa()[0].get_value();
      if (this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.ragada || this._r.get_padyamSubType() === MiriyamUtil.PadyamSubType.divpada) {
        if (!(line % 2)) {
          this._score++;
          return;
        }
        if (line % 2 === 1 && line - 1 > 0) {
          p1 = this._g.get_anthyaPrasa()[line - 1].get_value();
        }
      }
      if (line >= this._g.get_anthyaPrasa().length) {
        return;
      }
      var p2 = this._g.get_anthyaPrasa()[line].get_value();
      var res = this._YPC.isPrasaMatched(p1, p2);
      if (res) {
        this._score++;
      }
      else {
        var E = new Chandam$Core$Errors();
        E.set_actual(p2);
        E.set_expected(p1);
        E.set_line(line + 1);
        E.set_position(-1);
        E.set_mismatch(MiriyamUtil.Mismatch.anthyaPrasa);
        this._l.push(E);
      }
      this._checkPrasaPoorva(this._g.get_anthyaPrasa(), line);
    },
    _yatiMatcher: function(p1, p2) {
      return this._YPC.isYatiMatched(p1, p2);
    },
    _lineStamper: function(lp) {
      var ret = '';
      var isOK = this._isOk(lp);
      if (isOK) {
        ret = "<label class='ok'>" + '\u2714' + '</label>';
      }
      else {
        ret = ret + "<label class='err'>" + '\u2718' + '</label>';
      }
      return ret;
    },
    _gStamper: function(lp, gp) {
      var ret = '';
      var isOK = this._isGOK(gp, lp);
      if (isOK) {
        ret = 'gOk';
      }
      else {
        return 'gErr';
      }
      return ret;
    },
    _isOk: function(lp) {
      var $enum1 = ss.enumerate(this._MR.get_errors());
      while ($enum1.moveNext()) {
        var E = $enum1.current;
        if (E.get_line() === lp + 1) {
          return false;
        }
      }
      if (lp + 1 > this._r.get_lines()) {
        return false;
      }
      return true;
    },
    _isGOK: function(GPassed, lp) {
      if (lp + 1 > this._r.get_lines()) {
        return false;
      }
      var $enum1 = ss.enumerate(this._MR.get_errors());
      while ($enum1.moveNext()) {
        var E = $enum1.current;
        if (E.get_line() === lp + 1 && E.get_position() === GPassed + 1) {
          return false;
        }
      }
      if (this._r.get_rowWiseRules() || this._r.get_ruleType() === MiriyamUtil.RuleType.weight) {
        if (lp < this._r.get_rules().length && this._r.get_rules().length !== 1 && GPassed >= this._r.get_rules()[lp].length) {
          return false;
        }
      }
      else {
        if (GPassed + 1 > this._r.get_rules()[0].length && !this._r.get_infiniteLength()) {
          return false;
        }
      }
      return true;
    },
    _update: function(gn, gn2, gstr) {
      this._g.set_gNamesStream(this._g.get_gNamesStream() + gn2);
      this._g.get_gNames().push(gn2);
      this._g.get_gString().push(gstr);
      this._g.get_gSymbols().push(gn);
    },
    build: function(_MR) {
      if (_MR == null) {
        throw new Error("Matching object can't be null..");
      }
      else {
        this._MR = _MR;
      }
      return this._buildHTML(this._r);
    },
    build2: function(_MR) {
      if (_MR == null) {
        throw new Error("Matching object can't be null..");
      }
      else {
        this._MR = _MR;
      }
      return this._buildText(this._r);
    },
    build3: function() {
      return ss.replaceString(this._s, '\n', '<br />');
    },
    _buildHTML: function(R) {
      var t1 = '';
      var t2 = '';
      var t3 = '';
      var n = '';
      var lp = 0;
      var CharsPassed = 0;
      var GPassed = 0;
      var NextYati = 1;
      var y = 0;
      var l_yati = 0;
      var marker = false;
      var maxG = this._maxOfG(this._g.get_gNames());
      for (var i = 0; i < this._g.get_gNames().length; i++) {
        if (lp < R.get_yati().length && !R.get_yati()[lp].length) {
          NextYati = -1;
        }
        if (!R.get_yati().length) {
          NextYati = -1;
        }
        if (this._g.get_gNames()[i] === MiriyamUtil.Constants.newLine) {
          var equal = n = n + "<tr  class='ga'>" + "<td  class='stamper' rowspan='3'>" + this._lineStamper(lp) + '</td>' + t1 + this._equivalize(maxG - GPassed) + '</tr>' + "<tr class='up'>" + t2 + '</tr>' + "<tr class='dw'>" + t3 + '</tr>\n';
          t1 = '';
          t2 = '';
          t3 = '';
          CharsPassed = 0;
          GPassed = 0;
          NextYati = 1;
          y = 0;
          l_yati = 0;
          lp++;
        }
        else {
          var Chars = this._g.get_gString()[i].split(' ');
          var x = this._gStamper(lp, GPassed);
          t1 = t1 + "<td class='X " + x + "' title='" + this._g.get_gNames()[i] + "'>" + MiriyamUtil.GDefinition.getGName(R.get_ruleType(), this._g.get_gNames()[i]) + '</td>';
          t2 = t2 + "<td class='X " + x + "'>" + ss.replaceString(ss.replaceString(this._g.get_gSymbols()[i], MiriyamUtil.Symbols.LAGHUVU, '| '), MiriyamUtil.Symbols.GURUVU, 'U ') + '</td>';
          t3 = t3 + "<td class='X3 " + x + "'> ";
          var TotalNonSpace = 0;
          if (R.get_reverseYati()) {
            for (var _i = 0; _i < Chars.length; _i++) {
              if (!!Chars[_i] && Chars[_i] !== ' ') {
                TotalNonSpace++;
              }
            }
          }
          var non_space = 0;
          for (var j = 0; j < Chars.length; j++) {
            if (!Chars[j]) {
              continue;
            }
            if (Chars[j] !== ' ') {
              non_space++;
            }
            if (R.get_prasa() && CharsPassed + 1 === 2) {
              t3 = t3 + " <span class='yati'>" + Chars[j] + '</span> ';
            }
            else {
              var found = false;
              switch (R.get_yatiMode()) {
                case MiriyamUtil.YatiMode.charPosition:
                  found = (CharsPassed + 1 === NextYati);
                  break;
                case MiriyamUtil.YatiMode.gPosition:
                  found = (GPassed + 1 === NextYati) && (non_space === ((R.get_reverseYati() && GPassed + 1 !== 1) ? TotalNonSpace : 1));
                  break;
              }
              if (found) {
                if (R.get_prasaYati() && this._g.get_prasaYati().length > 0 && lp < this._g.get_prasaYati().length && l_yati < this._g.get_prasaYati()[lp].length && this._g.get_prasaYati()[lp][l_yati]) {
                  var _local = this._nextNonSpace(j + 1, Chars);
                  t3 = t3 + " <span class='y1'><u>" + Chars[j] + ' ';
                  if (!!_local) {
                    t3 = t3 + ((R.get_prasa()) ? "<span class='yati'>" + _local + '</span> ' : _local);
                  }
                  else {
                    marker = true;
                  }
                  t3 = t3 + '</u></span> ';
                  j = j + 1;
                  CharsPassed++;
                }
                else {
                  t3 = t3 + " <span class='y1'><u>" + Chars[j] + '</u></span> ';
                }
                l_yati++;
                if (R.get_yati().length === R.get_lines()) {
                  if (lp < R.get_yati().length && !R.get_yati()[lp].length) {
                    NextYati = 0;
                  }
                  else {
                    NextYati = (lp < R.get_yati().length && y < R.get_yati()[lp].length && y >= 0) ? R.get_yati()[lp][y] : 0;
                  }
                }
                else {
                  if (R.get_yati().length > 0 && R.get_yati()[0].length > 0) {
                    NextYati = (y < R.get_yati()[0].length && y >= 0) ? R.get_yati()[0][y] : 0;
                  }
                }
                y++;
              }
              else {
                if (R.get_anthyaPrasa() && ((i + 1 < this._g.get_gNames().length && this._g.get_gNames()[i + 1] === MiriyamUtil.Constants.newLine) || i === this._g.get_gNames().length - 1) && j === Chars.length - 1) {
                  t3 = t3 + " <span class='yati'>" + Chars[j] + '</span> ';
                }
                else {
                  if (marker) {
                    var _local = this._nextNonSpace(j + 1, Chars);
                    t3 = t3 + " <u><span class='yati'>" + Chars[j] + '</span></u> ';
                    marker = false;
                  }
                  else {
                    t3 = t3 + ' ' + Chars[j];
                  }
                }
              }
            }
            if (j < Chars.length && Chars[j] !== ' ') {
              CharsPassed++;
            }
          }
          t3 = t3 + '</td>';
          GPassed++;
        }
      }
      return "<table cellspacing='0' border='1' class='tab'>" + n + "<tr  class='ga'>" + "<td  class='stamper' rowspan='3'>" + this._lineStamper(lp) + '</td>' + t1 + this._equivalize(maxG - GPassed) + '</tr>' + "<tr class='up'>" + t2 + '</tr>' + "<tr class='dw'>" + t3 + '</tr>\n' + '</table>';
    },
    _equivalize: function(p) {
      var s = '';
      for (var i = 0; i < p; i++) {
        s = s + '<td  rowspan="3">&nbsp;</td>';
      }
      return s;
    },
    _maxOfG: function(list) {
      var max = 0;
      var cnt = 0;
      var $enum1 = ss.enumerate(list);
      while ($enum1.moveNext()) {
        var g = $enum1.current;
        if (g === '\n') {
          if (cnt > max) {
            max = cnt;
          }
          cnt = 0;
          continue;
        }
        cnt++;
      }
      if (cnt > max) {
        max = cnt;
      }
      return max;
    },
    _nextNonSpace: function(from, Chars) {
      var got = false;
      while (!got) {
        if (from < Chars.length) {
          if (Chars[from] !== ' ') {
            return Chars[from];
          }
          from = from + 1;
        }
        else {
          got = true;
        }
      }
      return '';
    },
    _buildText: function(R) {
      var t3 = '';
      var n = '';
      var lp = 0;
      var CharsPassed = 0;
      var GPassed = 0;
      var NextYati = 1;
      var y = 0;
      var l_yati = 0;
      var tot = -1;
      var UMarkings = [];
      var BMarkings = [];
      for (var i = 0; i < this._g.get_gNames().length; i++) {
        if ((lp < R.get_yati().length && !R.get_yati()[lp].length) || !R.get_yati().length) {
          NextYati = -1;
        }
        if (this._g.get_gNames()[i] === MiriyamUtil.Constants.newLine) {
          n = n + t3 + '<br />';
          t3 = '';
          CharsPassed = 0;
          GPassed = 0;
          NextYati = 1;
          y = 0;
          l_yati = 0;
          lp++;
          tot++;
        }
        else {
          var Chars = this._g.get_gString()[i].split(' ');
          var TotalNonSpace = 0;
          if (R.get_reverseYati()) {
            for (var _i = 0; _i < Chars.length; _i++) {
              if (!!Chars[_i] && Chars[_i] !== ' ') {
                TotalNonSpace++;
              }
            }
          }
          var non_space = 0;
          for (var j = 0; j < Chars.length; j++) {
            if (!Chars[j]) {
              continue;
            }
            tot++;
            if (Chars[j] !== ' ') {
              non_space++;
            }
            if (R.get_anthyaPrasa() && ((i + 1 < this._g.get_gNames().length && this._g.get_gNames()[i + 1] === MiriyamUtil.Constants.newLine) || i === this._g.get_gNames().length - 1) && j === Chars.length - 1) {
              BMarkings.push(tot);
            }
            if (R.get_prasa() && CharsPassed + 1 === 2) {
              BMarkings.push(tot);
            }
            else {
              var found = false;
              switch (R.get_yatiMode()) {
                case MiriyamUtil.YatiMode.charPosition:
                  found = (CharsPassed + 1 === NextYati);
                  break;
                case MiriyamUtil.YatiMode.gPosition:
                  found = (GPassed + 1 === NextYati) && (non_space === ((R.get_reverseYati() && GPassed + 1 !== 1) ? TotalNonSpace : 1));
                  break;
              }
              if (found) {
                if (R.get_prasaYati() && this._g.get_prasaYati().length > 0 && lp < this._g.get_prasaYati().length && l_yati < this._g.get_prasaYati()[lp].length && this._g.get_prasaYati()[lp][l_yati]) {
                  UMarkings.push(tot);
                  UMarkings.push(tot + 1);
                }
                else {
                  UMarkings.push(tot);
                }
                l_yati++;
                if (R.get_yati().length === R.get_lines()) {
                  if (lp < R.get_yati().length && !R.get_yati()[lp].length) {
                    NextYati = 0;
                  }
                  else {
                    NextYati = (lp < R.get_yati().length && y < R.get_yati()[lp].length && y >= 0) ? R.get_yati()[lp][y] : 0;
                  }
                }
                else {
                  if (R.get_yati().length > 0 && R.get_yati()[0].length > 0) {
                    NextYati = (y < R.get_yati()[0].length && y >= 0) ? R.get_yati()[0][y] : 0;
                  }
                }
                y++;
              }
              else {
                var temp = (ss.endsWith(Chars[j], '\u0c4d')) ? Chars[j] + ' ' : Chars[j];
                t3 = t3 + '' + temp;
              }
            }
            if (Chars[j] !== ' ') {
              CharsPassed++;
            }
            else {
            }
          }
          t3 = t3 + '';
          GPassed++;
        }
      }
      var f = this._g.get_raw();
      var tot2 = -1;
      for (var i = 0; i < f.length; i++) {
        var _f = f[i];
        if (!MiriyamUtil.StringPlus.contains(this._g.get_accept() + '- ', _f)) {
          tot2++;
        }
        if ((UMarkings.indexOf(tot2) >= 0)) {
          f[i] = '<u>' + f[i] + '</u>';
        }
        if ((BMarkings.indexOf(tot2) >= 0)) {
          f[i] = '<b>' + f[i] + '</b>';
        }
      }
      var temp2 = '';
      var $enum1 = ss.enumerate(f);
      while ($enum1.moveNext()) {
        var _f = $enum1.current;
        temp2 = temp2 + ss.replaceString(_f, '\n', '<br />');
      }
      return temp2;
    }
  };


  // Chandam.Core.Prasa

  function Chandam$Core$Prasa(PoorvaSymbol, isAnthyaPrasa, val, PoorvaVal) {
    this._f = false;
    this.set_symbol(PoorvaSymbol);
    this.set_isAnthyaPrasa(isAnthyaPrasa);
    this.set_value(val);
    this.set_poorva(PoorvaVal);
  }
  var Chandam$Core$Prasa$ = {
    get_symbol: function() {
      return this._Symbol;
    },
    set_symbol: function(value) {
      this._Symbol = value;
      return value;
    },
    get_poorva: function() {
      return this._Poorva;
    },
    set_poorva: function(value) {
      this._Poorva = value;
      return value;
    },
    get_value: function() {
      return this._Value;
    },
    set_value: function(value) {
      this._Value = value;
      return value;
    },
    get_isAnthyaPrasa: function() {
      return this._f;
    },
    set_isAnthyaPrasa: function(value) {
      this._f = value;
      return value;
    }
  };


  // Chandam.Core.Probable

  function Chandam$Core$Probable() {
  }
  var Chandam$Core$Probable$ = {
    get_candiates: function() {
      return this._Candidates;
    },
    set_candiates: function(value) {
      this._Candidates = value;
      return value;
    },
    get_matchResult: function() {
      return this._M;
    },
    set_matchResult: function(value) {
      this._M = value;
      return value;
    },
    get_padyam: function() {
      return this._P;
    },
    set_padyam: function(value) {
      this._P = value;
      return value;
    },
    get_rule: function() {
      return this._R;
    },
    set_rule: function(value) {
      this._R = value;
      return value;
    }
  };


  // Chandam.Core.Yati

  function Chandam$Core$Yati() {
    this.p2 = [];
    this.positions = [];
    this.prasaYati = [];
    this.prevContext = [];
  }
  var Chandam$Core$Yati$ = {

  };


  // Chandam.Core.YatiPrasaChecker2

  function Chandam$Core$YatiPrasaChecker2() {
    this._AllowSantiPrasa = false;
    this._NoMoreChecks = false;
    this._SoundBasedSandi = false;
    this._i = new MiriyamUtil.IndicParser();
    this._i.set_charSet(new MiriyamUtil.TeluguCharSet());
    this._virama = '\u0c4d';
    this._HA = '\u0c39';
    this._conso = '\u0c15,\u0c16,\u0c17,\u0c18,\u0c19,\u0c1a,\u0c1b,\u0c1c,\u0c1d,\u0c1e,\u0c1f,\u0c20,\u0c21,\u0c22,\u0c23,\u0c24,\u0c25,\u0c26,\u0c27,\u0c28,\u0c2a,\u0c2b,\u0c2c,\u0c2d,\u0c2e,\u0c2f,\u0c30,\u0c31,\u0c32,\u0c33,\u0c35,\u0c36,\u0c37,\u0c38,\u0c39';
    this._y = '\u0c05,\u0c06,\u0c07,\u0c08,\u0c09,\u0c0a,\u0c0b,\u0c0e,\u0c0f,\u0c0c,\u0c61,\u0c10,\u0c12,\u0c13,\u0c14,\u0c60,\u0c15,\u0c16,\u0c17,\u0c18,\u0c19,\u0c1a,\u0c1b,\u0c1c,\u0c1d,\u0c1e,\u0c1f,\u0c20,\u0c21,\u0c22,\u0c23,\u0c24,\u0c25,\u0c26,\u0c27,\u0c28,\u0c2a,\u0c2b,\u0c2c,\u0c2d,\u0c2e,\u0c2f,\u0c30,\u0c31,\u0c32,\u0c33,\u0c35,\u0c36,\u0c37,\u0c38,\u0c39';
    this._YF = '\u0c3e\u0c3f\u0c40\u0c41\u0c42\u0c43\u0c44\u0c46\u0c47\u0c48\u0c4a\u0c4b\u0c4c\u0c02\u0c03\u0c56\u0c3d\u0c63\u0c62\u0c05,\u0c06,\u0c07,\u0c08,\u0c09,\u0c0a,\u0c0b,\u0c0e,\u0c0f,\u0c0c,\u0c10,\u0c12,\u0c13,\u0c14,\u0c60,\u0c0c,\u0c61';
    this._v = '\u0c05,\u0c06,\u0c07,\u0c08,\u0c09,\u0c0a,\u0c0b,\u0c0e,\u0c0f,\u0c0c,\u0c10,\u0c12,\u0c13,\u0c14,\u0c60,\u0c0c,\u0c61';
    this._f = '\u0c3e\u0c3f\u0c40\u0c41\u0c42\u0c43\u0c44\u0c46\u0c47\u0c48\u0c4a\u0c4b\u0c4c\u0c03\u0c56\u0c63\u0c62';
    this._ruKaaram = '\u0c43';
    this._ru = '\u0c0b';
    this._ruGroup = '\u0c07,\u0c08,\u0c0b,\u0c60,\u0c0e,\u0c0f,\u0c3f,\u0c40,\u0c43,\u0c44,\u0c46,\u0c47';
    this._aGroup = '\u0c3e,\u0c48 ,\u0c4c,\u0c02';
    this._SUNNA = '\u0c02';
    this._prasaGroups = [ '\u0c31,\u0c30', '\u0c28,\u0c23', '\u0c38,\u0c37,\u0c36', '\u0c32,\u0c33,\u0c21,\u0c30', '\u0c2a,\u0c35', '\u0c17,\u0c19', '\u0c1c,\u0c1e', '\u0c21,\u0c23', '\u0c26,\u0c28', '\u0c2c,\u0c2e', '\u0c26,\u0c21', '\u0c15,\u0c17', '\u0c16,\u0c18', '\u0c17,\u0c18', '\u0c1a,\u0c1c', '\u0c1b,\u0c1d', '\u0c1c,\u0c1d', '\u0c1f,\u0c21', '\u0c20,\u0c22', '\u0c21,\u0c22', '\u0c24,\u0c26', '\u0c25,\u0c27', '\u0c26,\u0c27', '\u0c2a,\u0c2c', '\u0c2b,\u0c2d', '\u0c2c,\u0c2d' ];
    this._vowelGroups = [ '\u0c05,\u0c06,\u0c10,\u0c14', '\u0c07,\u0c08,\u0c0b,\u0c60,\u0c0e,\u0c0f', '\u0c09,\u0c0a,\u0c12,\u0c13' ];
    this._vowelAndFinishGroups = [ '\u0c05,\u0c06,\u0c10,\u0c14,\u0c3e,\u0c48 ,\u0c4c', '\u0c07,\u0c08,\u0c0b,\u0c60,\u0c0e,\u0c0f,\u0c3f,\u0c40,\u0c43,\u0c44,\u0c46,\u0c47', '\u0c09,\u0c0a,\u0c12,\u0c13,\u0c41,\u0c42,\u0c4a,\u0c4b' ];
    this._consoGroups = [ '\u0c15,\u0c16,\u0c17,\u0c18', '\u0c1a,\u0c1b,\u0c1c,\u0c1d', '\u0c1f,\u0c20,\u0c21,\u0c22', '\u0c24,\u0c25,\u0c26,\u0c27', '\u0c2a,\u0c2b,\u0c2c,\u0c2d', '\u0c2f,\u0c39', '\u0c30,\u0c31', '\u0c35,\u0c2c', '\u0c32,\u0c33', '\u0c32,\u0c21', '\u0c2a,\u0c35', '\u0c2b,\u0c35', '\u0c2c,\u0c35', '\u0c2d,\u0c35', '\u0c36,\u0c37,\u0c38', '\u0c1a,\u0c1b,\u0c1c,\u0c1d,\u0c36,\u0c37,\u0c38', '\u0c28,\u0c23', '\u0c32,\u0c33,\u0c21,\u0c30' ];
    this._finishGroups = [ '\u0c3e,\u0c48,\u0c4c,\u0c02', '\u0c3f,\u0c40,\u0c43,\u0c44,\u0c46,\u0c47', '\u0c41,\u0c42,\u0c4a,\u0c4b' ];
  }
  var Chandam$Core$YatiPrasaChecker2$ = {
    isYatiMatched: function(s1, s2) {
      s1 = ss.replaceString(s1, '\u0c46\u0c56', '\u0c48');
      s2 = ss.replaceString(s2, '\u0c46\u0c56', '\u0c48');
      var f = false;
      s1 = ss.replaceString(s1, '\u0c3d', '\u0c05');
      s2 = ss.replaceString(s2, '\u0c3d', '\u0c05');
      var f1 = MiriyamUtil.StringPlus.contains(s1, this._ruKaaram);
      var f2 = MiriyamUtil.StringPlus.contains(s2, this._ruKaaram);
      if (f1 && f2) {
        this.set_lastName('\u0c60\u0c24\u0c4d\u0c35\u0c38\u0c4c\u0c2e\u0c4d\u0c2f\u0c35\u0c33\u0c3f');
        return true;
      }
      if (f1 || f2) {
        f = MiriyamUtil.StringPlus.contains(this._ruGroup, s1);
        if (f) {
          this.set_lastName('\u0c0b\u0c24\u0c4d\u0c35\u0c38\u0c02\u0c2c\u0c02\u0c27\u0c35\u0c33\u0c3f');
          return true;
        }
      }
      var f1 = MiriyamUtil.StringPlus.contains(s1, this._ru) || MiriyamUtil.StringPlus.contains(s1, this._ruKaaram);
      var f2 = MiriyamUtil.StringPlus.contains(s2, this._ru) || MiriyamUtil.StringPlus.contains(s2, this._ruKaaram);
      if (f1 || f2) {
        var c1 = MiriyamUtil.StringPlus.charAt((f1) ? s2 : s1, 0);
        if (c1 === '\u0c30') {
          var c2 = MiriyamUtil.StringPlus.charAt((f1) ? s2 : s1, (f1) ? (s2.length - 1) : (s1.length - 1));
          if (c2 === '\u0c3f' || c2 === '\u0c40' || c2 === '\u0c46' || c2 === '\u0c47') {
            this.set_lastName('\u0c0b\u0c35\u0c33\u0c3f');
            return true;
          }
        }
      }
      var C1 = this._extractVowelorFinish(s1);
      var C2 = this._extractVowelorFinish(s2);
      for (var i = 0; i < C1.length; i++) {
        for (var j = 0; j < C2.length; j++) {
          var c1 = C1[i];
          var c2 = C2[j];
          if (c1 === c2) {
            if (!(MiriyamUtil.StringPlus.contains(this._f, c1) && MiriyamUtil.StringPlus.contains(this._f, c2))) {
              this.set_lastName('\u0c38\u0c4d\u0c35\u0c30\u0c2a\u0c4d\u0c30\u0c27\u0c3e\u0c28\u0c35\u0c33\u0c3f');
              return true;
            }
          }
          var t = this._matchGroups(this._vowelAndFinishGroups, c1, c2);
          if (t) {
            if (!(MiriyamUtil.StringPlus.contains(this._f, c1) && MiriyamUtil.StringPlus.contains(this._f, c2))) {
              this.set_lastName('\u0c38\u0c4d\u0c35\u0c30\u0c2a\u0c4d\u0c30\u0c27\u0c3e\u0c28\u0c35\u0c33\u0c3f');
              return true;
            }
          }
        }
      }
      var C1 = this._extractConso(s1);
      var C2 = this._extractConso(s2);
      if (!C1.length || !C2.length) {
        var c1 = (C1.length > 0) ? C1[0] : '';
        var c2 = (C2.length > 0) ? C2[0] : '';
        if (c1 === '\u0c2f' || c1 === '\u0c39') {
          if (MiriyamUtil.StringPlus.contains(s2, '\u0c05')) {
            this.set_lastName('\u0c2a\u0c4d\u0c30\u0c24\u0c4d\u0c2f\u0c47\u0c15 \u0c2f\u0c24\u0c3f');
            return true;
          }
        }
        if (c2 === '\u0c2f' || c2 === '\u0c39') {
          if (MiriyamUtil.StringPlus.contains(s1, '\u0c05')) {
            this.set_lastName('\u0c2a\u0c4d\u0c30\u0c24\u0c4d\u0c2f\u0c47\u0c15 \u0c2f\u0c24\u0c3f');
            return true;
          }
        }
      }
      for (var i = 0; i < C1.length; i++) {
        for (var j = 0; j < C2.length; j++) {
          var c1 = C1[i];
          var c2 = C2[j];
          if (c1 === c2) {
            f = true;
            this.set_lastName('\u0c38\u0c2e\u0c3e\u0c28 \u0c39\u0c32\u0c4d\u0c32\u0c41');
            break;
          }
          if (c1 === '\u0c2f' || c1 === '\u0c39') {
            if (MiriyamUtil.StringPlus.contains(s2, '\u0c05')) {
              this.set_lastName('\u0c2a\u0c4d\u0c30\u0c24\u0c4d\u0c2f\u0c47\u0c15 \u0c2f\u0c24\u0c3f');
              return true;
            }
          }
          if (c2 === '\u0c2f' || c2 === '\u0c39') {
            if (MiriyamUtil.StringPlus.contains(s1, '\u0c05')) {
              this.set_lastName('\u0c2a\u0c4d\u0c30\u0c24\u0c4d\u0c2f\u0c47\u0c15 \u0c2f\u0c24\u0c3f');
              return true;
            }
          }
          f = this._matchGroups(this._consoGroups, c1, c2);
          if (f) {
            this.set_lastName('\u0c38\u0c4d\u0c35\u0c30\u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f\u0c35\u0c33\u0c3f/\u0c0b\u0c1c\u0c41 \u0c2f\u0c24\u0c41\u0c32\u0c41/\u0c0f\u0c15\u0c24\u0c30\u0c2f\u0c24\u0c41\u0c32\u0c41/\u0c05\u0c2d\u0c47\u0c26 \u0c35\u0c3f\u0c30\u0c24\u0c41\u0c32\u0c41/\u0c05\u0c2d\u0c47\u0c26 \u0c35\u0c30\u0c4d\u0c17 \u0c35\u0c3f\u0c30\u0c24\u0c41\u0c32\u0c41/\u0c0a\u0c37\u0c4d\u0c2e \u0c35\u0c3f\u0c36\u0c4d\u0c30\u0c3e\u0c02\u0c24\u0c41\u0c32\u0c41/\u0c38\u0c30\u0c38\u0c2f\u0c24\u0c3f');
            break;
          }
        }
        if (f) {
          break;
        }
      }
      if (!f) {
        var f1 = MiriyamUtil.StringPlus.contains(s1, '\u0c19');
        var f2 = MiriyamUtil.StringPlus.contains(s2, '\u0c19');
        if (f1 || f2) {
          var _f = MiriyamUtil.StringPlus.contains('\u0c02\u0c15,\u0c02\u0c16,\u0c02\u0c17,\u0c02\u0c18', (f1) ? s2 : s1);
          if (_f) {
            this.set_lastName('\u0c35\u0c3f\u0c36\u0c47\u0c37\u0c35\u0c33\u0c3f');
            f = true;
          }
        }
      }
      if (!f) {
        var f1 = MiriyamUtil.StringPlus.contains(s1, '\u0c28') || MiriyamUtil.StringPlus.contains(s1, '\u0c23');
        var f2 = MiriyamUtil.StringPlus.contains(s2, '\u0c28') || MiriyamUtil.StringPlus.contains(s2, '\u0c23');
        if (f1 || f2) {
          var _f = MiriyamUtil.StringPlus.contains((f1) ? s2 : s1, '\u0c19');
          if (_f) {
            this.set_lastName('\u0c24\u0c26\u0c4d\u0c2d\u0c35\u0c35\u0c4d\u0c2f\u0c3e\u0c1c \u0c35\u0c3f\u0c36\u0c4d\u0c30\u0c2e\u0c2e\u0c41\u0c32\u0c41');
            f = true;
          }
        }
      }
      if (!f) {
        var c1 = MiriyamUtil.StringPlus.charAt(s1, 0);
        var c2 = MiriyamUtil.StringPlus.charAt(s2, 0);
        var f1 = (c1 === this._SUNNA);
        var f2 = (c2 === this._SUNNA);
        if (f1 || f2) {
          var c2_1 = '';
          var c1_1 = '';
          if (f1) {
            c2_1 = MiriyamUtil.StringPlus.charAt(s2, 0).toString();
            c1_1 = (s1.length > 1) ? MiriyamUtil.StringPlus.charAt(s1, 1).toString() : '';
          }
          else {
            c2_1 = MiriyamUtil.StringPlus.charAt(s1, 0).toString();
            c1_1 = (s2.length > 1) ? MiriyamUtil.StringPlus.charAt(s2, 1).toString() : '';
          }
          switch (c2_1) {
            default:
              f = this._anuSeriesYati(s1, s2);
              if (!f) {
                f = this._anuSeriesYati(s2, s1);
              }
              if (!f) {
                var _f1 = MiriyamUtil.StringPlus.contains('\u0c02\u0c2f,\u0c02\u0c30,\u0c02\u0c32,\u0c02\u0c35,\u0c02\u0c36,\u0c02\u0c38,\u0c02\u0c37,\u0c02\u0c39', (f1) ? s1 : s2);
                if (_f1) {
                  var _f = MiriyamUtil.StringPlus.contains('\u0c2e', (f1) ? s2 : s1);
                  if (_f) {
                    this.set_lastName('\u0c2e\u0c41\u0c35\u0c30\u0c4d\u0c23  \u0c35\u0c3f\u0c30\u0c3e\u0c2e\u0c02');
                    return true;
                  }
                }
              }
              break;
            case '\u0c19':
              f = MiriyamUtil.StringPlus.contains('\u0c15,\u0c16,\u0c17,\u0c18', c1_1);
              if (f) {
                f = true;
              }
              break;
            case '\u0c1e':
              f = MiriyamUtil.StringPlus.contains('\u0c1a,\u0c1b,\u0c1c,\u0c1d', c1_1);
              if (f) {
                f = true;
              }
              break;
            case '\u0c23':
              f = MiriyamUtil.StringPlus.contains('\u0c24,\u0c25,\u0c26,\u0c27', c1_1) || MiriyamUtil.StringPlus.contains('\u0c1f,\u0c20,\u0c21,\u0c22', c1_1);
              if (f) {
                f = true;
              }
              break;
            case '\u0c28':
              f = MiriyamUtil.StringPlus.contains('\u0c24,\u0c25,\u0c26,\u0c27', c1_1) || MiriyamUtil.StringPlus.contains('\u0c1f,\u0c20,\u0c21,\u0c22', c1_1);
              if (f) {
                f = true;
              }
              break;
            case '\u0c2e':
              f = MiriyamUtil.StringPlus.contains('\u0c2a,\u0c2b,\u0c2c,\u0c2d', c1_1) || MiriyamUtil.StringPlus.contains('\u0c2f,\u0c30,\u0c32,\u0c35,\u0c36,\u0c38,\u0c37,\u0c39', c1_1);
              if (f) {
                f = true;
              }
              break;
          }
        }
      }
      if (f) {
        f = this._matchYatiFinishGroups(s1, s2);
      }
      var c10 = MiriyamUtil.StringPlus.charAt(s1, 0);
      var c1n = MiriyamUtil.StringPlus.charAt(s1, s1.length - 1);
      var c20 = MiriyamUtil.StringPlus.charAt(s2, 0);
      var c2n = MiriyamUtil.StringPlus.charAt(s2, s2.length - 1);
      var f1 = (c10 === '\u0c2e' && MiriyamUtil.StringPlus.contains('\u0c41\u0c42\u0c4a\u0c4b', c1n));
      var f2 = (c20 === '\u0c2e' && MiriyamUtil.StringPlus.contains('\u0c41\u0c42\u0c4a\u0c4b', c2n));
      if (f1 || f2) {
        var _f1 = MiriyamUtil.StringPlus.contains('\u0c2a\u0c2b\u0c2d\u0c2c\u0c2e', ((f1) ? c20 : c10));
        var _f2 = MiriyamUtil.StringPlus.contains('\u0c41\u0c42\u0c4a\u0c4b', ((f1) ? c2n : c1n));
        if (_f1 && _f2) {
          this.set_lastName('\u0c2e\u0c41\u0c35\u0c3f\u0c2d\u0c15\u0c4d\u0c24\u0c3f\u0c2f\u0c24\u0c3f \u0c32\u0c47\u0c26\u0c3e \u0c2e\u0c41\u0c15\u0c3e\u0c30\u0c2f\u0c24\u0c3f');
          return true;
        }
      }
      var f1 = MiriyamUtil.StringPlus.contains(s1, this._HA);
      var f2 = MiriyamUtil.StringPlus.contains(s2, this._HA);
      if (f1 || f2) {
        if (f1 && s2.length >= 3) {
          var c1 = MiriyamUtil.StringPlus.charAt(s2, 0);
          var c2 = MiriyamUtil.StringPlus.charAt(s2, 1);
          var c3 = MiriyamUtil.StringPlus.charAt(s2, 2);
          if (c2 === this._virama) {
            f = this._isJhuyMatch(c1, c3);
            if (f) {
              this.set_lastName('\u0c05\u0c02\u0c24\u0c4d\u0c2f\u0c4b\u0c37\u0c4d\u0c2e \u0c38\u0c02\u0c27\u0c3f \u0c15\u0c33\u0c41\u0c32\u0c41');
              return true;
            }
          }
        }
        if (f2 && s1.length >= 3) {
          var c1 = MiriyamUtil.StringPlus.charAt(s1, 0);
          var c2 = MiriyamUtil.StringPlus.charAt(s1, 1);
          var c3 = MiriyamUtil.StringPlus.charAt(s1, 2);
          if (c2 === this._virama) {
            f = this._isJhuyMatch(c1, c3);
            if (f) {
              this.set_lastName('\u0c05\u0c02\u0c24\u0c4d\u0c2f\u0c4b\u0c37\u0c4d\u0c2e \u0c38\u0c02\u0c27\u0c3f \u0c15\u0c33\u0c41\u0c32\u0c41');
              return true;
            }
          }
        }
      }
      if (this.get_soundexSandhi()) {
        f = this._matchYatiFinishGroups(s1, s2);
      }
      return f;
    },
    _matchYatiFinishGroups: function(s1, s2) {
      var f = false;
      var C1 = this._extractFinish(s1);
      var C2 = this._extractFinish(s2);
      if (!C1.length && !C2.length) {
        return true;
      }
      if (!C1.length) {
        var $enum1 = ss.enumerate(C2);
        while ($enum1.moveNext()) {
          var _s = $enum1.current;
          f = MiriyamUtil.StringPlus.contains(this._aGroup, _s);
          if (f) {
            return true;
          }
        }
      }
      if (!C2.length) {
        var $enum2 = ss.enumerate(C1);
        while ($enum2.moveNext()) {
          var _s = $enum2.current;
          f = MiriyamUtil.StringPlus.contains(this._aGroup, _s);
          if (f) {
            return true;
          }
        }
      }
      for (var i = 0; i < C1.length; i++) {
        for (var j = 0; j < C2.length; j++) {
          var c1 = C1[i];
          var c2 = C2[j];
          f = this._matchGroups(this._finishGroups, c1, c2);
          if (f) {
            return true;
          }
        }
      }
      return f;
    },
    _anuSeriesYati: function(s1, s2) {
      var f = false;
      var _f1 = MiriyamUtil.StringPlus.contains('\u0c02\u0c1f,\u0c02\u0c20,\u0c02\u0c21,\u0c02\u0c22', s1);
      var _f2 = MiriyamUtil.StringPlus.contains('\u0c02\u0c24,\u0c02\u0c25,\u0c02\u0c26,\u0c02\u0c27', s2);
      if (_f1 && _f2) {
        return true;
      }
      if (_f1) {
        var _f = MiriyamUtil.StringPlus.contains('\u0c28', s2);
        if (_f) {
          return true;
        }
      }
      if (_f1) {
        var _f = MiriyamUtil.StringPlus.contains('\u0c23', s2);
        if (_f) {
          return true;
        }
      }
      return f;
    },
    _isJhuyMatch: function(c1, c3) {
      switch (c1) {
        case '\u0c15':
          if (c3 === '\u0c16') {
            return true;
          }
          break;
        case '\u0c17':
          if (c3 === '\u0c18') {
            return true;
          }
          break;
        case '\u0c1a':
          if (c3 === '\u0c1b') {
            return true;
          }
          break;
        case '\u0c1c':
          if (c3 === '\u0c1d') {
            return true;
          }
          break;
        case '\u0c1f':
          if (c3 === '\u0c20') {
            return true;
          }
          break;
        case '\u0c21':
          if (c3 === '\u0c22') {
            return true;
          }
          break;
        case '\u0c24':
          if (c3 === '\u0c25') {
            return true;
          }
          break;
        case '\u0c26':
          if (c3 === '\u0c27') {
            return true;
          }
          break;
        case '\u0c2a':
          if (c3 === '\u0c2b') {
            return true;
          }
          break;
        case '\u0c2c':
          if (c3 === '\u0c2d') {
            return true;
          }
          break;
      }
      return false;
    },
    isPrasaMatched: function(s1, s2) {
      s1 = ss.replaceString(s1, '\u0c46\u0c56', '\u0c48');
      s2 = ss.replaceString(s2, '\u0c46\u0c56', '\u0c48');
      var f1 = MiriyamUtil.StringPlus.contains(this._v, s1);
      var f2 = MiriyamUtil.StringPlus.contains(this._v, s2);
      if (f1 || f2) {
        return true;
      }
      var T1 = new MiriyamUtil.TeluguParser();
      var A1 = T1.split(s1);
      var T2 = new MiriyamUtil.TeluguParser();
      var A2 = T2.split(s2);
      var C1 = this._extractConsoOrVowel(s1);
      var C2 = this._extractConsoOrVowel(s2);
      if (A1.length > 1) {
        C1 = this._extractConsoOrVowel(A1[0].toString2());
      }
      if (A2.length > 1) {
        C2 = this._extractConsoOrVowel(A2[0].toString2());
      }
      if (C1.length === C2.length) {
        var f = this._matchPrasaConsos(C1, C2);
        if (f) {
          if (this.get_lastName() == null) {
            this.set_lastName('\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c35\u0c48\u0c30\u0c2e\u0c41/\u0c2a\u0c4d\u0c30\u0c3e\u0c26\u0c3f \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41/\u0c36-\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41/\u0c05\u0c2d\u0c47\u0c26 \u0c2a\u0c4d\u0c30\u0c3e\u0c38/\u0c05\u0c2a\u0c4d\u0c30\u0c36\u0c38\u0c4d\u0c24 \u0c2a\u0c4d\u0c30\u0c3e\u0c38/\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41/\u0c35\u0c3f\u0c15\u0c32\u0c4d\u0c2a \u0c2a\u0c4d\u0c30\u0c3e\u0c38/\u0c38\u0c4d\u0c35\u0c35\u0c30\u0c4d\u0c17\u0c1c \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
          }
          return true;
        }
        return this._matchSantaPrasa(C1, C2);
      }
      else {
        if ((C1.length === 1 && C2.length === 2) || (C1.length === 2 && C1.length === 1)) {
          if (C1.length === 1 && C2.length === 2) {
            if (C2[1] === '\u0c32' || C2[1] === '\u0c30') {
              C2.splice(1, 1);
              var f = this._matchPrasaConsos(C1, C2);
              if (f) {
                if (this.get_lastName() == null) {
                  this.set_lastName('\u0c38\u0c02\u0c2f\u0c41\u0c24\u0c3e\u0c38\u0c02\u0c2f\u0c41\u0c24 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
                }
                return true;
              }
              return this._matchSantaPrasa(C1, C2);
            }
          }
          if (C2.length === 1 && C1.length === 2) {
            if (C1[1] === '\u0c32' || C1[1] === '\u0c30') {
              C2.splice(1, 1);
              var f = this._matchPrasaConsos(C1, C2);
              if (f) {
                if (this.get_lastName() == null) {
                  this.set_lastName('\u0c38\u0c02\u0c2f\u0c41\u0c24\u0c3e\u0c38\u0c02\u0c2f\u0c41\u0c24 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
                }
                return true;
              }
              return this._matchSantaPrasa(C1, C2);
            }
          }
        }
        if (C1.length === C2.length && (A1.length > 1 || A2.length > 1)) {
          var f = this._matchPrasaConsos(C1, C2);
          if (f) {
            return true;
          }
        }
        return this._matchSantaPrasa(C1, C2);
      }
    },
    _matchSantaPrasa: function(C1, C2) {
      if (!this._AllowSantiPrasa) {
        return false;
      }
      if (C1.length < 1 || C2.length < 1) {
        return false;
      }
      var f = (C1[0] === C2[0]);
      if (f) {
        this.set_lastName('\u0c36\u0c3e\u0c02\u0c24\u0c3f\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        return true;
      }
      f = (C1[C1.length - 1] === C2[C2.length - 1]);
      if (f) {
        this.set_lastName('\u0c36\u0c3e\u0c02\u0c24\u0c3f\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        return true;
      }
      return false;
    },
    _tryMatch: function(c1, c2) {
      var f = false;
      if (c1 === c2) {
        return true;
      }
      f = this._matchGroups(this._prasaGroups, c1, c2);
      if (f) {
        return true;
      }
      return f;
    },
    _matchPrasaConsos: function(C1, C2) {
      var f = false;
      if (C2.length === 2 && C1.length === 2) {
        if (C1[0] === '\u0c30' && C2[0] === C2[1] && C1[1] === C2[0]) {
          this.set_lastName('\u0c35\u0c32\u0c2a\u0c32\u0c3f\u0c17\u0c3f\u0c32\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
          this.set_noMoreChecks(true);
          return true;
        }
        if (C2[0] === '\u0c30' && C1[0] === C1[1] && C2[1] === C1[0]) {
          this.set_lastName('\u0c35\u0c32\u0c2a\u0c32\u0c3f\u0c17\u0c3f\u0c32\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
          this.set_noMoreChecks(true);
          return true;
        }
        if (C2[0] === '\u0c19' && C2[1] === '\u0c1e' && C1[0] === '\u0c17' && C1[1] === '\u0c28') {
          this.set_lastName('\u0c35\u0c3f\u0c15\u0c32\u0c4d\u0c2a \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
          return true;
        }
        if (C1[0] === '\u0c19' && C1[1] === '\u0c1e' && C2[0] === '\u0c17' && C2[1] === '\u0c28') {
          this.set_lastName('\u0c35\u0c3f\u0c15\u0c32\u0c4d\u0c2a \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
          return true;
        }
      }
      for (var i = 0; i < C1.length; i++) {
        var c1 = C1[i];
        var c2 = C2[i];
        if (c1 === c2) {
          f = true;
          continue;
        }
        f = this._matchGroups(this._prasaGroups, c1, c2);
        if (!f) {
          return false;
        }
      }
      return f;
    },
    isPrasaMatched2: function(P1, P2) {
      var C1 = this._extractConsoOrVowel(P1.get_value());
      var C2 = this._extractConsoOrVowel(P2.get_value());
      var f1 = MiriyamUtil.StringPlus.endsWith(P1.get_poorva(), this._SUNNA);
      var f2 = MiriyamUtil.StringPlus.endsWith(P2.get_poorva(), this._SUNNA);
      if (f1 && C1.length === 1 && C1[0] === this._HA && C2.length === 2 && C2[0] === this._HA && C2[1] === '\u0c35') {
        this.set_lastName('\u0c35\u0c3f\u0c15\u0c32\u0c4d\u0c2a \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
        return true;
      }
      if (f2 && C2.length === 1 && C2[0] === this._HA && C1.length === 2 && C1[0] === this._HA && C1[1] === '\u0c35') {
        this.set_lastName('\u0c35\u0c3f\u0c15\u0c32\u0c4d\u0c2a \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
        return true;
      }
      if (f1 && C1.length === 1 && (C1[0] === '\u0c28' || C1[0] === '\u0c2e') && C2.length === 2 && C2[0] === C2[1] && (C2[0] === C1[0])) {
        this.set_lastName('\u0c05\u0c28\u0c41\u0c28\u0c3e\u0c38\u0c3f\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        this.set_noMoreChecks(true);
        return true;
      }
      if (f2 && C2.length === 1 && (C2[0] === '\u0c28' || C2[0] === '\u0c2e') && C1.length === 2 && C1[0] === C1[1] && (C2[0] === C1[0])) {
        this.set_lastName('\u0c05\u0c28\u0c41\u0c28\u0c3e\u0c38\u0c3f\u0c15 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        this.set_noMoreChecks(true);
        return true;
      }
      if (f1 && C1.length === 1 && C1[0] === '\u0c2c' && C2.length === 2 && C2[0] === C2[1] && C2[0] === '\u0c2e') {
        this.set_lastName('\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
        this.set_noMoreChecks(true);
        return true;
      }
      if (f2 && C2.length === 1 && C2[0] === '\u0c2c' && C1.length === 2 && C1[0] === C1[1] && C1[0] === '\u0c2e') {
        this.set_lastName('\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
        this.set_noMoreChecks(true);
        return true;
      }
      if (f1 && f2 && (C1.length >= 1 && C2.length >= 1) && ((C1[0] === '\u0c2c' && C2[0] === '\u0c2e') || (C2[0] === '\u0c2e' && C1[0] === '\u0c2c'))) {
        this.set_lastName('\u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c48\u0c24\u0c4d\u0c30\u0c3f \u0c2a\u0c4d\u0c30\u0c3e\u0c38');
        this.set_noMoreChecks(true);
        return true;
      }
      if (C1.length === 2 && C1[0] === '\u0c28' && f2 && C2.length === 1 && C2[0] === C1[1]) {
        this.set_lastName('\u0c2c\u0c3f\u0c02\u0c26\u0c41 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        return true;
      }
      if (C2.length === 2 && C2[0] === '\u0c28' && f1 && C1.length === 1 && C1[0] === C2[1]) {
        this.set_lastName('\u0c2c\u0c3f\u0c02\u0c26\u0c41 \u0c2a\u0c4d\u0c30\u0c3e\u0c38\u0c2e\u0c41');
        return true;
      }
      return false;
    },
    isPrasaMatched3: function(P1, P2) {
      this.set_noMoreChecks(false);
      var res = this.isPrasaMatched(P1.get_value(), P2.get_value());
      if (!res) {
        res = this.isPrasaMatched2(P1, P2);
      }
      return res;
    },
    _extractConsoOrVowel: function(s1) {
      var L = [];
      var $enum1 = ss.enumerate(MiriyamUtil.StringPlus.toCharArray(s1));
      while ($enum1.moveNext()) {
        var c = $enum1.current;
        var f = MiriyamUtil.StringPlus.contains(this._y, c);
        if (f) {
          L.push(c);
        }
      }
      return L;
    },
    _extractVowelorFinish: function(s1) {
      var L = [];
      var $enum1 = ss.enumerate(MiriyamUtil.StringPlus.toCharArray(s1));
      while ($enum1.moveNext()) {
        var c = $enum1.current;
        var f = MiriyamUtil.StringPlus.contains(this._YF, c);
        if (f) {
          L.push(c);
        }
      }
      return L;
    },
    _extractConso: function(s1) {
      var L = [];
      var IA = new MiriyamUtil.IndicAkshar();
      IA.setChars(s1, this._i.get_charSet());
      var $enum1 = ss.enumerate(MiriyamUtil.StringPlus.toCharArray(s1));
      while ($enum1.moveNext()) {
        var c = $enum1.current;
        var f = MiriyamUtil.StringPlus.contains(this._conso, c);
        if (f) {
          L.push(c);
        }
      }
      return L;
    },
    _extractFinish: function(s1) {
      var L = [];
      var $enum1 = ss.enumerate(MiriyamUtil.StringPlus.toCharArray(s1));
      while ($enum1.moveNext()) {
        var c = $enum1.current;
        var f = MiriyamUtil.StringPlus.contains(this._f, c);
        if (f) {
          L.push(c);
        }
      }
      return L;
    },
    _extractConsoOrFinish: function(s1) {
      var L = [];
      var $enum1 = ss.enumerate(MiriyamUtil.StringPlus.toCharArray(s1));
      while ($enum1.moveNext()) {
        var c = $enum1.current;
        var f = MiriyamUtil.StringPlus.contains(this._y, c);
        if (f) {
          L.push(c);
        }
      }
      return L;
    },
    _matchGroups: function(Groups, c1, c2) {
      var f = false;
      var $enum1 = ss.enumerate(Groups);
      while ($enum1.moveNext()) {
        var group = $enum1.current;
        f = this._isGroupMatched(group, c1, c2);
        if (f) {
          return true;
        }
      }
      return false;
    },
    _isGroupMatched: function(g, s1, s2) {
      var f = MiriyamUtil.StringPlus.contains(g, s1) && MiriyamUtil.StringPlus.contains(g, s2);
      return f;
    },
    get_lastName: function() {
      return this._last;
    },
    set_lastName: function(value) {
      this._last = value;
      return value;
    },
    get_allowSantiPrasa: function() {
      return this._AllowSantiPrasa;
    },
    set_allowSantiPrasa: function(value) {
      this._AllowSantiPrasa = value;
      return value;
    },
    get_soundexSandhi: function() {
      return this._SoundBasedSandi;
    },
    set_soundexSandhi: function(value) {
      this._SoundBasedSandi = value;
      return value;
    },
    get_noMoreChecks: function() {
      return this._NoMoreChecks;
    },
    set_noMoreChecks: function(value) {
      this._NoMoreChecks = value;
      return value;
    }
  };


  // Chandam.Random

  function Chandam$Random() {
  }
  var Chandam$Random$ = {
    _next: function(p) {
      return Math.floor(Math.random() * p);
    }
  };


  // Chandam.Core.GanaVibhajana

  function Chandam$Core$GanaVibhajana(str, Lang) {
    this._lines$2 = 0;
    this._preLines$2 = 0;
    this._lang$2 = 0;
    MiriyamUtil.IndicParser.call(this);
    try {
      this.set_language(Lang);
      this.set_charSet(this._getLangCharSet$2());
      this._init$2();
      this._RawString$2 = str;
      if (str != null) {
        this._analyse$2();
      }
    }
    catch (ex) {
      throw new Error('Analysis failed as ..' + ex.message);
    }
  }
  var Chandam$Core$GanaVibhajana$ = {
    _getLangCharSet$2: function() {
      switch (this.get_language()) {
        case MiriyamUtil.RuleLanguage.telugu:
        default:
          return new MiriyamUtil.TeluguCharSet();
        case MiriyamUtil.RuleLanguage.kannada:
          return new MiriyamUtil.KannadaCharSet();
      }
    },
    _getLangAkshar$2: function() {
      switch (this.get_language()) {
        case MiriyamUtil.RuleLanguage.telugu:
        default:
          return new MiriyamUtil.TeluguAksharam();
        case MiriyamUtil.RuleLanguage.kannada:
          return new MiriyamUtil.KannadaAksharam();
      }
    },
    _analyse$2: function() {
      this._invarientVibhajana2$2(this._RawString$2);
    },
    get_accept: function() {
      return "!?,;.'";
    },
    _invarientVibhajana2$2: function(s) {
      var ICS = this.split(s);
      if (ICS == null) {
        return;
      }
      ICS = this._leftTrimLines$2(ICS);
      var L = [];
      var c = 0;
      var prev = '';
      var $enum1 = ss.enumerate(ICS);
      while ($enum1.moveNext()) {
        var A2 = $enum1.current;
        var curr = A2.toString2();
        var bypass = false;
        if (A2.get_chars().length === 1) {
          if (MiriyamUtil.StringPlus.contains(this.get_accept(), curr)) {
            this.get_raw().push(curr);
            curr = ' ';
            bypass = true;
          }
          if (MiriyamUtil.StringPlus.contains('-', curr)) {
            this.get_raw().push(curr);
            curr = '';
            bypass = false;
          }
        }
        if (!bypass) {
          if (!A2.get_isValid() || !A2.get_length()) {
            continue;
          }
        }
        if (curr === prev && (curr === MiriyamUtil.Constants.space || curr === MiriyamUtil.Constants.newLine)) {
          continue;
        }
        var T = new MiriyamUtil.IndicAkshar();
        T.setChars(curr, this.get_charSet());
        if (T.get_isPolluEnder()) {
          if (c - 1 >= 0) {
            this.get_raw()[this.get_raw().length - 1] = L[c - 1].toString2() + curr;
            T = this._getLangAkshar$2();
            T.setChars(L[c - 1].toString2() + curr, this.get_charSet());
            L[c - 1] = T;
            continue;
          }
        }
        this.get_raw().push(curr);
        L.push(T);
        prev = curr;
        c++;
      }
      var NL = false;
      var lastSym = '';
      var lastChar = '';
      var flg = false;
      var $enum2 = ss.enumerate(L);
      while ($enum2.moveNext()) {
        var T = $enum2.current;
        var currSym = T.getSymbol();
        if (currSym === MiriyamUtil.Constants.newLine) {
          NL = true;
          continue;
        }
        if (T.get_isCompoundChar() && !T.get_isPolluEnder()) {
          if (lastChar !== MiriyamUtil.Constants.blank && lastChar !== MiriyamUtil.Constants.space) {
            if (T.get_changePrev()) {
              lastSym = MiriyamUtil.Symbols.GURUVU;
            }
            if (!T.get_alwaysGuruvu()) {
              currSym = MiriyamUtil.Symbols.LAGHUVU;
            }
          }
        }
        else if (T.get_isPolluEnder()) {
          if (T.get_isCompoundChar() && lastChar !== MiriyamUtil.Constants.blank && lastChar !== MiriyamUtil.Constants.space) {
            if (T.get_changePrev()) {
              lastSym = MiriyamUtil.Symbols.GURUVU;
            }
            if (!T.get_alwaysGuruvu()) {
              currSym = MiriyamUtil.Symbols.LAGHUVU;
            }
          }
          currSym = MiriyamUtil.Symbols.GURUVU;
        }
        this._SymbStream$2 = this._SymbStream$2 + lastSym;
        this._StrStream$2 = this._StrStream$2 + lastChar + ((flg) ? MiriyamUtil.Constants.space : MiriyamUtil.Constants.blank);
        this._RawStrStream$2 = this._RawStrStream$2 + lastChar;
        if (!!lastChar) {
          this._GSplit$2.push(lastChar);
        }
        if (NL) {
          this._StrStream$2 = this._StrStream$2 + MiriyamUtil.Constants.newLine;
          this._SymbStream$2 = this._SymbStream$2 + MiriyamUtil.Constants.newLine;
          this._RawStrStream$2 = this._RawStrStream$2 + lastChar + MiriyamUtil.Constants.newLine;
          this._GSplit$2.push(MiriyamUtil.Constants.newLine);
          NL = false;
          lastChar = T.toString2();
          lastSym = currSym;
          continue;
        }
        lastSym = currSym;
        lastChar = T.toString2();
        flg = T.get_isPolluEnder();
      }
      if (lastSym !== MiriyamUtil.Constants.blank || lastChar !== MiriyamUtil.Constants.blank) {
        this._SymbStream$2 = this._SymbStream$2 + lastSym;
        this._StrStream$2 = this._StrStream$2 + lastChar + ((flg) ? MiriyamUtil.Constants.space : MiriyamUtil.Constants.blank);
        this._RawStrStream$2 = this._RawStrStream$2 + lastChar;
        this._GSplit$2.push(lastChar);
      }
      var _prel = 0;
      var $enum3 = ss.enumerate(ss.replaceString(this._SymbStream$2, ' ', '').split('\n'));
      while ($enum3.moveNext()) {
        var l = $enum3.current;
        if (l.length > 1) {
          _prel++;
        }
      }
      this.set_preLines(_prel);
    },
    _leftTrimLines$2: function(input) {
      var List = [];
      var newLineFound = false;
      var $enum1 = ss.enumerate(input);
      while ($enum1.moveNext()) {
        var ICS = $enum1.current;
        if (ICS.toString2() === MiriyamUtil.Constants.newLine) {
          newLineFound = true;
          List.push(ICS);
          continue;
        }
        if (newLineFound) {
          if (ICS.toString2() === MiriyamUtil.Constants.space) {
            continue;
          }
        }
        newLineFound = false;
        List.push(ICS);
      }
      var output = new Array(List.length);
      for (var i = 0; i < List.length; i++) {
        output[i] = List[i];
      }
      return output;
    },
    _init$2: function() {
      this._SymbStream$2 = '';
      this._StrStream$2 = '';
      this._RawStrStream$2 = '';
      this._GNamesString$2 = '';
      this._GSplit$2 = [];
      this._GNames$2 = [];
      this._GSymbols$2 = [];
      this._GString$2 = [];
      this._Yati$2 = [];
      this._Y1$2 = [];
      this._Raw$2 = [];
      this._PrasaYati$2 = [];
      this._PrevYati$2 = [];
      this._APrasa$2 = [];
      this._PP$2 = [];
      this._PP2$2 = [];
      this._preLines$2 = 0;
    },
    get_preLines: function() {
      return this._preLines$2;
    },
    set_preLines: function(value) {
      this._preLines$2 = value;
      return value;
    },
    get_rawString: function() {
      return this._RawString$2;
    },
    set_rawString: function(value) {
      this._RawString$2 = value;
      return value;
    },
    get_prevYati: function() {
      return this._PrevYati$2;
    },
    set_prevYati: function(value) {
      this._PrevYati$2 = value;
      return value;
    },
    get_prasaYati: function() {
      return this._PrasaYati$2;
    },
    set_prasaYati: function(value) {
      this._PrasaYati$2 = value;
      return value;
    },
    get_raw: function() {
      return this._Raw$2;
    },
    set_raw: function(value) {
      this._Raw$2 = value;
      return value;
    },
    get_rawStrStream: function() {
      return this._RawStrStream$2;
    },
    set_rawStrStream: function(value) {
      this._RawStrStream$2 = value;
      return value;
    },
    get_symbolsStream: function() {
      return this._SymbStream$2;
    },
    set_symbolsStream: function(value) {
      this._SymbStream$2 = value;
      return value;
    },
    get_stringStream: function() {
      return this._StrStream$2;
    },
    set_stringStream: function(value) {
      this._StrStream$2 = value;
      return value;
    },
    get_gNamesStream: function() {
      return this._GNamesString$2;
    },
    set_gNamesStream: function(value) {
      this._GNamesString$2 = value;
      return value;
    },
    get_gWiseString: function() {
      return this._GSplit$2;
    },
    set_gWiseString: function(value) {
      this._GSplit$2 = value;
      return value;
    },
    get_yati: function() {
      return this._Y1$2;
    },
    set_yati: function(value) {
      this._Y1$2 = value;
      return value;
    },
    get_prasa: function() {
      return this._PP$2;
    },
    set_prasa: function(value) {
      this._PP$2 = value;
      return value;
    },
    get_anthyaPrasa: function() {
      return this._PP2$2;
    },
    set_anthyaPrasa: function(value) {
      this._PP2$2 = value;
      return value;
    },
    get_gNames: function() {
      return this._GNames$2;
    },
    set_gNames: function(value) {
      this._GNames$2 = value;
      return value;
    },
    get_gSymbols: function() {
      return this._GSymbols$2;
    },
    set_gSymbols: function(value) {
      this._GSymbols$2 = value;
      return value;
    },
    get_gString: function() {
      return this._GString$2;
    },
    set_gString: function(value) {
      this._GString$2 = value;
      return value;
    },
    get_lines: function() {
      return this._lines$2;
    },
    set_lines: function(value) {
      this._lines$2 = value;
      return value;
    },
    get_min: function() {
      var _LSymbols = ss.replaceString(this.get_symbolsStream(), ' ', '').split('\n');
      var min = 99999;
      var $enum1 = ss.enumerate(_LSymbols);
      while ($enum1.moveNext()) {
        var _LSymbol = $enum1.current;
        if (_LSymbol.length < min) {
          min = _LSymbol.length;
        }
      }
      return min;
    },
    get_max: function() {
      var _LSymbols = ss.replaceString(this.get_symbolsStream(), ' ', '').split('\n');
      var max = 0;
      var $enum1 = ss.enumerate(_LSymbols);
      while ($enum1.moveNext()) {
        var _LSymbol = $enum1.current;
        if (_LSymbol.length > max) {
          max = _LSymbol.length;
        }
      }
      return max;
    },
    get_language: function() {
      return this._lang$2;
    },
    set_language: function(value) {
      this._lang$2 = value;
      return value;
    },
    clone: function() {
      var G = new Chandam$Core$GanaVibhajana(null, this.get_language());
      G.set_gWiseString(this._copy$2(this.get_gWiseString()));
      G.set_rawString(this.get_rawString());
      G.set_gWiseString(this.get_gWiseString());
      G.set_raw(this.get_raw());
      G.set_stringStream(this.get_stringStream());
      G.set_symbolsStream(this.get_symbolsStream());
      G.set_preLines(this.get_preLines());
      return G;
    },
    _copy$2: function(list) {
      var L = [];
      var $enum1 = ss.enumerate(list);
      while ($enum1.moveNext()) {
        var s = $enum1.current;
        L.push(s);
      }
      return L;
    }
  };


  var $exports = ss.module('MiriyamLib2', null,
    {
      CheatSheet: [ Chandam$Rules$CheatSheet, Chandam$Rules$CheatSheet$, null ],
      SortHelper2: [ Chandam$Rules$SortHelper2, Chandam$Rules$SortHelper2$, null ],
      MachinePoem: [ Library$Chandam$Labs$MachinePoem, Library$Chandam$Labs$MachinePoem$, null ],
      BarGraph: [ Chandam$Reports$BarGraph, Chandam$Reports$BarGraph$, null ],
      BarGraphValue: [ Chandam$Reports$BarGraphValue, Chandam$Reports$BarGraphValue$, null ],
      ChandamReports: [ Library$Reports$ChandamReports, Library$Reports$ChandamReports$, null ],
      YatiPrasaTester: [ Chandam$Extensions$YatiPrasaTester, Chandam$Extensions$YatiPrasaTester$, null ],
      Errors: [ Chandam$Core$Errors, Chandam$Core$Errors$, null ],
      MatchOptions: [ Chandam$Core$MatchOptions, Chandam$Core$MatchOptions$, null ],
      MatchResult: [ Chandam$Core$MatchResult, Chandam$Core$MatchResult$, null ],
      Padyam: [ Chandam$Core$Padyam, Chandam$Core$Padyam$, null ],
      Prasa: [ Chandam$Core$Prasa, Chandam$Core$Prasa$, null ],
      Probable: [ Chandam$Core$Probable, Chandam$Core$Probable$, null ],
      Yati: [ Chandam$Core$Yati, Chandam$Core$Yati$, null ],
      YatiPrasaChecker2: [ Chandam$Core$YatiPrasaChecker2, Chandam$Core$YatiPrasaChecker2$, null ],
      Random: [ Chandam$Random, Chandam$Random$, null ],
      GanaVibhajana: [ Chandam$Core$GanaVibhajana, Chandam$Core$GanaVibhajana$, MiriyamUtil.IndicParser ]
    });


  return $exports;
});
