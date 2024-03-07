$(document).ready(function () {
    getShippingInfoList();

    $('.select2').select2({ width: '100%' });

});
var ShippingInfoListDt;


function getShippingInfoList() {

    if (ShippingInfoListDt != null) {
        ShippingInfoListDt.destroy();
    }

    ShippingInfoListDt = $('#dtList').DataTable({
        language: {
            url: "//cdn.datatables.net/plug-ins/1.10.21/i18n/Turkish.json"
        },
        processing: true,
        serverSide: true,
        info: true,
        keys: true,
        filter: false,
        scrollY: '70vh',
        scrollX: true,
        scrollCollapse: true,
        drawCallback: function (oSettings) {

        },
        ajax: function (data, callback, settings) {
            $.ajax({
                type: "POST",
                url: '/Home/GetShippingInfoListByPaging',
                data: {
                    "draw": data.draw,
                    "start": data.start,
                    "length": data.length,
                    "order.column": data.columns[data.order[0].column].data,
                    "order.dir": data.order[0].dir,
                    "filter": $("#frmFilter").serializeArray()
                },
                dataType: "json",
                success: function (response) {


                    callback(response);
                },
                error: function (err) {

                }
            });
        },
        columns: [
            { data: "mode", name: "Mode" },
            { data: "movementType", name: "MovementType" },
            { data: "incoterms", name: "Incoterms" },
            { data: "country", name: "Country" },
            { data: "city", name: "City" },
            { data: "packageType", name: "PackageType" },
            { data: "unit1", name: "Unit1" },
            { data: "unit2", name: "Unit2" },
            { data: "currency", name: "Currency" }
        ],
        order: [[0, 'asc']],
        lengthMenu: [[10, 50, 100, 99999], [10, 50, 100, "Tümü"]]
    });
}