window.onerror = function (sMessage, sUrl, sLine) {
	try {

		alert("Error Details: " + sMessage + "\nLine: " + sLine + "\nFile: " + sUrl);
	}
	catch (err) {
	}
	return true;
}