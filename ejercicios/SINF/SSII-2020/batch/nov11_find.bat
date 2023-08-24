REM se ejecuta al inicio de sesion
REM sirve para mostrar los ficheros multimedia

@echo off
C:
cd \
dir *.mp4 *.avi /s >C:\CarlosBoni\Sistemas\listados\multimedia.txt

REM buscaremos solo las líneas que contienen nombres de directorios de ese fichero.
FIND "/" < C:\CarlosBoni\Sistemas\listados\multimedia.txt >C:\CarlosBoni\Sistemas\listados\soloficherosmultimedia.txt

type C:\CarlosBoni\Sistemas\listados\soloficherosmultimedia.txt

pause

exit




