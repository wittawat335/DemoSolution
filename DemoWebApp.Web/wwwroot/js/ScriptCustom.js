function validateDateFromTo(dateFromVal, dateToVal) {
    if (dateFromVal.val() == '' || dateFromVal.val() == undefined) {
        alertMessage("Please input DateFrom");
        return false;
    }
    if (dateToVal.val() == '' || dateToVal.val() == undefined) {
        alertMessage("Please input DateTo");
        return false;
    }

    var D_datefrom = dateFromVal.val().split("/");
    var D_dateto = dateToVal.val().split("/");
    var cus_Date_from = Date.parse(D_datefrom[1] + "/" + D_datefrom[0] + "/" + D_datefrom[2]);
    var cus_Date_to = Date.parse(D_dateto[1] + "/" + D_dateto[0] + "/" + D_dateto[2]);
    if (cus_Date_from > cus_Date_to) {
        alertMessage("Incorrect date from less then date to");
        return false;
    }
    return true;
}

function validateTextFromTo(idDateFrom, idDateTo) {
    var objFrom = document.getElementById(idDateFrom);
    var objTo = document.getElementById(idDateTo);
    if (objFrom.value == '') {
        alertMessage("Please input Days From");
        return false;
    }
    if (objTo.value == '') {
        alertMessage("Please input Days To");
        return false;
    }
    if (Number(objFrom.value) > Number(objTo.value)) {
        alertMessage("Incorrect Days From");
        return false;
    }
    return true;
}

function modalPOST(caption, controller, action, data, isFull, med) {
    var url = root + controller + '/' + action;
    alert(url);
    $.post(url, data, function (result) {
        $('#modalDialog > .modal-dialog > .modal-content > .modal-body').html(result);
        showModal(caption, isFull);
    });
}
function clearModal() {
    $('#modalDialog > .modal-dialog > .modal-content > .modal-body').html('');
    $('#modalDialog > .modal-dialog > .modal-content > .modal-header > .modal-title').text('');
    $('#modalDialog').modal('hide');
}

function showModal(caption, isFull, med) {

    $('#modalDialog > .modal-dialog').removeClass('modal-full');
    $('#modalDialog > .modal-dialog').removeClass('modal-20');
    $('#modalDialog > .modal-dialog').removeClass('modal-30');
    $('#modalDialog > .modal-dialog').removeClass('modal-40');
    $('#modalDialog > .modal-dialog').removeClass('modal-50');
    $('#modalDialog > .modal-dialog').removeClass('modal-55');
    $('#modalDialog > .modal-dialog').removeClass('modal-60');
    $('#modalDialog > .modal-dialog').removeClass('modal-60');
    $('#modalDialog > .modal-dialog').removeClass('modal-70');
    $('#modalDialog > .modal-dialog').removeClass('modal-80');
    $('#modalDialog > .modal-dialog').removeClass('modal-90');
    $('#modalDialog > .modal-dialog').removeClass('modal-99');

    if (typeof (isFull) === "boolean") {
        if (isFull)
            $('#modalDialog > .modal-dialog').addClass('modal-full');
        else
            $('#modalDialog > .modal-dialog').removeClass('modal-full');
    } else {
        if (typeof (isFull) === "number") {
            var x = isFull;
            switch (true) {
                case (x >= 20 && x < 30):
                    $('#modalDialog > .modal-dialog').addClass('modal-20');
                    break;
                case (x >= 30 && x < 38):
                    $('#modalDialog > .modal-dialog').addClass('modal-36');
                    break;
                case (x >= 30 && x < 40):
                    $('#modalDialog > .modal-dialog').addClass('modal-30');
                    break;
                case (x >= 40 && x < 50):
                    $('#modalDialog > .modal-dialog').addClass('modal-40');
                    break;
                case (x >= 50 && x < 60):
                    $('#modalDialog > .modal-dialog').addClass('modal-50');
                    break;
                case (x >= 55 && x < 60):
                    $('#modalDialog > .modal-dialog').addClass('modal-55');
                    break;
                case (x >= 60 && x < 70):
                    $('#modalDialog > .modal-dialog').addClass('modal-60');
                    break;
                case (x >= 70 && x < 80):
                    $('#modalDialog > .modal-dialog').addClass('modal-70');
                    break;
                case (x >= 80 && x < 90):
                    $('#modalDialog > .modal-dialog').addClass('modal-80');
                    break;
                case (x >= 90 && x < 95):
                    $('#modalDialog > .modal-dialog').addClass('modal-90');
                    break;
                case (x >= 95):
                    $('#modalDialog > .modal-dialog').addClass('modal-99');
                    break;
                default:
                    $('#modalDialog > .modal-dialog').addClass('modal-full');
                    break;
            }
        }
    }

    $('#modalDialog > .modal-dialog > .modal-content > .modal-header > .modal-title').text(caption);
    $('#modalDialog').modal('show');
}


//$(document).ready(function () {

//    $(document).ajaxStart(function () {
//        App.blockUI({
//            boxed: true
//        });
//    }).ajaxStop(function () {
//        App.unblockUI();
//    });
//})

//$.extend($.fn.dataTable.defaults, {
//    language: {
//        aria: {
//            sortAscending: ': activate to sort column ascending',
//            sortDescending: ': activate to sort column descending'
//        },
//        emptyTable: 'ไม่พบข้อมูล',
//        info: 'แสดง _START_ ถึง _END_ จาก _TOTAL_ รายการ',
//        infoEmpty: '',
//        infoFiltered: '', //(filtered1 จาก _MAX_ รายการทั้งหมด)
//        lengthMenu: '_MENU_ รายการ',
//        search: 'ค้นหา:',
//        zeroRecords: 'ไม่พบข้อมูล'
//    },

