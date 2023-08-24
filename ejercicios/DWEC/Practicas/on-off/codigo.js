// inicializamos variables necesarias
var agregadoJS = false;
var agregadoJQ = false;
var textoJS = "JS.- Architecto minus a assumenda necessitatibus fuga, mollitia reprehenderit laudantium distinctio. Magni, quos. Doloribus perspiciatis odit maxime soluta totam ipsa ad cum eum.";
var textoJQ = "JQ.- Nihil quam nemo maiores. Magnam sequi laboriosam aliquid suscipit. Corporis, in porro. Saepe accusamus iste dolores voluptatum delectus eum maiores architecto sequi.";

// nos aseguramos de que los códigos se ejecuten al terminar la carga del DOM
document.onload=agregaBotones();

// añadimos funcionalidad a los botones
function agregaBotones() {
    document.getElementById("conjs").addEventListener("click", agregaParrafo);
    document.getElementById("conJQ").addEventListener("click", agregaParrafojQ);
}

// definimos la función que añade un párrafo usando JavaScript
function agregaParrafo() {
    if (agregadoJS) {
        // evita que se ejecute más de una vez
        return (0);
    }
    // fabrico el nuevo parrafo
    var nuevoContenido = document.createTextNode(textoJS);
    var nuevoParrafo = document.createElement("p");
    nuevoParrafo.appendChild(nuevoContenido);
    // una vez creado el elemento del DOM lo debo añadir como hermano menor
    // del párrafo que ya existe, o sea como último hijo de su padre
    document.getElementsByTagName("p").item(0).parentNode.appendChild(nuevoParrafo);
    agregadoJS = true;
    return (1);
}

// la misma función pero usando jQuery
function agregaParrafojQ() {
    if (agregadoJQ) {
        // evita que se ejecute más de una vez
        return (1);
    }

}

