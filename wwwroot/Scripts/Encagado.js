var datatable;


$(document).ready(function () {
  
    loadDataTable();

  
});

function loadDataTable() {
    datatable = $('#tblDato').DataTable({
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
        dom: 'Bfrtip',
        buttons: [
            {
                extend: 'excelHtml5',
                text: '<i class="fas fa-file-excel"></i> ',
                titleAttr: 'Exportar a Excel',
                className: 'btn btn-success'
            },
            {
                extend: 'pdfHtml5',
                text: '<i class="fas fa-file-pdf"></i> ',
                titleAttr: 'Exportar a PDF',
                className: 'btn btn-danger'
            },
            {
                extend: 'print',
                text: '<i class="fa fa-print"></i> ',
                titleAttr: 'Imprimir',
                className: 'btn btn-info'
            },
        ],
        "ajax": {
            "url": "/Admin/Encargado/ObtenerTodos"
        },
        "columns": [
            { "data": "nombres", },
            { "data": "apellidos", },
            { "data": "estadoCivil", },
            { "data": "documentoIdentidad", },
            { "data": "ciudad", },
            { "data": "direccion", },
            {
                "data": "fechaRegistro", "render": function (data) {
                    var date = new Date(data);
                    var day = date.getDate();
                    var month = date.getMonth() + 1;
                    return ("0" + day).slice(-2) + "/" + (month.length > 1 ? month : + month) + "/" + date.getFullYear();
                }, "autoWidth": true,
               "width": "17%" },
            {
                "data": "tipoRelacion",
                "render": function (data) {
                    if (data == "1") {
                        return "Activo";
                    }
                    
                    else if (data == "2") {
                        return "Inactivo";
                    }

                    else {
                        return "Aplazado";
                    }
                }, 
            },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Encargado/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                <i class="fas fa-edit"></i>
                            </a>
                            <a onclick=Delete("/Admin/Encargado/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">                            
                                <i class="fas fa-trash"></i>
                            </a>
                        </div>
                        `;
                },

            }
        ]


    });

}


function Delete(url) {

    swal({
        title: "Esta Seguro que quiere Eliminar el Alumno?",
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
                        swal("Mensaje", "Alumno Eliminado", "success")
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