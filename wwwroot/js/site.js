// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function ConvertInt(str) {
    var obj = parseInt(str);
    return isNaN(obj) ? 0 : obj;
}
window.onload = function () {
    var e = document.getElementsByClassName('img-wrap');
    var imgArea = document.getElementsByClassName('carousel-inner');
    var w = imgArea[0].clientWidth;
    for (var i = 0; i < imgArea.length; i++) {
        imgArea[i].setAttribute('style', 'width:' + w + 'px;height:' + w + 'px;');
    }
    ReSetImgWrapSize(w);
}
window.onresize = function () {
    var imgArea = document.getElementsByClassName('carousel-inner');
    for (var i = 0; i < imgArea.length; i++) {
        imgArea[i].setAttribute('style', '');
    }
    var w = imgArea[0].clientWidth;
    ReSetImgWrapSize(w);
}
function ReSetImgWrapSize(w) {
    var e = document.getElementsByClassName('img-wrap');
    for (var i = 0; i < e.length; i++) {
        var c = e[i].firstElementChild;
        var strStyle = 'max-width:' + w + 'px;max-height:' + w + 'px;';
        if (c.height > c.width) {
            strStyle = 'height:' + w + 'px;' + strStyle;
        } else {
            strStyle = 'width:' + w + 'px;' + strStyle;
            e[i].setAttribute('style', 'line-height:' + w + 'px;');
        }
        c.setAttribute('style', strStyle);
    }
    var imgArea = document.getElementsByClassName('carousel-inner');
    for (var i = 0; i < imgArea.length; i++) {
        imgArea[i].setAttribute('style', 'width:' + w + 'px;height:' + w + 'px;');
    }
}