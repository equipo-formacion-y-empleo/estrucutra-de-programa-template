# Ejercicio 8: Simulador de Cuenta Bancaria

## Descripción
Implementa funciones que modifiquen una variable global `balance` usando operadores de asignación para simular transacciones bancarias.

## Instrucciones
1. Implementa las funciones `Deposit`, `Withdraw`, `ApplyInterest` y `ApplyCommission`.
2. Cada función debe modificar la variable global `balance` usando operadores de asignación (+=, -=, *=, /=).
3. Las funciones no devuelven valores, solo modifican el estado global.

## Funciones a Implementar
- **`Deposit(amount)`**: Añade el monto al saldo
- **`Withdraw(amount)`**: Resta el monto del saldo
- **`ApplyInterest(interestRate)`**: Aplica interés al saldo
- **`ApplyCommission(commissionRate)`**: Aplica comisión al saldo

## Argumentos de Línea de Comandos
- **Posición 0**: Saldo inicial (por defecto: 1000,0)
- **Posición 1**: Depósito 1 (por defecto: 250,50)
- **Posición 2**: Depósito 2 (por defecto: 100,0)
- **Posición 3**: Retiro 1 (por defecto: 75,25)
- **Posición 4**: Retiro 2 (por defecto: 50,0)
- **Posición 5**: Factor de interés (por defecto: 1,02)
- **Posición 6**: Factor de comisión (por defecto: 1,01)

## Ejemplo de Ejecución

```powershell
dotnet run
```
**Salida esperada:**
```
Saldo inicial: 1000,00
Después del depósito 1: 1250,50
Después del depósito 2: 1350,50
Después del retiro 1: 1275,25
Después del retiro 2: 1225,25
Después de intereses: 1249,76
Saldo tras comisiones: 1237,38
```