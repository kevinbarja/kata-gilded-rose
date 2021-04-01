### Sistema Gilded Rose

El cliente GildedRose mandó realizar un sistema para mantener el inventario de sus productos (ítems), el sistema fué
desarrollado en varias etapas bajo los siguientes requerimientos:

**Etapa 1**
 - Todos los ítems tienen un valor **sellIn**(venderEn) que indica la cantidad de días que se tiene para vender el item
 - Todos los ítems tienen un valor **Quality** que indica el valor del item.
 - Al final de cada día, el programa baja los valores para cada ítem.
 
**Etapa 2**
 - Una vez que la cantidad de días para vender el item ha llegado al punto mínimo (cero días), el **Quality** se degrada el doble de rápido.
 - El **Quality** de un ítem nunca es un número negativo.
 - El item “Aged Brie" incrementa su **Quality** a medida que envejece.
 - El Quality de un ítem nunca es más que 50.
 - El producto “Sulfuras" es legendario y nunca cambia su **Quality**.
 - El item “Backstage passes", como el “Aged Brie", incrementa su **Quality** a medida que se acerca a su valor de **sellIn**: el **Quality** se duplica cuando hay 10 días o menos, se triplica cuando hay 5 días o menos, y se anula cuando se pasó la fecha de venta.
 
**Etapa 3**

- Comercialización de items “Conjured”. Los items “Conjured" (encantados) degradan su **Quality** dos veces mas rapido que los items normales.

- Un item no puede incrementar su **Quality** mas de 50. El caso especial es “Sulfuras" que es un item legendario y por tanto su calidad es 80 y permanece inalterable. 