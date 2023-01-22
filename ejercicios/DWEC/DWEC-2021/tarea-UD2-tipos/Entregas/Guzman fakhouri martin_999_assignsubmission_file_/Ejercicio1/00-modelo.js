function verNumeroMayor() {
    
        let input1 = document.getElementById('numero1');
        let input2 = document.getElementById('numero2');

        var numero = parseInt( input1.value ); 
        var numero2 = parseInt( input2.value );      

        var p = document.getElementById('mensaje');

       


        var noEsNumero = isNaN(numero); // 10//False    
        var noEsNumero2 = isNaN(numero2); // pepe//True

      
      if (noEsNumero == false && noEsNumero2 == false) {
         

        switch(numero > numero2) {
            case true:
                if (numero > 20){
                    console.log("hola!");
                    p.innerHTML = "<br>El numero " + numero +" es mayor que 20 y mayor que el numero " + numero2;
                }else if (numero < 20) {
                    p.innerHTML = "<br>El numero " + numero +" no es mayor que 20 pero es mayor que " +numero2;
                }else if(numero == 20) {
                    p.innerHTML = "<br>El numero " + numero +" es igual a 20";
                }
            break;
            case false:
                if (numero2 > 20){
                    p.innerHTML = "<br>El numero2 " + numero2 +" es mayor que 20 y mayor que el numero " + numero;
                }else if(numero2 < 20) {
                    p.innerHTML = "<br>El numero2 " + numero2 +" no es mayor que 20 pero es mayor que " +numero;
                }else if(numero2 == 20) {
                    p.innerHTML = "<br>El numero " + numero2 +" es igual a 20";
                }
        
            break;

            case FIN:
            document.write("<br>Se acabo el programa");
            default:
        
            
        }

    }else {
        p.innerHTML = "<br>No has puesto un numero . Vuelve a escribirlo y que esta vez si sea un numero";
    }

    /*
    En este trozo comentado del codigo podemos acceder al tipo de variable que es numero y numero2 usando el typeod

    document.write('<br>La variable numero es de tipo: ' + typeof numero);
    document.write('<br>La variable numero2 es de tipo: ' + typeof numero2);

    */

        //EL SIGUIENTE CODIGO ES LA MANERA DE HACER SIN LOS INPUTS PARA QUE EL PROGRAMA ACABE CON LA PALABRA (FIN)
        //PERO SIN LAS MEJORAS DE LOS ERRORES CUANDO NO INTRODUCES UN NUMERO

        //var finaliza = prompt('Escribe la palabra FIN para terminar el programa sino puls auna tecla cualquier y dale a Enter ');
        //var numero = parseInt(prompt('Ingrese un numero: ')); // 
        //var numero2 = parseInt(prompt('Ingrese un numero: ')); // 

    /*
    switch(numero > numero2) {
        case true:
            if (numero > 20){
                document.write ("<br>El numero " + numero +" es mayor que 20 y mayor que el numero " + numero2);
            }else if (numero < 20) {
                document.write ("<br>El numero " + numero +" no es mayor que 20 pero es mayor que " +numero2);
            }
        break;
        case false:
            if (numero2 > 20){
                document.write ("<br>El numero2 " + numero2 +" es mayor que 20 y mayor que el numero " + numero);
            }else if(numero2 < 20) {
                document.write ("<br>El numero2 " + numero2 +" no es mayor que 20 pero es mayor que " +numero);
            }

        break;

        case FIN:
            document.write("<br>Se acabo el programa");
        default:
        
    }
    
    */

   

    
 
}