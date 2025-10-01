# Ejercicio 10b: Tercer Bit Activo y Positivo

## Descripción
Implementa una función que verifique si el tercer bit (posición 2) está activo y el número es positivo, usando expresiones complejas con la mínima cantidad de paréntesis.

## Instrucciones
1. Implementa la función `ThirdBitActiveAndPositive` que evalúe condiciones de bits y signo.
2. La función debe retornar `true` si el tercer bit está activo Y el número es positivo.
3. Usa la mínima cantidad de paréntesis posible.

## Función a Implementar
- **`ThirdBitActiveAndPositive(number)`**: Retorna `true` si el número cumple las condiciones

## Argumentos de Línea de Comandos
- **Posición 0**: Número a verificar (por defecto: 5)

## Ejemplo de Ejecución

```powershell
dotnet run 5
```
**Salida esperada:**
```
¿5 tiene el tercer bit activo y es positivo? True
```

```powershell
dotnet run 3
```
**Salida esperada:**
```
¿3 tiene el tercer bit activo y es positivo? False
```