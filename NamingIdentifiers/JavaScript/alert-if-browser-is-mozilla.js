(function () {
    'use strict';
    function alertIfBrowserIsMozilla() {
        var browser = window.navigator.appCodeName;

        if (browser === "Mozilla") {
            alert("Yes");
        } else {
            alert("No");
        }
    }

    document.getElementById('is-mozilla').addEventListener('click', alertIfBrowserIsMozilla);
}());