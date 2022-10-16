$(document).ready(function () {

    ShowAlumno()
});


function ShowAlumno() {
    $.ajax({
        url: '/Admin/Matricula/Prueba',
        type: 'Get',
        dataType: 'json',
        contentType: "application/json; charset=utf-8",
        success: function (result, statu, xhr) {
            var object = '';
            $.each(result, function (index, item) {
                object += '<tr>';
                object += '<td>' + item.alumno.direccion + '</td>';
                object += '<td>' + item.alumno.nombres + '</td>';
                object += '<td>' + item.periodo.descripcion+ '</td>';
                object += '<td>' + item.documentoIdentidad + '</td>';
                object += '<td>' + item.alumno.sexo+ '</td>';
                object += '<td>' + item.alumno.ciudad + '</td>';
                object += '<td>' + item.alumno.direccion + '</td>';
                object += '<td>' + item.alumno.estado + '</td>';
             
                object += '<td><a href="#" class="btn btn-primary">Editar</a> || <a href="#" class="btn btn-danger">Eliminar</a> </td>';
                object += '</tr>';
            });
            $('#tblDatos').html(object);
        },
        error: function () {
            alert("jjjj");
        }
    });

};