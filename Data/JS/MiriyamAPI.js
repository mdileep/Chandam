"use strict";

define('MiriyamAPI', ['ss', 'MiriyamUtil', 'MiriyamLib2'], function(ss, MiriyamUtil, MiriyamLib2) {
  var $global = this;

  // Chandam.Core.Business

  function Chandam$Core$Business() {
  }
  Chandam$Core$Business.buildResult = function(R, P, MR, Candidates, showGV) {
    var handleProse = (Candidates != null);
    var sb = new ss.StringBuilder();
    sb.appendLine("<div class='padyam'>");
    sb.appendLine("<div class='chandassu'  title='" + R.get_name() + "'>" + R.get_shortName() + '</div>');
    sb.appendLine("<div class='poem'>");
    sb.appendLine(P.build2(MR));
    sb.appendLine('</div>');
    if (showGV) {
      sb.append("<div class='open'>[O]</div>");
    }
    sb.appendLine('</div>');
    if (showGV) {
      sb.append("<div class='ganaVibhajana'>");
      sb.appendLine(Chandam$Core$Business.buildResult4(R, P, MR, Candidates));
      sb.appendLine('</div>');
    }
    return sb.toString2();
  };
  Chandam$Core$Business.buildResult4 = function(R, P, MR, Candidates) {
    var sb = new ss.StringBuilder();
    if (MR.get_percentage() !== 100) {
      sb.appendLine("<div class='err' style='text-align:center;width:100%;'>" + R.get_shortName());
      sb.appendLine(": <b class='percentage'>" + parseFloat(MR.get_percentage().toString()).toFixed() + '%</b>(' + MR.get_score() + '/' + MR.get_total() + ')');
      sb.appendLine('</div>');
    }
    else {
      sb.appendLine("<div class='err Green' style='text-align:center;width:100%;'>");
      sb.appendLine(R.get_shortName());
      sb.appendLine('</div>');
    }
    if (!R.get_infiniteLength()) {
      sb.appendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>\u0c17\u0c23 \u0c35\u0c3f\u0c2d\u0c1c\u0c28</div>");
      sb.appendLine(P.build(MR));
      sb.appendLine('</div>');
      if (MR.get_percentage() !== 100) {
        sb.appendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c41</div>");
        sb.appendLine(MR.showErrors(MiriyamUtil.OutputFormat.HTML));
        sb.appendLine('</div>');
      }
    }
    else {
      if (MR.get_percentage() !== 100) {
        sb.appendLine("<div style='float:left;width:50%;margin-right:10px;'><div class='err' style='text-align:right;'>\u0c26\u0c4b\u0c37\u0c3e\u0c32\u0c41</div>");
        sb.appendLine(MR.showErrors(MiriyamUtil.OutputFormat.HTML));
        sb.appendLine('</div>');
      }
      sb.appendLine("<div style='float:left;width:40%;margin-left:10px;'><div class='err'>\u0c17\u0c23 \u0c35\u0c3f\u0c2d\u0c1c\u0c28</div>");
      sb.appendLine(P.build(MR));
      sb.appendLine('</div>');
    }
    return sb.toString2();
  };
  Chandam$Core$Business.determine = function(s, Options2) {
    if (s == null || !s.trim().length) {
      return null;
    }
    var Options = MiriyamAPI$Worker.getOptions(Options2);
    var Pr = MiriyamLib2.Padyam.mostProbable(s, Options);
    return Pr;
  };
  Chandam$Core$Business.buildResult2 = function(Pr, showGV) {
    if (Pr == null) {
      return '';
    }
    var P = Pr.get_padyam();
    var MR = Pr.get_matchResult();
    var R = Pr.get_rule();
    if (!MR.get_total()) {
      return '';
    }
    var s2 = Chandam$Core$Business.buildResult(R, P, MR, Pr.get_candiates(), showGV);
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
    var Options2 = MiriyamAPI$Worker.getOptions(Options);
    var P = new MiriyamLib2.Padyam();
    P.set_matchYati(Options2.get_matchYati());
    P.set_matchPrasa(Options2.get_matchPrasa());
    P.set_allowSantiPrasa(Options2.get_allowSantiPrasa());
    P.set_sandiMatch(Options2.get_experimenatalSandhi());
    var MR = P.match(s, R);
    if (!MR.get_total()) {
      return '';
    }
    return Chandam$Core$Business.buildResult(R, P, MR, null, (Options == null) ? true : Options.showGV);
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


  // MiriyamAPI.Worker

  function MiriyamAPI$Worker() {
  }
  MiriyamAPI$Worker.beautifyAll = function(identifier, parent, Options2) {
    var List = (parent == null) ? document.getElementsByTagName('*') : parent.getElementsByTagName('*');
    if (List == null) {
      return;
    }
    var L = new Array(List.length);
    for (var i = 0; i < List.length; i++) {
      L[i] = List[i];
    }
    if (Options2 == null) {
      Options2 = MiriyamApp$MapRules.defaultOptions();
      Options2.showGV = true;
    }
    for (var i = 0; i < L.length; i++) {
      var elem = L[i];
      var chandam = elem.getAttribute('chandam');
      var identifier2 = elem.getAttribute('chandassu');
      if (chandam === '0') {
        continue;
      }
      if (chandam === '1' || !!identifier2) {
        if (identifier2 != null && !!identifier2) {
          MiriyamAPI$Worker.beautify(elem, identifier2, Options2);
        }
        else {
          MiriyamAPI$Worker.beautify(elem, identifier, Options2);
        }
      }
    }
  };
  MiriyamAPI$Worker.beautifyId = function(id, identifier, Options2) {
    MiriyamAPI$Worker.beautify(document.getElementById(id), identifier, Options2);
  };
  MiriyamAPI$Worker.beautifyTags = function(tag, identifier, Options2) {
    var List = document.getElementsByTagName(tag);
    var L = new Array(List.length);
    for (var i = 0; i < List.length; i++) {
      L[i] = List[i];
    }
    if (Options2 == null) {
      Options2 = MiriyamApp$MapRules.defaultOptions();
      Options2.showGV = true;
    }
    var $enum1 = ss.enumerate(L);
    while ($enum1.moveNext()) {
      var e = $enum1.current;
      if (e.tagName.toLowerCase() === 'div') {
        return;
      }
      MiriyamAPI$Worker.beautify(e, identifier, Options2);
    }
  };
  MiriyamAPI$Worker.beautify = function(elem, identifier, Options2) {
    if (elem == null) {
      return;
    }
    if (identifier === 'ignore') {
      return;
    }
    MiriyamAPI$Worker._init();
    var padyam = MiriyamAPI$Worker._cleanHTML(elem.innerHTML.toUpperCase());
    var html = '';
    if (Options2 == null) {
      Options2 = MiriyamApp$MapRules.defaultOptions();
    }
    html = (identifier == null || !identifier) ? MiriyamAPI$Worker.determine(padyam, Options2) : MiriyamAPI$Worker._tryMatch(padyam, identifier, Options2);
    if (!!html) {
      elem.innerHTML = "<div class='formatted'>" + html + '</div>' + "<div class='orginal'>" + elem.innerHTML + '</div>';
    }
    var Close = MiriyamApp$Util.findByClass(elem, 'open');
    if (Close == null) {
      return;
    }
    MiriyamApp$Util.registerClick3(Close, function(ee) {
      var Anchor = ee.target.parentNode.parentNode;
      var Target = MiriyamApp$Util.findByClass(Anchor, 'ganaVibhajana');
      var OD = new MiriyamApp$OverlayDialog('', Target.innerHTML);
      OD.set_footerText("\u0c1b\u0c02\u0c26\u0c02<sup class='copyright'>\u00a9</sup> \u0c24\u0c4b \u0c2a\u0c26\u0c4d\u0c2f\u0c38\u0c3e\u0c39\u0c3f\u0c24\u0c4d\u0c2f\u0c02 \u0c2e\u0c30\u0c3f\u0c02\u0c24 \u0c30\u0c38\u0c2e\u0c2f\u0c02..!! [<a target='_blank' href='http://chandam.apphb.com'>http://chandam.apphb.com</a>]");
      OD.set_showClose(false);
      OD.show();
    });
  };
  MiriyamAPI$Worker._tryMatch = function(padyam, identifier, Options2) {
    return Chandam$Core$Business.tryMatch(padyam, identifier, Options2);
  };
  MiriyamAPI$Worker.getOptions = function(Options2) {
    if (Options2 == null) {
      return MiriyamAPI$Worker._settings();
    }
    else {
      return MiriyamApp$MapRules.mapOptions(Options2);
    }
  };
  MiriyamAPI$Worker.determine = function(padyam, Options2) {
    var Pr = Chandam$Core$Business.determine(padyam, Options2);
    return Chandam$Core$Business.buildResult2(Pr, (Options2 == null) ? true : Options2.showGV);
  };
  MiriyamAPI$Worker._init = function() {
    if (Config.Loaded == null || !Config.Loaded) {
      MiriyamApp$MapRules.loadExternalRules();
      Config.Loaded = true;
    }
  };
  MiriyamAPI$Worker._cleanHTML = function(str) {
    str = ss.replaceString(str, '&nbsp;', ' ');
    str = ss.replaceString(str, '\t', ' ');
    var exp = new RegExp('<(.*?)/>', 'mig');
    str = str.replace(exp, '\n');
    exp = new RegExp('<(.*?)>', 'mig');
    str = str.replace(exp, '\n');
    str = ss.replaceString(ss.replaceString(ss.replaceString(str, '<BR>', '\n'), '<BR />', '\n'), '\n\n', '\n');
    while (str.indexOf('\n\n') !== -1) {
      str = ss.replaceString(str, '\n\n', '\n');
    }
    var sb = new ss.StringBuilder();
    var $enum1 = ss.enumerate(str.split('\n'));
    while ($enum1.moveNext()) {
      var line = $enum1.current;
      if (line.trim().length > 0) {
        sb.appendLine(line);
      }
    }
    return sb.toString2();
  };
  MiriyamAPI$Worker._settings = function() {
    var Options = new MiriyamLib2.MatchOptions();
    Options.set_matchYati(true);
    Options.set_matchPrasa(true);
    Options.set_allowSantiPrasa(true);
    Options.set_quickMatch(true);
    Options.set_experimenatalSandhi(true);
    Options.set_language(MiriyamUtil.RuleLanguage.telugu);
    return Options;
  };


  var $exports = ss.module('MiriyamAPI', null,
    {
      Business: [ Chandam$Core$Business, null, null ],
      MapRules: [ MiriyamApp$MapRules, MiriyamApp$MapRules$, null ],
      OverlayDialog: [ MiriyamApp$OverlayDialog, MiriyamApp$OverlayDialog$, null ],
      Events: [ MiriyamApp$Events, null, null ],
      Util: [ MiriyamApp$Util, null, null ],
      Patterns: [ MiriyamApp$Patterns, MiriyamApp$Patterns$, null ],
      Worker: [ MiriyamAPI$Worker, null, null ]
    });

  MiriyamApp$Events.click = 'click';
  MiriyamApp$Events.change = 'change';
  MiriyamApp$Patterns.email = /^[a-zA-Z_\.]+?@[a-zA-Z_\.]+?\.[a-zA-Z]{2,3}$/;

  return $exports;
});