//    buttons: [
//            { extend: 'print', className: 'btn dark btn-outline' },
//            { extend: 'copy', className: 'btn red btn-outline' },
//            { extend: 'pdf', className: 'btn green btn-outline' },
//            { extend: 'excel', className: 'btn yellow btn-outline ' },
//            { extend: 'csv', className: 'btn purple btn-outline ' },
//            { extend: 'colvis', className: 'btn dark btn-outline', text: 'Columns' }
//    ],
//    //responsive: true,
//    //scrollX: true,
//    //paging: true,
//    lengthMenu: [
//            [5, 10, 15, 20, -1],
//            [5, 10, 15, 20, 'All'] // change per page values here
//    ],
//    // set the initial value
//    pageLength: 10,
//    dom: "<<l><f><r>><'table-scrollable't><'row'<'col-md-5 col-sm-6'i><'col-md-7 col-sm-6'p>>", // horizobtal scrollable datatable
//});


function alertMessage(message, mode, title) {
    if (!message)
        message = '';
    alertMessageComfirm(message, mode, title);

    //bootbox.alert({
    //    title: "Destroy planet?",
    //    message: message,
    //    backdrop: true
    //}, function () { });
}

function alertMessageComfirm(message, mode, title) {
    var t = (title == '' || title == undefined) ? 'แจ้งเตือน' : title; //title
    var m = (message == '' || message == undefined) ? 'Unknown' : message; //title; //msg
    var i = ''; //icon
    var b = ''; //button
    //d = danger ,w = warning ,s = success , null = info
    if (mode == 'd') {
        i = '<i class="fa fa-times-circle-o fa-lg text-danger" style="padding-right: 6px;"></i>';
    } else if (mode == 'w') {
        i = '<i class="fa fa-warning fa-lg text-warning" style="padding-right: 6px;"></i>';
    } else if (mode == 's') {
        i = '<i class="fa fa-check-circle-o fa-lg text-success" style="padding-right: 6px;"></i>';
    } else {
        i = '<i class="fa fa-info-circle fa-lg text-info" style="padding-right: 6px;"></i>';
    }
    bootbox.dialog({
        title: i + t,
        message: m,
        backdrop: true,
        buttons: {
            ok: function (result) {
                label: 'Ok';
                return true;
            },

        },
        //callback: function () {
        //    //Begin Callback
        //    alert("Finished");
        //}
    });
}





//$.extend($.validator.messages, {
//    required: "กรุณากรอกข้อมูล",
//    remote: "Please fix this field.",
//    email: "Please enter a valid email address.",
//    url: "Please enter a valid URL.",
//    date: "Please enter a valid date.",
//    dateISO: "Please enter a valid date (ISO).",
//    number: "Please enter a valid number.",
//    digits: "Please enter only digits.",
//    creditcard: "Please enter a valid credit card number.",
//    equalTo: "Please enter the same value again.",
//    accept: "Please enter a value with a valid extension.",
//    maxlength: $.validator.format("กรุณากรอกข้อมูลไม่เกิน {0} ตัว"),
//    minlength: $.validator.format("กรุณากรอกข้อมูลอย่างน้อย {0} ตัว"),
//    rangelength: $.validator.format("Please enter a value between {0} and {1} characters long."),
//    range: $.validator.format("Please enter a value between {0} and {1}."),
//    max: $.validator.format("Please enter a value less than or equal to {0}."),
//    min: $.validator.format("Please enter a value greater than or equal to {0}.")
//});

//$.validator.setDefaults({
//    debug: true,
//    errorElement: 'span', //default input error message container
//    errorClass: 'help-block help-block-error', // default input error message class
//    focusInvalid: true, // do not focus the last invalid input
//    ignore: '*:not([name])',  // validate all fields including form hidden input


//    errorPlacement: function (error, element) { // render error placement for each input type
//        var icon = $(element).parent('.input-icon').children('i');
//        icon.removeClass('fa-check').addClass("fa-warning");
//        icon.attr("data-original-title", error.text()).tooltip({ 'container': 'body' });
//    },



//    unhighlight: function (element) { // revert the change done by hightlight
//        var icon = $(element).parent('.input-icon').children('i');
//        icon.removeClass("fa-warning").addClass("fa-check");
//        //icon.attr("data-original-title", error.text()).tooltip({ 'container': 'body' });
//        $(element).closest('.form-group').removeClass("has-error").addClass('has-success'); // set error class to the control group   
//        $(element).closest('form').find('.alert-danger').hide();
//        $(element).closest('form').find('.alert-success').show();
//    },

//    success: function (label, element) {
//        var icon = $(element).parent('.input-icon').children('i');
//        $(element).closest('.form-group').removeClass('has-error').addClass('has-success'); // set success class to the control group
//        icon.removeClass("fa-warning").addClass("fa-check");
//    },

//    highlight: function (element) { // hightlight error inputs
//        $(element).closest('.form-group').removeClass("has-success").addClass('has-error'); // set error class to the control group  
//        $(element).closest('form').find('.alert-danger').show();
//        $(element).closest('form').find('.alert-success').hide();
//    },
//});

//add button export file
function DataTableExport(tableName, divTarget, title) {

    var configObj = {
        //dom: 'Bfrtip',
        "dom": '<"col-md-offset-10"<B>> <"clearfix"> lf<"table-scrollable"t>ip',
        buttons: [{
            extend: 'excelHtml5',
            title: title,
            header: true,
            exportOptions: {
                columns: ':visible'
            }
        }, 'colvis']
    };



    var table = $(tableName).DataTable(configObj);

    if (divTarget != null || divTarget != undefined)
        table.buttons().container().appendTo(divTarget);
}


//BindControl
function SetSelect2Value(id, text, val) {
    $(id).append(new Option(text, val, true, true));
}
