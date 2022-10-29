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
                object += '<td>' + item.sexo + '</td>';
                object += '<td>' + item.ciudad + '</td>';
                object += '<td>' + item.direccion.val(ObtenerFormatoFecha(json.FechaNacimiento)); + '</td>';
                object += '<td>' + item.nombres + '</td>';

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

function ObtenerFormatoFecha(datetime) {

    var re = /-?\d+/;
    var m = re.exec(datetime);
    var d = new Date(parseInt(m[0]))


    var month = d.getMonth() + 1;
    var day = d.getDate();
    var output = (('' + day).length < 2 ? '0' : '') + day + '-' + (('' + month).length < 2 ? '0' : '') + month + '-' + d.getFullYear();

    return output;
}