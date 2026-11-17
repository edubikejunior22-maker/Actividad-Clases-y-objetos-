# Control de inventario de TecnoPunto

## Datos del autor
| Campo       | Detalles                            |
|-------------|------------------------------------|
| Nombre      | Pedro Yunior Edubike Hernandez|
| Matrícula   | 2025-1422                          |
| Materia     | Programación Básica                |
| Sección     | ISW-122-2                          |
| Profesor    | Gamalier Reyes Del Carmen          |
| Universidad | Universidad Central del Este (UCE) |

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
<img width="497" height="949" alt="image" src="https://github.com/user-attachments/assets/5ee4e8d7-5e19-4a34-a1fb-586e0694666d" />



### 2. Precio negativo
<img width="834" height="709" alt="image" src="https://github.com/user-attachments/assets/8aaca8af-c215-4f8b-a3f9-90288316ce70" />



### 3. Nombre vacío
<img width="911" height="717" alt="image" src="https://github.com/user-attachments/assets/cc569624-f9f3-42b2-8126-7ac3d27289e2" />




### 4. Cantidad cero
<img width="983" height="646" alt="image" src="https://github.com/user-attachments/assets/94723c48-8730-4158-9a97-a28331b127d9" />


