# Tp3_UPSO

tp 3 de csharp de la universidad


## TRABAJO PRÁCTICO UNIDAD 3

## Asignatura: Programacion C#/.NET

## Docente/s: Lic. Diaz Marcelo - Sr. Juan Fernando Desages

## Fecha: 03/05/2026- 09/05/2026

## EJERCICIOS

## BIBLIOGRAFÍA

### https://learn.microsoft.com/es-es/dotnet/csharp/

## TRABAJO PRÁCTICO UNIDAD 3

## Asignatura: Programacion C#/.NET

## Ejercicio 1:
Crear una clase Persona con:
 propiedades Nombre y Edad
 constructor que reciba ambos datos
 método Saludar()
Instanciar dos objetos y mostrar sus datos.

## Ejercicio 2:
Crear una clase Producto con:
 Nombre
 Precio
 Stock
Métodos:
 ActualizarStock()
 MostrarProducto()
Validar que el stock no sea negativo.

## Ejercicio 3:
Crear una clase Rectangulo con:
 Base
 Altura
Implementar:
 constructor vacío
 constructor con parámetros
Métodos:
 CalcularArea()
 CalcularPerimetro()

## Ejercicio 4:
Crear una clase CuentaBancaria.
Requisitos:
 atributo privado saldo
 propiedad pública de solo lectura para consultar saldo
Métodos:
 Depositar()
 Extraer()
Validar que no se pueda extraer más dinero del disponible.

## Ejercicio 5:
Crear una clase base Vehiculo.
Derivar:
 Auto
 Moto
Agregar método:
 MostrarInformacion()
Crear una interfaz IDibujable con método Dibujar(). Implementar en las clases Circulo,
Rectangulo y Triangulo.

## Ejercicio 6:
Crear una clase base Empleado.
Derivar:
 EmpleadoTiempoCompleto
 EmpleadoPorHora
Método:
 CalcularSueldo()
Mostrar el cálculo usando polimorsmo.

## Ejercicio 7:
Crear una clase abstracta Figura.
Método abstracto:
 CalcularArea()
Implementar:
 Circulo
 Cuadrado
 Triangulo

## Ejercicio 8:
Crear una interfaz IImprimible.
Método:
 Imprimir()
Implementarla en:
 Factura
 Ticket
 Contrato
## Ejercicio 9:
Crear una clase estática Conversor.
Métodos:
 CelsiusAFahrenheit()
 FahrenheitACelsius()
Agregar:
 KilometrosAMillas()
 MillasAKilometros()

## Ejercicio 10:
Crear una clase base Animal.
Derivar:
 Perro
 Gato
 Pajaro
Crear interfaz:
 IVolador
Implementarla únicamente en Pajaro.
Ejercicio 11:
Crear una clase abstracta Estudiante.
Propiedades:
 Nombre
 DNI
Método abstracto:
 CalcularNotaFinal()
Derivar:
 EstudiantePresencial
 EstudianteVirtual
Aplicar polimorsmo.

## Ejercicio 12:
Crear una clase abstracta Habitacion.
Propiedades:
 Numero
 PrecioBase
Método abstracto:
 CalcularCosto(int dias)
Subclases:
 HabitacionSimple
 HabitacionDoble
 HabitacionSuite

## BONUS TRACK

## Ejercicio BT1:
Crear una clase Jugador.
Propiedades:
 Nombre, Edad, Posicion
Constructor con parámetros.
Método:
 MostrarFicha()

## Ejercicio BT2:
Crear una clase Equipo.
Propiedades:
 Nombre, Categoria
Método:
 MostrarEquipo()
Ejercicio BT3:
Clase base:
 PersonaDeportiva
Subclases:
 Jugador, Entrenador, Arbitro

## Ejercicio BT3:
Crear interfaz:
 IEstadistica
Implementarla en: Jugador, Equipo
