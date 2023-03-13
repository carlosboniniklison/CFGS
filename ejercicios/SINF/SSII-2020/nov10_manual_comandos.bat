REM evita mensajes abundantes por consola
@echo off

REM borra la consola
cls

REM Comandos Windows para un programa por lotes (Batch)
REM
REM Sistemas Informaticos - 1DAW - 2020
REM

REM El siguiente comando muestra directorio actual
CD

REM ahora nos paramos en la raíz de la unidad actual
CD \

REM ahora miramos todos los ficheros .js que están en la carpeta CarlosBoni\*
REM o en sus carpetas descendientes
dir C:\CarlosBoni\*.js /s
pause
exit

REM y si queremos que se guarden en un fichero en lugar de verlo por pantalla:
dir C:\CarlosBoni\*.js /s >C:\CarlosBoni\ficherosjavascript.txt

REM y luego puedo ver el contenido de ese fichero, con windows, o con:
type C:\CarlosBoni\ficherosjavascript.txt

REM pero como ocupa más de una pantalla, le digo que lo muestre de a poco:
type C:\CarlosBoni\ficherosjavascript.txt |more

REM y si queremos añadir todos los ficheros .zip al final de un fichero:
dir C:\*.zip /s /a >>C:\CarlosBoni\ficheroszip.txt
REM ahora tendremos todos los listados hechos, en el mismo fichero de texto.
REM y hemos incluido los ocultos y del sistema, usando /a

REM buscaremos solo las líneas que contienen nombres de directorios de ese fichero.
FIND "<DIR>" < C:\CarlosBoni\ficheroszip.txt >C:\CarlosBoni\directorioszip.txt




