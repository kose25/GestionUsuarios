$.ajaxSetup({
    data: {
        __RequestVerificationToken: document.getElementsByName("__RequestVerificationToken")[0].value
    }
});

var isEdition = false;
var UsuarioActual;

async function Salvar() {
    var form = $("#FormUsuario").dxForm("instance");
    if (form.validate().isValid) {
        var data = form.option("formData");
        console.log(data);
        await RegistrarUsuario(data);
        isEdition = false;
    }
}

async function Editar() {
    var form = $("#FormUsuarioEdit").dxForm("instance");
    if (form.validate().isValid) {
        var data = form.option("formData");
        console.log(data);
        await RegistrarUsuario(data);
        isEdition = false;
    }
}

async function RegistrarUsuario(dataFormulario) {
    let token = $('input[name="__RequestVerificationToken"]').val();
    try {
        Cargando();
        if (dataFormulario.Id && dataFormulario.Id > 0) {
            let respuesta = await $.ajax({ url: "/UsuarioConsulta?handler=ActualizarUsuario", type: "post", data: { usuario: dataFormulario, __RequestVerificationToken: token } });
            swal.close();
            UsuarioActual = null;
            if (respuesta) {
                $("#FormUsuarioEdit").dxForm("instance").resetValues();
                swal.fire("Éxito", "Se ha actualizado la información", "success");
                esconderFormulario();
                $("#TablaUsuarios").dxDataGrid("instance").refresh();
            }
            else {
                await swal.fire("Atención", "No se pudo actualizar el registro, por favor verifique la información", "warning");
            }
        } else {
            let respuesta = await $.ajax({ url: "/Index?handler=RegistrarUsuario", type: "post", data: { usuario: dataFormulario, __RequestVerificationToken: token } });
            swal.close();
            UsuarioActual = null;
            if (respuesta != null && respuesta.Id > 0) {
                $("#FormUsuario").dxForm("instance").resetValues();
                swal.fire("Éxito", "Información guardada correctamente", "success");
            }
            else {
                await swal.fire("Atención", "No se pudo agregar el registro, por favor verifique la información", "warning");
            }
        }        

    } catch (error) {
        Swal.fire(
            'Atencion',
            'Ocurrio un error inesperado',
            'error'
        )
    }
}
function SeleccionarRegistro(e) {
    UsuarioActual = e.data;
}
async function EditarUsuarioFromGrid(e) {

    try {
        UsuarioActual = e.row.data; 
        $("#FormUsuarioEdit").dxForm("instance").resetValues();
        $("#FormUsuarioEdit").dxForm("instance").option("formData", UsuarioActual);       
        $("#TablaUsuarios").hide();
        $("#divformulario").show();
        isEdition = true;
        
        console.log(e);
    } catch (e) {
        Swal.fire(
            'Atencion',
            'Ocurrio un error inesperado',
            'error'
        )

        console.log(e);
    }    

}

function esconderGrid() {
    $("#divgrid").hide();
    $("#divformulario").show();
}

function esconderFormulario() {
    $("#divformulario").hide();
    $("#TablaUsuarios").show();
    $("#TablaUsuarios").dxDataGrid("instance").refresh();
    $("#FormUsuarioEdit").dxForm("instance").resetValues();    
    $("#btnsalvar").dxButton("instance").option("disabled", false);
}



function Cargando() {
    Swal.fire({
        title: 'Cargando...',
        html: 'Un momento por favor, no cierre el navegador',
        type: 'info',
        allowOutsideClick: false,
        allowEscapeKey: false,
        onBeforeOpen: () => {
            Swal.showLoading();
        }
    });
}

async function EliminarUsuario(e) {
    let token = $('input[name="__RequestVerificationToken"]').val();
    UsuarioActual = e.row.data;
    try {

        if (UsuarioActual != null) {            

            let result = await Swal.fire({
                title: 'Confirmación',
                text: "¿Desea Eliminar el usuario " + UsuarioActual.Nombre+"?",
                type: 'warning',
                allowOutsideClick: false,
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Si, Eliminar',
                cancelButtonText: 'Cancelar'
            });

            if (result.value) {
                Cargando();

                let anulado = await $.ajax({ url: "/UsuarioConsulta?handler=EliminarUsuario", type: "post", data: { usuario: UsuarioActual, __RequestVerificationToken: token } });
                swal.close();
                if (anulado) {
                    UsuarioActual = null;
                    swal.fire("Éxito", "Registro Eliminado correctamente", "success");
                    $("#TablaUsuarios").dxDataGrid("instance").refresh();
                }
                else {
                    await swal.fire("Atención", "No se pudo eliminar el usuario", "warning");
                }
            }
            else {
                UsuarioActual = null;
            }

        }

    } catch (e) {
        selectedRegistro = null;
        Swal.fire('Error', 'Ha ocurrido un error en el servidor', 'error');
    }
}