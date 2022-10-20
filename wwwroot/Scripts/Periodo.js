var datatable;


$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    datatable = $('#tblDatos').DataTable({
        language: {
            "lengthMenu": "Mostrar _MENU_ registros",
            "zeroRecords": "No se encontraron resultados",
            "infoEmpty": "Mostrando registros del 0 al 0 de un total de 0 registros",
            "info": "Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros",
            "infoFiltered": "(filtrado de un total de _MAX_ registros)",
            "sSearch": "Buscar:",
            "oPaginate": {
                "sFirst": "Primero",
                "sLast": "Último",
                "sNext": "Siguiente",
                "sPrevious": "Anterior"
            },
            "sProcessing": "Procesando...",
        },
        /*  para usar los botones  */
        responsive: "true",
        dom: 'Blfrtip',
        buttons: [
          
        ],
        "ajax": {
            "url": "/Admin/Periodo/ObtenerTodos"
        },
        "columns": [
            { "data": "descripcion", "width": "20%" },
            {
                "data": "fechaInicio", "width": "20%", "render": function (data) {

                    var date = new Date(data);
                    var day = date.getDate();
                    var month = date.getMonth() + 1;
                    return ("0" + day).slice(-2) + "/" + (month.length > 1 ? month : + month) + "/" + date.getFullYear();
                }, "autoWidth": true },
            {
                "data": "fechaFin", "width": "20%", "render": function (data) {
                  
                    var date = new Date(data);
                    var day = date.getDate();
                    var month = date.getMonth() + 1;
                    return ("0" + day).slice(-2) + "/" + (month.length > 1 ? month : + month) + "/" + date.getFullYear() ;
                }, "autoWidth": true
            },
            {
                "data": "estado",
                "render": function (data) {
                    if (data == true) {
                        return "Activo";
                    }
                    else {
                        return "Inactivo";
                    }
                }, "width": "20%"
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Periodo/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                <i class="fas fa-edit"></i>
                            </a>
                            <a onclick=Delete("/Admin/Periodo/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">                            
                                <i class="fas fa-trash"></i>
                            </a>
                        </div>
                        `;
                }, "width": "20%"
            }
        ]
    });
}


function Delete(url) {
    
    swal({
        title: "Esta Seguro que quiere Eliminar el Periodo?",
        text: "Este Registro no se podra recuperar",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((borrar) => {
        if (borrar) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        datatable.ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            });
        }
    });    
}

$(function () {
    $("#datepicker").datepicker();
});
 


