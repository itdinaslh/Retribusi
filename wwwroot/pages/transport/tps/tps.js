$(document).ready(function () {
    loadTable();
});

$(document).on('shown.bs.modal', function () {
    
});

function loadContent() {
    loadTable();
}

function loadTable() {
    $('#tblData').DataTable().clear().destroy();
    $('#tblData').DataTable({
        processing: false,
        serverSide: true,
        lengthMenu: [5, 10, 25, 50],
        stateSave: true,
        filter: true,
        orderMulti: false,
        ajax: {
            url: "/api/transport/tps",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: "nama", name: "nama", sortable: false, autoWidth: true },
            { data: "alamat", name: "alamat", sortable: false, autoWidth: true },
            { data: "jenis", name: "jenis", sortable: false, autoWidth: true },
            { data: "status", name: "status", sortable: false, autoWidth: true },            
            {
                data: 'tpsId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/transport/tps/edit/?tpsId=" + row.tpsId + "'> Edit</button>" },
                sortable: false
            }
        ]
    });
}