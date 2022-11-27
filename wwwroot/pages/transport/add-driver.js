var exist = false;

$(document).on('select2:open', () => {
    document.querySelector('.select2-search__field').focus();
});

$(document).ready(function () {
    $('#theBidang').select2({
        placeholder: 'Pilih Bidang...',
        dropdownPosition: 'below',      
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

    $('#theKota').select2({
        placeholder: 'Pilih Kota/Kabupaten...',        
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

$('#frmDriver').submit(function (e) {
    e.preventDefault();
    
    if (!exist) {
        CheckDriver();
    } else {
        $.ajax({
            url: this.action,
            type: this.method,
            data: $(this).serialize(),
            success: function(result) {
                if (result.success) {
                    successfulDriverAdd();
                }
            }
        });
    }
});

function PopulateKecamatan(kab) {
    $('#theKecamatan').select2({
        placeholder: 'Pilih Kecamatan...',
        dropdownPosition: 'below',        
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

function ChangeState() {
    // $('#frmDriver').attr('action', '/transport/driver/store');
    if (exist == true) {
        $('#frmDriver').attr('action', '/transport/driver/store');
        $('#btnSubmit').text("Submit");
        $('#theKota').prop('required', true);
    } else {
        $('#frmDriver').attr('action', '/transport/driver/check');
        $('#btnSubmit').text("Cek Driver");
    }
}

$('#nik').on('keypress', function (e) {
    if (e.which == 13) {
        CheckDriver();
    }
});

function CheckDriver() {
    var nik = $('#nik').val();

    $.ajax({
        url: '/transport/driver/check/?nik=' + nik,
        type: 'GET',
        crossDomain: true,
        headers: {
            "Access-Control-Allow-Origin":"*",
            "Access-Control-Allow-Credentials":"true",
            "Access-Control-Allow-Methods":"GET"
        },        
        success: function (result) {
            if (result.failed) {
                exist = false;
                ChangeState();
                ClearInput();
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

function successfulDriverAdd() {
    swal({
        position: 'top-end',
        type: 'success',
        title: 'Data berhasil disimpan!',
        showConfirmButton: false,
        timer: 1000
    }).then(function () {
        window.Location.href = 'https://localhost:7333/transport/drivers';
    });
}

function ClearInput() {
    $('.myData').val('');
}