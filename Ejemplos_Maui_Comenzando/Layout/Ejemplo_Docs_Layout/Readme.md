# Grid en .NET MAUI — Resumen

## ¿Qué es Grid?

`Grid` es un layout de MAUI que divide el espacio en **filas y columnas**. Los hijos se posicionan en celdas usando coordenadas de fila/columna. Es ideal para formularios, dashboards y layouts complejos donde otros paneles no alcanzan.

---

## Definición de filas y columnas

### RowDefinitions — altura de cada fila

| Valor | Nombre | Descripción |
|-------|--------|-------------|
| `Auto` | Auto | Se ajusta al tamaño del contenido |
| `*` | Star | Ocupa el espacio proporcional restante |
| `2*`, `3*` | Star ponderado | Proporcional; `2*` toma el doble que `*` |
| `100` | Absoluto | Altura fija en unidades independientes de densidad |

### ColumnDefinitions — ancho de cada columna

Acepta los mismos valores que `RowDefinitions`, pero aplicados al ancho.

```xml
<Grid RowDefinitions="Auto, *, 80"
      ColumnDefinitions="*, 2*">
```

---

## Posicionamiento de elementos

Los atributos adjuntos se aplican directamente sobre los **hijos** del Grid. El índice empieza en `0`.

| Atributo | Descripción |
|----------|-------------|
| `Grid.Row="0"` | Fila donde se ubica el elemento |
| `Grid.Column="1"` | Columna donde se ubica el elemento |
| `Grid.RowSpan="2"` | Cuántas filas ocupa el elemento |
| `Grid.ColumnSpan="3"` | Cuántas columnas ocupa el elemento |

```xml
<Label Text="Header"
       Grid.Row="0" Grid.Column="0"
       Grid.ColumnSpan="2" />
```

---

## Espaciado

| Atributo | Descripción |
|----------|-------------|
| `RowSpacing="8"` | Espacio entre filas |
| `ColumnSpacing="8"` | Espacio entre columnas |

---

## Otros atributos del Grid

| Atributo | Descripción |
|----------|-------------|
| `Padding` | Espaciado interno del Grid respecto a sus bordes |
| `Margin` | Espaciado externo del Grid respecto al contenedor padre |
| `HorizontalOptions` | `Fill`, `Start`, `Center`, `End`, `FillAndExpand`… |
| `VerticalOptions` | `Fill`, `Start`, `Center`, `End`, `FillAndExpand`… |
| `BackgroundColor` | Color de fondo del Grid |
| `IsVisible` | Muestra u oculta el Grid |
| `ZIndex` | Orden de apilamiento cuando los hijos se superponen |

---

## Ejemplo completo

```xml
<Grid RowDefinitions="Auto, *, Auto"
      ColumnDefinitions="*, 2*"
      RowSpacing="8"
      ColumnSpacing="8"
      Padding="16">

    <!-- Fila 0: header a todo el ancho -->
    <Label Text="Título"
           Grid.Row="0" Grid.Column="0"
           Grid.ColumnSpan="2" />

    <!-- Fila 1: sidebar + contenido -->
    <StackLayout Grid.Row="1" Grid.Column="0" />
    <ScrollView  Grid.Row="1" Grid.Column="1" />

    <!-- Fila 2: footer -->
    <Button Text="Guardar"
            Grid.Row="2" Grid.Column="1" />

</Grid>
```
