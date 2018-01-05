//Credits:tinyxhr by Shimon Doodkin -https://gist.github.com/4706967
Ajax = {};
Ajax.makeCall = function (url, callBack, method, post,async,contenttype) {
	var requestTimeout, xhr;
	try {
		xhr = new XMLHttpRequest();
	} catch (e) {
		try {
			xhr = new ActiveXObject("Msxml2.XMLHTTP");
		} catch (e) {
			if (console) console.log("tinyxhr: XMLHttpRequest not supported");
			return null;
		}
	}
	//requestTimeout = setTimeout(function () { xhr.abort(); callBack(new Error("tinyxhr: aborted by a timeout"), "", xhr); }, 30000);
	xhr.onreadystatechange = function () {
		if (xhr.readyState != 4) return;
		clearTimeout(requestTimeout);
		callBack(xhr.status != 200 ? new Error("tinyxhr: server respnse status is " + xhr.status) : false, xhr.responseText, xhr);
	}
	xhr.open(method ? method.toUpperCase() : "GET", url, (async==null)?true:async);
	//xhr.withCredentials = true;
	if (!post) {
		xhr.send();
	}
	else {
		xhr.setRequestHeader('Content-type', contenttype ? contenttype : 'application/x-www-form-urlencoded');
		xhr.send(post)
	}
}
