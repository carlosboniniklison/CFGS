/* Este codigo ha sido generado por el modulo psexport 20180802-w32 de PSeInt.
Es posible que el codigo generado no sea completamente correcto. Si encuentra
errores por favor reportelos en el foro (http://pseint.sourceforge.net). */

// En java, el nombre de un archivo fuente debe coincidir con el nombre de la clase que contiene,
// por lo que este archivo deber�a llamarse "CALCULADORADEMIGUEL.java."

import java.io.*;

public class calculadorademiguel {

	public static void main(String args[]) throws IOException {
		BufferedReader bufEntrada = new BufferedReader(new InputStreamReader(System.in));
		String nro1;
		String nro2;
		int oper;
		// calculadora de Miguel
		System.out.println("Ingrese un n�mero");
		nro1 = bufEntrada.readLine();
		// Aqu� hay que permitir numeros reales
		System.out.println("Ingrese otro n�mero");
		nro2 = bufEntrada.readLine();
		// la misma validacion que reci�n
		System.out.println("Ingrese la operaci�n");
		oper = Integer.parseInt(bufEntrada.readLine());
		// permitir una cadena +,-,*,/, MOD 
		switch (oper) {
		case "suma":
			System.out.println(nro1+" + "+nro2+" = "+nro1+nro2);
			break;
		case "resta":
			break;
		case "division":
			break;
		case "multiplicacion":
			break;
		case "modulo":
			break;
		}
	}


}

