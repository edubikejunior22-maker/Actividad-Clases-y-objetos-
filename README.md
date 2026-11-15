# Control de inventario de TecnoPunto

## Datos del autor
- **Nombre:** Pedro Yunior Edubique Hernández
- **Matrícula:** 2025-1422
- **Universidad:** Universidad Central del Este (UCE) – Ingeniería de Software
- **Materia:** Programación Básica
-  Prof. Gamalier Reyes de Carmen

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
<img width="1531" height="922" alt="image" src="https://github.com/user-attachments/assets/7bbf7df8-86bd-416a-ac63-b523195997ca" />


### 2. Precio negativo
<img width="940" height="438" alt="image" src="https://github.com/user-attachments/assets/26e16b9a-fba5-4469-bd43-1b20e3d6d5cf" />


### 3. Nombre vacío
<img width="1125" height="467" alt="image" src="https://github.com/user-attachments/assets/a084783c-9e4e-45df-b429-8172f3d76f52" />


### 4. Cantidad cero
<img width="1351" height="454" alt="image" src="https://github.com/user-attachments/assets/515d8ccd-6a52-4248-b69a-ee82c01c8b74" />

