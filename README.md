# AspNetEcommerce

Ein E-Commerce Backend mit ASP.NET Core und Entity Framework Core.

## Features
- Verwaltung von Produkten und Produktkategorien
- Paging und Suche
- REST API mit ASP.NET Core
- SQLite als Datenbank

## Technologien
- ASP.NET Core 9
- Entity Framework Core
- SQLite
- C#

## Projektstruktur
- `AspNetEcommerce.API/` – Hauptprojekt mit API, Datenbank, Services und Repositories
- `entities/` – Datenmodelle (Product, ProductCategory)
- `db/` – DbContext (EcommerceDbContext)
- `repositories/` – Datenzugriffsschicht
- `services/` – Business-Logik
- `controller/` – API-Endpunkte
- `dto/` – Paging und Response-Objekte

## Setup
1. .NET 9 SDK installieren
2. SQLite installieren
3. ConnectionString in `appsettings.json` setzen:
   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Data Source=ecommerce.db"
   }
   ```
4. In `Program.cs` DbContext registrieren:
   ```csharp
   builder.Services.AddDbContext<EcommerceDbContext>(options =>
       options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
   ```
5. Repository und Service als Scoped registrieren:
   ```csharp
   builder.Services.AddScoped<IProductRepository, ProductRepository>();
   builder.Services.AddScoped<IProductService, ProductService>();
   ```
6. Migrationen erstellen und Datenbank aktualisieren:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

## API-Endpunkte
- `GET /api/product` – Alle Produkte mit Paging
- `GET /api/product/{id}` – Produkt nach ID
- `GET /api/product/category/{categoryId}` – Produkte nach Kategorie
- `GET /api/product/search?searchTerm=xyz` – Suche nach Name

## Paging
Paging erfolgt über das `PageRequest` DTO, z.B.:
```json
{
  "page": 0,
  "size": 10,
  "sort": "name,asc"
}
```

## Weiterentwicklung
- Weitere Entitäten wie Country und State können im selben DbContext integriert werden.
- Erweiterung um weitere Features wie Authentifizierung, Bestellungen etc.

## Lizenz
Dieses Projekt steht unter MIT-Lizenz.

