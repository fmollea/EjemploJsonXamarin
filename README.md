# EjemploJsonXamarin
Es una app a modo de ejemplo sobre el uso de JSON en xamarin. 

El main activity tiene los siguientes métodos.

  1- Generar Json: Este método genera un Json a partir de un objeto "Libro" creado en este proyecto de ejemplo.
    Luego guardamos el objeto json generado en un archivo de texto en la carpeta de descargas, para poder visualizarlo cuando querramos y chequear que efectivamente hemos generado un objeto Json correctamente.
    
  2- Mostrar Json: Este método lee el objeto que hemos generado y guardado en la carpeta descargas. Y lo muestra en un editText. Para poder visualizar nuestro objeto json sin la necesidad de ir hasta la carpeta descargas manualmente. 
  
  3- Generar Lista Json: Este método genera una lista de  N libros (donde N es un número ingresado por el usuario). Este método también genera un archivo en la carpeta de descargas para poder ver manualmente el objeto json generado.
    El objetivo de este método es ver cuanto tiempo demora nuestra app en generar un objeto json con N campos.
   
  4- Levantar Lista Json: Este método toma la lista generada de N elementos y la transforma en una lista de libros.
    El objetivo de este método es ver cuanto demora nuestra app en levantar la lista de objetos json y convertirla en una lista de libros.
    
Para trabajar con JSON desde c#/xamarin se usa la librería NewtonSoft.Json.

En este ejemplo se usan los métodos:

  a- JsonConvert.SerializeObject(Object obj) -> string; (Para convertir un objeto en un string con el formato de un objeto Json)
  b- JsonConvert.DeserializeObject<Object>(String str) -> Object; (Para convertir un string con el formato json en un objeto de nuestro proyecto).

Para escribir el archivo donde guardamos nuestro json usamos:
  . File.WriteAllText(string path, string str);
  
Para leer el archivo donde guardamos nuestro json usamos:
    File.ReadAllText(string path) -> string;
