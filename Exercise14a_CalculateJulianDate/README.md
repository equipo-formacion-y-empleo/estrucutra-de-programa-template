# Ejercicio 14a: Calcular Fecha Juliana

## Descripción
Implementa una función que calcule la fecha juliana a partir de una fecha gregoriana (día, mes, año).

## Instrucciones
1. Implementa la función `CalculateJulianDate` que convierta una fecha gregoriana al número de días julianos.
2. La función debe retornar el número de días transcurridos desde el 1 de enero del año 4713 a.C.
3. Usa los algoritmos estándar para conversión de fechas julianas.

## Función a Implementar
- **`CalculateJulianDate(day, month, year)`**: Retorna el día juliano correspondiente

## Argumentos de Línea de Comandos
- **Posición 0**: Día (por defecto: 1)
- **Posición 1**: Mes (por defecto: 1)
- **Posición 2**: Año (por defecto: 2000)

## Ejemplo de Ejecución

```powershell
dotnet run 1 1 2000
```
**Salida esperada:**
```
Fecha gregoriana: 1/1/2000
Fecha juliana: 2451545
```