var activo = false;

function comenzar() {
    console.log("página cargada. Puede comenzar el test...");
}

function conJs() {
    if (activo) {
        console.log("Activo con JavaScript");
        activo = false;
    } else {
        console.log("Desactivo con JavaScript");
        activo = true;
    }
}

function conJq() {
    if (activo) {
        console.log("Activo con jQuery");
        activo = false;
    } else {
        console.log("Desactivo con jQuery");
        activo = true;
    }
}
