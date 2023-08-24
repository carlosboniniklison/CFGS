@echo off
REM apagamos el echo para que los mensajes
REM sean más claros en la consola
REM recomendaciones:
REM 1.- usar rutas absolutas (comienzan en C:\)
REM 2.- no usar caracteres especiales
REM 3.- quitar el echo para no agobiar
REM 4.- usar pause para que se puedan ver los resultado

echo esto es un programa ejemplo pero que no hace nada
pause

REM limpiamos ahora la consola
cls
REM E: me "pasa" a estar parado en la unidad E:


REM una forma limpia y ordenada de finalizar
REM el lote de procesos (batch)
echo El proceso ha finalizado.
pause
REM se vuelve a restrablecer la forma normal
REM del echo
@echo on
exit
