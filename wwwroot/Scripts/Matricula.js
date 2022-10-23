var datatable;

$(document).ready(function () {
    loadDataTable()
});

function loadDataTable() {
    datatable = $('#tblDato').DataTable({
        "ajax": {
            "url": "/Admin/Matricula/ObtenerTodos"
        },
        "columns": [
            { "data": "situacion", },
            { "data": "estadoAlumno", },
            { "data": "nivel.descripcionNivel",  },
            { "data": "gradoSeccion.descripcionGrado",  },
            { "data": "grado.descripcionSeccion", },
            { "data": "alumno.nombres",},
            { "data": "alumno.apellidos",  },
            { "data": "alumno.documentoIdentidad",  },
            {
                "data": "id",
                "render": function (data) {
                    return `
                        <div class="text-center">
                            <a href="/Admin/Matricula/Upsert/${data}" class="btn btn-success text-white" style="cursor:pointer">
                                <i class="fas fa-edit"></i>
                            </a>
                            <a onclick=Delete("/Admin/Matricula/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
                                <i class="fas fa-trash"></i>
                            </a>
                        </div>
                        `;
                }, "width": "40%"
            }
        ]
    });
}


function Delete(url) {
    
    swal({
        title: "Esta Seguro que quiere Eliminar la Categoria?",
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