 Simulador de Café — Patrón Decorador + Adaptador
Descripción

Este proyecto es un simulador de cafetería en C# donde el usuario inicia con un café simple y puede agregar ingredientes opcionales como leche, azúcar, canela y caramelo.
Cada ingrediente incrementa el costo y modifica la descripción del café.

¿Qué patrones usé y para qué?
Este proyecto combina dos patrones de diseño:

🔸 Patrón Decorador → Me permite agregar ingredientes al café sin cambiar la estructura original.
En lugar de editar la clase del café, voy "envolviendo" el objeto con nuevos ingredientes.

🔸 Patrón Adaptador → Convierte el precio final de pesos a dólares usando un sistema externo.
Así, no tengo que modificar la lógica del café para mostrar precios en otra moneda.

Al finalizar el pedido, el sistema genera un ticket con la descripción y el total en pesos y dólares.

¿Cómo funciona?
*El sistema muestra un café simple con su precio.
*Me pregunta si deseo agregar ingredientes.
*Puedo elegir los extras que quiera, uno por uno.
*Cuando termino, genero mi ticket final, que incluye:

Mi café con todos los ingredientes
Total en pesos
Total en dólares (gracias al Adaptador)

CONCLUSION 
Durante el desarrollo de este simulador entendí que no siempre la solución es modificar una clase cada vez que necesitamos algo nuevo. Con el patrón Decorador pude añadir ingredientes al café de forma dinámica sin arruinar la estructura principal, y con el patrón Adaptador integré la conversión de moneda sin cambiar la lógica del sistema.
Gracias a esto comprobé que los patrones hacen el código más profesional: evitan duplicar código, facilitan el mantenimiento y permiten seguir creciendo sin empezar desde cero. El resultado fue un sistema claro, flexible y totalmente ampliable.

Nombre : LICZI CITLALI FLORES RAMIREZ -21210537
