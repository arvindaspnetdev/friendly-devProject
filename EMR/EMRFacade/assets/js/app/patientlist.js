$(document).ready(function () {
    //initialize the javascript
    //App.init();
    //App.dataTables();
    $("#tblpatient").dataTable({
        dom: "<'row be-datatable-header'<'col-sm-6'l<'toolbar'>><'col-sm-2'f><'col-sm-4 text-right'i>><'row be-datatable-body'<'col-sm-12'tr>><'row be-datatable-footer'<'col-sm-12'p>>",
        "bLengthChange": false,
        "bFilter": false,
        "fnInfoCallback": function (oSettings, iStart, iEnd, iMax, iTotal, sPre) {
            return "PAGE "+iStart + " OF " + iEnd;
        }
    });
    $("div.toolbar").html('<button type="button" class="btn btn-space btn-primary"><i class="icon icon-left mdi mdi-plus"></i> Add new patient</button><button class="btn btn-space btn-space btn-secondary"><i class="icon icon-left mdi mdi-upload"></i> Update patient (via C-CDA XML)</button>');
});