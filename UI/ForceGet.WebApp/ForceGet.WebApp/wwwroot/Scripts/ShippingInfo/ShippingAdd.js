$(document).ready(function () {

    $("#btnSave").on("click", function (e) {
        e.preventDefault();
        addShippingInfo();
    });


});


function addShippingInfo() {


    $("#btnSave").addClass("spinner spinner-white spinner-right");
    $("#btnSave").prop("disabled", true);
    console.log($("#frmAdd").serializeArray());
    var dataList = {};
    $.each($("#frmAdd").serializeArray(), function (i, item) {
        dataList[item.name] = item.value;
    });

    console.log(dataList);

    $.ajax({
        type: "Post",
        url: "/Home/CreateShipping",
        data: dataList,
        dataType: "json",
        success: function (data) {
            if (data.isSuccess) {
                toastr.success("İşlem başarıyla tamamlanmıştır.");

            }
            else {
                if (data.modelErrors.length > 0) {
                    var alert = '';
                    for (var i = 0; i < data.modelErrors.length; i++) {
                        alert += data.modelErrors[i].value + "<br />";
                    }

                    toastr.error(alert);
                }
                else {
                    toastr.error(data.errorText);
                }
            }

            $("#btnSave").removeClass("spinner spinner-white spinner-right");
            $("#btnSave").prop("disabled", false);
        },
        error: function ($xhr, textStatus, errorThrown) {
            if ($xhr.status == 401) {
                toastr.error("Hata! Tekrar giriş yapmalısınız.");
            } else {
                toastr.error("Hata! Tekrar deneyiniz.");
            }

            $("#btnSave").removeClass("spinner spinner-white spinner-right");
            $("#btnSave").prop("disabled", false);
        }
    });

}
