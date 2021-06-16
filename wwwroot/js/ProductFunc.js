//Product
function addColorFunc() {
    var colorArea = document.getElementById('ColorArea');
    var NewcolorItem = document.createElement("div");
    var NewColor = document.createElement("input");
    var NewRemoveColorBtn = document.createElement("input");

    NewColor.type = "color";
    NewColor.value = "#80A6FF";
    NewColor.name = "favcolor";

    NewRemoveColorBtn.type = "button";
    NewRemoveColorBtn.className = "btn btn-link RemoveColor";
    NewRemoveColorBtn.value = "刪除";
    NewRemoveColorBtn.onclick = function () { RemoveColorFunc(this); };

    NewcolorItem.className = "colorItem col-6";
    NewcolorItem.appendChild(NewColor);
    NewcolorItem.appendChild(NewRemoveColorBtn);

    colorArea.appendChild(NewcolorItem);
}
function RemoveColorFunc(e) {
    document.getElementById("ColorArea").removeChild(e.parentNode);
}
function addSizeFunc() {
    var SizeArea = document.getElementById("SizeArea");
    var SizeItem = document.createElement("div");
    var SizeCode = document.createElement("input");
    var SizeMemo = document.createElement("input");
    var NewRemoveSizeBtn = document.createElement("input");

    SizeCode.type = "text";
    SizeCode.name = "sizeCode";
    SizeCode.placeholder = "ex.M";
    SizeCode.className = "sizeCode form-control";

    SizeMemo.type = "text";
    SizeMemo.name = "sizeMemo";
    SizeMemo.placeholder = "ex.腰圍60 裙長78";
    SizeMemo.className = "sizeMemo form-control";

    NewRemoveSizeBtn.type = "button";
    NewRemoveSizeBtn.className = "btn btn-link RemoveSize";
    NewRemoveSizeBtn.value = "刪除";
    NewRemoveSizeBtn.onclick = function () { RemoveSizeFunc(this); };

    SizeItem.setAttribute("name", "SizeItem");
    SizeItem.className = "SizeItem";
    SizeItem.appendChild(SizeCode);
    SizeItem.appendChild(SizeMemo);
    SizeItem.appendChild(NewRemoveSizeBtn);

    SizeArea.appendChild(SizeItem);
}
function RemoveSizeFunc(e) {
    document.getElementById("SizeArea").removeChild(e.parentNode);
}
function RemoveImgFunc(e) {
    var strChooseItemId = e.parentNode.parentNode;
    var strChooseItemIdx = parseInt(strChooseItemId.id.split("ImgItem")[1], 10);
    var result = document.getElementById("result");
    result.removeChild(e.parentNode.parentNode);
    console.log(strChooseItemIdx);
    console.log(result);
    for (var i = strChooseItemIdx + 1; i <= result.childNodes.length; i++) {
        console.log("i:" + i);
        document.getElementById("ImgItem" + i).id = "ImgItem" + (i - 1);
    }
    console.log(result);
}
function FrontImgFunc(e) {
    var strChooseItemId = e.parentNode.parentNode;
    var strChooseItemIdx = parseInt(strChooseItemId.id.split("ImgItem")[1], 10);
    if (strChooseItemIdx == 1) {
        alert("已經排在最前面囉!");
        return;
    }
    document.getElementById("ImgItem" + strChooseItemIdx).id = "Temp999";
    document.getElementById("ImgItem" + (strChooseItemIdx - 1)).id = "ImgItem" + strChooseItemIdx;
    document.getElementById("Temp999").id = "ImgItem" + (strChooseItemIdx - 1);
    SortElementById("result");
    //if (window.screen.width < 576) {
    //    window.location.hash = "#ImgItem" + (strChooseItemIdx - 1);
    //}
    //else {
    //    window.location.hash = "";
    //}
}
function BackImgFunc(e) {
    var strChooseItemId = e.parentNode.parentNode;
    var strChooseItemIdx = parseInt(strChooseItemId.id.split("ImgItem")[1], 10);
    if (strChooseItemIdx == document.getElementById("result").childNodes.length - 1) {
        alert("已經排在最後面囉!");
        return;
    }
    document.getElementById("ImgItem" + strChooseItemIdx).id = "Temp999";
    document.getElementById("ImgItem" + (strChooseItemIdx + 1)).id = "ImgItem" + strChooseItemIdx;
    document.getElementById("Temp999").id = "ImgItem" + (strChooseItemIdx + 1);
    SortElementById("result");
    //if (window.screen.width < 576) {
    //    window.location.hash = "#ImgItem" + (strChooseItemIdx + 1);
    //}
    //else
    //{
    //    window.location.hash = "";
    //}
}
function SortElementById(strParentId) {
    var ret = document.getElementById(strParentId);
    [].map.call(ret.children, Object).sort(function (a, b) {
        return +a.id.match(/\d+/) - +b.id.match(/\d+/);
    }).forEach(function (elem) {
        ret.appendChild(elem);
    });
}


