$(document).ready(function () {
    loadTable();
});

function loadContent() {
    loadTable();
}

function loadTable() {
    $('#tblData').DataTable().clear().destroy();
    $('#tblData').DataTable({
        processing: false,
        serverSide: true,
        lengthMenu: [5,10,25,50],
        stateSave: true,
        filter: true,
        orderMulti: false,
        ajax: {
            url: "/api/transport/merk",            
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: "merkKendaraanId", name: "merkKendaraanId", autoWidth: true },
            { data: "kodeMerk", name: "kodeMerk", autoWidth: true },
            { data: "namaMerk", name: "namaMerk", autoWidth: true },
            {
                data: 'merkKendaraanId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/transport/merk-kendaraan/edit/?merkId=" + row.merkKendaraanId + "'> Edit</button>" }
            }
        ],
        order: [[0, "desc"]]
    })
}

