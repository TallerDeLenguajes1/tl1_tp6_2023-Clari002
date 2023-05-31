**¿String es un tipo por valor o un tipo por referencia**
En C#, el tipo **string** es un tipo por referencia. Aunque se asemeja a los tipos por valor en su uso y comportamiento, internamente se trata como un tipo por referencia. Esto significa que cuando asigna una cadena a una variable o la pasa como argumento a un metodo, en realidad se esta manejando una referencia a la cadena en la memoria, en lugar de copiar el valor completo de la cadena. Esto permite compartir la misma cadena en diferentes partes del codigo, lo que puede ser mas eficiente en terminos de memoria.

**¿Que secuencias de escape tiene el tipo string**
El tipo **string** en c# admite varias secuencias de escape, que son caracteres especiales utilizados para representar caracteres no imprimibles o caracteres que tienen un significado especial en una cadena. A continuacion se muestran algunas de las secuencias de escape mas comunes en c#:
**\"**: Comilla doble.
**\'**: Comilla simple.
**\\**: Barra invertida.
**\0**: Caracter nulo.
**\a**: Caracter de alarma (bip).
**\b**: Retroceso.
**\f**: Salto de pagina.
**\n**: Salto de linea.
**\r**: Retorno de carro.
**\t**: Tabulacion hotizontal.
**\v**: Tabulacion vertical.

**¿Que sucede cuando utiliza el caracter @ y $ antes de una cadena de texto**
La notacion **@** antes de una cadena de texto permite que la cadena se interprete literalmente, lo que significa que los caracteres de escape (como **\n** o **\t**) no seran procesados y se consideraran como caracteres normales dentro de la cadena. Esto puede ser util cuando se trabaja con cadenas de texto que contienen rutas de archivo, expresiones regulares u otros casos en los que se desea evitar las necesidad de escribir dobles barras invertidas () **\\** para representar una barra invertida en la cadena.

El caracter $ antes de una cadena de texto en c# indica que la cadena es una cadena de texto interpolada, tambien conocida como interpolaacion de cadenas. La interpolacion de cadenas permite incrustar expresiones dentro de una cadena utilizando la sintaxis '${expression}'. Las expresiones se evaluan en tiempo de ejecucion y se sustituyen por su valor correspondiente dentro de la cadena.

En resumen, el carácter @se utiliza para cadenas literales y evita el procesamiento de caracteres de escape, mientras que el carácter $se utiliza para la interpolación de cadenas y permite incrustar expresiones dentro de la cadena.