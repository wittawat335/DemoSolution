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

function modalPOST(caption, path, data, isFull) {
    var url = path;
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

function showModal(caption, isFull) {

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


