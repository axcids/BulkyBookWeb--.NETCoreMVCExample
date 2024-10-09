eeeeeeevar dataTable;

$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": {
            url: '/Admin/Product/GetAll'
        },
        "columns": [
            { data: 'title', "className": "text-center", "width": "25%" },
            { data: 'isbn', "className": "text-center", "width": "15%" },
            { data: 'listPrice', "className": "text-center", "width": "5%" },
            { data: 'author', "className": "text-center", "width": "20%" },
            { data: 'category.name', "className": "text-center", "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                    return `<div clas="w-100 btn-group" role="group">
                <a href="/admin/product/upsert?id=${data}" class="btn btn-primary"><i class="bi bi-pencil-square"></i> Edit</a>
                <a onClick=Delete('/admin/product/delete/${data}') class="btn btn-danger"><i class="bi bi-trash-fill"></i> Delete</a>
                </div>`
                },
                "Width": "25%"
            }

        ]
    });
}

function Delete(url) {
    Swal.fire({
        title: "Are you sure?",
        text: "You won't be able to revert this!",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Yes, delete it!"
    }).then((result) => {
        if (result.isConfirmed) {
            $.ajax({
                url: url,
                type: 'DELETE',
                success: function (data) {
                    dataTable.ajax.reload();
                    TempData.success(data.message);
                }
            })
        }
    });
}


