var dataTable;
$(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/vehicle/getall' },
        "columns": [
            { data: 'make', "width": "10%" },
            { data: 'model', "width": "10%" },
            { data: 'licenseNo', "width": "10%" },
            { data: 'year', "width": "10%" },
            { data: 'engineSize', "width": "15%" },
            { data: 'transmission', "width": "10%" },
            { data: 'features', "width": "30%" },
            { data: 'additionalInformation', "width": "10%" },
            { data: 'color', "width": "10%" },
            { data: 'mileage', "width": "10%" },
            { data: 'askingPrice', "width": "10%" },
            { data: 'category.name', "width": "10%" },
            {
                data: 'id',
                "render": function (data) {
                   
                    return `<div class="w-75 btn-group" role="group">
                    <a href="/admin/vehicle/upsert?id=${data}" class="btn btn-primary mx-2"> <i class="bi bi-pencil-square"></i> Edit</a>
                    <a onClick=Delete('/admin/vehicle/delete/${data}') class="btn btn-danger mx-2"> <i class="bi bi-trash-fill"></i> Delete</a>
                    </div>`
                },
                "width": "25%"
            }
        ],
        fixedColumns: true,
        paging: false,
        scrollCollapse: true,
        scrollX: true,
        scrollY: 300
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
                    toastr.success(data.message);

                }
            })
        }
    });
}
