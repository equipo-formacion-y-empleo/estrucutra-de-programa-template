# Ejercicio 10c: Múltiplo de 3 o (5 y mayor que 50)

## Descripción
Implementa una función que verifique si un número es múltiplo de 3 o es múltiplo de 5 y mayor que 50, usando expresiones complejas con la mínima cantidad de paréntesis.

## Instrucciones
1. Implementa la función `MultipleOf3Or5AndGreaterThan50` que evalúe múltiples condiciones con precedencia correcta.
2. La función debe retornar `true` si el número es múltiplo de 3 O (múltiplo de 5 Y mayor que 50).
3. Usa la mínima cantidad de paréntesis posible.

## Función a Implementar
- **`MultipleOf3Or5AndGreaterThan50(number)`**: Retorna `true` si el número cumple las condiciones

## Argumentos de Línea de Comandos
- **Posición 0**: Número a verificar (por defecto: 55)

## Ejemplo de Ejecución

```powershell
dotnet run 55
```
**Salida esperada:**
```
¿55 es múltiplo de 3 o (5 y >50)? True
```

```powershell
dotnet run 9
```
**Salida esperada:**
```
¿9 es múltiplo de 3 o (5 y >50)? True
```