Proceso boton-clic
	// cuenta solo sirve para estadistica diaria
	cuenta = 0;
	cola = 0;
	libre = true;
	Repetir
		Escribir clic;
		cuenta +=1;
		Si libre=true Entonces
			libre = false;
		SiNo
			cola+=1;
			Si cola=4 Entonces
				Escribir mensaje 4 en cola;
			FinSi
		FinSi
	Hasta Que condicion
FinProceso
