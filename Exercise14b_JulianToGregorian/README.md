# Ejercicio 14b: Convertir Fecha Juliana a Gregoriana

## Descripción
Implementa una función que convierta un día juliano a una fecha gregoriana (día, mes, año).

## Instrucciones
1. Implementa la función `JulianToGregorian` que convierta un número de día juliano a fecha gregoriana.
2. La función debe retornar una tupla con día, mes y año.
3. Usa los algoritmos estándar para conversión desde fechas julianas.

## Función a Implementar
- **`JulianToGregorian(julianDay)`**: Retorna una tupla (día, mes, año) de la fecha gregoriana

## Argumentos de Línea de Comandos
- **Posición 0**: Día juliano (por defecto: 2451545)

## Ejemplo de Ejecución

```powershell
dotnet run 2451545
```
**Salida esperada:**
```
Fecha juliana: 2451545
Fecha gregoriana: 1/1/2000
```