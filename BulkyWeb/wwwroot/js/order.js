
var dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Admin/Order/GetAll'
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
                <a href="/admin/Order/upsert?id=${data}" class="btn btn-primary"><i class="bi bi-pencil-square"></i></a>
                </div>`
                },
                "Width": "5%"
            }

        ]
    });
}


