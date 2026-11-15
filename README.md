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
<img width="1522" height="938" alt="image" src="https://github.com/user-attachments/assets/3f28c1cb-076b-4446-b285-317855fda0ec" />


### 2. Precio negativo
<img width="1427" height="538" alt="image" src="https://github.com/user-attachments/assets/19691a88-a9c0-4975-9960-068e62394484" />


### 3. Nombre vacío
<img width="1372" height="542" alt="image" src="https://github.com/user-attachments/assets/69e4fad5-a171-4f1a-9341-d6a6e6d4e798" />



### 4. Cantidad cero
<img width="1300" height="556" alt="image" src="https://github.com/user-attachments/assets/ef9f3e11-2ade-41d4-9523-cca50232a796" />


