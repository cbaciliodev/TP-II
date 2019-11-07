$(document).ready(function () {
    mostarFormularioRegistroUsuario();
});

function mostarFormularioRegistroUsuario() {

    var dataHtml = `<div class="form-group">
                         <form method="post">
                             <div asp-validation-summary="ModelOnly" class="text-danger"></div>
                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <!-- DNI - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="identificacion" class="control-label">Documento:</label>
                                           <input type="text" class="form-control" placeholder="DNI" id="identificacion"/>
                                            <input type="text" value="" hidden />
                                            <span class="text-danger"></span>
                                        </div>
                                        <!-- DNI - Fin -->

                                        <!-- Nombre - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">               
                                           <label for="nombre" class="control-label">Nombre:</label>
                                           <input type="text" class="form-control" placeholder="Nombre de usuario" id="nombre" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--- Nombre - Fin -->
                                    </div>
                                    
                                    <div class="row col-xs-12 col-md-12 col-lg-12">

                                        <!-- Apellido Paterno - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="apaterno" class="control-label">Apellido Paterno:</label>
                                           <input type="text" class="form-control" placeholder="Apellido Paterno" id="apaterno"/>
                                            <input type="text" value="" hidden />
                                            <span class="text-danger"></span>
                                        </div>
                                        <!-- Apellido Paterno - Fin -->

                                        <!-- Apellido Materno - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">               
                                           <label for="amaterno" class="control-label">Apellido Materno:</label>
                                           <input type="text" class="form-control" placeholder="Apellido Materno" id="amaterno" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!-- Apellido Paterno - Fin -->
                                    </div>

                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <!--Fecha de Nacimiento - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="nacimiento" class="control-label">Fecha de Nacimiento:</label>
                                           <input type="date" class="form-control pull-right" id="nacimiento" onchange="javascript: calcularEdad();"/>                                           
                                            <span class="text-danger" id="resultado"></span>
                                        </div>
                                       <!--Fecha de Nacimiento - Fin -->

                                        <!--Contraseña - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">               
                                           <label for="password" class="control-label">Contraseña:</label>
                                           <input type="password" class="form-control" placeholder="Contraseña" id="password" value=""/>                                            
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Contraseña - Fin -->
                                    </div>

                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <!--Sexo - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="sexo" class="control-label">Sexo:</label>
                                           <select id="sexo" class="form-control">
                                                <option value="" selected>Seleccione...</option>
                                                <option value="Masculino">Masculino</option>
                                                <option value="Femenino">Femenino</option>
                                            </select>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Sexo - Fin -->   
                                        <!--Categoria - Inicio -->
                                        <div class="form-group  col-xs-6 col-md-6 col-lg-6">
                                            <label for="categoria" class="control-label">Categoria:</label>
                                           <select id="categoria" class="form-control">
                                                <option value="" selected>Seleccione...</option>
                                                <option value="Masculino">Masculino</option>
                                                <option value="Femenino">Femenino</option>
                                            </select>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Sexo - Fin -->     

                                    </div>

                                    <div class="row col-xs-12 col-md-12 col-lg-12">                                       
                                        <!--Foto - Inicio -->
                                        <div class="form-group  col-xs-12 col-md-12 col-lg-12">               
                                           <label for="imagen" class="control-label">Imagen:</label>
                                           <input type="file" class="form-control" placeholder="Imagen" id="imagen" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Foto - Fin -->
                                    </div>

                                    <div class="row col-xs-12 col-md-12 col-lg-12">                                       
                                        <!--Foto - Inicio -->
                                        <div class="form-group  col-xs-12 col-md-12 col-lg-12">               
                                           <label for="academia" class="control-label">Nombre de Academia:</label>
                                           <input type="text" class="form-control" placeholder="Nombre de Academia" id="academia" value=""/>
                                            <span class="text-danger"></span>
                                        </div>
                                        <!--Foto - Fin -->
                                    </div>

                                    <div class="row col-xs-12 col-md-12 col-lg-12">
                                        <div class="form-group  col-xs-4 col-md-4 col-lg-4">
                                            <button type="button" value="Create" class="btn btn-primary form-control" 
                                                     onclick="javascript:guardarRegistroUsuario();">Registrar</button>
                                        </div>
                                    </div>
                                </form>
                            </div>`;

    $("#RegistroUsuario").html(dataHtml);


    
}

