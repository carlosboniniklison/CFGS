Algoritmo cargar_pagina
	// Leemos de sessionStorage
	Leer logueado, usr, pwd
	Si logueado = true Entonces
		// Estado 3
		ocultar elemento ingresar
		mostrar elemento desconectar
	SiNo
		// Se carga a página y debemos determinar por qué
		Si usr != vacio Entonces
			// Estado 2
			// Validar usuario
			buscar usr y pwd en XML
			Si concuerda Entonces
				logueado = true
				ocultar elemento ingresar
				mostrar elemento desconectar
			SiNo
				mostrar error de datos
				ocultar elemento desconectar
				mostrar elemento ingresar
			FinSi
		SiNo
			// Estado 1
			ocultar elemento desconectar
			mostrar elemento ingresar
		FinSi
	FinSi
FinAlgoritmo
