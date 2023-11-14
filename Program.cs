using PatronComposite;

ProductoHoja producto1 = new ProductoHoja("Huevo", 3, "Pz");
ProductoHoja producto2 = new ProductoHoja("Tocino", 50, "Gr");
ProductoHoja producto3 = new ProductoHoja("Leche", 21, "Lt");
ProductoHoja producto4 = new ProductoHoja("Pizza Food", 80, "Pz");

CarritoCompositor venta = new CarritoCompositor("Venta 1");
venta.AgregarProducto(producto1);
venta.AgregarProducto(producto2);
venta.AgregarProducto(producto3);

Console.WriteLine($"Total {venta.obtenerTotal}");

CarritoCompositor ventaActualizada = new CarritoCompositor("Venta 1 actualizada");
ventaActualizada.AgregarProducto(producto4);
ventaActualizada.AgregarProducto(venta);

Console.WriteLine($"Se actualizo la compra \nTotal {ventaActualizada.obtenerTotal}");