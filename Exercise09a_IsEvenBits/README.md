# Ejercicio 9a: Verificar Paridad con Bits

## Descripción
Implementa una función que determine si un número es par usando operaciones de bits en lugar de operadores aritméticos.

## Instrucciones
1. Implementa la función `IsEvenBits` que use operaciones de bits para determinar si un número es par.
2. La función debe retornar `true` si el número es par, `false` si es impar.

## Función a Implementar
- **`IsEvenBits(number)`**: Retorna `true` si el número es par usando operaciones de bits

## Argumentos de Línea de Comandos
- **Posición 0**: Número a verificar (por defecto: 8)

## Ejemplo de Ejecución

```powershell
dotnet run 8
```
**Salida esperada:**
```
¿Es 8 par usando bits? True
```

```powershell
dotnet run 7
```
**Salida esperada:**
```
¿Es 7 par usando bits? False
```