function validate_fecha(fecha) {

    var patron = new RegExp("^([0-9]{1,2})([-])([0-9]{1,2})([-])(19|20)+([0-9]{2})$");

    if (fecha.search(patron) == 0) {
        var values = fecha.split("-");
        if (isValidDate(values[0], values[1], values[2])) {
            return true;
        }
    }
    return false;
}


/*function calcularEdad(fecha) {
    var hoy = new Date();
    var cumpleanos = new Date(fecha);
    var edad = hoy.getFullYear() - cumpleanos.getFullYear();
    var m = hoy.getMonth() - cumpleanos.getMonth();

    if (m < 0 || (m === 0 && hoy.getDate() < cumpleanos.getDate())) {
        edad--;
    }

    return edad;
}*/



function calcularEdad() {
    
    var fecha = document.getElementById("nacimiento").value;

    console.log(fecha);

    var valorfecha = fecha.split('-');

    var dia = valorfecha[2];
    var mes = valorfecha[1];
    var anio = valorfecha[0];

    console.log(dia, ' dia');
    console.log(mes, ' mes');
    console.log(anio , ' anio');

    var fechaActual = new Date();

    console.log(fechaActual, ' fechaActual')

    console.log(fechaActual.getDate(), ' Dia')
    console.log(fechaActual.getMonth() + 1, ' Mes')
    console.log(fechaActual.getFullYear(), ' Anio')

    var edad = fechaActual.getFullYear() - anio;

    if (fechaActual.getMonth() + 1 < mes) {
        edad--;
    }
    if (fechaActual.getMonth() + 1 == mes && fechaActual.getDate() < dia) {
        edad--;
    }

    var meses = 0;

    if (fechaActual.getMonth() + 1 > mes) {
        meses = (fechaActual.getMonth() + 1) - mes;
    }
    if (fechaActual.getMonth() + 1 < mes) {
        meses = 12 - (mes - (fechaActual.getMonth() + 1));
    }


    console.log(edad, ' edad');


       if (validate_fecha(fecha) == true) {
           

           

           


            if (ahora_mes < mes)
                meses = 12 - (mes - ahora_mes);
            if (ahora_mes == mes && dia > ahora_dia)
                meses = 11;

            // calculamos los dias
            var dias = 0;
            if (ahora_dia > dia)
                dias = ahora_dia - dia;
            if (ahora_dia < dia) {
                ultimoDiaMes = new Date(ahora_ano, ahora_mes, 0);
                dias = ultimoDiaMes.getDate() - (dia - ahora_dia);
            }

           document.getElementById("resultado").innerHTML = "Tienes " + edad + " años, " + meses + " meses y " + dias + " días";

            var categoria = document.getElementById("categoria");

            if (4 <= edad && edad <= 6) {
                categoria.selectedIndex = 3;
            }
            else if (7 <= edad && edad <= 9) {
                categoria.selectedIndex = 2;
            }
            else if (10 <= edad && edad <= 13) {
                categoria.selectedIndex = 4;
            }
            else if (14 <= edad && edad <= 17) {
                categoria.selectedIndex = 5;
            }
            else if (18 <= edad && edad <= 21) {
                çategoria.selectedIndex = 6;
            }
            else if (22 <= edad && edad <= 34) {
                categoria.selectedIndex = 7;
            }
            else if (35 <= edad && edad <= 49) {
                categoria.selectedIndex = 8;
            }
            else if (50 <= edad && edad <= 62) {
                categoria.selectedIndex = 1;
            }
            else {
                categoria.selectedIndex = 0;
            }


        } else {
           document.getElementById("resultado").innerHTML = "La fecha " + fecha + " es incorrecta";
        }
        
}

function guardarRegistroUsuario() {

    var identificacion = document.getElementById('identificacion').value;
    var nombre = document.getElementById('nombre').value;
    var apaterno = document.getElementById('apaterno').value;
    var amaterno = document.getElementById('amaterno').value;

    if (identificacion == '') {
        $('#identificacion').focus();
        console.log(identificacion);
    }
    else if (nombre == '') {
        $('#nombre').focus();
        console.log(nombre);
    }
    else if (apaterno == '') {
        $('#apaterno').focus();
        console.log(apaterno);
    }
    else if (amaterno == '') {
        $('#amaterno').focus();
        console.log(amaterno);
    } else {
        console.log(identificacion);
        console.log(nombre);
        console.log(apaterno);
        console.log(amaterno);
    }                                                                 
}