﻿$(document).ready(function () {
    loadTable();
});

function loadContent() {
    loadTable();
}

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
});

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
            url: "/api/wr/clients",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: "objectName", name: "objectName", sortable: false, autoWidth: true },
            { data: "objectPhone", name: "objectPhone", sortable: false, autoWidth: true },
            { data: "alamat", name: "alamat", sortable: false, autoWidth: true },
            { data: "namaJenis", name: "namaJenis", sortable: false, autoWidth: true },
            { data: "kota", name: "kota", sortable: false, autoWidth: true },
            { data: "kecamatan", name: "kecamatan", sortable: false, autoWidth: true },
            { data: "kelurahan", name: "kelurahan", sortable: false, autoWidth: true, nowrap: false },
            {
                data: 'clientId',                
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/wr/lokasi/edit/?clientId=" + row.clientId + "'> Edit</button>" },
                sortable: false
            }
        ]
    });
}

$(document).on('shown.bs.modal', function () {
    // initiate select2 for kecamatan
    $('#theKecamatan').select2({
        placeholder: 'Pilih Kecamatan...'
    });

    PopulateOperator();
    PopulateJenis();

    // initiate select2 for kecamatan
    $('#theKelurahan').select2({
        placeholder: 'Pilih Kelurahan...'
    });    

    // Kota API search
    $('#theKota').select2({
        placeholder: 'Pilih Kota/Kabupaten...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/kabupaten/search",
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
                            text: item.namaKabupaten,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });

    $('#theKota').change(function () {
        var thisKab = this.value;

        if (thisKab == '') {
            $('#theKecamatan').prop("disabled", true);
        } else {
            $('#theKecamatan').prop("disabled", false);
            PopulateKecamatan(thisKab);
        }
    });

    $('#theKecamatan').change(function () {
        var thisKec = this.value;

        if (thisKec == '') {
            $('#theKelurahan').prop("disabled", true);
        } else {
            $('#theKelurahan').prop("disabled", false);
            PopulateKelurahan(thisKec);
        }
    });
});

function PopulateKecamatan(kab) {
    $('#theKecamatan').select2({
        placeholder: 'Pilih Kecamatan...',
        dropdownPosition: 'below',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/kecamatan/search/?kab=" + kab,
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
                            text: item.namaKecamatan,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}

function PopulateKelurahan(kec) {
    $('#theKelurahan').select2({
        placeholder: 'Pilih Kelurahan...',
        dropdownPosition: 'below',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/kelurahan/search/?kec=" + kec,
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
                            text: item.namaKelurahan,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}

function PopulateOperator() {
    $('#operator').select2({
        placeholder: 'Pilih Operator WR...',
        dropdownPosition: 'below',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/pegawai/operatorwr/search",
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
                            text: item.namaOperator,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}

function PopulateJenis() {
    $('#myJenis').select2({
        placeholder: 'Pilih Jenis WR...',
        dropdownPosition: 'below',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/wr/jenis/search",
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
                            text: item.namaJenis,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}