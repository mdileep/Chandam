<!--
//---------------------------------------------------------------------------------------------
// <copyright file="Default.aspx" company="Chandam-ఛందం">
//    Copyright © 2013 - 2018 'Chandam-ఛందం' : http://chandam.apphb.com
//    Original Author : Dileep Miriyala (m.dileep@gmail.com)
//    Last Updated    : 03-Feb-2018 21:39EST
//    Revisions:
//       Version    | Author                   | Email                     | Remarks
//       1.0        | Dileep Miriyala          | m.dileep@gmail.com        | Initial Commit
//       _._        | <TODO>                   |   <TODO>                  | <TODO>
// </copyright>
//---------------------------------------------------------------------------------------------
-->
<%@ Page Language="C#" AutoEventWireup="true" Inherits="Server.Home" EnableViewState="false" %>
<%@ OutputCache Duration="60" VaryByParam="*" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" lang="te">
<head runat="server" id="H">
    <title>ఛందం © | తెలుగు ఛందస్సుకు పూర్తి స్థాయి సాఫ్ట్‌వేర్ | Chandam ©| A Complete Software for Telugu Chandassu.</title>
    <meta http-equiv="content-type" content="text/html; charset=utf-8" />
    <meta name="keywords" id="keywords" runat="server" content="తెలుగు,ఛందస్సు,గణవిభజన,యతి, ప్రాస,Telugu, Chandassu,Chamdassu,Gana Vibhajana,Yati,Prasa" />
    <meta name="description" id="description" runat="server" content="గణవిభజన,యతి మరియూ ప్రాస లను కూడా సరిచూడగలదు,దోషాలను విడమర్చి చెప్పగలదు.343+ తెలుగు ఛందస్సులను గణించగలదు.550 కి పైగా ఉదాహరణలు.సరికొత్త ఛందస్సులను సృష్టించి గణించగలిగే సౌకర్యం ఇవన్నీ ఛందం © లో.." />
    <meta name="author" content="Dileep Miriyala(దిలీపు మిరియాల)" />
    <meta property='og:image' content='http://chandam.apphb.com/img/fbPreView.png' />
    <link rel="shortcut icon" href="/css/Miriyam.ico" />
    <!--[if lt IE 9]><script src="/js/es5-shim.js"></script><![endif]-->
    <!--[if lte IE 8]><script src="/js/html5shiv.js"></script><![endif]-->
    <!--[if lte IE 9]><link rel="stylesheet" href="/css/skel_ie9.css" /><![endif]-->
    <noscript>
        <link rel="stylesheet" href="/css/skel-noscript.css" />
        <link rel="stylesheet" href="/css/skel.css" />
        <link rel="stylesheet" href="/css/skel-desktop.css" />
    </noscript>
    <link href="/css/Chandam.css" type="text/css" rel="Stylesheet" />
