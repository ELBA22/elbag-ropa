using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IUnitOfWork
    {
        ICargo Cargos { get; }

        ICliente Clientes { get; }

        IColor Colores { get; }

        IDepartamento Departamentos { get; }

        IDetalleOrden DetallesOrdenes { get; }

        IDetalleVenta DetallesVentas { get; }

        IEmpleado Empleados { get; }
        IEmpresa Empresas { get; }

        IEstado Estados { get; }

        IFormaPago FormaPagos { get; }

        IGenero Generos { get; }

        IInsumo Insumos {get;}
        IInsumoPrenda InsumoPrendas {get;}

        IInsumoProveedor InsumoProveedores {get;}
        IInventario Inventarios {get;}

        IInventarioTalla InventariosTallas {get;}

        IMunicipio Municipios {get;}

        IOrden Ordenes {get;}

        IPais Paises {get;}

        IPrenda Prendas {get;}
        IProveedor Proveedores {get;}

        ITalla Tallas {get;}

        ITipoEstado TiposEstads {get;}

        ITipoProteccion TiposProteciones {get;}
    }
}