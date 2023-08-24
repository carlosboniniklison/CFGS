function mostrar () {
    let Nombre=document.getElementById("fname").value;
    let Edad=document.getElementById("lname").value;
    if (Edad<18) {
        let mensaje="Eres muy joven para esto";
    } else {
        let mensaje=Nombre+ " tiene "+Edad+" años."
    }
    alert(mensaje);
    }