window.onload = function () {

    //Check File API support
    if (window.File && window.FileList && window.FileReader) {
        var filesInput = document.getElementById("files");

        filesInput.addEventListener("change", function (event) {

            var files = event.target.files; //FileList object
            var output = document.getElementById("result");

            for (var i = 0; i < files.length; i++) {
                var file = files[i];

                //Only pics
                if (!file.type.match('image'))
                    continue;

                var picReader = new FileReader();

                picReader.addEventListener("load", function (event) {

                    var picFile = event.target;

                    var div = document.createElement("div");
                    var strDivImgFunc = "<div><input type='button' class='btn btn-link SortBack' value='排序往前' onclick='FrontImgFunc(this)' />";
                    strDivImgFunc += "<input type='button' class='btn btn-link SortFront' value='排序往後' onclick='BackImgFunc(this)' />";
                    strDivImgFunc += "<input type='button' class='btn btn-link RemoveImg' value='刪除' onclick='RemoveImgFunc(this)' /></div>";
                    div.innerHTML = "<img name='ImgItemTag' class='thumbnail' src='" + picFile.result + "'" + "title='" + picFile.name + "'/>" + strDivImgFunc;
                    div.id = "ImgItem" + output.childNodes.length;

                    output.insertBefore(div, null);

                });

                //Read the image
                picReader.readAsDataURL(file);
            }

        });
    }
    else {
        console.log("Your browser does not support File API");
    }
}

//商品新增
function CreateProd(e) {

    var ProductColorList = new Array();
    document.getElementsByName("favcolor").forEach(function (elem) {
        ProductColorList.push(
            {
                ColorCode: elem.value,
                ColorName: "",
                AddPrice: 0
            }
        );
    }
    );

    var ProductSizeList = new Array();
    document.getElementsByName("SizeItem").forEach(function (elem) {
        ProductSizeList.push(
            {
                SizeCode: elem.getElementsByClassName("sizeCode").sizeCode.value,
                SizeMemo: elem.getElementsByClassName("sizeMemo").sizeMemo.value,
                AddPrice: 0
            }
        );
    });

    var ProductImgList = new Array();
    document.getElementsByName("ImgItemTag").forEach(function (elem) {
        ProductImgList.push(
            {
                ImgName: elem.src
            }
        );
    });


    var params = {
        Product: {
            ProductId: ConvertInt($("#Product_ProductId").val()),
            Name: $("#Product_Name").val(),
            Memo: $("#Product_Memo").val().replace(new RegExp('\n', 'g'), '<br>'),
            Price: ConvertInt($("#Product_Price").val()),//parseInt($("#Product_Price").val()),
            Status: ConvertInt($("#Product_Status").val())//parseInt($("#Product_Status").val())
        },
        ProductColorList: ProductColorList,
        ProductSizeList: ProductSizeList,
        ProductImgList: ProductImgList
    }
    let targetUrl = $(e).data("url");
    console.log(targetUrl);
    $.ajax({
        type: "POST",
        contentType: 'application/json',
        url: targetUrl,
        headers: {
            RequestVerificationToken:
                $('input:hidden[name="RequestVerificationToken"]').val()
        },
        data: JSON.stringify(params),
        dataType: "json",
        async: true,
        success: function (response) {
            console.log(response.ret);
            alert(response.ret['msg']);
            console.log(response.ret['validationItemList']);
            $("[data-valmsg-for]").empty();
            if (response.ret['success']) {
                if (targetUrl.includes('Edit')) {
                    window.location.href = '../..' + targetUrl.replace("Edit", "Details");
                }
                else {
                    window.location.href = '../../Products/Index';
                }
            }
            else {
                for (var i = 0; i < response.ret['validationItemList'].length; i++) {
                    $("[data-valmsg-for='" + response.ret['validationItemList'][i]['key'] + "']").append(response.ret['validationItemList'][i]['msg']);
                }
            }
        }
    });
}
//End Product