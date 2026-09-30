# Ejercicio 3: Verificación de las API de Java SE

**1. ¿Con cuántos métodos cuenta la clase `Math` (paquete `java.lang`)?**

- En la API de Java 7 (la URL de la consigna) cuenta con unos 54 métodos públicos (abs, pow, sqrt, sin, cos, max, min, round, random, etc., contando las sobrecargas). Este número es de memoria y no lo comprobé en la documentación; conviene verificarlo en la página.
- En el JDK 26 instalado en esta máquina, `javap java.lang.Math` lista 108 métodos públicos, porque las versiones nuevas añadieron `addExact`, `floorMod`, `fma`, `clamp`, etc.

**2. ¿Qué clase es la superclase de todas las clases?**

`java.lang.Object`.

**3. Métodos de `String` para comparar dos cadenas**

- `equals(Object otra)`: compara el contenido, distingue mayúsculas y minúsculas.
- `equalsIgnoreCase(String otra)`: compara el contenido sin distinguir mayúsculas y minúsculas.
- `compareTo(String otra)`: comparación lexicográfica. Devuelve 0 si son iguales, un valor negativo si es menor y uno positivo si es mayor.
- `compareToIgnoreCase(String otra)`: igual que `compareTo`, sin distinguir mayúsculas y minúsculas.
- `contentEquals(CharSequence cs)`: compara con un `CharSequence` o `StringBuffer`.
- `regionMatches(...)`: compara una región de una cadena con una región de otra.
- `startsWith(String prefijo)` y `endsWith(String sufijo)`: comparan el inicio o el final.
