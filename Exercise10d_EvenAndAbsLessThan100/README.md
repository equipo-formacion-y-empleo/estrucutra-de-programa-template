# Ejercicio 10d: Par y Valor Absoluto Menor que 100

## Descripción
Implementa una función que verifique si un número es par y su valor absoluto es menor que 100, usando expresiones complejas con la mínima cantidad de paréntesis.

## Instrucciones
1. Implementa la función `EvenAndAbsLessThan100` que evalúe condiciones de paridad y rango.
2. La función debe retornar `true` si el número es par Y su valor absoluto es menor que 100.
3. Usa la mínima cantidad de paréntesis posible.

## Función a Implementar
- **`EvenAndAbsLessThan100(number)`**: Retorna `true` si el número cumple las condiciones

## Argumentos de Línea de Comandos
- **Posición 0**: Número a verificar (por defecto: 50,0)

## Ejemplo de Ejecución

```powershell
dotnet run 50,0
```
**Salida esperada:**
```
¿50 es par y |valor| < 100? True
```

```powershell
dotnet run -120,5
```
**Salida esperada:**
```
¿-120,5 es par y |valor| < 100? False
```