function comprobar() {
    let numero = document.getElementById("anio").value;
    let mensaje = document.getElementById("campo").value;
    let resultado = "";
    if (numero == "2022") {
        console.log("Su mensaje es válido y el formulario se enviará");
        console.log(mensaje);
        return true;
    } else {
        console.log("FUERA ROBOT");
        return false;
    };
    
}
