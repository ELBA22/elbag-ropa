# elbag-ropa
Filtro, arquitectura de 3 capas.
Elba Esther Garcia Bello.

# Creacion del proyecto

Se crea un repositorio, lo clonamos.
creamos la solucion dotnet new sln.
dotnet new webapi -o API
dotnet new classlib -o Infraestructure
dotnet new classlib -o Core

dotnet sln add API 
dotnet sln add Infraestructure
dotnet sln add Core

dotnet add reference
´

# ENTIDADES.
Creacion de Base Entity, la cual sera la madre de las demas entidades.

namespace Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
´´´
