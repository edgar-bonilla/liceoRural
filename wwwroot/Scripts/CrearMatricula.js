$(document).ready(function () {
jQuery.ajax({
    url: "/Admin/Periodo/ObtenerTodos"
    type: "GET",
    dataType: "json",
    contentType: "application/json; charset=utf-8",
    success: function (data) {

        if (data.data != null)
            $.each(data.data, function (data) {

                if (data.Activo == true) {
                    $("#txtnombreperiodo").text(item.descripcion)
                    $("#txtidperiodo").val(item.idPeriodo)
                  
                    return false;
                }
            })

    },
    error: function (error) {
        console.log(error)
    },
    beforeSend: function () {

    },
});

})