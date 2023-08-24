REM usaremos un parámetro
REM cada vez añadimos el resultado de la busqueda que nos han pedido al mismo fichero

dir c:\CarlosBoni\%1 /s >>C:\CarlosBoni\Sistemas\listados\busquedas.txt
echo ficheros %1 procesados