</head>
<body id="body">
    <div id="header-wrapper">
        <div class="container">
            <div class="row">
                <div class="12u">
                    <header id="header">
                        <h1  id="logoH1"><a href="?chandam"  id="logo" title="ఛందం ©">ఛందం <sup class="copyright">©</sup></a></h1>
                        <nav id="nav">
                            <a href="?about" id="btnAbout" title="ఛందం© గురించి">గురించి</a>
                            <a href="?credits" id="btnCredits" title="ఎందరో మహానుభావులు అందరికీ కృతజ్ఞతలు">కృతజ్ఞతలు</a>
                            <a href="?dedicated" id="btnDedicatedTo" title="అంకితము">అంకితము</a> 
                            <a href="?cheatSheet" id="learn" title="ఛందోరాజం అనబడే ఒక ఛందస్సు పట్టిక(ఛందస్సు మీద అవగాహన ఉన్న వాళ్ళ  కోసం)">ఛందోరాజం</a> 
                            <a href="?book" id="book" title="ఛందోరత్నావళి అనబడే ఒక ఛందస్సు పుస్తకం">ఛందోరత్నావళి</a> 
                            <a href="?chandassu=tel"  id="chandassu" title="తెలుగు ఛందస్సులు">ఛందస్సులు</a>
                        </nav>
                    </header>
                </div>
            </div>
        </div>
    </div>
    <div class="container" id="tc" style="visibility: hidden;">
        <div class="row">
            <div class="2u">
                <div id='toolbar' class="12u">
                    <a id="btnRandom" href="#tc" class="social random" title="500+ కు పైగా ఉన్న పద్యాల నుండి ఒక యాదృచ్చిక పద్యం"><span>యాదృచ్ఛిక పద్యం</span></a>&nbsp; 
                            <a id="btnClear" href="#tc" class="social clear" title="ఖాళీ చేయి"><span>ఖాళీ చేయి</span></a>&nbsp; 
                            <a id="permLink" href="#tc" class="social savelink" title="Permanent Link-శాశ్వత  లింకు"><span>Permanent Link - శాశ్వత లింకు</span></a>
                </div>
                &nbsp;
            </div>
            <div class="8u notification" id="notification">
                &nbsp;
            </div>
            <div class="2u">
                <a title="Share on Facebook" id="fbPost" class="social facebook" href="#tc"><span>Share on Facebook</span></a>&nbsp; 
                    <a title="Share on Twitter" id="twitterPost" href="#tc" class="social twitter"><span>Share on Twitter</span></a>&nbsp; 
                    <a title="Print" id="print" href="#tc" class="social print"><span>Print</span></a>
            </div>
        </div>
    </div>
    <div id="bannerWrapper" runat="server" style='color: White; font-size: 0.9em !important;'>
        <div class="container">
            <div class="row">
                &nbsp;
            </div>
            <div id="banner">
                <div id="ChandamContainer" runat="server">
                    <div class="row" id="input">
                        <div class="8u">
                            <textarea cols="40" rows="7" class="src" id="txt"></textarea>
                        </div>
                        <div class="4u">
                            <ul>
                                <li>
                                    <input type="checkbox" id="quickMatch" checked="checked" name="quickMatch" />
                                    <label for="quickMatch">కొత్త గణన పద్దతి<sup class="gName">‡</sup></label>
                                </li>
                                <li>
                                    <input type="checkbox" id="btnYatiCheck" checked="checked" name="yatiCheck" />
                                    <label for="yatiCheck">యతి మైత్రి , ప్రాస నియమం సరిచూడు<sup class="gName">*</sup></label>
                                </li>
                                <li>
                                    <input type="checkbox" id="experimentalYati" name="experimentalYati" />
                                    <label for="experimentalYati" id="lblexperimentalYati" title="అచ్చు ఆధారంగా యతి గుర్తింపు. ఇది ఒక ప్రయోగాత్మకమైన పద్ధతి. యతిస్థానంలో ఉన్న అక్షరాల అచ్చులు మాత్రమే ఆధారంగా సరిచూడబడుతుంది. హల్లులను ఎంత మాత్రమూ పరిగణించదు.సంధి ఉన్నప్పుడు ఉపయోగకరముగా ఉంటుంది.">అచ్చు ఆధారంగా సంధియుత యతి మైత్రి గుర్తింపు&nbsp;<sup class="gName">¤</sup></label>
                                </li>
                                <li>
                                    <input type="checkbox" id="allowSantiPrasa" name="allowSantiPrasa" />
                                    <label for="allowSantiPrasa" id="lblAllowSantiPrasa">శాంత ప్రాసను పరిగణించు<sup class="gName">#</sup></label>
                                </li>
                                <li>&nbsp;</li>
                                <li>
                                    <h5 class="link" id='create'>కొత్త ఛందస్సు సృష్టించు..!!</h5>
                                    <h5 class="link" id='hideDesigner' style="display: none;">కొత్త ఛందస్సు మరెప్పుడయినా..!!</h5>
                                </li>
                            </ul>
                        </div>
                        <div class="4u" id="sortTools">
                            <sub class="sub" id="sort_a2z">అ-హ &darr;</sub>
                            <sub class="sub" id="sort_g">స్వభావం ↴</sub>
                        </div>
                    </div>
                    <div class="row" id="DesignerContainer" style="display: none;">
                        <div class="12u">
                            <section>
                            <h3>కొత్త ఛందస్సు</h3>
                            <div id="Designer" class="12u">
                                <table  class="errTab3"  border="1">
                                    <thead>
                                        <tr>
                                            <th><label for="Name">పేరు</label></th>
                                            <td><input type="text" class="text" id="Name" /></td>
                                            <th><label for="PadyamType">పద్య స్వభావం</label></th>
                                            <td><select id="PadyamType" name="PadyamType"></select></td>
                                            <th><label for="GanaType">గణ స్వభావం</label></th>
                                            <td><select id="GanaType" name="GanaType"></select></td>
                                            <th>
                                            </th>
                                            <td><input type="checkbox" id="hasPrasa" checked="checked" name="hasPrasa" />
                                                <label for="hasPrasa">ప్రాస నియమం</label>
                                            </td>
                                            <th>
                                            </th>
                                            <td><input type="checkbox" id="hasPrasaYati" name="hasPrasaYati" />
                                                <label for="hasPrasa">ప్రాసయతి</label>
                                            </td>
                                            <th>
                                            </th>
                                            <td><input type="checkbox" id="hasAnthyaPrasa" name="hasAnthyaPrasa" />
                                                <label for="hasPrasa">అంత్యప్రాస</label>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td><input type="checkbox" id="hasSameRules" checked="checked" name="hasSameRules" />
                                                <label for="hasSameRules">అన్ని పాదాల లక్షణాలు ఒకటే</label>
                                            </td>
                                            <td  colspan="4">&nbsp;ఈ పద్యానికి<select id="Lines" name="Lines"></select>కలవు(దు) .
                                            </td>
                                            <td colspan="2" class="noshow"><input type="checkbox" id="isDaMdakamu" name="isDaMdakamu" />
                                                                            <label for="isDaMdakamu">ఇది ఒక దండకము</label>
                                            </td>
                                            <td colspan="7"><input type="checkbox" id="shareWithMe" name="shareWithMe" />
                                                            <label for="shareWithMe">ఈ పద్యలక్షణాలు నాకు కూడా పంపించు</label>
                                            </td>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                        </section>
                            <div class="row">
                                <div id="Rows" class="12u">
                                    <section>
                                    <h3>పాద లక్షణాలు</h3>
                                    <table class="errTab3" border="1" width="100%" cellpadding="2" cellspacing="2" style="border-collapse: collapse;text-align: center; vertical-align: bottom; margin-top: 10px; margin-left: 2px;margin-right: 2px; margin-bottom: 10px;">
                                    <colgroup>
                                        <col style="width: 10%" />
                                        <col style="width: 10%" />
                                        <col style="width: 15%" />
                                        <col style="width: 10%" />
                                        <col />
                                    </colgroup>
                                    <thead>
                                        <tr>
                                            <th>పాదాన్ని తొలగించు</th>
                                            <th>గణమును కలుపు</th>
                                            <th>గణమును తొలగించు</th>
                                            <th id="YatiRules">యతి</th>
                                            <th style="text-align: center;" id="Expand" colspan="1">లక్షణాలు</th>
                                        </tr>
                                    </thead>
                                    <tbody id="Rules">
                                    </tbody>
                                </table>
                                </section>
                                </div>
                            </div>
                            <div class="row">
                                <h5>ఇంకా చాలా లక్షణాలు ఉన్నాయా? Sorry ప్రస్తుతానికి Support లేదు. నాకు మెయిలు <a href="mailto:m.dileep@gmail.com" style="color: White;">m.dileep@gmail.com</a> కు చేయండి, ఎలా ఉంచాలో ఆలోచిస్తాను.</h5>
                                <div style="margin: 5px;">
                                    <input type="button" id="btnCreate" class="actions" value="గణించు" />
                                    |
                                <input type="button" id="btnCustomRules" class="actions" value="లక్షణాలు చూపించు" />
                                    |
                                <input type="button" class='actions' id="Reset" value="Reset" />
                                    |
                                <input type="text" class="text" placeholder="మీ Email" title="మీ Email" id="EmailId" />
                                    <input type="button" class='actions' id="Share" value="Share" />
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class="row" id="buttons">
                        <div class="1u">
                            <input type="button" class='actions' id="btnDetermine" value="గణించు" />
                        </div>
                        <div class="2u">
                            <input type="button" class='actions' id="btnScores" value="మూల్యాంకనం" />
                        </div>
                        <div class="3u">
                            <select id="list"></select>
                        </div>
                        <div class="2u">
                            <input type="button" class='actions' id="btnShowRules" value="లక్షణాలు చూపించు" />
                        </div>
                        <div class="2u">
                            <input type="button" class='actions' id="btnTry" value="..తో గణించు" />
                        </div>
                        <div class="2u">
                            <input type="button" class='actions' id="btnSamples" value="కొన్ని పద్యాలు చూపు" />
                        </div>
                    </div>
                </div>
                <div class="row" id="LabsPage" runat="server">
                    <div class="12u" style="float: left; width: 90%; margin: 15px;">
                        <h2 class='err'>ప్రయోగాలు</h2>
                        <ol>
                            <li>♬♫
                                <label class="gName">స,రి,గ,మ,ప,ద,ని</label>
                                ♫♬ లతో ఒక
                                <select id="MachineEnabled" name="MachineEnabled">
                                </select>పద్యం కంప్యూటర్‌తో
                                <input type="button" class='actions' id="btnGenPadyam" value="రాయించు" />
                            </li>
                            <li>
                                <select id="ChandamNames" name="ChandamNames">
                                </select>
                                &nbsp;
                            <input type="button" class='actions noshow' id="btnClear5" value="ఖాళీ చేయి" />
                                <ul style="list-style-type: square;">
                                    <li>ఛందమునకు పుట్టిన ఛందస్సులు
                                        <input type="button" class='actions' id="HowMany" value="ఎన్ని?" />
                                    </li>
                                    <li>ఛందమునందు
                                        <input type="number" min="1" id="txtNumber" class="two" placeholder="సంఖ్య" />
                                        ఛందస్సుకు గల గణములు
                                    <input type="button" class='actions' id="WhichG" value="ఏవి?" />
                                    </li>
                                </ul>
                            </li>
                            <li>
                                <input type="number" min="1" id="txtVruttam" class="two" placeholder="సంఖ్య" />&nbsp;
                            మాత్రలు గల వృత్తములు
                            <input type="button" class='actions' id="btnWVruttam" value="ఏవి?" />
                            </li>
                            <li>సరిజూడు:<input type="checkbox" id="allowSantiPrasa2" name="allowSantiPrasa2" />
                                <label for="allowSantiPrasa2" id="lblallowSantiPrasa2">శాంత ప్రాసను పరిగణించు<sup class="gName">#</sup></label>
                                <table>
                                    <tr>
                                        <td>
                                            <input type="text" id="Group1" class="two" placeholder="Group-1" /></td>
                                        <td>
                                            <input type="text" id="Group2" class="two" placeholder="Group-2" /></td>
                                        <td>&nbsp;<input id="YCheck" type="button" class='actions' value="యతి సరి జూడు" />&nbsp;</td>
                                        <td>
                                            <input id="PCheck" type="button" class='actions' value="ప్రాస సరి జూడు" /></td>
                                        <td class="noshow">
                                            <input type="button" class='actions' id="btnClear4" value="ఖాళీ చేయి" /></td>
                                    </tr>
                                </table>
                            </li>
                            <li class="noshow">ఇంకా మిగిలిన పని
                                <input type="button" class='actions' id="ReportPending" value="ఎంత?" /></li>
                            <li>Canvas &nbsp;<input type="button" class='actions' id="btnClear3" value="ఖాళీ చేయి" /></li>
                        </ol>
                    </div>
                </div>
                <div class="row" id="SearchPage" runat="server">
                    <div class="12u" style="float: left; width: 90%; margin: 15px;">
                        <h2 class='err'>వెతుకులాట</h2>
                        <table class="errTab3" border="0" cellpadding="2" cellspacing="2" width="90%" style="border-collapse: collapse; text-align: left; border-width: 1px;">
                            <tbody>
                                <tr>

                                    <th>పద్య స్వభావం </th>
                                    <td>
                                        <select id="SearchPadyamType" name="SearchPadyamType"></select></td>
                                    <th>మాత్రా శ్రేణులు</th>
                                    <td>
                                        <select id="SearchSreni" name="SearchSreni"></select></td>
                                </tr>
                                <tr>
                                    <th>పేరు</th>
                                    <td>
                                        <input type="text" class="text" id="SearchName" placeholder="పేరు" /></td>
                                    <td>&nbsp;</td>
                                    <td>&nbsp;</td>
                                </tr>
                                <tr>
                                    <th>మాత్రలు</th>
                                    <td>
                                        <input type="number" min="1" max="100" id="SearchMatra" class="two" placeholder="సంఖ్య" /></td>
                                    <th>పాదాక్షరాల సంఖ్య</th>
                                    <td>
                                        <input type="number" min="1" max="5" id="SearchCharLen" class="two" placeholder="సంఖ్య" /></td>
                                </tr>
                                <tr style="text-align: center;">
                                    <td colspan="2" style="visibility: hidden;">
                                        <input type="checkbox" id="SearchSansToo" name="SearchSansToo" />
                                        <label for="SearchSansToo">సంస్కృత ఛందస్సులు కూడా పరిగణించు</label>
                                    </td>
                                    <td colspan="2" style="text-align: left;">
                                        <input type="button" class="actions" id="Search" value="Search" /></td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class="row">
            &nbsp;	
        </div>
    </div>
    <div id="main" style='background-color: #ffffff !important; clear: both; min-height: 200px;'>
        <div class="container">
            <div class="row main-row" runat="server" id="contentRow">
                <div class="8u">
                    <div class="12u" id="Holder" runat="server">
                    </div>
                    <div class="4u" style="margin-top: 30px;" id="Holder4" runat="server">
                        <section>
                                <h2>వీటిని కూడా చూడండి.</h2>
                                    <ul class="link-list" runat="server"  id="related">
                                        <li><a href="?faq" title="తరచుగా అడిగే ప్రశ్ర్నలు(FAQ)">తరచుగా అడిగే ప్రశ్ర్నలు(FAQ)</a></li>
                                        <li><a href="?limitations" title="ఛందం© పరిధులు">పరిధులు</a></li>
                                        <li><a href="?CaseStudy" title="నిదర్శనాధ్యయనాలు">నిదర్శనాధ్యయనాలు</a></li>
                                        <li><a href="?search" title="ఛందస్సుల వెదుకులాట">ఛందస్సుల వెదుకులాట</a></li>
                                    </ul>
                            </section>
                    </div>
                </div>
                <div class="4u" id="Holder2" runat="server">
                    <section>
                            <h2>పద్యాన్ని గణించండి...!!</h2>
                            <p><label class='gName'>ఛందం <sup class="copyright">©</sup></label> యొక్క ప్రధానలక్ష్యం వాడుకరి చెప్పిన పద్యాన్ని గణించి అది ఏ ఛందస్సో కనిపెట్టడం మరియూ అందులోని ఛందోనియమాలను ఉల్లంఘించిన దోషాలను ఎత్తిచూపించడం. మరి మీదగ్గర ఉన్న లేదా వ్రాయబోతున్న పద్యమును గణించండి.</p>
                            <footer class="controls">
                                <a href="?chandam" class="button">మొదలు పెట్టండి ....</a>
                            </footer>
                        </section>
                </div>
                <div class="4u" style="margin-top: 24px;" id="Holder3" runat="server">
                    <section>
                            <h2>ఉపకరణాలు</h2>
                            <p><label class='gName'>ఛందం <sup class="copyright">©</sup></label> కేవలం ఛందోగణనమే కాకుండా మరికొన్ని ఛందస్సుకు పనికి వచ్చే పనిముట్లను కూడా అందిస్తోంది. దీనిలో కొన్ని ఛందస్సుకు సంబంధించి కొన్ని సాంకేతిక <label class='gName'>ప్రయోగాలు</label> కూడా ఉన్నాయి.
                                ఉదాహరణకు కంప్యూటర్‌తో ♬♫ <label class="gName White">స,రి,గ,మ,ప,ద,ని</label> ♫♬ లతో పద్యం రాయించడం.
                             </p>
                            <footer class="controls">
                                <a href="?lab" class="button">ఓసారి పరికించండి..</a>
                            </footer>
                        </section>
                </div>
            </div>
            <div class="row main-row" runat="server" id="mainRow">
                <div class="12u">
                    <div id="result" runat="server" style='min-height: 160px; min-height: 160px; min-width: 100%;'>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="container" style="float: right; right: 20px; clear: both; width: 100%; background-color: #ffffff !important; border-bottom: 1px dotted red !important;">
        <div class="row">
            <div class="12u" style="text-align: right;">
                <h3>ఛందం<sup class="copyright">©</sup> తో పద్య సాహిత్యం మరింత రసమయం..!!</h3>
            </div>
        </div>
    </div>
    <div class="row  notification2" id="notification2">
        <div class="3u">&nbsp;</div>
        <div class="6u">
            ఛందం<sup class="copyright">©</sup> ఫలితాలపైనే పూర్తిగా అధారపడవద్దు. స్వవిచక్షణతో నిర్ణయం తీసుకోగలరు.
        </div>
        <div class="3u">&nbsp;</div>
    </div>
    <div id="footer-wrapper" style="margin-top: 20px;">
        <div class="container">
            <div class="row">
                <div class="8u">
                    <section>
                        <h2>
                            You may be <span class="gName">Looking</span> for</h2>
                        <div>
                            <div class="row">
                                <div class="6u">
                                    <ul class="link-list">
                                    
                                        <li>
                                            <nobr><a id="faq"  href="?faq" title="తరచుగా అడిగే ప్రశ్ర్నలు(FAQ)">తరచుగా అడిగే ప్రశ్ర్నలు(FAQ)</a></nobr>
                                        </li>
                                        <li><nobr><a href="?lab"  title="ఛందస్సుకు సంబందించిన  పనిముట్లు">ఛందస్సుకు సంబందించిన  పనిముట్లు</a></nobr></li>
                                        <li>
                                            <nobr><a href="?limitations" id="btnLimitations"  title="ఛందం© పరిధులు">పరిధులు</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?history" id="hist"  title="ఛందం© చరిత్ర">చరిత్ర</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?CaseStudy" id="btnCaseStudies"  title="నిదర్శనాధ్యయనాలు">నిదర్శనాధ్యయనాలు</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?release" id="blog" title="ఛందం© రోడ్‌మ్యాప్  మరియూ ఛందం© రూపకర్త పంచుకోదలిచిన కొన్ని మాటలు">బ్లాగు</a> </nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?contact" id="btnContact"  title="రూపకర్త సంప్రదింపుల కొరకూ">సంప్రదింపులు</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?chandassu=tel" title="తెలుగు చందస్సులు">తెలుగు ఛందస్సులు</a> </nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?chandassu=sans" title="సంస్కృత ఛందస్సులు">సంస్కృత ఛందస్సులు</a></nobr>
                                        </li>
                                        <li><nobr><a href="?search" title="ఛందస్సుల వెదుకులాట">ఛందస్సుల వెదుకులాట</a></nobr></li>
                                        <li>
                                            <nobr><a href="?pv" title="ప్రశంసలు-విమర్శలు">ప్రశంసలు-విమర్శలు</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a href="?api" title="API">API &nbsp;<sup>కొత్తది</sup></a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a class="link" href="#footer-wrapper"  id="req" title="నివేదన">నివేదన&nbsp;<sup>కొత్తది</sup></a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a class="pink" href="#footer-wrapper" title="Bulk Compute"  id="bulk">Bulk Compute</a></nobr>
                                        </li>
                                    </ul>
                                </div>
                                <div class="6u">
                                    <ul class="link-list">
                                        <li>
                                            <nobr><a  href="#footer-wrapper" title="Feedback"  id='feedback'>Feedback</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a  href="#footer-wrapper" title="Report a Bug" >Report a Bug</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a  href="#footer-wrapper" title="Suggest a Feature">Suggest a Feature</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><span  class="link" id="subscribe" title="Subscibe">Email Subscribtion</span></nobr>
                                        </li>
                                        <li>
                                            <nobr><span  class="link" id="unSubscribe" title="UnSubscibe">Unsubscribe</span></nobr>
                                        </li>
                                        <li>
                                            <nobr><a  href="?blog" title="Blog"  id="blog2">Blog</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a  href="RSS.ashx" title="RSS"  id="feed">RSS Feed</a></nobr>
                                        </li>
                                        <li>
                                            <nobr><a  target="_blank" href="https://www.dropbox.com/s/3ef8nowcjlaclut/Chandam.pptx?dl=0" title="Press Release">Press Release</a> </nobr>
                                        </li>
                                    </ul>
                                </div>
                            </div>
                        </div>
                    </section>
                </div>
                <div class="4u">
                    <section>
                        <h2>ఛందస్సు నేర్చుకోండి..!!</h2>
                        <p><label class="high">ప</label>ద్యాలను వ్రాయడానికి ఉపయోగించే విధానాన్ని ఛందస్సు అంటారు. ఛందస్సును మొట్టమొదట సంస్కృతములో రచించిన వేదాలలో ఉపయోగించారు. వేదముల యొక్క అంగములనబడు ఆరు వేదాంగములలో ఛందస్సు ఒకటి...</p>
                        <footer class="controls">
                            <a href="?book" class="button">మొదలు పెట్టండి ....</a>
                        </footer>
                    </section>
                </div>
                <div class="4u" style="margin-top: 20px;">
                    <h2>గణాంకాలు</h2>
                    <ul class="link-list">
                        <li>
                            <iframe scrolling="no" frameborder="0" style="border: none; overflow: hidden; height: 22px;" allowtransparency="true" id="fbk" src="http://www.facebook.com/plugins/like.php?app_id=590773791009851&amp;href=http%3A%2F%2Fchandam.apphb.com&amp;send=false&amp;layout=button_count&amp;width=450&amp;show_faces=true&amp;action=like&amp;colorscheme=light&amp;font=arial&amp;height=22"></iframe>
                        </li>
                        <li>గణించగలిగిన ఛందస్సులు &nbsp;<span class="gName" id="totItems">343+</span></li>
                        <li>యాదృఛ్చిక పద్యం ఎన్నుకోబడే పద్యాల సంఖ్య &nbsp;<span class="gName" id="RandomItems">500+</span></li>
                        <li>చివరి గణనానికి పట్టిన సమయం &nbsp;<span class="gName" id="timeTaken">1.445 సెకన్లు</span></li>
                        <li>ఇప్పటి వరకూ గణించిన పద్యాలు &nbsp;<span class="gName" id="totCalcs">79,700+</span></li>
                        <li>చివరిసారిగా మార్పు చేసిన సమయము:<br />
                            <span class="gName">26-Jan-2016 12:08 IST</span></li>
                    </ul>
                </div>
            </div>
            <div class="row">
                &nbsp;
            </div>
            <div class="row" id="disclaimer" runat="server">
                <div class="12u">
                    <div id="copyright">
                        <h2>గమనికలు</h2>
                        <ul class="link-list2 link-list">
                            <li><span class="gName">*</span> &nbsp;గుర్తు గల లక్షణాల గణనం పరిధులకు లోబడి జరుగును. అప్పుడప్పుడు ఆశించిన ఫలితాలు రాకపోవచ్చు.</li>
                            <li><span class="gName">¤</span> &nbsp;అచ్చు ఆధారంగా యతి గుర్తింపు. ఇది ఒక ప్రయోగాత్మకమైన పద్ధతి. యతిస్థానంలో ఉన్న అక్షరాల అచ్చులు మాత్రమే ఆధారంగా సరిచూడబడుతుంది. హల్లులను ఎంత మాత్రమూ పరిగణించదు.సంధి ఉన్నప్పుడు ఉపయోగకరముగా ఉంటుంది.</li>
                            <li><span class="gName">‡</span> &nbsp;ఇది సరికొత్త గణన పద్ధతి, మరింత వేగవంతమైన ఫలితాలను సమర్థనీయంగా అందిస్తుంది.</li>
                            <li><span class="gName">#</span> &nbsp; సంయుక్తాక్షరాలలోని కొన్ని హల్లులు ఏదేని వరుసలో(మొదటి లేక చివరి హల్లులు; మామూలు సందర్భాలలో అన్ని హల్లులూ సరిపోవాలి ) ప్రాసకు సరిపోతే <span class="gName">శాంతప్రాస</span> అని అంటారు.</li>
                            <li><span class="gName">##</span> &nbsp;ఏదేని సమ వృత్తం అనేది ఒక పద్య రకం కాదు. ఇవ్వబడిన పద్యరకాలలో మీరు అనుకున్నది లేనిచో దీనిని ఉపయోగించగలరు. ఇది యతి, ప్రాసలను గుర్తించదు. గణనలో దీనిని పరిగణించదు.</li>
                            <li>వేగవంతమైన ఫలితాల కోసం Internet Explorer 11&gt;Chrome&gt;Mozilla. మిగిలిన విహరిణులతో పోల్చినపుడు Internet Explorer &lt;11 లో ~10 రెట్లు తక్కువ వేగంతో ఫలితాలు వస్తున్నాయి.</li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class="debug noshow" id="debug"></div>
        </div>
    </div>
    <div id="Scripts" runat="server"></div>
    <script src="//connect.facebook.net/en_US/all.js" async="async" type="text/javascript"></script>
</body>
</html>
