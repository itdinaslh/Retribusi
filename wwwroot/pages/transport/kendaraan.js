﻿$(document).ready(function () {
    loadTable();
});

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
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
            url: "/api/transport/kendaraan",
            type: "POST",
            dataType: "json"
        },
        columns: [
            { data: "kendaraanId", name: "kendaraanId", autoWidth: true },
            { data: "noPolisi", name: "noPolisi", autoWidth: true },
            { data: "jenis", name: "jenis", autoWidth: true },
            { data: "tahun", name: "tahun", autoWidth: true },
            { data: "bidang", name: "bidang", autoWidth: true },
            { data: "kabupaten", name: "kabupaten", autoWidth: true },
            { data: "kecamatan", name: "kecamatan", autoWidth: true },
            {
                data: 'kendaraanId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/transport/kendaraan/edit/?id=" + row.kendaraanId + "'> Edit</button>" }
            }
        ],
        order: [[0, "desc"]]
    })
}

$(document).on('shown.bs.modal', function () {
    $('#chkSame').change(function () {
        if (!this.checked) {
            $('.tugas').show();
            PopulateBidangTugas();
            PopulateKotaTugas();
            $('#KecamatanTugas').select2({
                placeholder: 'Pilih Kecamatan Penugasan...'
            });
        } else {
            $('.tugas').hide();
        }
    })

    // initiate select2 for kecamatan
    $('#KecamatanAsal').select2({
        placeholder: 'Pilih Kecamatan...'
    });

    // Merk API search
    $('#MyMerk').select2({
        placeholder: 'Pilih Merk...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/transport/merk/search",
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
                            text: item.namaMerk,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });

    // Tipe api search
    $('#MyTipe').select2({
        placeholder: 'Pilih Tipe...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/transport/tipe/search",
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
                            text: item.namaTipe,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });

    // Jenis api search
    $('#MyJenis').select2({
        placeholder: 'Pilih Jenis...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/transport/jenis/search",
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

    // Fungsi api search
    $('#Fungsi').select2({
        placeholder: 'Pilih Fungsi Kendaraan...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/transport/fungsi/search",
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
                            text: item.namaFungsi,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });

    // Bidang asal api search
    $('#MyBidang').select2({
        placeholder: 'Pilih Bidang...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/bidang/search",
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
                            text: item.namaBidang,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });

    // Kabupaten asal api search
    $('#KotaAsal').select2({
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

    $('#KotaAsal').change(function () {
        var thisKab = this.value;

        if (thisKab == '') {
            $('#KecamatanAsal').prop("disabled", true);
        } else {
            $('#KecamatanAsal').prop("disabled", false);
            PopulateKecamatan(thisKab);
        }
    });

    $('#KotaTugas').change(function () {
        var thisKab = this.value;

        if (thisKab == '') {
            $('#KecamatanTugas').prop("disabled", true)
        } else {
            $('#KecamatanTugas').prop("disabled", false)
            PopulateKecamatanTugas(thisKab);
        }
    });
});

function PopulateKecamatan(kab) {
    $('#KecamatanAsal').select2({
        placeholder: 'Pilih Kecamatan...',
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

function PopulateBidangTugas() {
    $('#MyBidangTugas').select2({
        placeholder: 'Pilih Bidang Penugasan...',
        dropdownParent: $('#myModal'),
        allowClear: true,
        ajax: {
            url: "/api/master/bidang/search",
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
                            text: item.namaBidang,
                            id: item.id
                        }
                    })
                }
            },
            cache: true
        }
    });
}

function PopulateKotaTugas() {
    $('#KotaTugas').select2({
        placeholder: 'Pilih Kota Penugasan...',
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
}

function PopulateKecamatanTugas(kab) {
    $('#KecamatanTugas').select2({
        placeholder: 'Pilih Kecamatan Penugasan...',
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