Proceso sin_titulo
	Leer sessionStorage.hayusuario;
	Si sessionStorage.hayusuario=true Entonces
		// Estado 3
		Escribir nombreusuario;
		Escribir botón desconectar;
	SiNo
		Escribir sessionStorage.usuarioIntentando;
		Si sessionStorage.usuarioIntentando!="" Entonces
			// Estado 2
			hayusuario = comprobar _si _está_registrado();
			Si hayusuario=true Entonces
				Escribir nombreusuario;
				Escribir botón desconectar;
			SiNo
				Escribir formulario de login;
			FinSi
		SiNo
			// Estado 1
			Escribir formulario de login;
		FinSi
	FinSi
FinProceso
