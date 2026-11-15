# Control de inventario de TecnoPunto

## Datos del autor
- **Nombre:** Pedro Yunior Edubique Hernández
- **Matrícula:** 2025-1422
- **Universidad:** Universidad Central del Este (UCE) – Ingeniería de Software
- **Materia:** Programación Básica – Prof. Gamalier Reyes de Carmen

## Descripción del programa
Aplicación de consola en C# que registra 3 productos de la tienda TecnoPunto y muestra su información.
Usa la clase `Producto`, que valida sus datos mediante propiedades (bloque `set`) y calcula por sí misma
el valor total que tiene en existencia. Si el usuario escribe un dato inválido, el programa muestra un
mensaje claro y vuelve a pedir los datos, sin cerrarse.

## Datos de entrada
Por cada producto (3 en total), por teclado:
- Código
- Nombre
- Precio
- Cantidad

## Datos que procesa
- Valida que el **Nombre** no esté vacío.
- Valida que el **Precio** sea mayor que 0.
- Valida que la **Cantidad** no sea negativa.
- Calcula el **ValorTotal** (Precio × Cantidad) con una propiedad de solo lectura.

## Datos de salida
Para cada producto: código, nombre, precio, cantidad y valor total.
Ante datos inválidos: un mensaje de error claro y nueva solicitud de los datos.

## Estructura
```
edubique-clases-objetos/
├── Producto.cs
├── Program.cs
└── README.md
```

## Capturas de la ejecución
### 1. Datos válidos
![Datos válidos](capturas/datos-validos.png)

### 2. Precio negativo
![Precio negativo](capturas/precio-negativo.png)

### 3. Nombre vacío
![Nombre vacío](capturas/nombre-vacio.png)

### 4. Cantidad cero
![Cantidad cero](capturas/cantidad-cero.png)
