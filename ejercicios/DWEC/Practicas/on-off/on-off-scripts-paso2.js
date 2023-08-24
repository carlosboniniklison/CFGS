// paso 1: añado indicadores de on-off en cada método
// paso 2: añado activación del botón

var activo = false;
var elemento = document.getElementById("boton");

function comenzar() {
    console.log("página cargada (comienzo del test)");
}

function conJs() {
    if (activo) {
        console.log("Desactivo con JavaScript");
        elemento.removeEventListener("click", actividad);
        elemento.innerHTML = "BOTON INACTIVO";
        activo = false;
    } else {
        console.log("Activo con JavaScript");
        elemento.addEventListener("click", actividad);
        elemento.innerHTML = "BOTON ACTIVO";
        activo = true;
    }
}

function conJq() {
    if (activo) {
        console.log("Desactivo con jQuery");
        $("#boton").off("click", actividad);
        $("#boton").text("BOTÓN INACTIVO");
        $("#boton").toggleClass("btnOn", false);
        activo = false;
    } else {
        console.log("Activo con jQuery");
        $("#boton").on("click", actividad);
        $("#boton").text("BOTÓN ACTIVO");
        $("#boton").toggleClass("btnOn", true);
        activo = true;
    }

}

function actividad() {
    console.log("Muestro un mensaje porque estoy Activado");
}