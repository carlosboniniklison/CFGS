Proceso SeleccionMultiple
	// Programa de practica
	Repetir
		Escribir "Ingrese Dia de la semana (0 para terminar)"
		Leer Ndia
		Segun Ndia Hacer
			1:
				Escribir 'Lunes '
			2:
				Escribir "Martes"
			3:
				Escribir "Miercoles"
			4:
				Escribir "Jueves"
			5:
				Escribir "Viernes"
			6:
				Escribir "Sabado"
			7:
				Escribir "Domingo"
			De Otro Modo:
				Escribir "(valores validos: 0 a 7)"
		FinSegun
	Mientras Que Ndia!=0
FinProceso
