
var dataTable;

$(document).ready(function () {
    var url = window.location.search;
    if (url.includes("inprocess")) {
        loadDataTable("inprocess");
    } else {
        if (url.includes("completed")) {
            loadDataTable("completed");
        } else {
            if (url.includes("pending")) {
                loadDataTable("pending");
            } else {
                if (url.includes("approved")) {
                    loadDataTable("approved");
                } else {
                    loadDataTable("all");
                }
            }
        }
    }
});

function loadDataTable(status) {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Admin/Order/GetAll?status=' + status
        },
        "columns": [
            { data: 'id', "className": "text-center", "width": "5%" },
            { data: 'name', "className": "text-center", "width": "20%" },
            { data: 'phoneNumber', "className": "text-center", "width": "20%" },
            { data: 'applicationUser.email', "className": "text-center", "width": "20%" },
            { data: 'orderStatus', "className": "text-center", "width": "20%" },
            { data: 'orderTotal', "className": "text-center", "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div clas="w-100 btn-group" role="group">
                <a href="/admin/Order/details?orderId=${data}" class="btn btn-primary"><i class="bi bi-pencil-square"></i></a>
                </div>`
                },
                "Width": "5%"
            }

        ]
    });
}


