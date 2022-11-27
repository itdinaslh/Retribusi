var exist = false;

$(document).ready(function () {
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
            url: "/api/transport/driver",
            type: "POST",
            dataType: "json"
        },
        columns: [            
            { data: "nama", name: "nama", sortable: false, autoWidth: true },
            { data: "nik", name: "nik", sortable: false, autoWidth: true },
            { data: "noHp", name: "noHp", sortable: false, autoWidth: true },
            { data: "tipe", name: "tipe", sortable: false, autoWidth: true },
            { data: "status", name: "status", sortable: false, autoWidth: true },
            { data: "bidang", name: "bidang", sortable: false, autoWidth: true },
            { data: "kota", name: "kota", sortable: false, autoWidth: true },
            { data: "kecamatan", name: "kecamatan", sortable: false, autoWidth: true },
            {
                data: 'pegawaiId',
                render: function (data, type, row) { return "<button type='button' class='btn btn-sm btn-success mr-2 showMe' style='width:100%;' data-href='/transport/driver/edit/?driverId=" + row.pegawaiId + "'> Edit</button>" },
                sortable: false
            }
        ]
    });
}

$(document).on('keypress', '#nik', function (e) {
    if (e.which == 13) {
        CheckDriver();
    }
});

$(document).on('shown.bs.modal', function () {
    // initiate select2 for kecamatan
    $('#theKecamatan').select2({
        placeholder: 'Pilih Kecamatan...'
    });

    // initiate select2 for kecamatan
    $('#theKelurahan').select2({
        placeholder: 'Pilih Kelurahan...'
    });

    // Bidang API search
    $('#theBidang').select2({
        placeholder: 'Pilih Bidang...',
        dropdownParent: $('#myModal'),
        dropdownPosition: 'bottom',
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

$(document).on('submit', '#frmDriver', function (e) {
    e.preventDefault();

    if (!exist) {
        CheckDriver();
    } else {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function (result) {
                if (result.success) {
                    successfulDriverAdd();
                }
            }
        });
    }
});

function CheckDriver() {
    var nik = $('#nik').val();

    $.ajax({
        url: '/transport/driver/check/?nik=' + nik,
        type: 'GET',
        crossDomain: true,
        headers: {
            "Access-Control-Allow-Origin": "*",
            "Access-Control-Allow-Credentials": "true",
            "Access-Control-Allow-Methods": "GET"
        },
        success: function (result) {
            if (result.failed) {
                exist = false;

                ChangeState();                
            } else {
                exist = true;

                ChangeState();

                $('#nama').val(result.namaPegawai);
                $('#hp').val(result.noHP);
                $('#email').val(result.email);
                $('#alamat').val(result.alamatKTP);
                $('#tglLahir').val(result.tglLahir);
                $('#rNIK').val(result.nik);
                $('#rNama').val(result.namaPegawai);

                if (result.bidangID != null) {
                    $('#theBidang').append(`<option value="${result.bidangID}" selected>
                                        ${result.namaBidang}
                                        </option>`);
                }
            }
        }
    });
}

function ClearInput() {
    $('.myData').val('');
}

function ChangeState() {
    // $('#frmDriver').attr('action', '/transport/driver/store');
    if (exist == true) {
        $('#frmDriver').attr('action', '/transport/driver/store');
        $('#btnSubmit').text("Submit");
        $('#theKota').prop('required', true);
    } else {
        $('#frmDriver').attr('action', '/transport/driver/check');
        $('#btnSubmit').text("Cek Driver");
        ClearInput();
    }
}

function successfulDriverAdd() {
    swal({
        position: 'top-end',
        type: 'success',
        title: 'Data berhasil disimpan!',
        showConfirmButton: false,
        timer: 1000
    }).then(function () {
        $('#myModal').modal('hide');
        loadContent();
    });
}