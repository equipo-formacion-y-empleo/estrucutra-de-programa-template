# Ejercicio 10a: Entre 10 y 20 o Par

## Descripción
Implementa una función que verifique si un número está entre 10 y 20 (exclusivo) o si es par, usando expresiones complejas con la mínima cantidad de paréntesis.

## Instrucciones
1. Implementa la función `Between10And20OrEven` que evalúe múltiples condiciones usando precedencia de operadores.
2. La función debe retornar `true` si el número está entre 10 y 20 (exclusivo) O si es par.
3. Usa la mínima cantidad de paréntesis posible.

## Función a Implementar
- **`Between10And20OrEven(number)`**: Retorna `true` si el número cumple las condiciones

## Argumentos de Línea de Comandos
- **Posición 0**: Número a verificar (por defecto: 15,0)

## Ejemplo de Ejecución

```powershell
dotnet run 15,5
```
**Salida esperada:**
```
¿15,5 está entre 10-20 o es par? True
```

```powershell
dotnet run 8,0
```
**Salida esperada:**
```
¿8 está entre 10-20 o es par? True
```