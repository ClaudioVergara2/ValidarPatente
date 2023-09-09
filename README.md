# Proyecto de Validación de Patentes

Este proyecto consta de tres componentes principales: una biblioteca de clases para la validación de patentes de automóviles, un proyecto de consola para realizar pruebas rápidas y un proyecto de interfaz de usuario utilizando WPF que permite ingresar patentes y validarlas.

## Biblioteca de Clases

La biblioteca de clases contiene una clase llamada `Automóvil` que se encarga de validar patentes en base a dos formatos: el formato antiguo y el formato actual. Aquí se describen las reglas de validación para ambas patentes:

### Formato AA·10-00 (1985-2007)

- Este formato consiste en dos letras y cuatro números (por ejemplo, AA·10-00).
- Las letras están separadas de los números por una figura simplificada del Escudo nacional.
- Los números están agrupados en dos pares de dígitos separados por un pequeño círculo.
- Además de los números visibles en la placa, el registro incorpora un dígito verificador.

Las letras válidas para la primera letra son: A, B, C, E, F, G, H, D, K, L, N, P, R, S, T, U, V, X, Y, Z, W y M. La letra I no se utiliza debido a su parecido con la J, a excepción de las placas que comienzan con D (quedando como DI.1234). La Ñ y la Q no se utilizan, excepto para vehículos de representación diplomática.

### Formato Actual BB-BB·10 (2007-presente)

- Este formato se compone de cuatro letras y dos números (por ejemplo, BB-BB·10).
- Utiliza 18 letras: B, C, D, F, G, H, J, K, L, P, R, S, T, V, W, X, Y y Z.
- No se emplean las letras M, N, Ñ, Q ni las vocales para evitar combinaciones que formen palabras.
