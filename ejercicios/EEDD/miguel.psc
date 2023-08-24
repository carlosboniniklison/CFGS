Proceso CalculadoraDeMiguel
	// calculadora de Miguel
	Escribir 'Ingrese un número'
	Leer nro1
	// Aquí hay que permitir numeros reales
	Escribir 'Ingrese otro número'
	Leer nro2
	// la misma validacion que recién
	Escribir 'Ingrese la operación'
	Leer oper
	// permitir una cadena +,-,*,/, MOD 
	Segun oper  Hacer
		'suma':
			Escribir Nro1," + ",Nro2," = ",Nro1+Nro2
		'resta':
		'division':
		'multiplicacion':
		'modulo':
	FinSegun
FinProceso
