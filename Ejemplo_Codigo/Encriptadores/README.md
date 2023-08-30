# Encriptadores
-> El ejercicio plantea que haya varios algoritmos de encriptacion y se puedan incluir nuevos algoritmos a la aplicacion de forma rapida, siendo cambios minimos en la aplicacion. Entonces el diseñador leyo ese requerimiento y planteo el diagrama que tenemos abajo. Lo primero que hizo fue crear una interfaz IEncriptador, esta interfaz es uno de los puntos mas importantes porque se ocupa del comportamiento primero (como interactua una entidad con el exterior, su firma) y luego del funcionamiento (como hace internamente para resolver el problema), entonces define la firma de los metodos (el comportamiento).   
Luego disenio una clase abstracta Encriptador (Encriptador esta en italica, asi se representa la clase abstracta en UML). La clase abstracta implementa la interfaz para garantizar que cada Encriptador tenga un nombre y el comportamiento que provee la interfaz.   
Luego se crean las clases de cada algoritmo. Estas clases heredan de la clase abstracta herencia e implementan, por consecuencia, el comportamiento de la interfaz.   
Lo importante es ver como se desacopla la implementacion del algoritmo del comportamiento en la interfaz. La logica esta encapsulada en los diferentes metodos.

El diseño de las clases de la aplicacion es el siguiente:  
![](https://res.cloudinary.com/dkjkgri6x/image/upload/v1693439260/encriptadores_zvgdul.png)