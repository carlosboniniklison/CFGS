document.addEventListener('DOMContentLoaded', function(){


    validar();
});


function validar(){
    let boton = document.getElementById('#boton'); 
    boton.addEventListener('click', function(){
        numeroMayor();
    });
}

function numeroMayor(){
    
    let num1 = document.querySelector('#primernumero');
    let num2 = document.querySelector('#segundonumero');
    let num3 = document.querySelector('#tercernumero');
    
    if(num1.value > num2.value && num1.value > num3.value ){
        alert("El numero uno es el mayor");
    }else if(num2.value > num1.value && num2.value > num3.value){
        alert("El dos es el mayor");
    }else{
        alert("El numero tres es el mayor");
    }
}
 