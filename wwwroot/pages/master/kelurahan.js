$(document).ready(function () {
    loadTable();
});

function loadContent() {
    loadTable();
}

function loadTable() {
    $('#tblData').DataTable().clear().destroy();
    $('#tblData').DataTable({
        processing: true,
        serverSide: true,
        lengthMenu: [5,10,25,50],
        filter: true,
        stateSave: true,
        orderMulti: false,
        ajax: {
            url: "/api/master/kelurahan",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: "kelurahanID", name: "kelurahanID", autoWidth: true },
            { data: "namaKelurahan", name: "namaKelurahan", autoWidth: true },
            { data: "namaKecamatan", name: "namaKecamatan", autoWidth: true },
            { data: "namaKabupaten", name: "namaKabupaten", autoWidth: true },
            { data: "namaProvinsi", name: "namaProvinsi", autoWidth: true }
        ]
    })
}

$(document).on('shown.bs.modal', function () {
    $('#sProvinsi').select2({
        placeholder: 'Pilih Provinsi...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/provinsi/search",
            contentType: "application/json; charset=utf-8",
            data: function (params) {
                var query = {
                    term: params.term,
                };
                return query;
            },
            processResults: function (result) {
                return {
                    results: $.map(result, function (item) {
                        return {
                            text: item.namaProvinsi,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
});