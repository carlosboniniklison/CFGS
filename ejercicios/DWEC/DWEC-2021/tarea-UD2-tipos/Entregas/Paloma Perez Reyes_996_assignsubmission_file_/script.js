const btnAdd = document.getElementById("add");
const spanAdd = document.getElementById("spanAdd");
const cont = document.getElementById("container");

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
btnAdd.addEventListener("click", () => {
  let n1 = parseInt(document.getElementById("n1").value);
  let n2 = parseInt(document.getElementById("n2").value);
  let n3 = parseInt(document.getElementById("n3").value);

 
  if (isNaN(n1) || isNaN(n2) || isNaN(n3)) {
    addError(); 
    alert("No tienen formatos correctos");
  } 
  
  if(n1%3!=0||n2%3!=0||n3%3!=0){
      alert("Los números no son múltiplos de 3"); 
      addError();
  } else {
    removeError(); 
      
    if (n3 != 20) {
      n3 = 20;
    }

   
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
});
