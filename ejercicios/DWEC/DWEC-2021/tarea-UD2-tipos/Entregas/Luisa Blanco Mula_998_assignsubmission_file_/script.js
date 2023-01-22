const btnAdd = document.getElementById("add");
const spanAdd = document.getElementById("spanAdd");
const cont = document.getElementById("container");

//Elementos que referencian a cada uno de los input a nivel de clase, para cambiar su css (debería usar querySelector All y recorrer con foreach)
let n1El = document.querySelector(".n1"); 
let n2El = document.querySelector(".n2"); 
let n3El = document.querySelector(".n3"); 
function addError(){
  n1El.classList.add("error");   
  n2El.classList.add("error");   
  n3El.classList.add("error");   
}
function removeError(){
  n1El.classList.remove("error");   
  n2El.classList.remove("error");   
  n3El.classList.remove("error"); 
}
  function validar(){
    //Una vez que se pulsa el botón es el momento idóneo para comprobar si se han rellenado los campos 
    let n1 = parseInt(document.getElementById("n1").value);
    let n2 = parseInt(document.getElementById("n2").value);
    let n3 = parseInt(document.getElementById("n3").value);

    //Comprobar si los campos tienen o no un formato correcto  
    if (isNaN(n1) || isNaN(n2) || isNaN(n3)) {
      addError(); 
      alert("No tienen formatos correctos");
    }else {
      removeError(); 
      //El número 3 tiene que tener 20 como valor  
      if (n3 != 20) {
        n3 = 20;
      }

      //Comprobación de tamaños
      if (n1 > n2) {
        if (n1 > n3) {
          spanAdd.innerHTML= n1 + " es el más grande";
        } if (n1 < n3) {
          spanAdd.innerHTML= n3 + " es el más grande";
        }else {
          spanAdd.innerHTML= n3 + " es igual a "+n1;}
      }else if (n1 < n2) {
        if (n2 > n3) {
          spanAdd.innerHTML= n2 + " es el más grande";
        } 
        if (n2 < n3) {
          spanAdd.innerHTML= n3 + " es el más grande";
        } else {
          spanAdd.innerHTML= n3 + " es igual a "+n2;}
      }else{
          spanAdd.innerHTML= n2 + " es igual a "+n1;
      }
    }
  }
