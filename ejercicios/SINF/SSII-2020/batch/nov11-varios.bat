REM apagamos el echo para que los mensajes
REM sean más claros en la consola
@echo off
echo buenos días
echo probaremos de limpiar la consola
echo usando el comando cls

REM ahora se pide una tecla para continuar
pause

REM limpiamos ahora la consola
cls

REM mostramos los programas .bat
dir C:\*.bat /s
REM si la ejecucion está tardando mucho
REM y queremos interrumpirla, presionar
REM las teclas CTRL+C a la vez



REM una forma limpia y ordenada de finalizar
REM el lote de procesos (batch)
echo El proceso ha finalizado.
pause
REM se vuelve a restrablecer la forma normal
REM del echo
@echo on
exit


