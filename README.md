### Tarea Grupal # 3 : TDD Gilded Rose

#### Integrantes del grupo # 3:
- Aguilar Perez Kleber Isaac
- Barja Hoyos Kevin Eduardo
- Cano Encinas Patricia
- Aillon Salinas Raúl Fernando

#### Introducción

Durante la sesión en línea de la semana 2, presentamos el [taller de TDD: Gilded Rose, desde la perspectiva Tester](https://youtu.be/8LSXMItMNtI).

Para la presente tarea grupal, se requiere elaborar los requerimientos y agregarlos al [documento compartido](https://docs.google.com/spreadsheets/d/1lTKd4vPwAnfR_FMv43RK3UBfenFcgP8HWeqHzhGDfuU/edit?usp=sharing).


Además por cada requerimiento agregado se deben agregar los casos de prueba que el grupo considere necesarios.

#### Fecha de presentación 

Jueves 1 de abril 19:00.

#### Intrucciones

1. Cada grupo analiza el [sistema Gilded Rose](gilded-rose.md) (asumiendo que se lo construirá de 0)
2. Cada grupo debe agregar los requerimientos que considere necesarios en el [documento compartido](https://docs.google.com/spreadsheets/d/1lTKd4vPwAnfR_FMv43RK3UBfenFcgP8HWeqHzhGDfuU/edit?usp=sharing) (tab requerimientos)
3. Cada grupo debe adicionar los casos de prueba que considere necesarios para probar el requerimiento agregado (Tab Pruebas)
4. Por cada caso de prueba agregado, el equipo debe aplicar TDD para la implementación en el sistema
5. Cada equipo debe contar con una solución completa que pueda ejecutar todos los casos (no es necesario UI, solo que todos los requerimientos esten respaldados por pruebas)
6. El equipo puede implementar la solución en cualquier stack **(excepto JAVA)**

#### Criterios de aceptación

1. El equipo publicará un enlace de acceso público al repositorio que contiene la solución
2. Cada miembro del equipo debe agregar #equipo + enlace como entrega de la tarea
3. **Durante la siguiente sesión online, de forma aleatoria se evaluará el análisis, implementación y las decisiones tomadas respecto de las pruebas por medio de pruebas Docente -> Grupo**
4. Para la sesión en online el equipo debe contar con al menos un participante que tenga todo el ambiente preparado para demostrar la ejecución de todas las pruebas implementadas.

#### Bitacora del grupo
1.- Elegimos c# porque la mayoría conoce.
2.- Organizamos la solución en dos proyectos GildedRose y UnitTestGildedRose, este último tiene dependencia con el framework xUnit y con el proyecto GildedRose.


**Nuget package manager console commands:**
install-package xUnit
install-package xUnit.runner.console
install-package xUnit.runner.visualstudio
update-package